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
    public partial class UpdateMasterDlg : Form
    {
        private string id;
        private Query query;
        private DataSet dataSet;

        public UpdateMasterDlg(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            if (username_input.TextLength == 0 || password_input.TextLength == 0)
            {
                MessageBox.Show("你有未填写的信息", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.OK == MessageBox.Show("学号：\t" + id_input.Text.Trim() + "\n" +
                "姓名：\t" + username_input.Text.Trim() + "\n" +
                "密码：\t" + password_input.Text.Trim() + "\n" +
                "确认信息无误", "核对信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
                Query query = new Query();

                User user = new User();
                user.id = id_input.Text.Trim();
                user.name = username_input.Text.Trim();
                user.password = password_input.Text.Trim();

                try
                {
                    if (query.UpdateMasterInfo(user))
                    {
                        MessageBox.Show("修改成功!", "恭喜！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "温馨提示:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void UpdateMasterDlg_Load(object sender, EventArgs e)
        {
            query = new Query();
            dataSet = query.SelectOneUser(id);
            id_input.Text = dataSet.Tables[0].Rows[0][0].ToString();
            id_input.Enabled = false;
            username_input.Text = dataSet.Tables[0].Rows[0][1].ToString();
            password_input.Text = dataSet.Tables[0].Rows[0][2].ToString();
        }
    }
}
