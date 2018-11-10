namespace BusTicketAdmin
{
    partial class FormCreateInfo
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
            this.panelCreateInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelCreateInfo
            // 
            this.panelCreateInfo.Location = new System.Drawing.Point(0, 0);
            this.panelCreateInfo.Name = "panelCreateInfo";
            this.panelCreateInfo.Size = new System.Drawing.Size(1220, 780);
            this.panelCreateInfo.TabIndex = 0;
            // 
            // FormCreateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 782);
            this.Controls.Add(this.panelCreateInfo);
            this.Name = "FormCreateInfo";
            this.Text = "FormCreateInfo";
            this.Load += new System.EventHandler(this.FormCreateInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateInfo;
    }
}