using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BatchFix
{
	/*	Name:		GeneralFixes
	 *	Summary:	GeneralFixes contains generic fixes required for some states, e.g. sanitizing input and removing
	 *				special characters. This does not include editing demographic information.
	 */
	class GeneralFixes
	{
		// TODO figure out how to access constants stored in their own class
		string ValidCharacters = MyConstants.VALID_CHARACTERS.ToString();

		//todo add common fixes that are required by several states but not by specific pieces of information
		//todo maybe check employer phone = null or blank in final general check?

		public string AddLeadingZeros(string input, int length)
		{
			while(input.Length < length)
			{
				input = "0" + input;
			}
			
			return input;
		}
		
		public String RemoveSpecialChars(String input, char[] chars)
		{
			// valid chars VALID_CHARACTERS
			
			foreach (char c in input)
			{
				// This is using String.Contains for .NET 2 compat.,
				//   hence the requirement for ToString()
				if (!ValidCharacters.Contains(c.ToString()))
					input.Remove(c); // remove invalid chars one at a time
			}

			return input;
		}

		String RemoveAmpersand(String input)
		{
			//todo remove ampersand
			return input;
		}

		public void WriteError(string message)
		{
			//todo Write error messages to a log file instead of console
			Console.WriteLine(message);
		}
	}
}
