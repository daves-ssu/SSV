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

using System.Collections.ObjectModel;
using System.ComponentModel;


namespace SSVMissionEditor
{
	public class Mission_ILOAD : INotifyPropertyChanged
	{
		public static ObservableCollection<Mission_ILOAD> LoadDefault()
		{
			ObservableCollection<Mission_ILOAD> list = new ObservableCollection<Mission_ILOAD>
			{
				// ASCENT
				new Mission_ILOAD( "CPRESS", "0.0364062 0.0364062 0.0364062" ),
				new Mission_ILOAD( "KMIN", "67" ),
				new Mission_ILOAD( "KMAX_NOM", "104" ),
				new Mission_ILOAD( "KMAX_ABORT", "104" ),
				new Mission_ILOAD( "KMAX_SECONDARY", "109" ),
				new Mission_ILOAD( "K_CO_MAX", "91" ),
				new Mission_ILOAD( "QPOLY", "60.0 383.0 617.0 1397.0" ),
				new Mission_ILOAD( "THROT", "104 104 72 104" ),
				new Mission_ILOAD( "TREF_ADJUST", "17.87" ),
				new Mission_ILOAD( "VREF_ADJUST", "368.0" ),
				new Mission_ILOAD( "OMSASS", "1" ),
				new Mission_ILOAD( "NOMTM", "59.0" ),
				new Mission_ILOAD( "MASS_LOW_LEVEL", "11500.0" ),
				new Mission_ILOAD( "ALIM_1", "96.200405" ),
				new Mission_ILOAD( "ALIM_2", "96.522146" ),
				new Mission_ILOAD( "PHI_CMD", "3.141593" ),
				new Mission_ILOAD( "PHI_2STG", "0.0" ),
				new Mission_ILOAD( "V_RHO_PHI", "12200.0" ),
				new Mission_ILOAD( "LPS_GO_FOR_AUTO_SEQ_T", "-27.0" ),// TODO confirm
				new Mission_ILOAD( "SRB_IGN_ARM_T", "-18.0" ),
				new Mission_ILOAD( "SRB_PIC_VOLTS_CHK_T", "-15.0" ),
				new Mission_ILOAD( "IMU_TO_INERTIAL_T", "-15.0" ),
				new Mission_ILOAD( "AUTO_RECYCLE_T", "-23.0" ),
				new Mission_ILOAD( "OPN_LO2_ACC_RECIRC_VLV_T", "-12.5" ),
				new Mission_ILOAD( "NAV_INIT_T", "-11.0" ),
				new Mission_ILOAD( "CONFIG_VNT_DRS_FOR_LCH_T", "-27.92" ),
				new Mission_ILOAD( "CHK_MPS_VLVS_POS_T", "-9.5" ),
				new Mission_ILOAD( "CLSE_LO2_OVBD_BV_T", "-9.4" ),
				new Mission_ILOAD( "CHK_PREVLVS_OPN_T", "-7.0" ),
				new Mission_ILOAD( "START_SSMES_T", "-6.6" ),
				new Mission_ILOAD( "ALL_ENG_PERCENT_CHB_PRS_CHK", "90" ),
				new Mission_ILOAD( "ENG_PERCENT_CHB_PRS_FOR_GO", "90" ),
				new Mission_ILOAD( "ENG_TIMER_FOR_THRUST_OK", "4.6" ),// 5.5 for low fps
				new Mission_ILOAD( "VERIFY_ALL_ENG_SHTDN_TIMER", "8.0" ),
				new Mission_ILOAD( "ME1_LOX_PREVLV_CLSE_DELAY", "4.5" ),
				new Mission_ILOAD( "ME2_LOX_PREVLV_CLSE_DELAY", "4.5" ),
				new Mission_ILOAD( "ME3_LOX_PREVLV_CLSE_DELAY", "4.5" ),
				new Mission_ILOAD( "SRB_IGN_TIME_DELAY", "6.6" ),
				new Mission_ILOAD( "ME1_LH2_PREVLV_CLSE_T_DELAY", "0.8" ),
				new Mission_ILOAD( "ME2_LH2_PREVLV_CLSE_T_DELAY", "0.8" ),
				new Mission_ILOAD( "ME3_LH2_PREVLV_CLSE_T_DELAY", "0.8" ),
				new Mission_ILOAD( "SRB_IGN_PIC_LEVEL", "438" ),
				new Mission_ILOAD( "FRF_CUTOFF_TIME_DELAY", "22.0" ),
				new Mission_ILOAD( "FLT_CNTL_TVC_INIT_TIME_DELAY", "8.0" ),
				new Mission_ILOAD( "FRF_THROTTLE_TO_92_TIME_DELAY", "18.4" ),
				new Mission_ILOAD( "FRF_THROTTLE_TO_100_TIME_DELAY", "20.2" ),
				new Mission_ILOAD( "FRF_TEST_FLAG", "0" ),
				new Mission_ILOAD( "BP_ROLL_RATE_LMT_CONSTANT", "99999" ),
				new Mission_ILOAD( "BQ_PITCH_RATE_LMT_CONSTANT", "99999" ),
				new Mission_ILOAD( "BR_YAW_RATE_LMT_CONSTANT", "99999" ),
				new Mission_ILOAD( "DYNAMIC_PRS_LMT", "99999" ),
				new Mission_ILOAD( "SRB_SEP_BACKUP_CUE_T", "131.28" ),
				new Mission_ILOAD( "SRB_SEP_MODING_T_DELAY", "3.2" ),
				new Mission_ILOAD( "SRB_SEP_COMMAND_T_DELAY", "4.9" ),
				new Mission_ILOAD( "MAX_SRB_SEP_CUE_DIFRNTL", "5.5" ),
				// ORBIT
				new Mission_ILOAD( "TVR_ROLL", "0" ),
                new Mission_ILOAD( "DTIG_OMS", "102.0 1740.0" ),
                new Mission_ILOAD( "HTGT_OMS", "729134.0 674449.0" ),
                new Mission_ILOAD( "THETA_OMS", "2.32129 5.49779" ),
                new Mission_ILOAD( "C1_OMS", "0.0 0.0" ),
                new Mission_ILOAD( "C2_OMS", "0.0 0.0" ),
                new Mission_ILOAD( "T1_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 -56.8 0.0 20.0 48.7 17.0 27.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "DT_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 56.8 75.7 55.7 27.0 10.0 13.0 0.0 0.0 0.0 0.0 27.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "EL_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.5002112 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "XOFF_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 -48600.0 -900.0 -900.0 -900.0 -900.0 0.0 0.0 0.0 0.0 0.0 -900.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "YOFF_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "ZOFF_ILOAD_ARRAY", "0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 1200.0 1800.0 1800.0 1800.0 1800.0 600.0 0.0 0.0 0.0 0.0 1800.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "PROX_DTMIN", "60.0" ),
				new Mission_ILOAD( "PROX_DTMIN_LAMB", "60.0" ),
				new Mission_ILOAD( "BASE_START_DAY", "1" ),
				new Mission_ILOAD( "BASE_START_HR", "18" ),
				new Mission_ILOAD( "BASE_START_MIN", "0" ),
				new Mission_ILOAD( "BASE_START_SEC", "0.0" ),
				new Mission_ILOAD( "EL_TOL", "0.005" ),
				new Mission_ILOAD( "LAMB_ILOAD", "1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1" ),
				new Mission_ILOAD( "EL_DH_TOL", "10.0" ),
				new Mission_ILOAD( "R_TOL", "250.0" ),
				new Mission_ILOAD( "N_MAX_ITER", "10" ),
				new Mission_ILOAD( "CONE", "0.1396263" ),
				new Mission_ILOAD( "DEL_T_MAX", "900" ),
				new Mission_ILOAD( "DU", "1.745329e-7" ),
				new Mission_ILOAD( "EP_TRANSFER", "0.1396263" ),
				new Mission_ILOAD( "EPS_U", "1.0e-6" ),
				new Mission_ILOAD( "N_MIN", "3" ),
				new Mission_ILOAD( "DEL_X_GUESS", "100.0 60.0" ),
				new Mission_ILOAD( "IC_MAX", "20" ),
				new Mission_ILOAD( "DEL_X_TOL", "0.0 0.0002" ),
				new Mission_ILOAD( "GMD_I", "4" ),
				new Mission_ILOAD( "GMO_I", "0" ),// Should be 4 but Orbiter doesn't support it
				new Mission_ILOAD( "ATM_I", "1 2" ),
				new Mission_ILOAD( "DTMIN_I", "180.0" ),
				new Mission_ILOAD( "DMP_I", "1 1" ),
				new Mission_ILOAD( "VMP_I", "0 0" ),
				new Mission_ILOAD( "R_TOL_CW", "0.0001" ),
				// ENTRY
				new Mission_ILOAD( "OVHD", "1" ),
				new Mission_ILOAD( "IGS", "1" ),
				new Mission_ILOAD( "IGI", "1" ),
				new Mission_ILOAD( "RWID", "1" ),
				new Mission_ILOAD( "LSID", "1" ),
				new Mission_ILOAD( "AL_R", "25896.8 26409.5 32218.9 32860.9" ),
				new Mission_ILOAD( "X_K", "-3313.48 -2138.13 -2775.87 -1577.49" ),
				new Mission_ILOAD( "H_K", "26035.03 26516.81 32341.99 32952.57" ),
				new Mission_ILOAD( "X_EXP", "-4901.98 -3757.87 -4533.71 -3374.8" ),
				new Mission_ILOAD( "H_DECAY", "32.45 32.44 26.18 26.3" ),
				new Mission_ILOAD( "SIGMA", "920.0" ),
				new Mission_ILOAD( "GAMMA_REF_1", "-20.0 -18.0" ),
				new Mission_ILOAD( "GAMMA_REF_2", "-1.5" ),
				new Mission_ILOAD( "X_ZERO", "-7500.0 -6500.0" ),
				new Mission_ILOAD( "X_AIM", "1000.0" ),
				new Mission_ILOAD( "H_FLARE", "2000.0" ),
				new Mission_ILOAD( "H_CLOOP", "1700.0" ),
				new Mission_ILOAD( "V_REF", "506.3" ),
				new Mission_ILOAD( "SB_SEL", "1" ),
				new Mission_ILOAD( "AEROJET_FCS_PITCH", "1" ),
				new Mission_ILOAD( "AEROJET_FCS_ROLL", "1" ),
				new Mission_ILOAD( "AEROJET_FCS_SB", "1" ),
				new Mission_ILOAD( "AEROJET_FCS_BF", "1" ),
				new Mission_ILOAD( "WGT_SD", "6030.0" ),
				new Mission_ILOAD( "EAS_SD", "180.0" ),
				new Mission_ILOAD( "LD_REL_BIAS", "10.0" ),
				new Mission_ILOAD( "NWS_LIM", "9.0" ),
				new Mission_ILOAD( "ENT_SB_1", "0.0" ),
				new Mission_ILOAD( "ENT_SB_2", "80.0" ),
				new Mission_ILOAD( "ENT_SB_3", "65.0" ),
				new Mission_ILOAD( "ENT_SB_VS", "3200.0" ),
				new Mission_ILOAD( "ENT_SB_C1", "800.0" ),
				new Mission_ILOAD( "ENT_SB_C2", "-0.08" ),
				new Mission_ILOAD( "ENT_SB_C3", "11.4285" ),
				new Mission_ILOAD( "ENT_SB_C4", "0.0214286" ),
				new Mission_ILOAD( "DSB_MAX", "98.6" ),
				new Mission_ILOAD( "MACH_SBH", "10000.0" ),
				new Mission_ILOAD( "DSB_CLOSED", "-9.9" ),
				new Mission_ILOAD( "DSB_BIAS_U", "0.0" ),
				new Mission_ILOAD( "DSB_MIN_L", "-9.9" ),
				new Mission_ILOAD( "DSB_MIN_U", "15.0" ),
				new Mission_ILOAD( "DSB_MIN_M", "25.0" ),
				new Mission_ILOAD( "ALFERR_LIM", "2.0" ),
				new Mission_ILOAD( "GQALR", "0.33" ),
				new Mission_ILOAD( "DPJET_CUTOFF", "1.0" ),
				new Mission_ILOAD( "PADB", "0.245" ),
				new Mission_ILOAD( "PBDB", "0.25" ),
				new Mission_ILOAD( "VCO", "549.125" ),
				new Mission_ILOAD( "GDQ_MIN", "0.2" ),
				new Mission_ILOAD( "GDQ_MAX", "5.0" ),
				new Mission_ILOAD( "WOWLON", "0" ),
				new Mission_ILOAD( "FLATTURN", "0" ),
				new Mission_ILOAD( "ROLLOUT", "0" ),
				new Mission_ILOAD( "GSENBL", "0" ),
				new Mission_ILOAD( "HUD_WOWLON", "0" ),
				new Mission_ILOAD( "HUD_ROLLOUT", "0" ),
				new Mission_ILOAD( "PMODE", "0" ),
				new Mission_ILOAD( "FMODE", "1" ),
				new Mission_ILOAD( "IPHASE", "1" ),
				new Mission_ILOAD( "TG_END", "0" ),
				new Mission_ILOAD( "HALI", "10018.0 10018.0" ),
				new Mission_ILOAD( "HFTC", "12018.0 12018.0" ),
				new Mission_ILOAD( "HMEP", "6000.0 6000.0" ),
				new Mission_ILOAD( "WT_GS1", "6837.808943" ),
				new Mission_ILOAD( "PBHC", "78161.826 81000.0" ),
				new Mission_ILOAD( "PBGC", "0.1112666 0.1112666" ),
				new Mission_ILOAD( "PBRC", "256527.82 282035.6903" ),
				new Mission_ILOAD( "CUBIC_C3", "-1.64854e-07 -2.15359e-08" ),
				new Mission_ILOAD( "CUBIC_C4", "-8.51609e-13 -8.44417e-13" ),
				new Mission_ILOAD( "EOW_SPT", "76068.0 76068.0" ),
				new Mission_ILOAD( "EN_C1", "949.0 15360.0 949.0 15360.0" ),
				new Mission_ILOAD( "EN_C2", "0.6005 0.46304 0.6005 0.46304" ),
				new Mission_ILOAD( "R2MAX", "115000.0" ),
				new Mission_ILOAD( "ESHFMX", "20000.0" ),
				new Mission_ILOAD( "ES1", "4523.0 4523.0" ),
				new Mission_ILOAD( "EDRS", "0.69946182 0.69946182" ),
				new Mission_ILOAD( "EMEP_C1", "-3263.0 12088.0 -3263.0 12088.0" ),
				new Mission_ILOAD( "EMEP_C2", "0.51554944 0.265521 0.51554944 0.265521" ),
				new Mission_ILOAD( "EMOHC1", "-3894.0 -3894.0" ),
				new Mission_ILOAD( "EMOHC2", "0.51464 0.51464" ),
				new Mission_ILOAD( "YERRLM", "160.0" ),
				new Mission_ILOAD( "GY", "0.04" ),
				new Mission_ILOAD( "GYDOT", "0.4" ),
				new Mission_ILOAD( "DNZLC1", "-0.5" ),
				new Mission_ILOAD( "DNZLC2", "-0.5" ),
				new Mission_ILOAD( "DNZUC1", "0.5" ),
				new Mission_ILOAD( "DNZUC2", "0.5" ),
				new Mission_ILOAD( "DR3", "5300.0" ),
				new Mission_ILOAD( "DR4", "2000.0" ),
				new Mission_ILOAD( "RF0", "14000.0" ),
				new Mission_ILOAD( "RFMN", "5000.0" ),
				new Mission_ILOAD( "RFMX", "14000.0" ),
				new Mission_ILOAD( "R1", "0.0" ),
				new Mission_ILOAD( "R2", "0.093" ),
				new Mission_ILOAD( "PSHARS", "270.0" ),
				new Mission_ILOAD( "PSRF", "90.0" ),
				new Mission_ILOAD( "DHOH1", "0.11" ),
				new Mission_ILOAD( "DHOH2", "35705.0" ),
				new Mission_ILOAD( "DHOH3", "6000.0" ),
				new Mission_ILOAD( "DRFK", "-3.0" ),
				new Mission_ILOAD( "PHAVGC", "63.33" ),
				new Mission_ILOAD( "PHAVGLL", "30.0" ),
				new Mission_ILOAD( "PHAVGS", "13.33" ),
				new Mission_ILOAD( "PHAVGUL", "50.0" ),
				new Mission_ILOAD( "PHILM0", "50.0" ),
				new Mission_ILOAD( "PHILM1", "50.0" ),
				new Mission_ILOAD( "PHILM2", "60.0" ),
				new Mission_ILOAD( "PHILM3", "30.0" ),
				new Mission_ILOAD( "PHILMSUP", "30.0" ),
				new Mission_ILOAD( "PHILS", "-300.0" ),
				new Mission_ILOAD( "PHIM", "0.95" ),
				new Mission_ILOAD( "PHILMC", "100.0" ),
				new Mission_ILOAD( "PHILM4", "60.0" ),
				new Mission_ILOAD( "QBARDL", "20.0" ),
				new Mission_ILOAD( "CQG", "0.5583958" ),
				new Mission_ILOAD( "CQDG", "0.31886857" ),
				new Mission_ILOAD( "CDEQD", "0.68113143" ),
				new Mission_ILOAD( "DEL_H1", "0.19" ),
				new Mission_ILOAD( "DEL_H2", "900.0" ),
				new Mission_ILOAD( "Y_RANGE1", "0.18" ),
				new Mission_ILOAD( "Y_RANGE2", "800.0" ),
				new Mission_ILOAD( "GAMMA_COEF1", "0.0007" ),
				new Mission_ILOAD( "GAMMA_COEF2", "3.0" ),
				new Mission_ILOAD( "QB_ERROR2", "24.0" ),
				new Mission_ILOAD( "H_REF1", "10000.0" ),
				new Mission_ILOAD( "H_REF2", "5000.0" ),
				new Mission_ILOAD( "HMIN3", "7000.0" ),
				new Mission_ILOAD( "P2TRNC1", "1.1" ),
				new Mission_ILOAD( "ENBIAS", "10000.0" ),
				new Mission_ILOAD( "RMINST", "122204.6 122204.6" ),
				new Mission_ILOAD( "PSSTRN", "200.0" ),
				new Mission_ILOAD( "PSOHAL", "200.0" ),
				new Mission_ILOAD( "RMOH", "273500.0" ),
				new Mission_ILOAD( "XHACL", "-40519.2" ),
				new Mission_ILOAD( "XHACH", "-44487.6" ),
				new Mission_ILOAD( "ASTART", "4.25" ),
				new Mission_ILOAD( "CALP0", "5.034479 -13.81545 40.0 40.0 40.0 40.0 40.0 40.0 40.0 40.0" ),
				new Mission_ILOAD( "CALP1", "0.003586207 0.008786196 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "CALP2", "0.0 -3.586207e-7 0.0 0.0 0.0 0.0 0.0 0.0 0.0 0.0" ),
				new Mission_ILOAD( "VALP", "7250.0 12250.0 14500.0 14500.0 14500.0 14500.0 14500.0 14500.0 14500.0" ),
				new Mission_ILOAD( "NALP", "9" ),
				new Mission_ILOAD( "VNOALP", "23000.0" ),
				new Mission_ILOAD( "VALMOD", "23000.0" ),
				new Mission_ILOAD( "VC20", "2500.0" ),
				new Mission_ILOAD( "DLAPLM", "2.0" ),
				new Mission_ILOAD( "DDMIN", "0.15" ),
				new Mission_ILOAD( "RDMAX", "12.0" ),
				new Mission_ILOAD( "CRDEAF", "4.0" ),
				new Mission_ILOAD( "DLALLM", "43.0" ),
				new Mission_ILOAD( "ACLAM1", "9.352966" ),
				new Mission_ILOAD( "ACLAM2", "0.003058794" ),
				new Mission_ILOAD( "ACLIM1", "37.0" ),
				new Mission_ILOAD( "ACLIM2", "0.0" ),
				new Mission_ILOAD( "ACLIM3", "7.6666667" ),
				new Mission_ILOAD( "ACLIM4", "0.00223333" ),
				new Mission_ILOAD( "Y1", "0.1832595" ),
				new Mission_ILOAD( "Y2", "0.1745329" ),
				new Mission_ILOAD( "Y3", "0.3054325" ),
				new Mission_ILOAD( "CY0", "-0.2181662" ),
				new Mission_ILOAD( "CY1", "0.0001309" ),
				new Mission_ILOAD( "DLRDLM", "150.0" ),
				new Mission_ILOAD( "VHS1", "12310.0" ),
				new Mission_ILOAD( "VHS2", "19675.5" ),
				new Mission_ILOAD( "HS01", "18075.0" ),
				new Mission_ILOAD( "HS02", "27000.0" ),
				new Mission_ILOAD( "HS03", "45583.5" ),
				new Mission_ILOAD( "HS11", "0.725" ),
				new Mission_ILOAD( "HS13", "-0.9445" ),
				new Mission_ILOAD( "HSMIN", "20500.0" ),
				new Mission_ILOAD( "ALFM", "33.0" ),
				new Mission_ILOAD( "DELV", "2300.0" ),
				new Mission_ILOAD( "VTRAN", "10500.0" ),
				new Mission_ILOAD( "VQ", "5000.0" ),
				new Mission_ILOAD( "ETRAN", "6.002262e7" ),
				new Mission_ILOAD( "EEF4", "2.0e6" ),
				new Mission_ILOAD( "DF", "21.0" ),
				new Mission_ILOAD( "RPT1", "22.4" ),
				new Mission_ILOAD( "VSAT", "25766.2" ),
				new Mission_ILOAD( "VS1", "23283.5" ),
				new Mission_ILOAD( "D230", "19.8" ),
				new Mission_ILOAD( "VB1", "19000.0" ),
				new Mission_ILOAD( "VA", "27637.0" ),
				new Mission_ILOAD( "VA1", "22000.0" ),
				new Mission_ILOAD( "VA2", "27637.0" ),
				new Mission_ILOAD( "AK", "-3.4573" ),
				new Mission_ILOAD( "AK1", "-4.76" ),
				new Mission_ILOAD( "LODMIN", "0.5" ),
				new Mission_ILOAD( "DT2MIN", "0.008" ),
				new Mission_ILOAD( "E1", "0.01" ),
				new Mission_ILOAD( "GS1", "0.02" ),
				new Mission_ILOAD( "GS2", "0.02" ),
				new Mission_ILOAD( "GS3", "0.03767" ),
				new Mission_ILOAD( "GS4", "0.03" ),
				new Mission_ILOAD( "DRDDL", "-1.5" ),
				new Mission_ILOAD( "ALIM", "70.84" ),
				new Mission_ILOAD( "CT16", "0.1354 -0.1 0.006" ),
				new Mission_ILOAD( "VC16", "23000.0" ),
				new Mission_ILOAD( "CT16MN", "0.025" ),
				new Mission_ILOAD( "CT16MX", "0.35" ),
				new Mission_ILOAD( "CT17MN", "0.0025" ),
				new Mission_ILOAD( "CT17MX", "0.014" ),
				new Mission_ILOAD( "CT17M2", "0.00133" ),
				new Mission_ILOAD( "CT17", "1.537e-2 -5.8146e-1" ),
				new Mission_ILOAD( "C17MP", "0.75" ),
				new Mission_ILOAD( "C21", "0.06" ),
				new Mission_ILOAD( "C22", "-0.001" ),
				new Mission_ILOAD( "C23", "4.25e-6" ),
				new Mission_ILOAD( "C24", "0.01" ),
				new Mission_ILOAD( "C25", "0.0" ),
				new Mission_ILOAD( "C27", "0.0" ),
				new Mission_ILOAD( "CDDOT1", "1500.0" ),
				new Mission_ILOAD( "CDDOT2", "2000.0" ),
				new Mission_ILOAD( "CDDOT3", "0.15" ),
				new Mission_ILOAD( "CDDOT4", "0.0783" ),
				new Mission_ILOAD( "CDDOT5", "-8.165e-3" ),
				new Mission_ILOAD( "CDDOT6", "6.833e-4" ),
				new Mission_ILOAD( "CDDOT7", "7.5e-5" ),
				new Mission_ILOAD( "CDDOT8", "13.666e-4" ),
				new Mission_ILOAD( "CDDOT9", "-8.165e-3" ),
				new Mission_ILOAD( "VRDT", "23000.0" ),
				new Mission_ILOAD( "DDLIM", "2.0" ),
				new Mission_ILOAD( "ZK1", "1.0" ),
				new Mission_ILOAD( "ALMN1", "0.7986355" ),
				new Mission_ILOAD( "ALMN2", "0.9659258" ),
				new Mission_ILOAD( "ALMN3", "0.93969" ),
				new Mission_ILOAD( "ALMN4", "1.0" ),
				new Mission_ILOAD( "YLMIN", "0.03" ),
				new Mission_ILOAD( "YLMN2", "0.07" ),
				new Mission_ILOAD( "VYLMAX", "23000.0" ),
				new Mission_ILOAD( "VELMN", "8000.0" ),
				new Mission_ILOAD( "ACN1", "50.0" ),
				new Mission_ILOAD( "VRLMC", "2500.0" ),
				new Mission_ILOAD( "RLMC1", "70.0" ),
				new Mission_ILOAD( "RLMC2", "70.0" ),
				new Mission_ILOAD( "RLMC3", "0.0" ),
				new Mission_ILOAD( "RLMC4", "70.0" ),
				new Mission_ILOAD( "RLMC5", "0.0" ),
				new Mission_ILOAD( "RLMC6", "70.0" ),
				new Mission_ILOAD( "VEROLC", "8000.0" ),
				new Mission_ILOAD( "V_TAEM", "2500.0" ),
				new Mission_ILOAD( "PREBNK", "0" ),
				new Mission_ILOAD( "HUDMAXDECEL", "16.0" ),
				new Mission_ILOAD( "RWTOGO", "1000.0" ),
				new Mission_ILOAD( "SBDMN", "950.0" ),
				new Mission_ILOAD( "SBDMX", "9800.0" ),
				new Mission_ILOAD( "SBDLIM", "20.0" ),
				new Mission_ILOAD( "MACH_RRXF", "600.0" ),
				new Mission_ILOAD( "QBARLOWQ", "2.0" ),
				new Mission_ILOAD( "QBARLOWMIDQ", "10.0" ),
				new Mission_ILOAD( "QBARHIGHQ", "40.0" ),
				new Mission_ILOAD( "WRAP", "1" )
			};
			return list;
		}

		public Mission_ILOAD( string _id, string _val )
		{
			ID = _id;
			Val = _val;
			return;
		}


		private string id;
		public string ID
		{
			get { return id; }
			set
			{
				id = value;
				OnPropertyChanged( "ID" );
			}
		}

		private string val;
		public string Val
		{
			get { return val; }
			set
			{
				val = value;
				OnPropertyChanged( "Val" );
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged( string prop )
		{
			PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( prop ) );
		}
	}
}
