using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;

namespace BatchFix
{
	class State
	{
		private string name;
		private string delimiter;			// delimiter symbol (comma, carat, or space)
		private string answerTrue;			// 1, Y, or TRUE - sets format for state
		private string answerFalse;			// 0, N, or FALSE - sets format for state
		private Array zipCodesRRC;			// list of zip codes that qualify for RRC
		private Array citiesEmpowerment;    // list of cities that are empowerment zones
	}
	
	InitializeState(int thisState){
		switch (thisState){
			case: 	STATE_AK
				// TODO Verify these answers. This is just an example.
				name = "AK";
				delimiter = DELMT_COMMA;
				answerTrue = TRUE_Y;
				answerFalse = FALSE_N;
				// Create RRC_AK.csv from combined lists of EZ and zip codes
				// Individual file per state = faster read time
				// TODO load citiesEmpowerment from RRC_AK.csv
				// TODO load zipCodesRRC from RRC_AK.csv
				break;
			case: 	STATE_AL
				break;
			case: 	STATE_AR
				break;
			case: 	STATE_AZ
				break;
			case: 	STATE_CA
				break;
			case: 	STATE_CO
				break;
			case: 	STATE_CT
				break;
			case: 	STATE_DC
				break;
			case: 	STATE_DE
				break;
			case: 	STATE_FL
				break;
			case: 	STATE_GA
				break;
			case: 	STATE_GUAM
				break;
			case: 	STATE_HI
				break;
			case: 	STATE_IA
				break;
			case: 	STATE_ID
				break;
			case: 	STATE_IL
				break;
			case: 	STATE_IN
				break;
			case: 	STATE_KS
				break;
			case: 	STATE_KY
				break;
			case: 	STATE_LA
				break;
			case: 	STATE_MA
				break;
			case: 	STATE_MD
				break;
			case: 	STATE_ME
				break;
			case: 	STATE_MI
				break;
			case: 	STATE_MN
				break;
			case: 	STATE_MO
				break;
			case: 	STATE_MS
				break;
			case: 	STATE_MT
				break;
			case: 	STATE_NC
				break;
			case: 	STATE_ND
				break;
			case: 	STATE_NE
				break;
			case: 	STATE_NH
				break;
			case: 	STATE_NJ
				break;
			case: 	STATE_NM
				break;
			case: 	STATE_NV
				break;
			case: 	STATE_NY
				break;
			case: 	STATE_OH
				break;
			case: 	STATE_OK
				break;
			case: 	STATE_OR
				break;
			case: 	STATE_PA
				break;
			case: 	STATE_PR
				break;
			case: 	STATE_RI
				break;
			case: 	STATE_SC
				break;
			case: 	STATE_SD
				break;
			case: 	STATE_TN
				break;
			case: 	STATE_TX
				break;
			case: 	STATE_UT
				break;
			case: 	STATE_VA
				break;
			case: 	STATE_VT
				break;
			case: 	STATE_WA
				break;
			case: 	STATE_WI
				break;
			case: 	STATE_WV
				break;
			case: 	STATE_WY
				break;
		}
		
	}
}
