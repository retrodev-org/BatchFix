using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	class MyDate
	{
		// Date formats
		const int MMDDYY = 1;
		const int MMDDYY_HYPHEN = 2;
		const int MMDDYY_SLASH = 3;
		const int MMDDYYYY = 4;
		const int MMDDYYYY_HYPHEN = 5;
		const int MMDDYYYY_SLASH = 6;
		const int YYYYMMDD = 7;
		const int YYYYMMDD_HYPHEN = 8;
		const int YYYYMMDD_SLASH = 9;

		string date;

		public string Date { get => date; set => date = value; }

		String FormatDate(int oldFormat, int newFormat)
		{
			if (oldFormat == MMDDYY)
			{
				if (newFormat == MMDDYY_HYPHEN)
					return date.Substring(0,2) + "-" + date.Substring(2,2) + "-" + date.Substring(4);
				if (newFormat == MMDDYYYY)
					return date;
			}

			return date;
		}
	}
}
