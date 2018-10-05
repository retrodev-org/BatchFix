using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	public class MyConstants
	{
		// CONSULTANT EF
		public readonly string EF_NAME				= "Efficient Forms, LLC";
		public readonly string EF_ADDRESS			= "10499 West Bradford Rd, Suite 102";
		public readonly string EF_CITY				= "Littleton";
		public readonly string EF_STATE			= "CO";
		public readonly string EF_ZIP				= "80127";
		public readonly string EF_PHONE			= "3037858600";
		public readonly string EF_FAX				= "3034849586";
		public readonly string EF_EMAIL			= "wotc@efficientforms.com";
		public readonly string EF_SIGNER			= "Dave Kenney";
		public readonly string EF_SIGNER_TITLE		= "Dir WOTC Operations";

		// CONSULTANT NTC
		public readonly string NTC_NAME			= "National Tax Credit";
		public readonly string NTC_ADDRESS			= "1025 Rose Creek Dr PO Box 620-324";
		public readonly string NTC_CITY			= "Woodstock";
		public readonly string NTC_STATE			= "GA";
		public readonly string NTC_ZIP				= "30189";
		public readonly string NTC_PHONE			= "8664996356";
		public readonly string NTC_FAX				= "4043934468";
		public readonly string NTC_EMAIL			= "aankele@ntcusa.com";
		public readonly string NTC_SIGNER			= "Stephen Johnstone";
		public readonly string NTC_SIGNER_TITLE	= "WOTC Coordinator";

		// TRUE-FALSE
		public readonly string TRUE_Y		= "Y";
		public readonly string TRUE_WORD	= "TRUE";
		public readonly string TRUE_NUM	= "1";
		public readonly string FALSE_N		= "N";
		public readonly string FALSE_WORD	= "FALSE";
		public readonly string FALSE_NUM	= "0";
		
		// DELIMITERS
		public readonly string DELMT_PIPE		= "|";
		public readonly string DELMT_COMMA		= ",";
		public readonly string DELMT_HYPHEN	= "-";
		public readonly string DELMT_SPACE		= " ";

		// STATES
		public readonly int STATE_AK	= 1;
		public readonly int STATE_AL	= 2;
		public readonly int STATE_AR	= 3;
		public readonly int STATE_AZ	= 4;
		public readonly int STATE_CA	= 5;
		public readonly int STATE_CO	= 6;
		public readonly int STATE_CT	= 7;
		public readonly int STATE_DC	= 8;
		public readonly int STATE_DE	= 9;
		public readonly int STATE_FL	= 10;
		public readonly int STATE_GA	= 11;
		public readonly int STATE_GUAM	= 12;
		public readonly int STATE_HI	= 13;
		public readonly int STATE_IA	= 14;
		public readonly int STATE_ID	= 15;
		public readonly int STATE_IL	= 16;
		public readonly int STATE_IN	= 17;
		public readonly int STATE_KS	= 18;
		public readonly int STATE_KY	= 19;
		public readonly int STATE_LA	= 20;
		public readonly int STATE_MA	= 21;
		public readonly int STATE_MD	= 22;
		public readonly int STATE_ME	= 23;
		public readonly int STATE_MI	= 24;
		public readonly int STATE_MN	= 25;
		public readonly int STATE_MO	= 26;
		public readonly int STATE_MS	= 27;
		public readonly int STATE_MT	= 28;
		public readonly int STATE_NC	= 29;
		public readonly int STATE_ND	= 30;
		public readonly int STATE_NE	= 31;
		public readonly int STATE_NH	= 32;
		public readonly int STATE_NJ	= 33;
		public readonly int STATE_NM	= 34;
		public readonly int STATE_NV	= 35;
		public readonly int STATE_NY	= 36;
		public readonly int STATE_OH	= 37;
		public readonly int STATE_OK	= 38;
		public readonly int STATE_OR	= 39;
		public readonly int STATE_PA	= 40;
		public readonly int STATE_PR	= 41;
		public readonly int STATE_RI	= 42;
		public readonly int STATE_SC	= 43;
		public readonly int STATE_SD	= 44;
		public readonly int STATE_TN	= 45;
		public readonly int STATE_TX	= 46;
		public readonly int STATE_UT	= 47;
		public readonly int STATE_VA	= 48;
		public readonly int STATE_VT	= 49;
		public readonly int STATE_WA	= 50;
		public readonly int STATE_WI	= 51;
		public readonly int STATE_WV	= 52;
		public readonly int STATE_WY	= 53;

		// Minimum wages
		public readonly double WAGE_DEFAULT = 9.00;

		// Input validation
		public readonly string VALID_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789//";
	}
}
