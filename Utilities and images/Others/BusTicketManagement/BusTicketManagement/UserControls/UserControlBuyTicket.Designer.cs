namespace BusTicketManagement
{
    partial class UserControlBuyTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBuyTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFareTicket = new System.Windows.Forms.Label();
            this.labelTotalTicket = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelOperatorName = new System.Windows.Forms.Label();
            this.ButtonSearchAgain = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.LabelFare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 670);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "And Get Amazing Discount!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create An Account Today";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelFareTicket);
            this.panel2.Controls.Add(this.labelTotalTicket);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LabelOperatorName);
            this.panel2.Controls.Add(this.ButtonSearchAgain);
            this.panel2.Controls.Add(this.ButtonConfirm);
            this.panel2.Controls.Add(this.LabelFare);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(343, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 669);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelFareTicket
            // 
            this.labelFareTicket.AutoSize = true;
            this.labelFareTicket.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFareTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelFareTicket.Location = new System.Drawing.Point(212, 160);
            this.labelFareTicket.Name = "labelFareTicket";
            this.labelFareTicket.Size = new System.Drawing.Size(60, 23);
            this.labelFareTicket.TabIndex = 17;
            this.labelFareTicket.Text = "Taka";
            this.labelFareTicket.Click += new System.EventHandler(this.labelFareTicket_Click);
            // 
            // labelTotalTicket
            // 
            this.labelTotalTicket.AutoSize = true;
            this.labelTotalTicket.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTotalTicket.Location = new System.Drawing.Point(212, 134);
            this.labelTotalTicket.Name = "labelTotalTicket";
            this.labelTotalTicket.Size = new System.Drawing.Size(67, 23);
            this.labelTotalTicket.TabIndex = 16;
            this.labelTotalTicket.Text = "Name";
            this.labelTotalTicket.Click += new System.EventHandler(this.labelOperatorNameDb_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Location = new System.Drawing.Point(8, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 10);
            this.panel3.TabIndex = 14;
            // 
            // LabelOperatorName
            // 
            this.LabelOperatorName.AutoSize = true;
            this.LabelOperatorName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperatorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelOperatorName.Location = new System.Drawing.Point(26, 134);
            this.LabelOperatorName.Name = "LabelOperatorName";
            this.LabelOperatorName.Size = new System.Drawing.Size(135, 23);
            this.LabelOperatorName.TabIndex = 13;
            this.LabelOperatorName.Text = "Total Ticket:";
            // 
            // ButtonSearchAgain
            // 
            this.ButtonSearchAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSearchAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchAgain.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchAgain.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchAgain.Location = new System.Drawing.Point(18, 254);
            this.ButtonSearchAgain.Name = "ButtonSearchAgain";
            this.ButtonSearchAgain.Size = new System.Drawing.Size(306, 37);
            this.ButtonSearchAgain.TabIndex = 11;
            this.ButtonSearchAgain.Text = "Search Again";
            this.ButtonSearchAgain.UseVisualStyleBackColor = false;
            this.ButtonSearchAgain.Click += new System.EventHandler(this.ButtonSearchAgain_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(18, 198);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(306, 37);
            this.ButtonConfirm.TabIndex = 3;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // LabelFare
            // 
            this.LabelFare.AutoSize = true;
            this.LabelFare.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelFare.Location = new System.Drawing.Point(28, 162);
            this.LabelFare.Name = "LabelFare";
            this.LabelFare.Size = new System.Drawing.Size(68, 23);
            this.LabelFare.TabIndex = 1;
            this.LabelFare.Text = "Fare :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ticket Summery";
            // 
            // UserControlBuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlBuyTicket";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControlBuyTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFareTicket;
        private System.Windows.Forms.Label labelTotalTicket;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelOperatorName;
        private System.Windows.Forms.Button ButtonSearchAgain;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Label LabelFare;
        private System.Windows.Forms.Label label3;
    }
}
