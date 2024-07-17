namespace Census_System
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Hello = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.label_familycount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marital_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indigenous_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.household_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educational_attainment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.school_attended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_enrollment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.health_insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voter_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.Location = new System.Drawing.Point(199, 12);
            this.Hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(49, 19);
            this.Hello.TabIndex = 0;
            this.Hello.Text = "label1";
            this.Hello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hello.Click += new System.EventHandler(this.Hello_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(320, 12);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 19);
            this.date.TabIndex = 1;
            this.date.Text = "Date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 44);
            this.panel1.TabIndex = 2;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(452, 12);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(43, 19);
            this.time.TabIndex = 11;
            this.time.Text = "Time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::Census_System.Properties.Resources.images;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(864, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.LightCoral;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(754, 7);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(92, 27);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.Hello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 39);
            this.panel2.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(29, 7);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 28);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add New Data";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(569, 6);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 28);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBox.BackColor = System.Drawing.Color.Linen;
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(676, 7);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(211, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 344);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btn_export);
            this.panel4.Controls.Add(this.label_familycount);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(894, 37);
            this.panel4.TabIndex = 5;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Yellow;
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_export.Location = new System.Drawing.Point(781, 0);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 37);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "Export Data";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label_familycount
            // 
            this.label_familycount.AutoSize = true;
            this.label_familycount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_familycount.ForeColor = System.Drawing.Color.Red;
            this.label_familycount.Location = new System.Drawing.Point(232, 10);
            this.label_familycount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_familycount.Name = "label_familycount";
            this.label_familycount.Size = new System.Drawing.Size(16, 17);
            this.label_familycount.TabIndex = 2;
            this.label_familycount.Text = "#";
            this.label_familycount.Click += new System.EventHandler(this.label_familycount_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total number of registered people:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Census_System.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Census_System.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.full_name,
            this.birth_date,
            this.age,
            this.gender,
            this.marital_status,
            this.citizenship,
            this.religion,
            this.indigenous_group,
            this.address,
            this.mobile_number,
            this.email_address,
            this.relationship,
            this.household_size,
            this.educational_attainment,
            this.school_attended,
            this.current_enrollment_status,
            this.employment_status,
            this.health_insurance,
            this.voter_status,
            this.disability,
            this.btn_edit,
            this.btn_delete});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(894, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Visible = false;
            this.Column1.Width = 5;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.full_name.HeaderText = "Full Name";
            this.full_name.Name = "full_name";
            this.full_name.Width = 93;
            // 
            // birth_date
            // 
            this.birth_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birth_date.HeaderText = "Birth Date";
            this.birth_date.Name = "birth_date";
            this.birth_date.Width = 94;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.Width = 57;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 75;
            // 
            // marital_status
            // 
            this.marital_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marital_status.HeaderText = "Marital Status";
            this.marital_status.Name = "marital_status";
            this.marital_status.Width = 114;
            // 
            // citizenship
            // 
            this.citizenship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.citizenship.HeaderText = "Citizenship";
            this.citizenship.Name = "citizenship";
            this.citizenship.Width = 95;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.religion.HeaderText = "Religion";
            this.religion.Name = "religion";
            this.religion.Width = 79;
            // 
            // indigenous_group
            // 
            this.indigenous_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.indigenous_group.HeaderText = "Indigenous Group";
            this.indigenous_group.Name = "indigenous_group";
            this.indigenous_group.Width = 135;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 81;
            // 
            // mobile_number
            // 
            this.mobile_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mobile_number.HeaderText = "Mobile Number";
            this.mobile_number.Name = "mobile_number";
            this.mobile_number.Width = 124;
            // 
            // email_address
            // 
            this.email_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email_address.HeaderText = "Email Address";
            this.email_address.Name = "email_address";
            this.email_address.Width = 117;
            // 
            // relationship
            // 
            this.relationship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.relationship.HeaderText = "Relationship to Household Head";
            this.relationship.Name = "relationship";
            this.relationship.Width = 220;
            // 
            // household_size
            // 
            this.household_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.household_size.HeaderText = "Household Size";
            this.household_size.Name = "household_size";
            this.household_size.Width = 122;
            // 
            // educational_attainment
            // 
            this.educational_attainment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.educational_attainment.HeaderText = "Educational Attainment";
            this.educational_attainment.Name = "educational_attainment";
            this.educational_attainment.Width = 168;
            // 
            // school_attended
            // 
            this.school_attended.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.school_attended.HeaderText = "School Attended";
            this.school_attended.Name = "school_attended";
            this.school_attended.Width = 128;
            // 
            // current_enrollment_status
            // 
            this.current_enrollment_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.current_enrollment_status.HeaderText = "Current Enrollment Status";
            this.current_enrollment_status.Name = "current_enrollment_status";
            this.current_enrollment_status.Width = 184;
            // 
            // employment_status
            // 
            this.employment_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employment_status.HeaderText = "Employment Status";
            this.employment_status.Name = "employment_status";
            this.employment_status.Width = 145;
            // 
            // health_insurance
            // 
            this.health_insurance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.health_insurance.HeaderText = "Health Insurance Coverage";
            this.health_insurance.Name = "health_insurance";
            this.health_insurance.Width = 194;
            // 
            // voter_status
            // 
            this.voter_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.voter_status.HeaderText = "Voter Status";
            this.voter_status.Name = "voter_status";
            this.voter_status.Width = 104;
            // 
            // disability
            // 
            this.disability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.disability.HeaderText = "Disability";
            this.disability.Name = "disability";
            this.disability.Width = 86;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btn_edit.HeaderText = "";
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_edit.Text = "Edit/View";
            this.btn_edit.UseColumnTextForButtonValue = true;
            this.btn_edit.Width = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseColumnTextForButtonValue = true;
            this.btn_delete.Width = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barangay San Isidro Galas Census System";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(894, 464);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label_familycount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn marital_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenship;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn indigenous_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn household_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn educational_attainment;
        private System.Windows.Forms.DataGridViewTextBoxColumn school_attended;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_enrollment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn employment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn health_insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn voter_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn disability;
        private System.Windows.Forms.DataGridViewButtonColumn btn_edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
        private System.Windows.Forms.Label label2;
    }
}