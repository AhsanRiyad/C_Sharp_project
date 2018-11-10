namespace BusTicketAdmin.NewFolder1
{
    partial class UserControlManageTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManageTrip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextboxseat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelseat = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxtype = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelType = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxfare = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelf = new System.Windows.Forms.Label();
            this.bunifuDropdownfrom = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdownto = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdowntime = new Bunifu.Framework.UI.BunifuDropdown();
            this.labeltime = new System.Windows.Forms.Label();
            this.bunifuDatepickerdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.labelfrom = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelname = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelid = new System.Windows.Forms.Label();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.Buttondelete = new System.Windows.Forms.Button();
            this.Buttoninsert = new System.Windows.Forms.Button();
            this.Buttonupdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 670);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 299);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 139);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuMaterialTextboxseat);
            this.panel2.Controls.Add(this.labelseat);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxtype);
            this.panel2.Controls.Add(this.labelType);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxfare);
            this.panel2.Controls.Add(this.labelf);
            this.panel2.Controls.Add(this.bunifuDropdownfrom);
            this.panel2.Controls.Add(this.bunifuDropdownto);
            this.panel2.Controls.Add(this.bunifuDropdowntime);
            this.panel2.Controls.Add(this.labeltime);
            this.panel2.Controls.Add(this.bunifuDatepickerdate);
            this.panel2.Controls.Add(this.labelfrom);
            this.panel2.Controls.Add(this.labelto);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxname);
            this.panel2.Controls.Add(this.labelname);
            this.panel2.Controls.Add(this.bunifuMaterialTextboxid);
            this.panel2.Controls.Add(this.labelid);
            this.panel2.Controls.Add(this.buttonlogout);
            this.panel2.Controls.Add(this.Buttondelete);
            this.panel2.Controls.Add(this.Buttoninsert);
            this.panel2.Controls.Add(this.Buttonupdate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(342, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 670);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuMaterialTextboxseat
            // 
            this.bunifuMaterialTextboxseat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextboxseat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxseat.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxseat.HintText = "";
            this.bunifuMaterialTextboxseat.isPassword = false;
            this.bunifuMaterialTextboxseat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxseat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxseat.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxseat.LineThickness = 3;
            this.bunifuMaterialTextboxseat.Location = new System.Drawing.Point(101, 403);
            this.bunifuMaterialTextboxseat.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxseat.Name = "bunifuMaterialTextboxseat";
            this.bunifuMaterialTextboxseat.Size = new System.Drawing.Size(131, 37);
            this.bunifuMaterialTextboxseat.TabIndex = 38;
            this.bunifuMaterialTextboxseat.Text = "24";
            this.bunifuMaterialTextboxseat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxseat.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextboxseat_OnValueChanged);
            // 
            // labelseat
            // 
            this.labelseat.AutoSize = true;
            this.labelseat.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelseat.Location = new System.Drawing.Point(3, 403);
            this.labelseat.Name = "labelseat";
            this.labelseat.Size = new System.Drawing.Size(87, 23);
            this.labelseat.TabIndex = 37;
            this.labelseat.Text = "Seat No";
            // 
            // bunifuMaterialTextboxtype
            // 
            this.bunifuMaterialTextboxtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextboxtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxtype.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxtype.HintText = "";
            this.bunifuMaterialTextboxtype.isPassword = false;
            this.bunifuMaterialTextboxtype.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxtype.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxtype.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxtype.LineThickness = 3;
            this.bunifuMaterialTextboxtype.Location = new System.Drawing.Point(101, 342);
            this.bunifuMaterialTextboxtype.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxtype.Name = "bunifuMaterialTextboxtype";
            this.bunifuMaterialTextboxtype.Size = new System.Drawing.Size(131, 37);
            this.bunifuMaterialTextboxtype.TabIndex = 36;
            this.bunifuMaterialTextboxtype.Text = "Non-AC";
            this.bunifuMaterialTextboxtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxtype.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextboxtype_OnValueChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelType.Location = new System.Drawing.Point(29, 352);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(58, 23);
            this.labelType.TabIndex = 35;
            this.labelType.Text = "Type";
            // 
            // bunifuMaterialTextboxfare
            // 
            this.bunifuMaterialTextboxfare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextboxfare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxfare.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxfare.HintText = "";
            this.bunifuMaterialTextboxfare.isPassword = false;
            this.bunifuMaterialTextboxfare.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxfare.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxfare.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxfare.LineThickness = 3;
            this.bunifuMaterialTextboxfare.Location = new System.Drawing.Point(101, 297);
            this.bunifuMaterialTextboxfare.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxfare.Name = "bunifuMaterialTextboxfare";
            this.bunifuMaterialTextboxfare.Size = new System.Drawing.Size(131, 37);
            this.bunifuMaterialTextboxfare.TabIndex = 34;
            this.bunifuMaterialTextboxfare.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelf
            // 
            this.labelf.AutoSize = true;
            this.labelf.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelf.Location = new System.Drawing.Point(29, 305);
            this.labelf.Name = "labelf";
            this.labelf.Size = new System.Drawing.Size(56, 23);
            this.labelf.TabIndex = 33;
            this.labelf.Text = "Fare";
            // 
            // bunifuDropdownfrom
            // 
            this.bunifuDropdownfrom.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownfrom.BorderRadius = 3;
            this.bunifuDropdownfrom.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownfrom.Items = new string[] {
        "From",
        "Rangpur",
        "Sylhet",
        "Barisal",
        "Dhaka",
        "Khulna",
        "Chittagong",
        "Rajshahi",
        "Mymensigh"};
            this.bunifuDropdownfrom.Location = new System.Drawing.Point(101, 205);
            this.bunifuDropdownfrom.Name = "bunifuDropdownfrom";
            this.bunifuDropdownfrom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdownfrom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdownfrom.selectedIndex = 0;
            this.bunifuDropdownfrom.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdownfrom.TabIndex = 32;
            // 
            // bunifuDropdownto
            // 
            this.bunifuDropdownto.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownto.BorderRadius = 3;
            this.bunifuDropdownto.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownto.Items = new string[] {
        "To",
        "Dhaka",
        "Khulna",
        "Chittagong",
        "Rajshahi",
        "Mymensigh",
        "Rangpur",
        "Sylhet",
        "Barisal"};
            this.bunifuDropdownto.Location = new System.Drawing.Point(101, 155);
            this.bunifuDropdownto.Name = "bunifuDropdownto";
            this.bunifuDropdownto.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdownto.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdownto.selectedIndex = 0;
            this.bunifuDropdownto.Size = new System.Drawing.Size(206, 36);
            this.bunifuDropdownto.TabIndex = 31;
            this.bunifuDropdownto.onItemSelected += new System.EventHandler(this.bunifuDropdownto_onItemSelected);
            // 
            // bunifuDropdowntime
            // 
            this.bunifuDropdowntime.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdowntime.BorderRadius = 3;
            this.bunifuDropdowntime.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdowntime.Items = new string[] {
        "Time",
        "10:00 ",
        "12:30",
        "14:00",
        "15:00",
        "22:00"};
            this.bunifuDropdowntime.Location = new System.Drawing.Point(101, 255);
            this.bunifuDropdowntime.Name = "bunifuDropdowntime";
            this.bunifuDropdowntime.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdowntime.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDropdowntime.selectedIndex = 0;
            this.bunifuDropdowntime.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdowntime.TabIndex = 30;
            this.bunifuDropdowntime.onItemSelected += new System.EventHandler(this.bunifuDropdowntime_onItemSelected);
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labeltime.Location = new System.Drawing.Point(24, 255);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(60, 23);
            this.labeltime.TabIndex = 29;
            this.labeltime.Text = "Time";
            // 
            // bunifuDatepickerdate
            // 
            this.bunifuDatepickerdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuDatepickerdate.BorderRadius = 0;
            this.bunifuDatepickerdate.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepickerdate.FormatCustom = null;
            this.bunifuDatepickerdate.Location = new System.Drawing.Point(30, 459);
            this.bunifuDatepickerdate.Name = "bunifuDatepickerdate";
            this.bunifuDatepickerdate.Size = new System.Drawing.Size(303, 36);
            this.bunifuDatepickerdate.TabIndex = 25;
            this.bunifuDatepickerdate.Value = new System.DateTime(2018, 9, 4, 14, 14, 27, 456);
            this.bunifuDatepickerdate.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelfrom.Location = new System.Drawing.Point(18, 205);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(62, 23);
            this.labelfrom.TabIndex = 24;
            this.labelfrom.Text = "From";
            this.labelfrom.Click += new System.EventHandler(this.labelfrom_Click);
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelto.Location = new System.Drawing.Point(26, 155);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(35, 23);
            this.labelto.TabIndex = 23;
            this.labelto.Text = "To";
            this.labelto.Click += new System.EventHandler(this.labelfare_Click);
            // 
            // bunifuMaterialTextboxname
            // 
            this.bunifuMaterialTextboxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextboxname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxname.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxname.HintText = "";
            this.bunifuMaterialTextboxname.isPassword = false;
            this.bunifuMaterialTextboxname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxname.LineThickness = 3;
            this.bunifuMaterialTextboxname.Location = new System.Drawing.Point(101, 64);
            this.bunifuMaterialTextboxname.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxname.Name = "bunifuMaterialTextboxname";
            this.bunifuMaterialTextboxname.Size = new System.Drawing.Size(131, 37);
            this.bunifuMaterialTextboxname.TabIndex = 21;
            this.bunifuMaterialTextboxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelname.Location = new System.Drawing.Point(18, 77);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(67, 23);
            this.labelname.TabIndex = 20;
            this.labelname.Text = "Name";
            // 
            // bunifuMaterialTextboxid
            // 
            this.bunifuMaterialTextboxid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextboxid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxid.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxid.HintText = "";
            this.bunifuMaterialTextboxid.isPassword = false;
            this.bunifuMaterialTextboxid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxid.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuMaterialTextboxid.LineThickness = 3;
            this.bunifuMaterialTextboxid.Location = new System.Drawing.Point(101, 109);
            this.bunifuMaterialTextboxid.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxid.Name = "bunifuMaterialTextboxid";
            this.bunifuMaterialTextboxid.Size = new System.Drawing.Size(131, 33);
            this.bunifuMaterialTextboxid.TabIndex = 19;
            this.bunifuMaterialTextboxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelid.Location = new System.Drawing.Point(30, 119);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(31, 23);
            this.labelid.TabIndex = 18;
            this.labelid.Text = "Id";
            this.labelid.Click += new System.EventHandler(this.labeladdid_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.Color.White;
            this.buttonlogout.Location = new System.Drawing.Point(27, 630);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(306, 37);
            this.buttonlogout.TabIndex = 17;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // Buttondelete
            // 
            this.Buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttondelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttondelete.ForeColor = System.Drawing.Color.White;
            this.Buttondelete.Location = new System.Drawing.Point(27, 587);
            this.Buttondelete.Name = "Buttondelete";
            this.Buttondelete.Size = new System.Drawing.Size(306, 37);
            this.Buttondelete.TabIndex = 14;
            this.Buttondelete.Text = "Delete";
            this.Buttondelete.UseVisualStyleBackColor = false;
            this.Buttondelete.Click += new System.EventHandler(this.Buttondelete_Click);
            // 
            // Buttoninsert
            // 
            this.Buttoninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Buttoninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttoninsert.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttoninsert.ForeColor = System.Drawing.Color.White;
            this.Buttoninsert.Location = new System.Drawing.Point(28, 501);
            this.Buttoninsert.Name = "Buttoninsert";
            this.Buttoninsert.Size = new System.Drawing.Size(306, 37);
            this.Buttoninsert.TabIndex = 11;
            this.Buttoninsert.Text = "Insert";
            this.Buttoninsert.UseVisualStyleBackColor = false;
            this.Buttoninsert.Click += new System.EventHandler(this.Buttoninsert_Click);
            // 
            // Buttonupdate
            // 
            this.Buttonupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buttonupdate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonupdate.ForeColor = System.Drawing.Color.White;
            this.Buttonupdate.Location = new System.Drawing.Point(28, 544);
            this.Buttonupdate.Name = "Buttonupdate";
            this.Buttonupdate.Size = new System.Drawing.Size(306, 37);
            this.Buttonupdate.TabIndex = 3;
            this.Buttonupdate.Text = "Update";
            this.Buttonupdate.UseVisualStyleBackColor = false;
            this.Buttonupdate.Click += new System.EventHandler(this.Buttonupdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome";
            // 
            // UserControlManageTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlManageTrip";
            this.Size = new System.Drawing.Size(732, 670);
            this.Load += new System.EventHandler(this.UserControlManageTrip_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxname;
        private System.Windows.Forms.Label labelname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button Buttondelete;
        private System.Windows.Forms.Button Buttoninsert;
        private System.Windows.Forms.Button Buttonupdate;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepickerdate;
        private System.Windows.Forms.Label labelfrom;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownfrom;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownto;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdowntime;
        private System.Windows.Forms.Label labeltime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxfare;
        private System.Windows.Forms.Label labelf;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxseat;
        private System.Windows.Forms.Label labelseat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxtype;
        private System.Windows.Forms.Label labelType;
    }
}
