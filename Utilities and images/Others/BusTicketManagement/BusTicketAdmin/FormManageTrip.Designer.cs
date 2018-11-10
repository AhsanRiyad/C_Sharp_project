namespace BusTicketAdmin
{
    partial class FormManageTrip
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelManageTrip = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelManageTrip
            // 
            this.panelManageTrip.Location = new System.Drawing.Point(2, 0);
            this.panelManageTrip.Name = "panelManageTrip";
            this.panelManageTrip.Size = new System.Drawing.Size(1031, 773);
            this.panelManageTrip.TabIndex = 0;
            // 
            // FormManageTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 785);
            this.Controls.Add(this.panelManageTrip);
            this.Name = "FormManageTrip";
            this.Text = "FormManageTrip";
            this.Load += new System.EventHandler(this.FormManageTrip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageTrip;
    }
}