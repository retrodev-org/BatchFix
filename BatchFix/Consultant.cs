using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;

namespace BatchFix
{
	class Consultant
	{
		private string name;
		private string address;
		private string city;
		private string state;
		private string zipCode;
		private string phone;
		private string fax;
		private string email;
		private string signerName;
		private string signerTitle;

		Consultant(string consultantName)
		{

			if (Name == "EF")
			{
				// Assign values based on constant strings for each company
				name = EF_NAME;
				address = EF_ADDRESS;
				city = EF_CITY;
				state = EF_STATE;
				zipCode = EF_ZIP;
				phone = EF_PHONE;
				fax = EF_FAX;
				email = EF_EMAIL;
				signerName = EF_SIGNER;
				signerTitle = EF_SIGNER_TITLE;
				
			} else if (Name == "NTC")
			{
				// Assign values based on constant strings for each company
				name = NTC_NAME;
				address = NTC_ADDRESS;
				city = NTC_CITY;
				state = NTC_STATE;
				zipCode = NTC_ZIP;
				phone = NTC_PHONE;
				fax = NTC_FAX;
				email = NTC_EMAIL;
				signerName = NTC_SIGNER;
				signerTitle = NTC_SIGNER_TITLE;
			}
			else
			{
				// todo error message for invalid consultant
			}
		}

		public string Name { get => name; set => name = value; }
		public string Address { get => address; set => address = value; }
		public string City { get => city; set => city = value; }
		public string State { get => state; set => state = value; }
		public string ZipCode { get => zipCode; set => zipCode = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Email { get => email; set => email = value; }
		public string SignerName { get => signerName; set => signerName = value; }
		public string SignerTitle { get => signerTitle; set => signerTitle = value; }
	}
}
