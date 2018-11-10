using System;

namespace BusTicketManagement
{
    partial class UserControlSearchBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSearchBus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelOperatorName = new System.Windows.Forms.Label();
            this.ButtonSearchAgain = new System.Windows.Forms.Button();
            this.ButtonShowSeat = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.LabelFare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSeatAvailable = new System.Windows.Forms.Label();
            this.labelOperatorNameDb = new System.Windows.Forms.Label();
            this.labelFareDb = new System.Windows.Forms.Label();
            this.labelTimeDb = new System.Windows.Forms.Label();
            this.labelSeatDb = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.labelSeatDb);
            this.panel2.Controls.Add(this.labelTimeDb);
            this.panel2.Controls.Add(this.labelFareDb);
            this.panel2.Controls.Add(this.labelOperatorNameDb);
            this.panel2.Controls.Add(this.labelSeatAvailable);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LabelOperatorName);
            this.panel2.Controls.Add(this.ButtonSearchAgain);
            this.panel2.Controls.Add(this.ButtonShowSeat);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.LabelFare);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(344, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 669);
            this.panel2.TabIndex = 3;
            // 
            // LabelOperatorName
            // 
            this.LabelOperatorName.AutoSize = true;
            this.LabelOperatorName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperatorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelOperatorName.Location = new System.Drawing.Point(29, 86);
            this.LabelOperatorName.Name = "LabelOperatorName";
            this.LabelOperatorName.Size = new System.Drawing.Size(110, 23);
            this.LabelOperatorName.TabIndex = 13;
            this.LabelOperatorName.Text = "Operator :";
            this.LabelOperatorName.Click += new System.EventHandler(this.LabelOperatorName_Click);
            // 
            // ButtonSearchAgain
            // 
            this.ButtonSearchAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSearchAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchAgain.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchAgain.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchAgain.Location = new System.Drawing.Point(32, 572);
            this.ButtonSearchAgain.Name = "ButtonSearchAgain";
            this.ButtonSearchAgain.Size = new System.Drawing.Size(306, 37);
            this.ButtonSearchAgain.TabIndex = 11;
            this.ButtonSearchAgain.Text = "Search Again";
            this.ButtonSearchAgain.UseVisualStyleBackColor = false;
            // 
            // ButtonShowSeat
            // 
            this.ButtonShowSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonShowSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowSeat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowSeat.ForeColor = System.Drawing.Color.White;
            this.ButtonShowSeat.Location = new System.Drawing.Point(27, 187);
            this.ButtonShowSeat.Name = "ButtonShowSeat";
            this.ButtonShowSeat.Size = new System.Drawing.Size(306, 37);
            this.ButtonShowSeat.TabIndex = 3;
            this.ButtonShowSeat.Text = "Show Seat";
            this.ButtonShowSeat.UseVisualStyleBackColor = false;
            this.ButtonShowSeat.Click += new System.EventHandler(this.ButtonShowSeat_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTime.Location = new System.Drawing.Point(30, 134);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 23);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time :";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // LabelFare
            // 
            this.LabelFare.AutoSize = true;
            this.LabelFare.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LabelFare.Location = new System.Drawing.Point(30, 111);
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
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Buses";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Location = new System.Drawing.Point(12, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 10);
            this.panel3.TabIndex = 14;
            // 
            // labelSeatAvailable
            // 
            this.labelSeatAvailable.AutoSize = true;
            this.labelSeatAvailable.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelSeatAvailable.Location = new System.Drawing.Point(30, 157);
            this.labelSeatAvailable.Name = "labelSeatAvailable";
            this.labelSeatAvailable.Size = new System.Drawing.Size(166, 23);
            this.labelSeatAvailable.TabIndex = 15;
            this.labelSeatAvailable.Text = "Seat Available :";
            // 
            // labelOperatorNameDb
            // 
            this.labelOperatorNameDb.AutoSize = true;
            this.labelOperatorNameDb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperatorNameDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelOperatorNameDb.Location = new System.Drawing.Point(212, 86);
            this.labelOperatorNameDb.Name = "labelOperatorNameDb";
            this.labelOperatorNameDb.Size = new System.Drawing.Size(67, 23);
            this.labelOperatorNameDb.TabIndex = 16;
            this.labelOperatorNameDb.Text = "Name";
            // 
            // labelFareDb
            // 
            this.labelFareDb.AutoSize = true;
            this.labelFareDb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFareDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelFareDb.Location = new System.Drawing.Point(212, 111);
            this.labelFareDb.Name = "labelFareDb";
            this.labelFareDb.Size = new System.Drawing.Size(60, 23);
            this.labelFareDb.TabIndex = 17;
            this.labelFareDb.Text = "Taka";
            // 
            // labelTimeDb
            // 
            this.labelTimeDb.AutoSize = true;
            this.labelTimeDb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTimeDb.Location = new System.Drawing.Point(212, 134);
            this.labelTimeDb.Name = "labelTimeDb";
            this.labelTimeDb.Size = new System.Drawing.Size(49, 23);
            this.labelTimeDb.TabIndex = 18;
            this.labelTimeDb.Text = "Tim";
            // 
            // labelSeatDb
            // 
            this.labelSeatDb.AutoSize = true;
            this.labelSeatDb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelSeatDb.Location = new System.Drawing.Point(212, 157);
            this.labelSeatDb.Name = "labelSeatDb";
            this.labelSeatDb.Size = new System.Drawing.Size(34, 23);
            this.labelSeatDb.TabIndex = 19;
            this.labelSeatDb.Text = "40";
            // 
            // UserControlSearchBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlSearchBus";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControlSearchBus_Load);
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
        private System.Windows.Forms.Label labelSeatDb;
        private System.Windows.Forms.Label labelTimeDb;
        private System.Windows.Forms.Label labelFareDb;
        private System.Windows.Forms.Label labelOperatorNameDb;
        private System.Windows.Forms.Label labelSeatAvailable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelOperatorName;
        private System.Windows.Forms.Button ButtonSearchAgain;
        private System.Windows.Forms.Button ButtonShowSeat;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label LabelFare;
        private System.Windows.Forms.Label label3;
    }
}
