using System;
using Constants;

namespace BatchFix
{
	/// <summary>
	/// Class:	Employer
	/// Use:	Read and store employer information. (EIN, Address, Phone, etc.)
	/// </summary>
	public class Employer
	{
		private string fein;
		private string name;
		private string street1;
		private string street2;
		private string city;
		private string state;
		private string zipCode;
		private string phone;
		
		// TODO: create getters and setters
		
		public Employer()
		{
			// TODO: create Employer constructor
		}
		
		public void CheckPhone(){
			if (this.Phone = null || this.Phone.Length < 10)
			{
				
			}
		}
	}
}
