using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;

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

		private string date;
		private DateTime dateTime;
		private String day;
		private String month;
		private String year;
		private String divider;

		// Getters and setters
		public DateTime DateTime { get => dateTime; set => dateTime = value; }
		public string Day { get => day; set => day = value; }
		public string Month { get => month; set => month = value; }
		public string Year { get => year; set => year = value; }
		public string Divider { get => divider; set => divider = value; }
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
		
		// return default 8 digit date mmddyyyy
		String toString(){return Day + Month + Year;}
		String toStringMMDDYYYY(){return Day + Month + Year;}

		// return 10 char date with forward dash or hyphen between digits
		String toStringHyphenMMDDYYYY()
		{
			Divider = "-";
			return Day + Divider + Month + Divider + Year;
		}

		// return 10 char date with forward slash between digits
		String toStringSlashMMDDYYYY(){
			Divider = "/";
			return Day+Divider+Month+Divider+Year;
		}

		//todo toString for different date types needed by states YYYYMMDD, DDMMYYYY, etc
	}
}
