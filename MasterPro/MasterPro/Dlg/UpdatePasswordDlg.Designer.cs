namespace MasterPro.Dlg
{
    partial class UpdatePasswordDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.old_input = new System.Windows.Forms.TextBox();
            this.new_input = new System.Windows.Forms.TextBox();
            this.sure_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧  密  码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新  密  码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "再次新密码";
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(19, 186);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(100, 40);
            this.SureBtn.TabIndex = 3;
            this.SureBtn.Text = "确认";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(154, 186);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "取消";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // old_input
            // 
            this.old_input.Location = new System.Drawing.Point(111, 22);
            this.old_input.Name = "old_input";
            this.old_input.Size = new System.Drawing.Size(143, 25);
            this.old_input.TabIndex = 5;
            this.old_input.UseSystemPasswordChar = true;
            // 
            // new_input
            // 
            this.new_input.Location = new System.Drawing.Point(111, 73);
            this.new_input.Name = "new_input";
            this.new_input.Size = new System.Drawing.Size(143, 25);
            this.new_input.TabIndex = 6;
            this.new_input.UseSystemPasswordChar = true;
            // 
            // sure_input
            // 
            this.sure_input.Location = new System.Drawing.Point(112, 124);
            this.sure_input.Name = "sure_input";
            this.sure_input.Size = new System.Drawing.Size(142, 25);
            this.sure_input.TabIndex = 7;
            this.sure_input.UseSystemPasswordChar = true;
            // 
            // UpdatePasswordDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.sure_input);
            this.Controls.Add(this.new_input);
            this.Controls.Add(this.old_input);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "UpdatePasswordDlg";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.TextBox old_input;
        private System.Windows.Forms.TextBox new_input;
        private System.Windows.Forms.TextBox sure_input;
    }
}