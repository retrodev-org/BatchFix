using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	class State
	{
		private string name;
		private string delimiter;			// delimiter symbol (comma, carat, or space)
		private string AnswerTrue;			// 1, Y, or TRUE
		private string answerFalse;			// 0, N, or FALSE
		private Array zipCodesRRC;			// list of zip codes that qualify for RRC
		private Array citiesEmpowerment;    // list of cities that are empowerment zones
	}
}
