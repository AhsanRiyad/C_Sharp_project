using System.Windows.Forms;

namespace BusTicketManagement
{
    partial class UserControlShowBusesGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlShowBusesGridView));
            this.dataGridViewBusAvailable = new System.Windows.Forms.DataGridView();
            this.ButtonSignIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelSeatAv = new System.Windows.Forms.Label();
            this.labelFare = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBusName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelToFrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcomUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusAvailable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBusAvailable
            // 
            this.dataGridViewBusAvailable.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewBusAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusAvailable.Location = new System.Drawing.Point(317, 110);
            this.dataGridViewBusAvailable.Name = "dataGridViewBusAvailable";
            this.dataGridViewBusAvailable.Size = new System.Drawing.Size(393, 353);
            this.dataGridViewBusAvailable.TabIndex = 3;
            this.dataGridViewBusAvailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBusAvailable_CellContentClick);
            this.dataGridViewBusAvailable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_RowHeaderMouseClick);
            // 
            // ButtonSignIn
            // 
            this.ButtonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ButtonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignIn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.ButtonSignIn.Location = new System.Drawing.Point(324, 484);
            this.ButtonSignIn.Name = "ButtonSignIn";
            this.ButtonSignIn.Size = new System.Drawing.Size(366, 37);
            this.ButtonSignIn.TabIndex = 12;
            this.ButtonSignIn.Text = "Show Seat";
            this.ButtonSignIn.UseVisualStyleBackColor = false;
            this.ButtonSignIn.Click += new System.EventHandler(this.ButtonSignIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(324, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 667);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.labelSeatAv);
            this.panel4.Controls.Add(this.labelFare);
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Controls.Add(this.labelBusName);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(9, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 149);
            this.panel4.TabIndex = 24;
            // 
            // labelSeatAv
            // 
            this.labelSeatAv.AutoSize = true;
            this.labelSeatAv.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatAv.ForeColor = System.Drawing.Color.White;
            this.labelSeatAv.Location = new System.Drawing.Point(3, 112);
            this.labelSeatAv.Name = "labelSeatAv";
            this.labelSeatAv.Size = new System.Drawing.Size(156, 23);
            this.labelSeatAv.TabIndex = 30;
            this.labelSeatAv.Text = "Seats Avilable";
            // 
            // labelFare
            // 
            this.labelFare.AutoSize = true;
            this.labelFare.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFare.ForeColor = System.Drawing.Color.White;
            this.labelFare.Location = new System.Drawing.Point(3, 87);
            this.labelFare.Name = "labelFare";
            this.labelFare.Size = new System.Drawing.Size(57, 23);
            this.labelFare.TabIndex = 29;
            this.labelFare.Text = "Fare";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(3, 64);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 23);
            this.labelTime.TabIndex = 28;
            this.labelTime.Text = "Time";
            // 
            // labelBusName
            // 
            this.labelBusName.AutoSize = true;
            this.labelBusName.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusName.ForeColor = System.Drawing.Color.White;
            this.labelBusName.Location = new System.Drawing.Point(3, 41);
            this.labelBusName.Name = "labelBusName";
            this.labelBusName.Size = new System.Drawing.Size(114, 23);
            this.labelBusName.TabIndex = 27;
            this.labelBusName.Text = "Bus Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "#You have selected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelToFrom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(9, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 149);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Trip";
            // 
            // labelToFrom
            // 
            this.labelToFrom.AutoSize = true;
            this.labelToFrom.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToFrom.ForeColor = System.Drawing.Color.White;
            this.labelToFrom.Location = new System.Drawing.Point(19, 49);
            this.labelToFrom.Name = "labelToFrom";
            this.labelToFrom.Size = new System.Drawing.Size(112, 23);
            this.labelToFrom.TabIndex = 26;
            this.labelToFrom.Text = "to to from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "#You are searching for";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "to select trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "*click on row header";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 128);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelWelcomUser
            // 
            this.labelWelcomUser.AutoSize = true;
            this.labelWelcomUser.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelWelcomUser.Location = new System.Drawing.Point(338, 16);
            this.labelWelcomUser.Name = "labelWelcomUser";
            this.labelWelcomUser.Size = new System.Drawing.Size(339, 33);
            this.labelWelcomUser.TabIndex = 16;
            this.labelWelcomUser.Text = "Showing Available Trip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(362, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "For:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDateText
            // 
            this.labelDateText.AutoSize = true;
            this.labelDateText.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelDateText.Location = new System.Drawing.Point(439, 49);
            this.labelDateText.Name = "labelDateText";
            this.labelDateText.Size = new System.Drawing.Size(94, 33);
            this.labelDateText.TabIndex = 18;
            this.labelDateText.Text = "For11";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(315, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 10);
            this.panel3.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(324, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Next Day";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControlShowBusesGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelDateText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcomUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSignIn);
            this.Controls.Add(this.dataGridViewBusAvailable);
            this.Name = "UserControlShowBusesGridView";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControlShowBusesGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusAvailable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBusAvailable;
        private System.Windows.Forms.Button ButtonSignIn;
        private System.Windows.Forms.Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelWelcomUser;
        private Label label1;
        private Label labelDateText;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Label labelToFrom;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label labelSeatAv;
        private Label labelFare;
        private Label labelTime;
        private Label labelBusName;
        private Label label6;
        private Label label4;
    }
}
