﻿/****************************************************************************
  This file is part of Space Shuttle Vessel Mission Editor
  
  Space Shuttle Vessel is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  Space Shuttle Vessel is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Space Shuttle Vessel; if not, write to the Free Software
  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

  See https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html or
  file SSV-LICENSE.txt for more details.

  **************************************************************************/

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;


namespace SSVMissionEditor.model
{
	public class Mission_SPDS : INotifyPropertyChanged
	{
		public Mission_SPDS()
		{
			PLID = new int[5];
			Reversed = new bool[4];

			Payload = new Mission_Payload();

			LoadDefault();
		}

		public void LoadDefault()
		{
			for (int i = 0; i < 5; i++) PLID[i] = 0;
			for (int i = 0; i < 4; i++) Reversed[i] = false;

			Payload.LoadDefault();
			return;
		}

		public void LoadEmpty()
		{
			Payload.LoadEmpty();

			LoadDefault();
			return;
		}

		public void Load_V1( JToken jtk )
		{
			JToken jlatches = jtk["Latches"];
			List<JToken> jpllatchl = jlatches.ToObject<List<JToken>>();
			int portlatch = 0;
			int stbdlatch = 2;
			int keellatch = 4;
			foreach (JToken jpllatchlitem in jpllatchl)
			{
				switch ((string)jpllatchlitem["Type"])
				{
					case "Port Longeron":
						if (portlatch <= 1)
						{
							PLID[portlatch] = (int)jpllatchlitem["PLID"];
							Reversed[portlatch] = (bool)jpllatchlitem["Reversed"];

							portlatch++;
						}
						else {}// TODO kaput
						break;
					case "Starboard Longeron":
						if (stbdlatch <= 3)
						{
							PLID[stbdlatch] = (int)jpllatchlitem["PLID"];
							Reversed[stbdlatch] = (bool)jpllatchlitem["Reversed"];

							stbdlatch++;
						}
						else {}// TODO kaput
						break;
					case "Keel":
						if (keellatch <= 4)
						{
							PLID[keellatch] = (int)jpllatchlitem["PLID"];

							keellatch++;
						}
						else {}// TODO kaput
						break;
					default:
						// TODO kaput
						break;
				}
			}

			Payload.Load_V1( jtk["Payload"] );
			return;
		}

		public JObject Save_V1()
		{
			JObject jobj = new JObject();

			JArray jlatches = new JArray();
			for (int j = 0; j < 5; j++)
			{
				JObject jlatch = new JObject();
				if (j < 2) jlatch["Type"] = "Port Longeron";
				else if (j < 4) jlatch["Type"] = "Starboard Longeron";
				else jlatch["Type"] = "Keel";

				jlatch["PLID"] = PLID[j];
				if (j < 4) jlatch["Reversed"] = Reversed[j];

				jlatches.Add( jlatch );
			}
			jobj["Latches"] = jlatches;

			jobj["Payload"] = Payload.Save_V1();
			return jobj;
		}


		/// <summary>
		/// PLID
		/// 0	port 1
		/// 1	port 2
		/// 2	stbd 1
		/// 3	stbd 2
		/// 4	keel 1
		/// </summary>
		private int[] plid;
		public int[] PLID
		{
			get { return plid; }
			set
			{
				plid = value;
				OnPropertyChanged( "PLID" );
			}
		}

		/// <summary>
		/// Is reversed?
		/// 0	port 1
		/// 1	port 2
		/// 2	stbd 1
		/// 3	stbd 2
		/// </summary>
		private bool[] reversed;
		public bool[] Reversed
		{
			get { return reversed; }
			set
			{
				reversed = value;
				OnPropertyChanged( "Reversed" );
			}
		}

		/// <summary>
		/// Payload installed in attachment
		/// </summary>
		private Mission_Payload payload;
		public Mission_Payload Payload
		{
			get { return payload; }
			set
			{
				payload = value;
				OnPropertyChanged( "Payload" );
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged( string prop )
		{
			PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( prop ) );
		}
	}
}
