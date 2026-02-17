namespace testtest
{
    partial class EditDispensers
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDispensers));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDispensers = new System.Windows.Forms.TabPage();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.comboBoxFloor = new Krypton.Toolkit.KryptonComboBox();
            this.comboBoxUser = new Krypton.Toolkit.KryptonComboBox();
            this.textBoxId = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dispensersGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.textBoxPriority = new Krypton.Toolkit.KryptonTextBox();
            this.textBoxPassword = new Krypton.Toolkit.KryptonTextBox();
            this.textboxUsername = new Krypton.Toolkit.KryptonTextBox();
            this.btnClearUserField = new Krypton.Toolkit.KryptonButton();
            this.btnDeleteUser = new Krypton.Toolkit.KryptonButton();
            this.btnUpdateUser = new Krypton.Toolkit.KryptonButton();
            this.btnAddUser = new Krypton.Toolkit.KryptonButton();
            this.usersGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.usageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnFilter = new Krypton.Toolkit.KryptonButton();
            this.dtpStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.dtpEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.tabControl1.SuspendLayout();
            this.tabDispensers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensersGridView)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDispensers);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDispensers
            // 
            this.tabDispensers.Controls.Add(this.kryptonGroupBox1);
            this.tabDispensers.Controls.Add(this.dispensersGridView);
            this.tabDispensers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDispensers.Location = new System.Drawing.Point(4, 33);
            this.tabDispensers.Margin = new System.Windows.Forms.Padding(4);
            this.tabDispensers.Name = "tabDispensers";
            this.tabDispensers.Padding = new System.Windows.Forms.Padding(4);
            this.tabDispensers.Size = new System.Drawing.Size(1059, 517);
            this.tabDispensers.TabIndex = 0;
            this.tabDispensers.Text = "Manage dispensers";
            this.tabDispensers.UseVisualStyleBackColor = true;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(537, 4);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnClear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDelete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnUpdate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnAdd);
            this.kryptonGroupBox1.Panel.Controls.Add(this.comboBoxFloor);
            this.kryptonGroupBox1.Panel.Controls.Add(this.comboBoxUser);
            this.kryptonGroupBox1.Panel.Controls.Add(this.textBoxId);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(518, 509);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Dispenser details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(379, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.TabIndex = 9;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAdd.Values.Text = "Add new";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.DropDownWidth = 160;
            this.comboBoxFloor.Location = new System.Drawing.Point(91, 137);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(160, 27);
            this.comboBoxFloor.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFloor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.comboBoxFloor.TabIndex = 5;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownWidth = 160;
            this.comboBoxUser.Location = new System.Drawing.Point(91, 94);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(160, 27);
            this.comboBoxUser.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.comboBoxUser.TabIndex = 4;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(91, 53);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(160, 28);
            this.textBoxId.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.TabIndex = 3;
            this.textBoxId.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 137);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(78, 22);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Floor:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(7, 94);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(78, 22);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "User:";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(19, 53);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 22);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "ID:";
            // 
            // dispensersGridView
            // 
            this.dispensersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispensersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispensersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dispensersGridView.Location = new System.Drawing.Point(4, 4);
            this.dispensersGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dispensersGridView.Name = "dispensersGridView";
            this.dispensersGridView.RowHeadersWidth = 51;
            this.dispensersGridView.RowTemplate.Height = 24;
            this.dispensersGridView.Size = new System.Drawing.Size(533, 509);
            this.dispensersGridView.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.kryptonGroupBox2);
            this.tabUsers.Controls.Add(this.usersGridView);
            this.tabUsers.Location = new System.Drawing.Point(4, 33);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tabUsers.Size = new System.Drawing.Size(1059, 517);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Manage users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionVisible = false;
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(537, 4);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox2.Panel.Controls.Add(this.textBoxPriority);
            this.kryptonGroupBox2.Panel.Controls.Add(this.textBoxPassword);
            this.kryptonGroupBox2.Panel.Controls.Add(this.textboxUsername);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnClearUserField);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnDeleteUser);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnUpdateUser);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnAddUser);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(518, 509);
            this.kryptonGroupBox2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "User details";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.AutoSize = false;
            this.kryptonLabel6.Location = new System.Drawing.Point(41, 137);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Floor:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(4, 94);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "Password:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(41, 52);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(71, 22);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "User:";
            this.kryptonLabel4.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(121, 137);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(160, 28);
            this.textBoxPriority.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPriority.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(121, 94);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(160, 28);
            this.textBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.TabIndex = 12;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(121, 48);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(160, 28);
            this.textboxUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.TabIndex = 11;
            // 
            // btnClearUserField
            // 
            this.btnClearUserField.Location = new System.Drawing.Point(379, 191);
            this.btnClearUserField.Name = "btnClearUserField";
            this.btnClearUserField.Size = new System.Drawing.Size(100, 34);
            this.btnClearUserField.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUserField.TabIndex = 10;
            this.btnClearUserField.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClearUserField.Values.Text = "Clear";
            this.btnClearUserField.Click += new System.EventHandler(this.btnClearUserField_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(259, 191);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDeleteUser.Values.Text = "Delete";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(139, 191);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.TabIndex = 8;
            this.btnUpdateUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUpdateUser.Values.Text = "Update";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(23, 191);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 34);
            this.btnAddUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddUser.Values.Text = "Add new";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersGridView.Location = new System.Drawing.Point(4, 4);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowHeadersWidth = 51;
            this.usersGridView.RowTemplate.Height = 24;
            this.usersGridView.Size = new System.Drawing.Size(533, 509);
            this.usersGridView.TabIndex = 0;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.usageChart);
            this.tabStatistics.Controls.Add(this.statsGridView);
            this.tabStatistics.Controls.Add(this.kryptonPanel1);
            this.tabStatistics.Location = new System.Drawing.Point(4, 33);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(1059, 517);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // usageChart
            // 
            this.usageChart.BackColor = System.Drawing.Color.GhostWhite;
            this.usageChart.BorderlineColor = System.Drawing.Color.RoyalBlue;
            chartArea2.Name = "ChartArea1";
            this.usageChart.ChartAreas.Add(chartArea2);
            this.usageChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.usageChart.Location = new System.Drawing.Point(3, 3);
            this.usageChart.Name = "usageChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.usageChart.Series.Add(series2);
            this.usageChart.Size = new System.Drawing.Size(616, 311);
            this.usageChart.TabIndex = 1;
            this.usageChart.Text = "chart1";
            // 
            // statsGridView
            // 
            this.statsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statsGridView.Location = new System.Drawing.Point(3, 314);
            this.statsGridView.Name = "statsGridView";
            this.statsGridView.RowHeadersWidth = 51;
            this.statsGridView.RowTemplate.Height = 24;
            this.statsGridView.Size = new System.Drawing.Size(1053, 200);
            this.statsGridView.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnFilter);
            this.kryptonPanel1.Controls.Add(this.dtpStart);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.dtpEnd);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Location = new System.Drawing.Point(614, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(442, 311);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(164, 147);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(142, 38);
            this.btnFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFilter.Values.Text = "Filter statistics";
            this.btnFilter.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(224, 43);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 27);
            this.dtpStart.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.TabIndex = 2;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.AutoSize = false;
            this.kryptonLabel7.Location = new System.Drawing.Point(115, 43);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(120, 25);
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 4;
            this.kryptonLabel7.Values.Text = "Start date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(224, 86);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 27);
            this.dtpEnd.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.TabIndex = 3;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.AutoSize = false;
            this.kryptonLabel8.Location = new System.Drawing.Point(120, 86);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(115, 25);
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 5;
            this.kryptonLabel8.Values.Text = "End date:";
            this.kryptonLabel8.Click += new System.EventHandler(this.kryptonLabel8_Click);
            // 
            // EditDispensers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDispensers";
            this.Text = "EditDispensers";
            this.Load += new System.EventHandler(this.EditDispensers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDispensers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispensersGridView)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDispensers;
        private System.Windows.Forms.TabPage tabUsers;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDataGridView dispensersGridView;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox comboBoxFloor;
        private Krypton.Toolkit.KryptonComboBox comboBoxUser;
        private Krypton.Toolkit.KryptonTextBox textBoxId;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnUpdate;
        private Krypton.Toolkit.KryptonDataGridView usersGridView;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonButton btnClearUserField;
        private Krypton.Toolkit.KryptonButton btnDeleteUser;
        private Krypton.Toolkit.KryptonButton btnUpdateUser;
        private Krypton.Toolkit.KryptonButton btnAddUser;
        private Krypton.Toolkit.KryptonTextBox textboxUsername;
        private Krypton.Toolkit.KryptonTextBox textBoxPriority;
        private Krypton.Toolkit.KryptonTextBox textBoxPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.TabPage tabStatistics;
        private Krypton.Toolkit.KryptonDataGridView statsGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart usageChart;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonDateTimePicker dtpEnd;
        private Krypton.Toolkit.KryptonDateTimePicker dtpStart;
        private Krypton.Toolkit.KryptonButton btnFilter;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}