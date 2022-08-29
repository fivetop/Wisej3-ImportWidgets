namespace WisejWebPageApplication1
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
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.Location = new System.Drawing.Point(117, 88);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "particles.js";
            package1.Source = "https://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js";
            this.widget1.Packages.Add(package1);
            this.widget1.Size = new System.Drawing.Size(561, 402);
            this.widget1.TabIndex = 0;
            this.widget1.Text = "widget1";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.widget1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(787, 564);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Widget widget1;
    }
}

