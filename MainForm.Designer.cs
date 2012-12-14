/*
 * Created by SharpDevelop.
 * User: wjackson
 * Date: 12/13/2012
 * Time: 10:49 AM
 */

namespace AESMailer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textHtmlFile = new System.Windows.Forms.TextBox();
			this.textTextFile = new System.Windows.Forms.TextBox();
			this.buttonBrowseHtml = new System.Windows.Forms.Button();
			this.buttonBrowseText = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webPreview = new System.Windows.Forms.WebBrowser();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textPreview = new System.Windows.Forms.TextBox();
			this.textSubject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "HTML File:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Text File:";
			// 
			// textHtmlFile
			// 
			this.textHtmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textHtmlFile.Location = new System.Drawing.Point(78, 2);
			this.textHtmlFile.Name = "textHtmlFile";
			this.textHtmlFile.Size = new System.Drawing.Size(497, 20);
			this.textHtmlFile.TabIndex = 2;
			// 
			// textTextFile
			// 
			this.textTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textTextFile.Location = new System.Drawing.Point(78, 26);
			this.textTextFile.Name = "textTextFile";
			this.textTextFile.Size = new System.Drawing.Size(497, 20);
			this.textTextFile.TabIndex = 3;
			// 
			// buttonBrowseHtml
			// 
			this.buttonBrowseHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseHtml.Location = new System.Drawing.Point(581, 0);
			this.buttonBrowseHtml.Name = "buttonBrowseHtml";
			this.buttonBrowseHtml.Size = new System.Drawing.Size(28, 23);
			this.buttonBrowseHtml.TabIndex = 4;
			this.buttonBrowseHtml.Text = "...";
			this.buttonBrowseHtml.UseVisualStyleBackColor = true;
			this.buttonBrowseHtml.Click += new System.EventHandler(this.ButtonBrowseHtmlClick);
			// 
			// buttonBrowseText
			// 
			this.buttonBrowseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseText.Location = new System.Drawing.Point(581, 24);
			this.buttonBrowseText.Name = "buttonBrowseText";
			this.buttonBrowseText.Size = new System.Drawing.Size(28, 23);
			this.buttonBrowseText.TabIndex = 5;
			this.buttonBrowseText.Text = "...";
			this.buttonBrowseText.UseVisualStyleBackColor = true;
			this.buttonBrowseText.Click += new System.EventHandler(this.ButtonBrowseTextClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 81);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(597, 338);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webPreview);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(589, 312);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "HTML Preview";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webPreview
			// 
			this.webPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webPreview.Location = new System.Drawing.Point(3, 3);
			this.webPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this.webPreview.Name = "webPreview";
			this.webPreview.Size = new System.Drawing.Size(583, 306);
			this.webPreview.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textPreview);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(589, 312);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Text Preview";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textPreview
			// 
			this.textPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textPreview.Location = new System.Drawing.Point(3, 3);
			this.textPreview.Multiline = true;
			this.textPreview.Name = "textPreview";
			this.textPreview.Size = new System.Drawing.Size(583, 306);
			this.textPreview.TabIndex = 0;
			// 
			// textSubject
			// 
			this.textSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textSubject.Location = new System.Drawing.Point(78, 55);
			this.textSubject.Name = "textSubject";
			this.textSubject.Size = new System.Drawing.Size(497, 20);
			this.textSubject.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Subject:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "All Files|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 431);
			this.Controls.Add(this.textSubject);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonBrowseText);
			this.Controls.Add(this.buttonBrowseHtml);
			this.Controls.Add(this.textTextFile);
			this.Controls.Add(this.textHtmlFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "AESMailer";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textSubject;
		private System.Windows.Forms.TextBox textPreview;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.WebBrowser webPreview;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button buttonBrowseText;
		private System.Windows.Forms.TextBox textTextFile;
		private System.Windows.Forms.TextBox textHtmlFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBrowseHtml;
	}
}
