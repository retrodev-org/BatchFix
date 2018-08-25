using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFix
{
	class Application
	{
		private Employee employee;
		private String requestID;
		private MyDate startDate;
		private MyDate hireDate;
		private MyDate infoDate;
		private MyDate offerDate;
		private MyDate employeeSignDate;
		private MyDate employerSignDate;
		private MyDate rehireWorkDate;
		private MyDate convictionDate;
		private MyDate releaseDate;

		private string wage;
		private string position;
		private string occupationCode;
		private string benefitsRecipientSNAP;
		private string benefitsStateSNAP;
		private string benefitsRecipientTANF;
		private string benefitsStateTANF;
		private string benefitsRecipientVetSNAP;
		private string benefitsStateVetSNAP;
		private string unemploymentState;

		private bool prescreenQ1; // Form 8850 conditional certification from state workforce agency (SWA)
		private bool prescreenQ2; // SNAP, TANF, Vet SNAP, Ex-Felon, RRC, SSI, Vet 4wks-6mo
		private bool prescreenQ3; // Veteran unemployed 6+ months
		private bool prescreenQ4; // Veteran with service-connected disability, discharge w/in past year
		private bool prescreenQ5; // Veteran with service-connected disability, unemployed 6+ months
		private bool prescreenQ6; // TANF
		private bool prescreenQ7; // Long term unemployment
		private bool ready = false;
		private bool rehire;

		// Getters and setters
		public string RequestID { get => requestID; set => requestID = value; }
		public string Wage { get => wage; set => wage = value; }
		public string Position { get => position; set => position = value; }
		public string OccupationCode { get => occupationCode; set => occupationCode = value; }
		public string BenefitsRecipientSNAP { get => benefitsRecipientSNAP; set => benefitsRecipientSNAP = value; }
		public string BenefitsStateSNAP { get => benefitsStateSNAP; set => benefitsStateSNAP = value; }
		public string BenefitsRecipientTANF { get => benefitsRecipientTANF; set => benefitsRecipientTANF = value; }
		public string BenefitsStateTANF { get => benefitsStateTANF; set => benefitsStateTANF = value; }
		public string BenefitsRecipientVetSNAP { get => benefitsRecipientVetSNAP; set => benefitsRecipientVetSNAP = value; }
		public string BenefitsStateVetSNAP { get => benefitsStateVetSNAP; set => benefitsStateVetSNAP = value; }
		public string UnemploymentState { get => unemploymentState; set => unemploymentState = value; }
		public bool PrescreenQ1 { get => prescreenQ1; set => prescreenQ1 = value; }
		public bool PrescreenQ2 { get => prescreenQ2; set => prescreenQ2 = value; }
		public bool PrescreenQ3 { get => prescreenQ3; set => prescreenQ3 = value; }
		public bool PrescreenQ4 { get => prescreenQ4; set => prescreenQ4 = value; }
		public bool PrescreenQ5 { get => prescreenQ5; set => prescreenQ5 = value; }
		public bool PrescreenQ6 { get => prescreenQ6; set => prescreenQ6 = value; }
		public bool PrescreenQ7 { get => prescreenQ7; set => prescreenQ7 = value; }
		public bool Ready { get => ready; set => ready = value; }
		public bool Rehire { get => rehire; set => rehire = value; }
		internal Employee Employee { get => employee; set => employee = value; }
		internal MyDate StartDate { get => startDate; set => startDate = value; }
		internal MyDate HireDate { get => hireDate; set => hireDate = value; }
		internal MyDate InfoDate { get => infoDate; set => infoDate = value; }
		internal MyDate OfferDate { get => offerDate; set => offerDate = value; }
		internal MyDate EmployeeSignDate { get => employeeSignDate; set => employeeSignDate = value; }
		internal MyDate EmployerSignDate { get => employerSignDate; set => employerSignDate = value; }
		internal MyDate RehireWorkDate { get => rehireWorkDate; set => rehireWorkDate = value; }
		internal MyDate ConvictionDate { get => convictionDate; set => convictionDate = value; }
		internal MyDate ReleaseDate { get => releaseDate; set => releaseDate = value; }
	}

	class Date
	{
		DateTime dateTime;
		String day;
		String month;
		String year;
		String divider;

		// Getters and setters
		public DateTime DateTime { get => dateTime; set => dateTime = value; }
		public string Day { get => day; set => day = value; }
		public string Month { get => month; set => month = value; }
		public string Year { get => year; set => year = value; }
		public string Divider { get => divider; set => divider = value; }

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
