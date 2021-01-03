
namespace CarryGO.userControls
{
    partial class ucCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CustomerLastNameBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carryGODBDataSet2 = new CarryGO.CarryGODBDataSet2();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearchbyName = new System.Windows.Forms.Button();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.genderTableAdapter = new CarryGO.CarryGODBDataSet2TableAdapters.GenderTableAdapter();
            this.customerTableAdapter = new CarryGO.CarryGODBDataSet2TableAdapters.CustomerTableAdapter();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carryGODBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 123);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CarryGO.Properties.Resources.WELCOME4;
            this.pictureBox1.Location = new System.Drawing.Point(430, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 471);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.IDBox);
            this.splitContainer1.Panel1.Controls.Add(this.MailBox);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerLastNameBox);
            this.splitContainer1.Panel1.Controls.Add(this.GenderComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.PhoneBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.AddressBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CustomerNameBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 471);
            this.splitContainer1.SplitterDistance = 426;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Customer ID";
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.Coral;
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.IDBox.ForeColor = System.Drawing.Color.White;
            this.IDBox.Location = new System.Drawing.Point(166, 144);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(205, 30);
            this.IDBox.TabIndex = 58;
            this.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MailBox
            // 
            this.MailBox.BackColor = System.Drawing.Color.Coral;
            this.MailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MailBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.MailBox.ForeColor = System.Drawing.Color.White;
            this.MailBox.Location = new System.Drawing.Point(165, 384);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(205, 30);
            this.MailBox.TabIndex = 57;
            this.MailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(66, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(98, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 54;
            this.label12.Text = "Name";
            // 
            // CustomerLastNameBox
            // 
            this.CustomerLastNameBox.BackColor = System.Drawing.Color.Coral;
            this.CustomerLastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerLastNameBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.CustomerLastNameBox.ForeColor = System.Drawing.Color.White;
            this.CustomerLastNameBox.Location = new System.Drawing.Point(166, 97);
            this.CustomerLastNameBox.Name = "CustomerLastNameBox";
            this.CustomerLastNameBox.Size = new System.Drawing.Size(205, 30);
            this.CustomerLastNameBox.TabIndex = 51;
            this.CustomerLastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.Coral;
            this.GenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CustomerGender", true));
            this.GenderComboBox.DataSource = this.genderBindingSource;
            this.GenderComboBox.DisplayMember = "GenderName";
            this.GenderComboBox.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(165, 285);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(205, 38);
            this.GenderComboBox.TabIndex = 50;
            this.GenderComboBox.ValueMember = "GenderID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.carryGODBDataSet2;
            // 
            // carryGODBDataSet2
            // 
            this.carryGODBDataSet2.DataSetName = "CarryGODBDataSet2";
            this.carryGODBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.carryGODBDataSet2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(108, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 47;
            this.label11.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(92, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(75, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address";
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.Coral;
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.PhoneBox.ForeColor = System.Drawing.Color.White;
            this.PhoneBox.Location = new System.Drawing.Point(165, 339);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(205, 30);
            this.PhoneBox.TabIndex = 43;
            this.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Customer";
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.Color.Coral;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.AddressBox.ForeColor = System.Drawing.Color.White;
            this.AddressBox.Location = new System.Drawing.Point(165, 186);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(205, 86);
            this.AddressBox.TabIndex = 40;
            this.AddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Customer";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.BackColor = System.Drawing.Color.Coral;
            this.CustomerNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNameBox.Font = new System.Drawing.Font("Google Sans Medium", 14F, System.Drawing.FontStyle.Bold);
            this.CustomerNameBox.ForeColor = System.Drawing.Color.White;
            this.CustomerNameBox.Location = new System.Drawing.Point(166, 48);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(205, 30);
            this.CustomerNameBox.TabIndex = 36;
            this.CustomerNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataCustomer
            // 
            this.dataCustomer.AllowUserToAddRows = false;
            this.dataCustomer.AllowUserToDeleteRows = false;
            this.dataCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.ReadOnly = true;
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCustomer.Size = new System.Drawing.Size(850, 471);
            this.dataCustomer.TabIndex = 1;
            this.dataCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCustomer_CellEnter);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.panel6);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 594);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1280, 126);
            this.panelBottom.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel6.BackgroundImage = global::CarryGO.Properties.Resources.WELCOME_1_1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.btnSearchbyName);
            this.panel6.Controls.Add(this.btnViewCustomer);
            this.panel6.Controls.Add(this.btnAddCustomer);
            this.panel6.Controls.Add(this.btnUpdateCustomer);
            this.panel6.Controls.Add(this.btnDeleteCustomer);
            this.panel6.Controls.Add(this.errorLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1280, 120);
            this.panel6.TabIndex = 25;
            // 
            // btnSearchbyName
            // 
            this.btnSearchbyName.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchbyName.BackgroundImage = global::CarryGO.Properties.Resources.searchbyName;
            this.btnSearchbyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchbyName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchbyName.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSearchbyName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchbyName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearchbyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchbyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.btnSearchbyName.Location = new System.Drawing.Point(643, 24);
            this.btnSearchbyName.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnSearchbyName.Name = "btnSearchbyName";
            this.btnSearchbyName.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.btnSearchbyName.Size = new System.Drawing.Size(119, 59);
            this.btnSearchbyName.TabIndex = 29;
            this.btnSearchbyName.UseVisualStyleBackColor = false;
            this.btnSearchbyName.Click += new System.EventHandler(this.btnSearchbyName_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomer.BackgroundImage = global::CarryGO.Properties.Resources.ViewCostumer;
            this.btnViewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.btnViewCustomer.Location = new System.Drawing.Point(510, 24);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.btnViewCustomer.Size = new System.Drawing.Size(119, 59);
            this.btnViewCustomer.TabIndex = 28;
            this.btnViewCustomer.UseVisualStyleBackColor = false;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.BackgroundImage = global::CarryGO.Properties.Resources.addCustomer;
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(166, 27);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.btnAddCustomer.Size = new System.Drawing.Size(119, 59);
            this.btnAddCustomer.TabIndex = 27;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomer.BackgroundImage = global::CarryGO.Properties.Resources.Screenshot_2020_12_30_WELCOME;
            this.btnUpdateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(301, 27);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.btnUpdateCustomer.Size = new System.Drawing.Size(61, 59);
            this.btnUpdateCustomer.TabIndex = 26;
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.BackgroundImage = global::CarryGO.Properties.Resources.Screenshot_2020_12_30_WELCOME_2_;
            this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(377, 27);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.btnDeleteCustomer.Size = new System.Drawing.Size(119, 56);
            this.btnDeleteCustomer.TabIndex = 25;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Google Sans", 14F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.errorLabel.Location = new System.Drawing.Point(841, 39);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(402, 30);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "ADD NEW CUSTOMER TO SYSTEM";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarryGO.Properties.Resources.MainPageBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carryGODBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CustomerLastNameBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CarryGODBDataSet2 carryGODBDataSet2;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private CarryGODBDataSet2TableAdapters.GenderTableAdapter genderTableAdapter;
        private CarryGODBDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button btnSearchbyName;
        public System.Windows.Forms.DataGridView dataCustomer;
    }
}
