using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	public class Constants
	{
		// Numbers
		const double WAGE_DEFAULT = 9.00;
		
		// Markers / Flags
		const int COMPANY_EF = 1;
		const int COMPANY_NTC = 2;
		const string TRUE_Y			= "Y";
		const string TRUE_WORD		= "TRUE";
		const string TRUE_NUM		= "1";
		const string FALSE_N		= "N";
		const string FALSE_WORD		= "FALSE";
		const string FALSE_NUM		= "0";
		
		// Efficient Forms address info
		const string EF_NAME		= "Efficient Forms, LLC";
		const string EF_ADDRESS		= "10499 West Bradford Rd Suite 102";
		const string EF_CITY		= "Littleton";
		const string EF_STATE		= "CO";
		const string EF_ZIP			= "80127";
		const string EF_PHONE		= "8008597479";
		const string EF_FAX			= "3034849586";
		const string EF_EMAIL		= "wotc@efficientforms.com";
		const string EF_SIGNER		= "Dave Kenney";
		const string EF_SIGNER_TITLE = "Dir WOTC Operations";

		// National Tax Credit address info
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
	}
}