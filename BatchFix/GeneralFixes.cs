using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	/*	Name:		GeneralFixes
	 *	Summary:	GeneralFixes contains generic fixes required for some states, e.g. sanitizing input and removing
	 *				special characters. This does not include editing demographic information.
	 */
	class GeneralFixes
	{
		//todo add common fixes that are required by several states but not by specific pieces of information
		//todo maybe check employer phone = null or blank in final general check?

		String RemoveSpecialChars(String input, char[] chars)
		{
			//todo use array of chars as guide for characters to remove from given string
			return input;
		}

		String RemoveAmpersand(String input)
		{
			//todo remove ampersand
			return input;
		}

		Application FinalAppCheck(Application application, String state)
		{
			//todo run checks based on which state file is for
			return application;
		}

		void WriteError(string message)
		{
			//todo Write error messages to a log file instead of console
			Console.WriteLine(message);
		}
	}
}
