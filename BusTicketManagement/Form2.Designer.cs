namespace BusTicketManagement
{
    public partial class FormBusTicketBD
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
            this.panelSignInForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSignInForm
            // 
            this.panelSignInForm.Location = new System.Drawing.Point(-1, 0);
            this.panelSignInForm.Name = "panelSignInForm";
            this.panelSignInForm.Size = new System.Drawing.Size(723, 647);
            this.panelSignInForm.TabIndex = 0;
            this.panelSignInForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignInForm_Paint);
            // 
            // FormBusTicketBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 646);
            this.Controls.Add(this.panelSignInForm);
            this.Name = "FormBusTicketBD";
            this.Text = "BusTicketBD";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSignInForm;
    }
}