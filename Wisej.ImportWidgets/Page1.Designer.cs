namespace Wisej.ImportWidgets
{
	partial class Page1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.FromArgb(191, 63, 134);
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(75, 90);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package3.Name = "particles.js";
            package3.Source = "https://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js";
            this.widget1.Packages.Add(package3);
            this.widget1.Size = new System.Drawing.Size(504, 448);
            this.widget1.TabIndex = 0;
            this.widget1.Text = "widget1";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.widget1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1055, 542);
            this.Text = "Page1";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Widget widget1;
	}
}

