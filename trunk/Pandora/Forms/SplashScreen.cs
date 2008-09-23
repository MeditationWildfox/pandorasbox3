using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TheBox.Forms
{
	/// <summary>
	/// Summary description for SplashScreen.
	/// </summary>
	public class SplashScreen : System.Windows.Forms.Form
	{
		/// <summary>
		/// Sets the text for the current action
		/// </summary>
		/// <param name="action">The action text</param>
		public void SetActionText( string action )
		{
			if ( m_ActionLabel != null )
			{
				m_ActionLabel.Text = action;
				Update();
			}
		}

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labVersion;
		private System.Windows.Forms.Label m_ActionLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SplashScreen()
		{
			InitializeComponent();

			labVersion.Text = Application.ProductVersion;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SplashScreen));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labVersion = new System.Windows.Forms.Label();
			this.m_ActionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(600, 352);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 352);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Version:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labVersion
			// 
			this.labVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labVersion.ForeColor = System.Drawing.Color.White;
			this.labVersion.Location = new System.Drawing.Point(56, 352);
			this.labVersion.Name = "labVersion";
			this.labVersion.Size = new System.Drawing.Size(48, 16);
			this.labVersion.TabIndex = 2;
			this.labVersion.Text = "2.0.0.3";
			this.labVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_ActionLabel
			// 
			this.m_ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.m_ActionLabel.ForeColor = System.Drawing.Color.White;
			this.m_ActionLabel.Location = new System.Drawing.Point(320, 352);
			this.m_ActionLabel.Name = "m_ActionLabel";
			this.m_ActionLabel.Size = new System.Drawing.Size(272, 16);
			this.m_ActionLabel.TabIndex = 4;
			this.m_ActionLabel.Text = "Loading...";
			this.m_ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplashScreen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(600, 376);
			this.Controls.Add(this.m_ActionLabel);
			this.Controls.Add(this.labVersion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SplashScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pandora\'s Box 2";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
