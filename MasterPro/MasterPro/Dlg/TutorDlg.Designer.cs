namespace MasterPro.Dlg
{
    partial class TutorDlg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tutor_master_tabPage = new System.Windows.Forms.TabPage();
            this.QuitBtn1 = new System.Windows.Forms.Button();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.selectStudentBtn = new System.Windows.Forms.Button();
            this.delStudentBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.masterView = new System.Windows.Forms.DataGridView();
            this.tutor_score_tabPage = new System.Windows.Forms.TabPage();
            this.QuitBtn2 = new System.Windows.Forms.Button();
            this.updateScoreBtn = new System.Windows.Forms.Button();
            this.selectScoreBtn = new System.Windows.Forms.Button();
            this.delScoreBtn = new System.Windows.Forms.Button();
            this.addScoreBtn = new System.Windows.Forms.Button();
            this.scoreView = new System.Windows.Forms.DataGridView();
            this.master_tabPage = new System.Windows.Forms.TabPage();
            this.QuitBtn3 = new System.Windows.Forms.Button();
            this.updatePassWordBtn = new System.Windows.Forms.Button();
            this.selectCourseBtn = new System.Windows.Forms.Button();
            this.scoreViewByMaster = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tutor_master_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterView)).BeginInit();
            this.tutor_score_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).BeginInit();
            this.master_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreViewByMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tutor_master_tabPage);
            this.tabControl1.Controls.Add(this.tutor_score_tabPage);
            this.tabControl1.Controls.Add(this.master_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MaximumSize = new System.Drawing.Size(785, 555);
            this.tabControl1.MinimumSize = new System.Drawing.Size(785, 555);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tutor_master_tabPage
            // 
            this.tutor_master_tabPage.Controls.Add(this.QuitBtn1);
            this.tutor_master_tabPage.Controls.Add(this.updateStudentBtn);
            this.tutor_master_tabPage.Controls.Add(this.selectStudentBtn);
            this.tutor_master_tabPage.Controls.Add(this.delStudentBtn);
            this.tutor_master_tabPage.Controls.Add(this.addStudentBtn);
            this.tutor_master_tabPage.Controls.Add(this.masterView);
            this.tutor_master_tabPage.Location = new System.Drawing.Point(4, 25);
            this.tutor_master_tabPage.Name = "tutor_master_tabPage";
            this.tutor_master_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tutor_master_tabPage.Size = new System.Drawing.Size(777, 526);
            this.tutor_master_tabPage.TabIndex = 0;
            this.tutor_master_tabPage.Text = "学生管理";
            this.tutor_master_tabPage.UseVisualStyleBackColor = true;
            // 
            // QuitBtn1
            // 
            this.QuitBtn1.Location = new System.Drawing.Point(626, 476);
            this.QuitBtn1.Name = "QuitBtn1";
            this.QuitBtn1.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn1.TabIndex = 5;
            this.QuitBtn1.Text = "退出系统";
            this.QuitBtn1.UseVisualStyleBackColor = true;
            this.QuitBtn1.Click += new System.EventHandler(this.QuitBtn1_Click);
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Location = new System.Drawing.Point(481, 476);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(100, 40);
            this.updateStudentBtn.TabIndex = 4;
            this.updateStudentBtn.Text = "修改学生";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            this.updateStudentBtn.Click += new System.EventHandler(this.updateStudentBtn_Click);
            // 
            // selectStudentBtn
            // 
            this.selectStudentBtn.Location = new System.Drawing.Point(336, 476);
            this.selectStudentBtn.Name = "selectStudentBtn";
            this.selectStudentBtn.Size = new System.Drawing.Size(100, 40);
            this.selectStudentBtn.TabIndex = 3;
            this.selectStudentBtn.Text = "查找学生";
            this.selectStudentBtn.UseVisualStyleBackColor = true;
            this.selectStudentBtn.Click += new System.EventHandler(this.selectStudentBtn_Click);
            // 
            // delStudentBtn
            // 
            this.delStudentBtn.Location = new System.Drawing.Point(191, 476);
            this.delStudentBtn.Name = "delStudentBtn";
            this.delStudentBtn.Size = new System.Drawing.Size(100, 40);
            this.delStudentBtn.TabIndex = 2;
            this.delStudentBtn.Text = "删除学生";
            this.delStudentBtn.UseVisualStyleBackColor = true;
            this.delStudentBtn.Click += new System.EventHandler(this.delStudentBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(46, 476);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(100, 40);
            this.addStudentBtn.TabIndex = 1;
            this.addStudentBtn.Text = "增加学生";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // masterView
            // 
            this.masterView.AllowUserToAddRows = false;
            this.masterView.AllowUserToDeleteRows = false;
            this.masterView.AllowUserToResizeColumns = false;
            this.masterView.AllowUserToResizeRows = false;
            this.masterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterView.Location = new System.Drawing.Point(0, 0);
            this.masterView.Name = "masterView";
            this.masterView.ReadOnly = true;
            this.masterView.RowTemplate.Height = 27;
            this.masterView.Size = new System.Drawing.Size(775, 470);
            this.masterView.TabIndex = 0;
            // 
            // tutor_score_tabPage
            // 
            this.tutor_score_tabPage.Controls.Add(this.QuitBtn2);
            this.tutor_score_tabPage.Controls.Add(this.updateScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.selectScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.delScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.addScoreBtn);
            this.tutor_score_tabPage.Controls.Add(this.scoreView);
            this.tutor_score_tabPage.Location = new System.Drawing.Point(4, 25);
            this.tutor_score_tabPage.Name = "tutor_score_tabPage";
            this.tutor_score_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tutor_score_tabPage.Size = new System.Drawing.Size(777, 526);
            this.tutor_score_tabPage.TabIndex = 1;
            this.tutor_score_tabPage.Text = "学生成绩";
            this.tutor_score_tabPage.UseVisualStyleBackColor = true;
            // 
            // QuitBtn2
            // 
            this.QuitBtn2.Location = new System.Drawing.Point(626, 476);
            this.QuitBtn2.Name = "QuitBtn2";
            this.QuitBtn2.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn2.TabIndex = 10;
            this.QuitBtn2.Text = "退出系统";
            this.QuitBtn2.UseVisualStyleBackColor = true;
            this.QuitBtn2.Click += new System.EventHandler(this.QuitBtn2_Click);
            // 
            // updateScoreBtn
            // 
            this.updateScoreBtn.Location = new System.Drawing.Point(481, 476);
            this.updateScoreBtn.Name = "updateScoreBtn";
            this.updateScoreBtn.Size = new System.Drawing.Size(100, 40);
            this.updateScoreBtn.TabIndex = 9;
            this.updateScoreBtn.Text = "修改成绩";
            this.updateScoreBtn.UseVisualStyleBackColor = true;
            this.updateScoreBtn.Click += new System.EventHandler(this.updateScoreBtn_Click);
            // 
            // selectScoreBtn
            // 
            this.selectScoreBtn.Location = new System.Drawing.Point(336, 476);
            this.selectScoreBtn.Name = "selectScoreBtn";
            this.selectScoreBtn.Size = new System.Drawing.Size(100, 40);
            this.selectScoreBtn.TabIndex = 8;
            this.selectScoreBtn.Text = "查找成绩";
            this.selectScoreBtn.UseVisualStyleBackColor = true;
            this.selectScoreBtn.Click += new System.EventHandler(this.selectScoreBtn_Click);
            // 
            // delScoreBtn
            // 
            this.delScoreBtn.Location = new System.Drawing.Point(191, 476);
            this.delScoreBtn.Name = "delScoreBtn";
            this.delScoreBtn.Size = new System.Drawing.Size(100, 40);
            this.delScoreBtn.TabIndex = 7;
            this.delScoreBtn.Text = "删除成绩";
            this.delScoreBtn.UseVisualStyleBackColor = true;
            this.delScoreBtn.Click += new System.EventHandler(this.delScoreBtn_Click);
            // 
            // addScoreBtn
            // 
            this.addScoreBtn.Location = new System.Drawing.Point(46, 476);
            this.addScoreBtn.Name = "addScoreBtn";
            this.addScoreBtn.Size = new System.Drawing.Size(100, 40);
            this.addScoreBtn.TabIndex = 6;
            this.addScoreBtn.Text = "录入成绩";
            this.addScoreBtn.UseVisualStyleBackColor = true;
            this.addScoreBtn.Click += new System.EventHandler(this.addScoreBtn_Click);
            // 
            // scoreView
            // 
            this.scoreView.AllowUserToAddRows = false;
            this.scoreView.AllowUserToDeleteRows = false;
            this.scoreView.AllowUserToResizeColumns = false;
            this.scoreView.AllowUserToResizeRows = false;
            this.scoreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreView.Location = new System.Drawing.Point(0, 0);
            this.scoreView.Name = "scoreView";
            this.scoreView.ReadOnly = true;
            this.scoreView.RowTemplate.Height = 27;
            this.scoreView.Size = new System.Drawing.Size(775, 470);
            this.scoreView.TabIndex = 0;
            // 
            // master_tabPage
            // 
            this.master_tabPage.Controls.Add(this.QuitBtn3);
            this.master_tabPage.Controls.Add(this.updatePassWordBtn);
            this.master_tabPage.Controls.Add(this.selectCourseBtn);
            this.master_tabPage.Controls.Add(this.scoreViewByMaster);
            this.master_tabPage.Location = new System.Drawing.Point(4, 25);
            this.master_tabPage.Name = "master_tabPage";
            this.master_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.master_tabPage.Size = new System.Drawing.Size(777, 526);
            this.master_tabPage.TabIndex = 2;
            this.master_tabPage.Text = "学生成绩";
            this.master_tabPage.UseVisualStyleBackColor = true;
            // 
            // QuitBtn3
            // 
            this.QuitBtn3.Location = new System.Drawing.Point(622, 479);
            this.QuitBtn3.Name = "QuitBtn3";
            this.QuitBtn3.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn3.TabIndex = 4;
            this.QuitBtn3.Text = "退出系统";
            this.QuitBtn3.UseVisualStyleBackColor = true;
            this.QuitBtn3.Click += new System.EventHandler(this.QuitBtn3_Click);
            // 
            // updatePassWordBtn
            // 
            this.updatePassWordBtn.Location = new System.Drawing.Point(329, 479);
            this.updatePassWordBtn.Name = "updatePassWordBtn";
            this.updatePassWordBtn.Size = new System.Drawing.Size(100, 40);
            this.updatePassWordBtn.TabIndex = 3;
            this.updatePassWordBtn.Text = "修改密码";
            this.updatePassWordBtn.UseVisualStyleBackColor = true;
            this.updatePassWordBtn.Click += new System.EventHandler(this.updatePassWordBtn_Click);
            // 
            // selectCourseBtn
            // 
            this.selectCourseBtn.Location = new System.Drawing.Point(36, 479);
            this.selectCourseBtn.Name = "selectCourseBtn";
            this.selectCourseBtn.Size = new System.Drawing.Size(100, 40);
            this.selectCourseBtn.TabIndex = 2;
            this.selectCourseBtn.Text = "查询科目";
            this.selectCourseBtn.UseVisualStyleBackColor = true;
            this.selectCourseBtn.Click += new System.EventHandler(this.selectCourseBtn_Click);
            // 
            // scoreViewByMaster
            // 
            this.scoreViewByMaster.AllowUserToAddRows = false;
            this.scoreViewByMaster.AllowUserToDeleteRows = false;
            this.scoreViewByMaster.AllowUserToResizeColumns = false;
            this.scoreViewByMaster.AllowUserToResizeRows = false;
            this.scoreViewByMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreViewByMaster.Location = new System.Drawing.Point(0, 0);
            this.scoreViewByMaster.Name = "scoreViewByMaster";
            this.scoreViewByMaster.ReadOnly = true;
            this.scoreViewByMaster.RowTemplate.Height = 27;
            this.scoreViewByMaster.Size = new System.Drawing.Size(775, 470);
            this.scoreViewByMaster.TabIndex = 1;
            // 
            // TutorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TutorDlg";
            this.Text = "研究生成绩管理系统";
            this.tabControl1.ResumeLayout(false);
            this.tutor_master_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterView)).EndInit();
            this.tutor_score_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreView)).EndInit();
            this.master_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreViewByMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tutor_master_tabPage;
        private System.Windows.Forms.DataGridView masterView;
        private System.Windows.Forms.TabPage tutor_score_tabPage;
        private System.Windows.Forms.DataGridView scoreView;
        private System.Windows.Forms.Button QuitBtn1;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.Button selectStudentBtn;
        private System.Windows.Forms.Button delStudentBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button QuitBtn2;
        private System.Windows.Forms.Button updateScoreBtn;
        private System.Windows.Forms.Button selectScoreBtn;
        private System.Windows.Forms.Button delScoreBtn;
        private System.Windows.Forms.Button addScoreBtn;
        private System.Windows.Forms.TabPage master_tabPage;
        private System.Windows.Forms.Button QuitBtn3;
        private System.Windows.Forms.Button updatePassWordBtn;
        private System.Windows.Forms.Button selectCourseBtn;
        private System.Windows.Forms.DataGridView scoreViewByMaster;
    }
}