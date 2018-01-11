namespace MasterPro.Dlg
{
    partial class UpdateScoreDlg
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
            this.c_id_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.score_input = new System.Windows.Forms.TextBox();
            this.c_name_input = new System.Windows.Forms.TextBox();
            this.m_name_input = new System.Windows.Forms.TextBox();
            this.m_id_input = new System.Windows.Forms.TextBox();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SureBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_id_input
            // 
            this.c_id_input.Location = new System.Drawing.Point(84, 83);
            this.c_id_input.Name = "c_id_input";
            this.c_id_input.Size = new System.Drawing.Size(172, 25);
            this.c_id_input.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "课程ID";
            // 
            // score_input
            // 
            this.score_input.Location = new System.Drawing.Point(84, 155);
            this.score_input.Name = "score_input";
            this.score_input.Size = new System.Drawing.Size(172, 25);
            this.score_input.TabIndex = 21;
            // 
            // c_name_input
            // 
            this.c_name_input.Location = new System.Drawing.Point(84, 119);
            this.c_name_input.Name = "c_name_input";
            this.c_name_input.Size = new System.Drawing.Size(172, 25);
            this.c_name_input.TabIndex = 20;
            // 
            // m_name_input
            // 
            this.m_name_input.Location = new System.Drawing.Point(84, 47);
            this.m_name_input.Name = "m_name_input";
            this.m_name_input.Size = new System.Drawing.Size(172, 25);
            this.m_name_input.TabIndex = 19;
            // 
            // m_id_input
            // 
            this.m_id_input.Location = new System.Drawing.Point(84, 11);
            this.m_id_input.Name = "m_id_input";
            this.m_id_input.Size = new System.Drawing.Size(172, 25);
            this.m_id_input.TabIndex = 18;
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(157, 202);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(100, 40);
            this.QuitBtn.TabIndex = 17;
            this.QuitBtn.Text = "取消";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(32, 201);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(100, 40);
            this.SureBtn.TabIndex = 16;
            this.SureBtn.Text = "确定";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "成  绩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "课程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "学生名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "学生ID";
            // 
            // UpdateScoreDlg
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
            this.Name = "UpdateScoreDlg";
            this.Text = "修改学生课程成绩";
            this.Load += new System.EventHandler(this.UpdateScoreDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_id_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox score_input;
        private System.Windows.Forms.TextBox c_name_input;
        private System.Windows.Forms.TextBox m_name_input;
        private System.Windows.Forms.TextBox m_id_input;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}