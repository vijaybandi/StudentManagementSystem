namespace MasterPro.Dlg
{
    partial class UpdateMasterDlg
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
            this.id_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码";
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(26, 178);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(100, 40);
            this.SureBtn.TabIndex = 3;
            this.SureBtn.Text = "确认";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(152, 178);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "取消";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(82, 17);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(170, 25);
            this.id_input.TabIndex = 5;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(82, 68);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(170, 25);
            this.username_input.TabIndex = 6;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(82, 118);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(170, 25);
            this.password_input.TabIndex = 7;
            // 
            // UpdateMasterDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMasterDlg";
            this.Text = "修改学生";
            this.Load += new System.EventHandler(this.UpdateMasterDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
    }
}