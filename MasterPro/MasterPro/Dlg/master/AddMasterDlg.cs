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
    public partial class AddMasterDlg : Form
    {
        public AddMasterDlg()
        {
            InitializeComponent();
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            if (id_input.TextLength == 0 || username_input.TextLength == 0
               || password_input.TextLength == 0)
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
                user.role = "master";

                try
                {
                    if (query.AddMaster(user))
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
    }
}
