using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConstants;

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

		public string CheckLength(string input, int length)
		{
			while(input.length < length)
			{
				input = "0" + input;
			}
			
			return input;
		}
		
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

		void WriteError(string message)
		{
			//todo Write error messages to a log file instead of console
			Console.WriteLine(message);
		}
	}
}
