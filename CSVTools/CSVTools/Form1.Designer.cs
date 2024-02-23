namespace CSVTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            csvgenerate = new TabControl();
            csvgeneratepage = new TabPage();
            dataGridView1 = new DataGridView();
            lblCsvFileOption = new Label();
            panel1 = new Panel();
            txtLineNumber = new TextBox();
            lblLineNumber = new Label();
            btnBrowser = new Button();
            tbxOutputLocation = new TextBox();
            tbxFilename = new TextBox();
            lblOutputLocation = new Label();
            lblFilename = new Label();
            tbxLinePerFile = new TextBox();
            chkSplitFile = new CheckBox();
            lblLinePerFile2 = new Label();
            lblLinePerFile1 = new Label();
            tabPage2 = new TabPage();
            btnRun = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            grbHandle = new GroupBox();
            Header = new DataGridViewTextBoxColumn();
            Type = new DataGridViewComboBoxColumn();
            PaddingZero = new DataGridViewCheckBoxColumn();
            PaddingZeroLen = new DataGridViewTextBoxColumn();
            IsRandom = new DataGridViewCheckBoxColumn();
            StartValue = new DataGridViewTextBoxColumn();
            EndValue = new DataGridViewTextBoxColumn();
            RangeValue = new DataGridViewTextBoxColumn();
            DateFormat = new DataGridViewComboBoxColumn();
            Maxlength = new DataGridViewTextBoxColumn();
            ValueInit = new DataGridViewTextBoxColumn();
            csvgenerate.SuspendLayout();
            csvgeneratepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            grbHandle.SuspendLayout();
            SuspendLayout();
            // 
            // csvgenerate
            // 
            csvgenerate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            csvgenerate.Controls.Add(csvgeneratepage);
            csvgenerate.Controls.Add(tabPage2);
            csvgenerate.Location = new Point(12, 12);
            csvgenerate.Name = "csvgenerate";
            csvgenerate.SelectedIndex = 0;
            csvgenerate.Size = new Size(1161, 553);
            csvgenerate.TabIndex = 0;
            // 
            // csvgeneratepage
            // 
            csvgeneratepage.Controls.Add(dataGridView1);
            csvgeneratepage.Controls.Add(lblCsvFileOption);
            csvgeneratepage.Controls.Add(panel1);
            csvgeneratepage.Location = new Point(4, 24);
            csvgeneratepage.Name = "csvgeneratepage";
            csvgeneratepage.Padding = new Padding(3);
            csvgeneratepage.Size = new Size(1153, 525);
            csvgeneratepage.TabIndex = 0;
            csvgeneratepage.Text = "CSV Generate";
            csvgeneratepage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Header, Type, PaddingZero, PaddingZeroLen, IsRandom, StartValue, EndValue, RangeValue, DateFormat, Maxlength, ValueInit });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(6, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1141, 397);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // lblCsvFileOption
            // 
            lblCsvFileOption.AutoSize = true;
            lblCsvFileOption.ForeColor = SystemColors.ControlDarkDark;
            lblCsvFileOption.Location = new Point(6, 11);
            lblCsvFileOption.Name = "lblCsvFileOption";
            lblCsvFileOption.Size = new Size(88, 15);
            lblCsvFileOption.TabIndex = 1;
            lblCsvFileOption.Text = "CSV File Option";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtLineNumber);
            panel1.Controls.Add(lblLineNumber);
            panel1.Controls.Add(btnBrowser);
            panel1.Controls.Add(tbxOutputLocation);
            panel1.Controls.Add(tbxFilename);
            panel1.Controls.Add(lblOutputLocation);
            panel1.Controls.Add(lblFilename);
            panel1.Controls.Add(tbxLinePerFile);
            panel1.Controls.Add(chkSplitFile);
            panel1.Controls.Add(lblLinePerFile2);
            panel1.Controls.Add(lblLinePerFile1);
            panel1.Location = new Point(6, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 87);
            panel1.TabIndex = 0;
            // 
            // txtLineNumber
            // 
            txtLineNumber.Location = new Point(308, 3);
            txtLineNumber.Name = "txtLineNumber";
            txtLineNumber.Size = new Size(100, 23);
            txtLineNumber.TabIndex = 6;
            // 
            // lblLineNumber
            // 
            lblLineNumber.AutoSize = true;
            lblLineNumber.Location = new Point(221, 6);
            lblLineNumber.Name = "lblLineNumber";
            lblLineNumber.Size = new Size(81, 15);
            lblLineNumber.TabIndex = 5;
            lblLineNumber.Text = "* Line number";
            // 
            // btnBrowser
            // 
            btnBrowser.Location = new Point(469, 59);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.Size = new Size(77, 25);
            btnBrowser.TabIndex = 1;
            btnBrowser.Text = "Browser";
            btnBrowser.UseVisualStyleBackColor = true;
            btnBrowser.Click += btnBrowser_Click;
            // 
            // tbxOutputLocation
            // 
            tbxOutputLocation.Location = new Point(144, 61);
            tbxOutputLocation.Name = "tbxOutputLocation";
            tbxOutputLocation.Size = new Size(309, 23);
            tbxOutputLocation.TabIndex = 4;
            tbxOutputLocation.Click += tbxOutputLocation_Click;
            // 
            // tbxFilename
            // 
            tbxFilename.Location = new Point(102, 3);
            tbxFilename.Name = "tbxFilename";
            tbxFilename.Size = new Size(100, 23);
            tbxFilename.TabIndex = 4;
            // 
            // lblOutputLocation
            // 
            lblOutputLocation.AutoSize = true;
            lblOutputLocation.Location = new Point(39, 64);
            lblOutputLocation.Name = "lblOutputLocation";
            lblOutputLocation.Size = new Size(99, 15);
            lblOutputLocation.TabIndex = 3;
            lblOutputLocation.Text = "* Output location";
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new Point(39, 6);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(65, 15);
            lblFilename.TabIndex = 3;
            lblFilename.Text = "* File name";
            // 
            // tbxLinePerFile
            // 
            tbxLinePerFile.Location = new Point(208, 30);
            tbxLinePerFile.Name = "tbxLinePerFile";
            tbxLinePerFile.Size = new Size(45, 23);
            tbxLinePerFile.TabIndex = 2;
            // 
            // chkSplitFile
            // 
            chkSplitFile.AutoSize = true;
            chkSplitFile.Location = new Point(43, 34);
            chkSplitFile.Name = "chkSplitFile";
            chkSplitFile.Size = new Size(70, 19);
            chkSplitFile.TabIndex = 1;
            chkSplitFile.Text = "Split File";
            chkSplitFile.UseVisualStyleBackColor = true;
            chkSplitFile.CheckedChanged += chkSplitFile_CheckedChanged;
            // 
            // lblLinePerFile2
            // 
            lblLinePerFile2.AutoSize = true;
            lblLinePerFile2.Location = new Point(259, 34);
            lblLinePerFile2.Name = "lblLinePerFile2";
            lblLinePerFile2.Size = new Size(11, 15);
            lblLinePerFile2.TabIndex = 0;
            lblLinePerFile2.Text = ")";
            // 
            // lblLinePerFile1
            // 
            lblLinePerFile1.AutoSize = true;
            lblLinePerFile1.Location = new Point(122, 35);
            lblLinePerFile1.Name = "lblLinePerFile1";
            lblLinePerFile1.Size = new Size(80, 15);
            lblLinePerFile1.TabIndex = 0;
            lblLinePerFile1.Text = "(Lines per file ";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1153, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(6, 22);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(77, 38);
            btnRun.TabIndex = 1;
            btnRun.Text = "Generate";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 22);
            button2.Name = "button2";
            button2.Size = new Size(77, 38);
            button2.TabIndex = 1;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(172, 22);
            button3.Name = "button3";
            button3.Size = new Size(77, 38);
            button3.TabIndex = 1;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(260, 22);
            button4.Name = "button4";
            button4.Size = new Size(77, 38);
            button4.TabIndex = 1;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // grbHandle
            // 
            grbHandle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grbHandle.Controls.Add(button4);
            grbHandle.Controls.Add(button3);
            grbHandle.Controls.Add(button2);
            grbHandle.Controls.Add(btnRun);
            grbHandle.Location = new Point(12, 571);
            grbHandle.Name = "grbHandle";
            grbHandle.Size = new Size(343, 68);
            grbHandle.TabIndex = 2;
            grbHandle.TabStop = false;
            grbHandle.Text = "Handle";
            // 
            // Header
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Header.DefaultCellStyle = dataGridViewCellStyle2;
            Header.HeaderText = "* Header";
            Header.Name = "Header";
            // 
            // Type
            // 
            dataGridViewCellStyle3.NullValue = "------";
            Type.DefaultCellStyle = dataGridViewCellStyle3;
            Type.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Type.HeaderText = "* Type";
            Type.Items.AddRange(new object[] { "Number", "Date", "String" });
            Type.Name = "Type";
            // 
            // PaddingZero
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.NullValue = false;
            PaddingZero.DefaultCellStyle = dataGridViewCellStyle4;
            PaddingZero.HeaderText = "PaddingZero";
            PaddingZero.Name = "PaddingZero";
            PaddingZero.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PaddingZeroLen
            // 
            PaddingZeroLen.HeaderText = "PaddingZeroLen";
            PaddingZeroLen.Name = "PaddingZeroLen";
            // 
            // IsRandom
            // 
            IsRandom.HeaderText = "IsRandom";
            IsRandom.Name = "IsRandom";
            // 
            // StartValue
            // 
            StartValue.HeaderText = "StartValue";
            StartValue.Name = "StartValue";
            // 
            // EndValue
            // 
            EndValue.HeaderText = "EndValue";
            EndValue.Name = "EndValue";
            // 
            // RangeValue
            // 
            RangeValue.HeaderText = "RangeValue";
            RangeValue.Name = "RangeValue";
            // 
            // DateFormat
            // 
            dataGridViewCellStyle5.NullValue = "------";
            DateFormat.DefaultCellStyle = dataGridViewCellStyle5;
            DateFormat.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            DateFormat.HeaderText = "DateFormat";
            DateFormat.Items.AddRange(new object[] { "yyyy/MM/dd", "yyyy-MM-dd", "yyyyMMdd", "yyyy/MM", "yyyy-MM", "yyyyMM" });
            DateFormat.Name = "DateFormat";
            // 
            // Maxlength
            // 
            Maxlength.HeaderText = "Maxlength";
            Maxlength.Name = "Maxlength";
            // 
            // ValueInit
            // 
            ValueInit.HeaderText = "PrefixValue";
            ValueInit.Name = "ValueInit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 651);
            Controls.Add(grbHandle);
            Controls.Add(csvgenerate);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSVTools";
            csvgenerate.ResumeLayout(false);
            csvgeneratepage.ResumeLayout(false);
            csvgeneratepage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbHandle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl csvgenerate;
        private TabPage csvgeneratepage;
        private TabPage tabPage2;
        private Label lblCsvFileOption;
        private Panel panel1;
        private Button btnRun;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblOutputLocation;
        private Label lblFilename;
        private TextBox tbxLinePerFile;
        private CheckBox chkSplitFile;
        private Label lblLinePerFile2;
        private Label lblLinePerFile1;
        private Button btnBrowser;
        private TextBox tbxOutputLocation;
        private TextBox tbxFilename;
        private DataGridView dataGridView1;
        private TextBox txtLineNumber;
        private Label lblLineNumber;
        private GroupBox grbHandle;
        private DataGridViewTextBoxColumn Header;
        private DataGridViewComboBoxColumn Type;
        private DataGridViewCheckBoxColumn PaddingZero;
        private DataGridViewTextBoxColumn PaddingZeroLen;
        private DataGridViewCheckBoxColumn IsRandom;
        private DataGridViewTextBoxColumn StartValue;
        private DataGridViewTextBoxColumn EndValue;
        private DataGridViewTextBoxColumn RangeValue;
        private DataGridViewComboBoxColumn DateFormat;
        private DataGridViewTextBoxColumn Maxlength;
        private DataGridViewTextBoxColumn ValueInit;
    }
}