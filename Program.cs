/*
 * Created by SharpDevelop.
 * User: wjackson
 * Date: 12/13/2012
 * Time: 10:49 AM
 */

using System;
using System.Windows.Forms;

namespace AESMailer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
