namespace mysql
{
    partial class MainForm
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkedListBoxTypes = new System.Windows.Forms.CheckedListBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.buttonRefreshCakeTypes = new System.Windows.Forms.Button();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxImgFileName = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonDeleFile = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxTypeShow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeMan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeWoman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeChild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeFantang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypePic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeFactory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeFruit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeShou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeFlower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTypeLove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttoRefreshFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(328, 41);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(50, 26);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(54, 14);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(248, 21);
            this.textBoxServer.TabIndex = 1;
            this.textBoxServer.Text = "bdm253246483.my3w.com";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(368, 14);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(100, 21);
            this.textBoxAccount.TabIndex = 2;
            this.textBoxAccount.Text = "bdm253246483";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据库";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(516, 15);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Quqw112233";
            // 
            // checkedListBoxTypes
            // 
            this.checkedListBoxTypes.FormattingEnabled = true;
            this.checkedListBoxTypes.Location = new System.Drawing.Point(6, 87);
            this.checkedListBoxTypes.Name = "checkedListBoxTypes";
            this.checkedListBoxTypes.Size = new System.Drawing.Size(120, 212);
            this.checkedListBoxTypes.TabIndex = 9;
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(54, 41);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(248, 21);
            this.textBoxDB.TabIndex = 10;
            this.textBoxDB.Text = "bdm253246483_db";
            // 
            // buttonRefreshCakeTypes
            // 
            this.buttonRefreshCakeTypes.Location = new System.Drawing.Point(62, 57);
            this.buttonRefreshCakeTypes.Name = "buttonRefreshCakeTypes";
            this.buttonRefreshCakeTypes.Size = new System.Drawing.Size(50, 26);
            this.buttonRefreshCakeTypes.TabIndex = 11;
            this.buttonRefreshCakeTypes.Text = "刷新";
            this.buttonRefreshCakeTypes.UseVisualStyleBackColor = true;
            this.buttonRefreshCakeTypes.Click += new System.EventHandler(this.buttonRefreshCakeTypes_Click);
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(62, 6);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(64, 21);
            this.textBoxTypeName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "类别英文";
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(6, 58);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(50, 26);
            this.buttonAddType.TabIndex = 14;
            this.buttonAddType.Text = "添加";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(175, 38);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(50, 26);
            this.buttonAddFile.TabIndex = 17;
            this.buttonAddFile.Text = "添加";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "文件";
            // 
            // textBoxImgFileName
            // 
            this.textBoxImgFileName.Location = new System.Drawing.Point(175, 6);
            this.textBoxImgFileName.Name = "textBoxImgFileName";
            this.textBoxImgFileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxImgFileName.Size = new System.Drawing.Size(349, 21);
            this.textBoxImgFileName.TabIndex = 15;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(540, 6);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(50, 26);
            this.buttonSelectFile.TabIndex = 18;
            this.buttonSelectFile.Text = "选择";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonDeleFile
            // 
            this.buttonDeleFile.Location = new System.Drawing.Point(236, 39);
            this.buttonDeleFile.Name = "buttonDeleFile";
            this.buttonDeleFile.Size = new System.Drawing.Size(50, 26);
            this.buttonDeleFile.TabIndex = 19;
            this.buttonDeleFile.Text = "删除";
            this.buttonDeleFile.UseVisualStyleBackColor = true;
            this.buttonDeleFile.Click += new System.EventHandler(this.buttonDeleFile_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Enabled = false;
            this.tabControlMain.Location = new System.Drawing.Point(12, 68);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(604, 341);
            this.tabControlMain.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxTypeShow);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.buttoRefreshFile);
            this.tabPage1.Controls.Add(this.checkedListBoxTypes);
            this.tabPage1.Controls.Add(this.buttonRefreshCakeTypes);
            this.tabPage1.Controls.Add(this.buttonDeleFile);
            this.tabPage1.Controls.Add(this.textBoxTypeName);
            this.tabPage1.Controls.Add(this.buttonSelectFile);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonAddFile);
            this.tabPage1.Controls.Add(this.buttonAddType);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxImgFileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "照片操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeShow
            // 
            this.textBoxTypeShow.Location = new System.Drawing.Point(62, 33);
            this.textBoxTypeShow.Name = "textBoxTypeShow";
            this.textBoxTypeShow.Size = new System.Drawing.Size(64, 21);
            this.textBoxTypeShow.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "名称中文";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnTypeMan,
            this.columnTypeWoman,
            this.columnTypeChild,
            this.columnTypeFantang,
            this.columnTypePic,
            this.columnTypeFactory,
            this.columnTypeFruit,
            this.columnTypeShou,
            this.columnTypeFlower,
            this.columnTypeLove});
            this.listView1.Location = new System.Drawing.Point(142, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 228);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "文件名";
            // 
            // columnTypeMan
            // 
            this.columnTypeMan.Text = "男士";
            this.columnTypeMan.Width = 30;
            // 
            // columnTypeWoman
            // 
            this.columnTypeWoman.Text = "女士";
            this.columnTypeWoman.Width = 30;
            // 
            // columnTypeChild
            // 
            this.columnTypeChild.Text = "儿童";
            this.columnTypeChild.Width = 30;
            // 
            // columnTypeFantang
            // 
            this.columnTypeFantang.Text = "翻糖";
            this.columnTypeFantang.Width = 30;
            // 
            // columnTypePic
            // 
            this.columnTypePic.Text = "照片";
            this.columnTypePic.Width = 30;
            // 
            // columnTypeFactory
            // 
            this.columnTypeFactory.Text = "企业";
            this.columnTypeFactory.Width = 30;
            // 
            // columnTypeFruit
            // 
            this.columnTypeFruit.Text = "水果";
            this.columnTypeFruit.Width = 30;
            // 
            // columnTypeShou
            // 
            this.columnTypeShou.Text = "寿宴";
            this.columnTypeShou.Width = 30;
            // 
            // columnTypeFlower
            // 
            this.columnTypeFlower.Text = "裱花";
            this.columnTypeFlower.Width = 30;
            // 
            // columnTypeLove
            // 
            this.columnTypeLove.Text = "爱情";
            this.columnTypeLove.Width = 30;
            // 
            // buttoRefreshFile
            // 
            this.buttoRefreshFile.Location = new System.Drawing.Point(474, 38);
            this.buttoRefreshFile.Name = "buttoRefreshFile";
            this.buttoRefreshFile.Size = new System.Drawing.Size(50, 26);
            this.buttoRefreshFile.TabIndex = 20;
            this.buttoRefreshFile.Text = "刷新";
            this.buttoRefreshFile.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 421);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.buttonConnect);
            this.Name = "MainForm";
            this.Text = "数据库操作软件0.1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckedListBox checkedListBoxTypes;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.Button buttonRefreshCakeTypes;
        private System.Windows.Forms.TextBox textBoxTypeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxImgFileName;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonDeleFile;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ColumnHeader columnTypeMan;
        private System.Windows.Forms.ColumnHeader columnTypeWoman;
        private System.Windows.Forms.ColumnHeader columnTypeChild;
        private System.Windows.Forms.ColumnHeader columnTypeFantang;
        private System.Windows.Forms.ColumnHeader columnTypePic;
        private System.Windows.Forms.ColumnHeader columnTypeFactory;
        private System.Windows.Forms.ColumnHeader columnTypeFruit;
        private System.Windows.Forms.ColumnHeader columnTypeShou;
        private System.Windows.Forms.ColumnHeader columnTypeFlower;
        private System.Windows.Forms.ColumnHeader columnTypeLove;
        private System.Windows.Forms.Button buttoRefreshFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxTypeShow;
        private System.Windows.Forms.Label label7;
    }
}

