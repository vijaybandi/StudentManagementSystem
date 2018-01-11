namespace MasterPro.Dlg
{
    partial class AddScoreDlg
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
            this.label4 = new System.Windows.Forms.Label();
            this.SureBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.m_id_input = new System.Windows.Forms.TextBox();
            this.m_name_input = new System.Windows.Forms.TextBox();
            this.c_name_input = new System.Windows.Forms.TextBox();
            this.score_input = new System.Windows.Forms.TextBox();
            this.c_id_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "成  绩";
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(33, 198);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(100, 40);
            this.SureBtn.TabIndex = 4;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(158, 199);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn.TabIndex = 5;
            this.QuitBtn.Text = "取消";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // m_id_input
            // 
            this.m_id_input.Location = new System.Drawing.Point(85, 8);
            this.m_id_input.Name = "m_id_input";
            this.m_id_input.Size = new System.Drawing.Size(172, 25);
            this.m_id_input.TabIndex = 6;
            // 
            // m_name_input
            // 
            this.m_name_input.Location = new System.Drawing.Point(85, 44);
            this.m_name_input.Name = "m_name_input";
            this.m_name_input.Size = new System.Drawing.Size(172, 25);
            this.m_name_input.TabIndex = 7;
            // 
            // c_name_input
            // 
            this.c_name_input.Location = new System.Drawing.Point(85, 116);
            this.c_name_input.Name = "c_name_input";
            this.c_name_input.Size = new System.Drawing.Size(172, 25);
            this.c_name_input.TabIndex = 8;
            // 
            // score_input
            // 
            this.score_input.Location = new System.Drawing.Point(85, 152);
            this.score_input.Name = "score_input";
            this.score_input.Size = new System.Drawing.Size(172, 25);
            this.score_input.TabIndex = 9;
            // 
            // c_id_input
            // 
            this.c_id_input.Location = new System.Drawing.Point(85, 80);
            this.c_id_input.Name = "c_id_input";
            this.c_id_input.Size = new System.Drawing.Size(172, 25);
            this.c_id_input.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "课程ID";
            // 
            // AddScoreDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.c_id_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.score_input);
            this.Controls.Add(this.c_name_input);
            this.Controls.Add(this.m_name_input);
            this.Controls.Add(this.m_id_input);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AddScoreDlg";
            this.Text = "添加学生课程成绩";
            this.Load += new System.EventHandler(this.AddScoreDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.TextBox m_id_input;
        private System.Windows.Forms.TextBox m_name_input;
        private System.Windows.Forms.TextBox c_name_input;
        private System.Windows.Forms.TextBox score_input;
        private System.Windows.Forms.TextBox c_id_input;
        private System.Windows.Forms.Label label5;
    }
}