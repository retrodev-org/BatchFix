using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	public class Constants
	{
		// CONSULTANT EF
		const string EF_NAME		= "Efficient Forms, LLC";
		const string EF_ADDRESS		= "10499 West Bradford Rd, Suite 102";
		const string EF_CITY		= "Littleton";
		const string EF_STATE		= "CO";
		const string EF_ZIP			= "80127";
		const string EF_PHONE		= "3037858600";
		const string EF_FAX			= "3034849586";
		const string EF_EMAIL		= "wotc@efficientforms.com";
		const string EF_SIGNER		= "Dave Kenney";
		const string EF_SIGNER_TITLE = "Dir WOTC Operations";

		// CONSULTANT NTC
		const string NTC_NAME		= "National Tax Credit";
		const string NTC_ADDRESS	= "1025 Rose Creek Dr PO Box 620-324";
		const string NTC_CITY		= "Woodstock";
		const string NTC_STATE		= "GA";
		const string NTC_ZIP		= "30189";
		const string NTC_PHONE		= "8664996356";
		const string NTC_FAX		= "4043934468";
		const string NTC_EMAIL		= "aankele@ntcusa.com";
		const string NTC_SIGNER		= "Stephen Johnstone";
		const string NTC_SIGNER_TITLE = "WOTC Coordinator";

		// TRUE-FALSE
		const string TRUE_Y			= "Y";
		const string TRUE_WORD		= "TRUE";
		const string TRUE_NUM		= "1";
		const string FALSE_N		= "N";
		const string FALSE_WORD		= "FALSE";
		const string FALSE_NUM		= "0";
		
		// DELIMITERS
		const string DELMT_PIPE		= "|";
		const string DELMT_COMMA	= ",";
		const string DELMT_HYPHEN	= "-";
		const string DELMT_SPACE	= " ";
		
		// STATES
		const int	STATE_AK			= 1;
		const int	STATE_AL			= 2;
		const int	STATE_AR			= 3;
		const int	STATE_AZ			= 4;
		const int	STATE_CA			= 5;
		const int	STATE_CO			= 6;
		const int	STATE_CT			= 7;
		const int	STATE_DC			= 8;
		const int	STATE_DE			= 9;
		const int	STATE_FL			= 10;
		const int	STATE_GA			= 11;
		const int	STATE_GUAM			= 12;
		const int	STATE_HI			= 13;
		const int	STATE_IA			= 14;
		const int	STATE_ID			= 15;
		const int	STATE_IL			= 16;
		const int	STATE_IN			= 17;
		const int	STATE_KS			= 18;
		const int	STATE_KY			= 19;
		const int	STATE_LA			= 20;
		const int	STATE_MA			= 21;
		const int	STATE_MD			= 22;
		const int	STATE_ME			= 23;
		const int	STATE_MI			= 24;
		const int	STATE_MN			= 25;
		const int	STATE_MO			= 26;
		const int	STATE_MS			= 27;
		const int	STATE_MT			= 28;
		const int	STATE_NC			= 29;
		const int	STATE_ND			= 30;
		const int	STATE_NE			= 31;
		const int	STATE_NH			= 32;
		const int	STATE_NJ			= 33;
		const int	STATE_NM			= 34;
		const int	STATE_NV			= 35;
		const int	STATE_NY			= 36;
		const int	STATE_OH			= 37;
		const int	STATE_OK			= 38;
		const int	STATE_OR			= 39;
		const int	STATE_PA			= 40;
		const int	STATE_PR			= 41;
		const int	STATE_RI			= 42;
		const int	STATE_SC			= 43;
		const int	STATE_SD			= 44;
		const int	STATE_TN			= 45;
		const int	STATE_TX			= 46;
		const int	STATE_UT			= 47;
		const int	STATE_VA			= 48;
		const int	STATE_VI			= 49;
		const int	STATE_VT			= 50;
		const int	STATE_WA			= 51;
		const int	STATE_WI			= 52;
		const int	STATE_WV			= 53;
		const int	STATE_WY			= 54;
		
		// Minimum wages
		const double	WAGE_DEFAULT	= 09.00;
		const double	MIN_AK			= 09.84;
		const double	MIN_AL			= WAGE_DEFAULT;
		const double	MIN_AR			= 08.50;
		const double	MIN_AZ			= 10.50;
		const double	MIN_CA			= 11.00;
		const double	MIN_CO			= 10.20;
		const double	MIN_CT			= 10.10;
		const double	MIN_DC			= 13.25;
		const double	MIN_DE			= 08.25;
		const double	MIN_FL			= 08.25;
		const double	MIN_GA			= 05.15;
		const double	MIN_GUAM 		= 08.25;
		const double	MIN_HI			= 10.10;
		const double	MIN_IA			= 07.25;
		const double	MIN_ID			= 07.25;
		const double	MIN_IL			= 08.25;
		const double	MIN_IN			= 07.25;
		const double	MIN_KS			= 07.25;
		const double	MIN_KY			= 07.25;
		const double	MIN_LA			= WAGE_DEFAULT;
		const double	MIN_MA			= 11.00;
		const double	MIN_MD			= 10.10;
		const double	MIN_ME			= 10.00;
		const double	MIN_MI			= 09.25;
		const double	MIN_MN			= 09.65;
		const double	MIN_MO			= 07.85;
		const double	MIN_MS			= WAGE_DEFAULT;
		const double	MIN_MT			= 08.30;
		const double	MIN_NC			= 07.25;
		const double	MIN_ND			= 07.25;
		const double	MIN_NE			= 09.00;
		const double	MIN_NH			= WAGE_DEFAULT;
		const double	MIN_NJ			= 08.60;
		const double	MIN_NM			= 07.50;
		const double	MIN_NV			= 08.25;
		const double	MIN_NY			= 10.40;
		const double	MIN_OH			= 08.30;
		const double	MIN_OK			= 07.25;
		const double	MIN_OR			= 10.75;
		const double	MIN_PA			= 07.25;
		const double	MIN_PR			= 07.25;
		const double	MIN_RI			= 10.10;
		const double	MIN_SC			= WAGE_DEFAULT;
		const double	MIN_SD			= 08.85;
		const double	MIN_TN			= WAGE_DEFAULT;
		const double	MIN_TX			= 07.25;
		const double	MIN_UT			= 07.25;
		const double	MIN_VA			= 07.25;
		const double	MIN_VI			= 10.50;
		const double	MIN_VT			= 10.50;
		const double	MIN_WA			= 11.50;
		const double	MIN_WI			= 07.25;
		const double	MIN_WV			= 08.75;
		const double	MIN_WY			= 05.15;
	}
}
