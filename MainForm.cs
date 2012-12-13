/*
 * Created by SharpDevelop.
 * User: wjackson
 * Date: 12/13/2012
 * Time: 10:49 AM
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

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
		
		void Button1Click(object sender, EventArgs e)
		{
			
			using(OdbcConnection conn = new OdbcConnection("Driver={MySQL ODBC 5.1 Driver};Server=localhost;Database=jtdata;User=root;Password=mysql;Option=3;"))
			{
				conn.Open();
				
				string sql = "select id, name, email, valid_email from customers";
				
				using(OdbcCommand cmd = new OdbcCommand(sql, conn))
				{
					using(OdbcDataReader reader = cmd.ExecuteReader())
					{
						while(reader.Read())
						{
							int id = reader.GetInt32(0);
							string name = reader.GetString(1);
							string email = reader.GetString(2);
							//bool valid = reader.GetBoolean(3);
							
							Mailer.SendEmail("no-reply@riataleather.com", email, string.Format("Hi {0}, this is a test subject", name),
							                 string.Format("Hi {0}, this is the test in text", name),
							                 string.Format("<p>Hi {0}, This is the test in HTML</p>", name));
						}
					}
				}
			}
		}
	}	
}
