/******* SSV File Modification Notice *******
Date         Developer
2020/06/20   GLS
2021/05/30   GLS
2021/06/01   GLS
2021/06/09   GLS
2021/06/10   GLS
2021/06/11   GLS
2021/08/23   GLS
2021/08/24   GLS
2022/01/23   GLS
2022/01/25   GLS
2022/08/05   GLS
2023/07/23   GLS
2023/07/25   GLS
********************************************/
#include "FMC1.h"


FMC1::FMC1( AtlantisSubsystemDirector *_director ):AtlantisSubsystem( _director, "FMC1" )
{
}

FMC1::~FMC1()
{
}

void FMC1::Realize( void )
{
	DiscreteBundle* pBundle = BundleManager()->CreateBundle( "VENTDOORS_MOTORS_1", 12 );
	//LH_VENTS_1_AND_2_MOTOR_1_PWR.Connect( pBundle, 0 );
	//LH_VENT_3_MOTOR_1_PWR.Connect( pBundle, 1 );
	//LH_VENTS_4_AND_7_MOTOR_1_PWR.Connect( pBundle, 2 );
	//LH_VENT_5_MOTOR_1_PWR.Connect( pBundle, 3 );
	//LH_VENT_6_MOTOR_1_PWR.Connect( pBundle, 4 );
	//LH_VENTS_8_AND_9_MOTOR_1_PWR.Connect( pBundle, 5 );
	RH_VENTS_1_AND_2_MOTOR_1_PWR.Connect( pBundle, 6 );
	//RH_VENT_3_MOTOR_1_PWR.Connect( pBundle, 7 );
	//RH_VENTS_4_AND_7_MOTOR_1_PWR.Connect( pBundle, 8 );
	//RH_VENT_5_MOTOR_1_PWR.Connect( pBundle, 9 );
	//RH_VENT_6_MOTOR_1_PWR.Connect( pBundle, 10 );
	//RH_VENTS_8_AND_9_MOTOR_1_PWR.Connect( pBundle, 11 );

	pBundle = BundleManager()->CreateBundle( "VENTDOORS_IND_RH_1", 16 );
	R_VENTS_1_AND_2_CLOSE_1.Connect( pBundle, 0 );
	R_VENTS_1_AND_2_OPEN_1.Connect( pBundle, 1 );
	R_VENTS_1_AND_2_PURGE_1_IND_1.Connect( pBundle, 2 );
	//RH_VENT_3_CLOSE_1.Connect( pBundle, 3 );
	//RH_VENT_3_OPEN_1.Connect( pBundle, 4 );
	//RH_VENTS_4_AND_7_CLOSE_1.Connect( pBundle, 5 );
	//RH_VENTS_4_AND_7_OPEN_1.Connect( pBundle, 6 );
	//RH_VENT_5_CLOSE_1.Connect( pBundle, 7 );
	//RH_VENT_5_OPEN_1.Connect( pBundle, 8 );
	//RH_VENT_6_CLOSE_1.Connect( pBundle, 9 );
	//RH_VENT_6_OPEN_1.Connect( pBundle, 10 );
	//RH_VENT_6_PURGE_1_IND_1.Connect( pBundle, 11 );
	//RH_VENT_6_PURGE_2_IND_1.Connect( pBundle, 12 );
	//RH_VENTS_8_AND_9_CLOSE_1.Connect( pBundle, 13 );
	//RH_VENTS_8_AND_9_OPEN_1.Connect( pBundle, 14 );
	//RH_VENTS_8_AND_9_PURGE_IND_1.Connect( pBundle, 15 );

	pBundle = BundleManager()->CreateBundle( "VENTDOORS_CMD_RH_1A", 16 );
	RH_VENTS_1_2_MOTOR_1_OPEN_A.Connect( pBundle, 0 );
	RH_VENTS_1_2_MOTOR_1_CLOSE_A.Connect( pBundle, 1 );
	RH_VENTS_1_2_MOTOR_1_PURGE_A.Connect( pBundle, 2 );
	//RH_VENT_3_MOTOR_1_OPEN_A.Connect( pBundle, 3 );
	//RH_VENT_3_MOTOR_1_CLOSE_A.Connect( pBundle, 4 );
	//RH_VENTS_4_7_MOTOR_1_OPEN_A.Connect( pBundle, 5 );
	//RH_VENTS_4_7_MOTOR_1_CLOSE_A.Connect( pBundle, 6 );
	//RH_VENT_5_MOTOR_1_OPEN_A.Connect( pBundle, 7 );
	//RH_VENT_5_MOTOR_1_CLOSE_A.Connect( pBundle, 8 );
	//RH_VENT_6_MOTOR_1_OPEN_A.Connect( pBundle, 9 );
	//RH_VENT_6_MOTOR_1_CLOSE_A.Connect( pBundle, 10 );
	//RH_VENT_6_MOTOR_1_PRG_1_A.Connect( pBundle, 11 );
	//RH_VENT_6_MOTOR_1_PRG_2_A.Connect( pBundle, 12 );
	//RH_VENTS_8_9_MOTOR_1_OPEN_A.Connect( pBundle, 13 );
	//RH_VENTS_8_9_MOTOR_1_CLOSE_A.Connect( pBundle, 14 );
	//RH_VENTS_8_9_MOTOR_1_PURGE_A.Connect( pBundle, 15 );

	pBundle = BundleManager()->CreateBundle( "VENTDOORS_CMD_RH_1B", 16 );
	RH_VENTS_1_2_MOTOR_1_OPEN_B.Connect( pBundle, 0 );
	RH_VENTS_1_2_MOTOR_1_CLOSE_B.Connect( pBundle, 1 );
	RH_VENTS_1_2_MOTOR_1_PURGE_B.Connect( pBundle, 2 );
	//RH_VENT_3_MOTOR_1_OPEN_B.Connect( pBundle, 3 );
	//RH_VENT_3_MOTOR_1_CLOSE_B.Connect( pBundle, 4 );
	//RH_VENTS_4_7_MOTOR_1_OPEN_B.Connect( pBundle, 5 );
	//RH_VENTS_4_7_MOTOR_1_CLOSE_B.Connect( pBundle, 6 );
	//RH_VENT_5_MOTOR_1_OPEN_B.Connect( pBundle, 7 );
	//RH_VENT_5_MOTOR_1_CLOSE_B.Connect( pBundle, 8 );
	//RH_VENT_6_MOTOR_1_OPEN_B.Connect( pBundle, 9 );
	//RH_VENT_6_MOTOR_1_CLOSE_B.Connect( pBundle, 10 );
	//RH_VENT_6_MOTOR_1_PRG_1_B.Connect( pBundle, 11 );
	//RH_VENT_6_MOTOR_1_PRG_2_B.Connect( pBundle, 12 );
	//RH_VENTS_8_9_MOTOR_1_OPEN_B.Connect( pBundle, 13 );
	//RH_VENTS_8_9_MOTOR_1_CLOSE_B.Connect( pBundle, 14 );
	//RH_VENTS_8_9_MOTOR_1_PURGE_B.Connect( pBundle, 15 );

	pBundle = BundleManager()->CreateBundle( "AIR_DATA_PROBES_FMC", 16 );
	L_ADP_STOW_1.Connect( pBundle, 0 );
	//L_ADP_STOW_2.Connect( pBundle, 1 );
	L_ADP_DEPLOY_1.Connect( pBundle, 2 );
	//L_ADP_DEPLOY_2.Connect( pBundle, 3 );
	LEFT_PROBE_MOTOR_1_PWR.Connect( pBundle, 4 );
	//LEFT_PROBE_MOTOR_2_PWR.Connect( pBundle, 5 );
	//R_ADP_STOW_1.Connect( pBundle, 6 );
	//R_ADP_STOW_2.Connect( pBundle, 7 );
	//R_ADP_DEPLOY_1.Connect( pBundle, 8 );
	//R_ADP_DEPLOY_2.Connect( pBundle, 9 );
	//RIGHT_PROBE_MOTOR_1_PWR.Connect( pBundle, 10 );
	//RIGHT_PROBE_MOTOR_2_PWR.Connect( pBundle, 11 );

	pBundle = BundleManager()->CreateBundle( "AIR_DATA_PROBES_POWER", 16 );
	AIR_DATA_PROBE_LEFT_DEPLOYHEAT.Connect( pBundle, 0 );
	AIR_DATA_PROBE_LEFT_DEPLOY.Connect( pBundle, 1 );
	AIR_DATA_PROBE_LEFT_STOW.Connect( pBundle, 2 );
	AIR_DATA_PROBE_STOW_LEFT_ENABLE.Connect( pBundle, 3 );
	//AIR_DATA_PROBE_RIGHT_DEPLOYHEAT.Connect( pBundle, 4 );
	//AIR_DATA_PROBE_RIGHT_DEPLOY.Connect( pBundle, 5 );
	//AIR_DATA_PROBE_RIGHT_STOW.Connect( pBundle, 6 );
	//AIR_DATA_PROBE_STOW_RIGHT_ENABLE.Connect( pBundle, 7 );

	pBundle = BundleManager()->CreateBundle( "STAR_TRACKER_DOORS_FMC", 16 );
	STAR_TRACKER_Y_DOOR_CLS_1.Connect( pBundle, 0 );
	//STAR_TRACKER_Y_DOOR_CLS_2.Connect( pBundle, 1 );
	STAR_TRACKER_Y_DOOR_OP_1.Connect( pBundle, 2 );
	//STAR_TRACKER_Y_DOOR_OP_2.Connect( pBundle, 3 );
	SYS_1_MOTOR_1_PWR.Connect( pBundle, 4 );
	//SYS_2_MOTOR_2_PWR.Connect( pBundle, 5 );
	//STAR_TRACKER_Z_DOOR_CLS_1.Connect( pBundle, 6 );
	//STAR_TRACKER_Z_DOOR_CLS_2.Connect( pBundle, 7 );
	//STAR_TRACKER_Z_DOOR_OP_1.Connect( pBundle, 8 );
	//STAR_TRACKER_Z_DOOR_OP_2.Connect( pBundle, 9 );
	//SYS_1_MOTOR_2_PWR.Connect( pBundle, 10 );
	//SYS_2_MOTOR_1_PWR.Connect( pBundle, 11 );

	pBundle = BundleManager()->CreateBundle( "STAR_TRACKER_POWER", 16 );
	STAR_TRACKER_POWER_Y.Connect( pBundle, 3 );
	STAR_TRACKER_DOOR_CONTROL_SYS_1_CLOSE.Connect( pBundle, 4 );// CLOSE
	STAR_TRACKER_DOOR_CONTROL_SYS_1_OPEN.Connect( pBundle, 5 );// OPEN

	pBundle = BundleManager()->CreateBundle( "MDM_OF1_IOM4_CH1", 16 );
	OPER_STATUS_1.Connect( pBundle, 4 );
	OPER_STATUS_2.Connect( pBundle, 5 );
	OPER_STATUS_3.Connect( pBundle, 6 );
	OPER_STATUS_4.Connect( pBundle, 7 );
	return;
}

void FMC1::OnPreStep( double simt, double simdt, double mjd )
{
	// TODO switch input
	bool MNA_RELAY_LOGIC_POWER = true;

	// VENT DOORS
	// right 1/2 motor 1
	bool K17 = MNA_RELAY_LOGIC_POWER && (RH_VENTS_1_2_MOTOR_1_OPEN_A && !R_VENTS_1_AND_2_OPEN_1);// OPN A
	bool K18 = MNA_RELAY_LOGIC_POWER && (RH_VENTS_1_2_MOTOR_1_OPEN_B && !R_VENTS_1_AND_2_OPEN_1);// OPN B
	bool K19 = MNA_RELAY_LOGIC_POWER && ((RH_VENTS_1_2_MOTOR_1_CLOSE_A || (RH_VENTS_1_2_MOTOR_1_PURGE_A && !R_VENTS_1_AND_2_PURGE_1_IND_1)) && !R_VENTS_1_AND_2_CLOSE_1);// CLS A
	bool K20 = MNA_RELAY_LOGIC_POWER && ((RH_VENTS_1_2_MOTOR_1_CLOSE_B || (RH_VENTS_1_2_MOTOR_1_PURGE_B && !R_VENTS_1_AND_2_PURGE_1_IND_1)) && !R_VENTS_1_AND_2_CLOSE_1);// CLS B

	if (K17 && K18)
	{
		if (K19 && K20) RH_VENTS_1_AND_2_MOTOR_1_PWR.SetLine( 0.0f );
		else RH_VENTS_1_AND_2_MOTOR_1_PWR.SetLine( 1.0f );
	}
	else
	{
		if (K19 && K20) RH_VENTS_1_AND_2_MOTOR_1_PWR.SetLine( -1.0f );
		else RH_VENTS_1_AND_2_MOTOR_1_PWR.SetLine( 0.0f );
	}

	// AIR DATA
	// left probe motor 1
	bool K9 = MNA_RELAY_LOGIC_POWER && ((AIR_DATA_PROBE_LEFT_DEPLOY || AIR_DATA_PROBE_LEFT_DEPLOYHEAT) && !L_ADP_DEPLOY_1);// DPY A
	bool K10 = (AIR_DATA_PROBE_LEFT_DEPLOY || AIR_DATA_PROBE_LEFT_DEPLOYHEAT) && !L_ADP_DEPLOY_1;// DPY B
	bool K11 = MNA_RELAY_LOGIC_POWER && (AIR_DATA_PROBE_LEFT_STOW && !L_ADP_STOW_1);// STW A
	bool K12 = AIR_DATA_PROBE_STOW_LEFT_ENABLE && !L_ADP_STOW_1;// STW B

	if (K9 && K10)
	{
		if (K11 && K12) LEFT_PROBE_MOTOR_1_PWR.SetLine( 0.0f );
		else LEFT_PROBE_MOTOR_1_PWR.SetLine( 1.0f );
	}
	else
	{
		if (K11 && K12) LEFT_PROBE_MOTOR_1_PWR.SetLine( -1.0f );
		else LEFT_PROBE_MOTOR_1_PWR.SetLine( 0.0f );
	}

	// STAR TRACKER
	// -y system 1 motor control
	bool K13 = MNA_RELAY_LOGIC_POWER && (STAR_TRACKER_POWER_Y && !STAR_TRACKER_Y_DOOR_OP_1);// OP
	bool K14 = STAR_TRACKER_DOOR_CONTROL_SYS_1_OPEN && !STAR_TRACKER_Y_DOOR_OP_1;// OP
	bool K15 = MNA_RELAY_LOGIC_POWER && (STAR_TRACKER_DOOR_CONTROL_SYS_1_CLOSE && !STAR_TRACKER_Y_DOOR_CLS_1);// CL
	bool K16 = STAR_TRACKER_DOOR_CONTROL_SYS_1_CLOSE && !STAR_TRACKER_Y_DOOR_CLS_1;// CL

	if (K13 && K14)
	{
		if (K15 && K16) SYS_1_MOTOR_1_PWR.SetLine( 0.0f );
		else SYS_1_MOTOR_1_PWR.SetLine( 1.0f );
	}
	else
	{
		if (K15 && K16) SYS_1_MOTOR_1_PWR.SetLine( -1.0f );
		else SYS_1_MOTOR_1_PWR.SetLine( 0.0f );
	}

	// oper status
	bool oper_status_1 = MNA_RELAY_LOGIC_POWER && !(/*K2 || K3 || K7 ||*/ K9 || K13 || K17);
	bool oper_status_2 = MNA_RELAY_LOGIC_POWER && !(/*K8 ||*/ K10 || K14 || K18);
	bool oper_status_3 = MNA_RELAY_LOGIC_POWER && !(/*K1 || K4 ||*/ K11 || K15 || K19);
	bool oper_status_4 = MNA_RELAY_LOGIC_POWER && !(/*K5 || K6 ||*/ K12 || K16 || K20);

	if (oper_status_1) OPER_STATUS_1.SetLine();
	else OPER_STATUS_1.ResetLine();
	if (oper_status_2) OPER_STATUS_2.SetLine();
	else OPER_STATUS_2.ResetLine();
	if (oper_status_3) OPER_STATUS_3.SetLine();
	else OPER_STATUS_3.ResetLine();
	if (oper_status_4) OPER_STATUS_4.SetLine();
	else OPER_STATUS_4.ResetLine();
	return;
}
