namespace SelectDB
{
    partial class SelectDB
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDB));
            this.panel_EnterDB = new System.Windows.Forms.Panel();
            this.button_WinConfirm = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_SeverName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_SelectTable = new System.Windows.Forms.Panel();
            this.button_TNReturn = new System.Windows.Forms.Button();
            this.button_SelectTable = new System.Windows.Forms.Button();
            this.groupBox_SelectTable = new System.Windows.Forms.GroupBox();
            this.panel_SelectColName = new System.Windows.Forms.Panel();
            this.button_Copy = new System.Windows.Forms.Button();
            this.textBox_ColName = new System.Windows.Forms.TextBox();
            this.checkedListBox_SelectColName = new System.Windows.Forms.CheckedListBox();
            this.panel_SelectDB = new System.Windows.Forms.Panel();
            this.button_DBReturn = new System.Windows.Forms.Button();
            this.button_SelectDB = new System.Windows.Forms.Button();
            this.groupBox_SelectDB = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_CNReturn = new System.Windows.Forms.Button();
            this.panel_EnterDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_SelectTable.SuspendLayout();
            this.panel_SelectColName.SuspendLayout();
            this.panel_SelectDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_EnterDB
            // 
            this.panel_EnterDB.Controls.Add(this.button_WinConfirm);
            this.panel_EnterDB.Controls.Add(this.button_Login);
            this.panel_EnterDB.Controls.Add(this.label3);
            this.panel_EnterDB.Controls.Add(this.label2);
            this.panel_EnterDB.Controls.Add(this.label1);
            this.panel_EnterDB.Controls.Add(this.textBox_Pwd);
            this.panel_EnterDB.Controls.Add(this.textBox_UserName);
            this.panel_EnterDB.Controls.Add(this.textBox_SeverName);
            this.panel_EnterDB.Controls.Add(this.pictureBox1);
            this.panel_EnterDB.Location = new System.Drawing.Point(4, 4);
            this.panel_EnterDB.Name = "panel_EnterDB";
            this.panel_EnterDB.Size = new System.Drawing.Size(775, 425);
            this.panel_EnterDB.TabIndex = 0;
            this.panel_EnterDB.Visible = false;
            // 
            // button_WinConfirm
            // 
            this.button_WinConfirm.Location = new System.Drawing.Point(390, 305);
            this.button_WinConfirm.Name = "button_WinConfirm";
            this.button_WinConfirm.Size = new System.Drawing.Size(350, 55);
            this.button_WinConfirm.TabIndex = 13;
            this.button_WinConfirm.Text = "SQLServerWindows验证";
            this.button_WinConfirm.UseVisualStyleBackColor = true;
            this.button_WinConfirm.Click += new System.EventHandler(this.button_WinConfirm_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(390, 226);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(350, 53);
            this.button_Login.TabIndex = 12;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "登录名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "数据库服务器";
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(491, 165);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(249, 25);
            this.textBox_Pwd.TabIndex = 8;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(491, 117);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(249, 25);
            this.textBox_UserName.TabIndex = 7;
            // 
            // textBox_SeverName
            // 
            this.textBox_SeverName.Location = new System.Drawing.Point(491, 72);
            this.textBox_SeverName.Name = "textBox_SeverName";
            this.textBox_SeverName.Size = new System.Drawing.Size(249, 25);
            this.textBox_SeverName.TabIndex = 6;
            this.textBox_SeverName.Text = "localhost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel_SelectTable
            // 
            this.panel_SelectTable.Controls.Add(this.button_TNReturn);
            this.panel_SelectTable.Controls.Add(this.button_SelectTable);
            this.panel_SelectTable.Controls.Add(this.groupBox_SelectTable);
            this.panel_SelectTable.Location = new System.Drawing.Point(10, 10);
            this.panel_SelectTable.Name = "panel_SelectTable";
            this.panel_SelectTable.Size = new System.Drawing.Size(775, 425);
            this.panel_SelectTable.TabIndex = 1;
            this.panel_SelectTable.Visible = false;
            this.panel_SelectTable.VisibleChanged += new System.EventHandler(this.panel_SelectTable_VisibleChanged);
            // 
            // button_TNReturn
            // 
            this.button_TNReturn.Location = new System.Drawing.Point(456, 330);
            this.button_TNReturn.Name = "button_TNReturn";
            this.button_TNReturn.Size = new System.Drawing.Size(201, 58);
            this.button_TNReturn.TabIndex = 3;
            this.button_TNReturn.Text = "返回";
            this.button_TNReturn.UseVisualStyleBackColor = true;
            this.button_TNReturn.Click += new System.EventHandler(this.button_TNReturn_Click);
            // 
            // button_SelectTable
            // 
            this.button_SelectTable.Location = new System.Drawing.Point(121, 330);
            this.button_SelectTable.Name = "button_SelectTable";
            this.button_SelectTable.Size = new System.Drawing.Size(201, 58);
            this.button_SelectTable.TabIndex = 2;
            this.button_SelectTable.Text = "下一步";
            this.button_SelectTable.UseVisualStyleBackColor = true;
            this.button_SelectTable.Click += new System.EventHandler(this.button_SelectTable_Click);
            // 
            // groupBox_SelectTable
            // 
            this.groupBox_SelectTable.Location = new System.Drawing.Point(38, 43);
            this.groupBox_SelectTable.Name = "groupBox_SelectTable";
            this.groupBox_SelectTable.Size = new System.Drawing.Size(699, 275);
            this.groupBox_SelectTable.TabIndex = 1;
            this.groupBox_SelectTable.TabStop = false;
            this.groupBox_SelectTable.Text = "选择表";
            // 
            // panel_SelectColName
            // 
            this.panel_SelectColName.Controls.Add(this.button_CNReturn);
            this.panel_SelectColName.Controls.Add(this.button_Copy);
            this.panel_SelectColName.Controls.Add(this.textBox_ColName);
            this.panel_SelectColName.Controls.Add(this.checkedListBox_SelectColName);
            this.panel_SelectColName.Location = new System.Drawing.Point(7, 7);
            this.panel_SelectColName.Name = "panel_SelectColName";
            this.panel_SelectColName.Size = new System.Drawing.Size(775, 425);
            this.panel_SelectColName.TabIndex = 1;
            this.panel_SelectColName.Visible = false;
            this.panel_SelectColName.VisibleChanged += new System.EventHandler(this.panel_SelectColName_VisibleChanged);
            // 
            // button_Copy
            // 
            this.button_Copy.Location = new System.Drawing.Point(345, 322);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(177, 55);
            this.button_Copy.TabIndex = 2;
            this.button_Copy.Text = "复制";
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // textBox_ColName
            // 
            this.textBox_ColName.Location = new System.Drawing.Point(349, 33);
            this.textBox_ColName.Multiline = true;
            this.textBox_ColName.Name = "textBox_ColName";
            this.textBox_ColName.ReadOnly = true;
            this.textBox_ColName.Size = new System.Drawing.Size(382, 282);
            this.textBox_ColName.TabIndex = 1;
            // 
            // checkedListBox_SelectColName
            // 
            this.checkedListBox_SelectColName.CheckOnClick = true;
            this.checkedListBox_SelectColName.FormattingEnabled = true;
            this.checkedListBox_SelectColName.Location = new System.Drawing.Point(38, 33);
            this.checkedListBox_SelectColName.Name = "checkedListBox_SelectColName";
            this.checkedListBox_SelectColName.Size = new System.Drawing.Size(263, 344);
            this.checkedListBox_SelectColName.TabIndex = 0;
            this.checkedListBox_SelectColName.SelectedValueChanged += new System.EventHandler(this.checkedListBox_SelectColName_SelectedValueChanged);
            // 
            // panel_SelectDB
            // 
            this.panel_SelectDB.Controls.Add(this.button_DBReturn);
            this.panel_SelectDB.Controls.Add(this.button_SelectDB);
            this.panel_SelectDB.Controls.Add(this.groupBox_SelectDB);
            this.panel_SelectDB.Location = new System.Drawing.Point(1, 1);
            this.panel_SelectDB.Name = "panel_SelectDB";
            this.panel_SelectDB.Size = new System.Drawing.Size(775, 425);
            this.panel_SelectDB.TabIndex = 2;
            this.panel_SelectDB.Visible = false;
            this.panel_SelectDB.VisibleChanged += new System.EventHandler(this.panel_SelectDB_VisibleChanged);
            // 
            // button_DBReturn
            // 
            this.button_DBReturn.Location = new System.Drawing.Point(445, 332);
            this.button_DBReturn.Name = "button_DBReturn";
            this.button_DBReturn.Size = new System.Drawing.Size(221, 52);
            this.button_DBReturn.TabIndex = 3;
            this.button_DBReturn.Text = "返回";
            this.button_DBReturn.UseVisualStyleBackColor = true;
            this.button_DBReturn.Click += new System.EventHandler(this.button_DBReturn_Click);
            // 
            // button_SelectDB
            // 
            this.button_SelectDB.Location = new System.Drawing.Point(120, 333);
            this.button_SelectDB.Name = "button_SelectDB";
            this.button_SelectDB.Size = new System.Drawing.Size(221, 52);
            this.button_SelectDB.TabIndex = 2;
            this.button_SelectDB.Text = "下一步";
            this.button_SelectDB.UseVisualStyleBackColor = true;
            this.button_SelectDB.Click += new System.EventHandler(this.button_SelectDB_Click);
            // 
            // groupBox_SelectDB
            // 
            this.groupBox_SelectDB.Location = new System.Drawing.Point(38, 43);
            this.groupBox_SelectDB.Name = "groupBox_SelectDB";
            this.groupBox_SelectDB.Size = new System.Drawing.Size(699, 270);
            this.groupBox_SelectDB.TabIndex = 1;
            this.groupBox_SelectDB.TabStop = false;
            this.groupBox_SelectDB.Text = "选择数据库";
            // 
            // button_CNReturn
            // 
            this.button_CNReturn.Location = new System.Drawing.Point(563, 322);
            this.button_CNReturn.Name = "button_CNReturn";
            this.button_CNReturn.Size = new System.Drawing.Size(168, 55);
            this.button_CNReturn.TabIndex = 3;
            this.button_CNReturn.Text = "返回";
            this.button_CNReturn.UseVisualStyleBackColor = true;
            this.button_CNReturn.Click += new System.EventHandler(this.button_CNReturn_Click);
            // 
            // SelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_SelectColName);
            this.Controls.Add(this.panel_EnterDB);
            this.Controls.Add(this.panel_SelectTable);
            this.Controls.Add(this.panel_SelectDB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "SelectDB";
            this.Text = "SelectDB";
            this.Load += new System.EventHandler(this.SelectDB_Load);
            this.panel_EnterDB.ResumeLayout(false);
            this.panel_EnterDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_SelectTable.ResumeLayout(false);
            this.panel_SelectColName.ResumeLayout(false);
            this.panel_SelectColName.PerformLayout();
            this.panel_SelectDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_EnterDB;
        private System.Windows.Forms.Button button_WinConfirm;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_SeverName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_SelectTable;
        private System.Windows.Forms.Panel panel_SelectColName;
        private System.Windows.Forms.Panel panel_SelectDB;
        private System.Windows.Forms.GroupBox groupBox_SelectDB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_SelectDB;
        private System.Windows.Forms.GroupBox groupBox_SelectTable;
        private System.Windows.Forms.Button button_SelectTable;
        private System.Windows.Forms.Button button_DBReturn;
        private System.Windows.Forms.Button button_TNReturn;
        private System.Windows.Forms.CheckedListBox checkedListBox_SelectColName;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.TextBox textBox_ColName;
        private System.Windows.Forms.Button button_CNReturn;
    }
}

