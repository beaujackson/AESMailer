/*
 * Created by SharpDevelop.
 * User: Beau
 * Date: 12/13/2012
 * Time: 7:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AESMailer
{
	/// <summary>
	/// Description of Customer.
	/// </summary>
	public class Customer
	{
		public Customer()
		{
			Id = -1;
			Name = string.Empty;
			Email = string.Empty;
			Valid = true;
			ErrorMessage = string.Empty;
		}
		
		public Customer(int id, string name, string email)
		{
			Id = id;
			Name = name;
			Email = email;
			Valid = true;
			ErrorMessage = string.Empty;
		}
		
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public bool Valid { get; set; }
		public string ErrorMessage { get; set; }
	}
}
