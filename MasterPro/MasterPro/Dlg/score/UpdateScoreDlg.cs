using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPro.Dlg
{
    public partial class UpdateScoreDlg : Form
    {
        private string id;

        private Query query;

        private DataSet dataSet;

        public UpdateScoreDlg(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            if (c_id_input.TextLength == 0 || c_name_input.TextLength == 0
               || score_input.TextLength == 0)
            {
                MessageBox.Show("你有未填写的信息", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.OK == MessageBox.Show("学号：\t" + dataSet.Tables[0].Rows[0][0].ToString().Trim() + "\n" +
                "姓名：\t" + dataSet.Tables[0].Rows[0][1].ToString().Trim() + "\n" +
                "课程ID：\t" + c_id_input.Text.Trim() + "\n" +
                "课程名：\t" + c_name_input.Text.Trim() + "\n" +
                "分数：\t" + score_input.Text.Trim() + "\n" +
                "确认信息无误", "核对信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
                Query query = new Query();

                Master master = new Master();
                master.id = dataSet.Tables[0].Rows[0][0].ToString().Trim();
                master.name = dataSet.Tables[0].Rows[0][1].ToString().Trim();
                master.c_id = c_id_input.Text.Trim();
                master.c_name = c_name_input.Text.Trim();
                master.score = score_input.Text.Trim();

                try
                {
                    if (query.UpdateScoreInfo(master))
                    {
                        MessageBox.Show("添加成功!", "恭喜！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "温馨提示:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Close();
                }
            }
            }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateScoreDlg_Load(object sender, EventArgs e)
        {
            query = new Query();
            dataSet = query.SelectOneMasterAndScore(id);
            m_id_input.Text = dataSet.Tables[0].Rows[0][0].ToString();
            m_id_input.Enabled = false;
            m_name_input.Text = dataSet.Tables[0].Rows[0][1].ToString();
            m_name_input.Enabled = false;
            c_id_input.Text = dataSet.Tables[0].Rows[0][2].ToString();
            c_id_input.Enabled = false;
            c_name_input.Text = dataSet.Tables[0].Rows[0][3].ToString();
            c_name_input.Enabled = false;
        }
    }
}
