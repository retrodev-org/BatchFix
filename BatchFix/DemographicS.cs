using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	class Demographics
	{
		bool errorState = false;

		// Function Notes
		public string CheckSocial(Employee employee)
		{
			string socialTemp = employee.Social;
			string socialVerified = "";
			string errorMessage = "Error_SSN";
			string allowedChars = "0123456789";
			int i = 0;

			try
			{
				socialTemp = employee.Social;

				// Copy numeric chars to verified SSN
				for (i = 0; i< socialTemp.Length; i++)
				{
					// copy only allowed characters
					if (allowedChars.Contains(socialTemp[i]))
						socialVerified += socialTemp[i].ToString();
				}

				// if SSN contained leading zeroes that were lost, replace them
				while (socialVerified.Length < 9)
					socialVerified = "0" + socialVerified;

				// final check for non-digit characters
				if (!socialVerified.All(char.IsDigit))
				{
					// Length of temp SSN minus 1 to use as array index, printing last 4 in error message
					int socialIndex = socialTemp.Length - 1;

					// set error flag
					errorState = true;

					// write log message
					WriteError("Invalid characters in SSN for " + employee.getName()
						+ ". SSN: XXX-XX-" + socialTemp.Substring(socialIndex - 4));
				}
			} // end try block
			catch
			{
				// set error flag
				errorState = true;

				// Length of SSN minus 1 to use as array index, printing last 4 in error message
				int socialLength = socialTemp.Length - 1;
				Console.WriteLine("Unexpected error encounter in CheckSocial() for " + employee.getName()
					+ ". SSN: XXX-XX-" + socialTemp.Substring(socialLength - 4));
			}

			// return error message if unexpected characters or if catch block was triggered
			if (errorState == true)
			{
				return errorMessage;
			} else
			{
				return socialVerified;
			}
		}
	}
}
