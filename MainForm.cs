/*
 * Created by SharpDevelop.
 * User: wjackson
 * Date: 12/13/2012
 * Time: 10:49 AM
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Net.Configuration;
using System.Windows.Forms;
using System.IO;

namespace AESMailer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		private List<Customer> GetCustomers()
		{
			List<Customer> customers = new List<Customer>();
			
			string connectString = ConfigurationManager.AppSettings["DBConnectString"];
			using(OdbcConnection conn = new OdbcConnection(connectString))
			{
				conn.Open();
				
				string sql = "select id, name, email, valid_email from customers";
				
				using(OdbcCommand cmd = new OdbcCommand(sql, conn))
				{
					using(OdbcDataReader reader = cmd.ExecuteReader())
					{
						while(reader.Read())
						{
							Customer c = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
							customers.Add(c);												
						}
					}
				}
			}

			return customers;			
		}
		
		private void SendMessages()
		{
			List<Customer> customers = GetCustomers();
				
			foreach (Customer c in customers) 
			{
				c.Valid = Mailer.SendEmail("no-reply@riataleather.com", 
				                           c,
				                           FormatWithCustomerData(textSubject.Text, c),
				                           FormatWithCustomerData(textPreview.Text, c),
				                           FormatWithCustomerData(webPreview.DocumentText, c));
				
				System.Threading.Thread.Sleep(250);
			}
		}
		
		private string FormatWithCustomerData(string messageText, Customer customer)
		{
			return string.Format(messageText, customer.Name, customer.Email);
		}
		
		void ButtonBrowseHtmlClick(object sender, EventArgs e)
		{
			string path = BrowseForFile("Select HTML message template");
			if(!string.IsNullOrEmpty(path))
			{
				textHtmlFile.Text = path;
				webPreview.DocumentText = GetFileContents(path);
			}
		}
		
		void ButtonBrowseTextClick(object sender, EventArgs e)
		{
			string path = BrowseForFile("Select Text message template");
			if(!string.IsNullOrEmpty(path))
			{
				textTextFile.Text = path;
				textPreview.Text = GetFileContents(path);
			}
		}
		
		string BrowseForFile(string caption)
		{
			openFileDialog1.Title = caption;
			if(DialogResult.OK == openFileDialog1.ShowDialog(this))
			{
				return openFileDialog1.FileName;
			}
			
			return null;
		}
		
		string GetFileContents(string path)
		{
			using(StreamReader reader = new StreamReader(path))
			{
				return reader.ReadToEnd();
			}			
		}
	}	
}
