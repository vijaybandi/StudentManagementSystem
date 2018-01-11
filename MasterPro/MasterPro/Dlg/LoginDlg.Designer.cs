namespace MasterPro
{
    partial class LoginDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userID_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.SureBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.tutor_select = new System.Windows.Forms.RadioButton();
            this.master_select = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // userID_input
            // 
            this.userID_input.Location = new System.Drawing.Point(105, 30);
            this.userID_input.Name = "userID_input";
            this.userID_input.Size = new System.Drawing.Size(188, 25);
            this.userID_input.TabIndex = 2;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(105, 77);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(188, 25);
            this.password_input.TabIndex = 3;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(47, 185);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(100, 40);
            this.SureBtn.TabIndex = 4;
            this.SureBtn.Text = "确认登录";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(193, 185);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn.TabIndex = 5;
            this.QuitBtn.Text = "取消登录";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // tutor_select
            // 
            this.tutor_select.AutoSize = true;
            this.tutor_select.Location = new System.Drawing.Point(47, 134);
            this.tutor_select.Name = "tutor_select";
            this.tutor_select.Size = new System.Drawing.Size(58, 19);
            this.tutor_select.TabIndex = 6;
            this.tutor_select.TabStop = true;
            this.tutor_select.Text = "导师";
            this.tutor_select.UseVisualStyleBackColor = true;
            // 
            // master_select
            // 
            this.master_select.AutoSize = true;
            this.master_select.Location = new System.Drawing.Point(169, 134);
            this.master_select.Name = "master_select";
            this.master_select.Size = new System.Drawing.Size(73, 19);
            this.master_select.TabIndex = 7;
            this.master_select.TabStop = true;
            this.master_select.Text = "研究生";
            this.master_select.UseVisualStyleBackColor = true;
            // 
            // LoginDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.master_select);
            this.Controls.Add(this.tutor_select);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.userID_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "LoginDlg";
            this.Text = "登录研究生成绩管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userID_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.RadioButton tutor_select;
        private System.Windows.Forms.RadioButton master_select;
    }
}

