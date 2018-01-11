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
    public partial class UpdatePasswordDlg : Form
    {
        private string id;

        private Query query;

        private DataSet dataSet;

        private User user;

        public UpdatePasswordDlg(string id)
        {
            InitializeComponent();
            this.id = id;
            user = new User();
            query = new Query();
            dataSet = query.SelectOneUser(id);
            user.id = dataSet.Tables[0].Rows[0][0].ToString();
            user.name = dataSet.Tables[0].Rows[0][1].ToString();
            user.password = dataSet.Tables[0].Rows[0][2].ToString();
            user.role = dataSet.Tables[0].Rows[0][3].ToString();
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            if (old_input.TextLength == 0 || new_input.TextLength == 0 || sure_input.TextLength == 0)
            {
                MessageBox.Show("你有未填写的信息", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (old_input.Text.Trim() == new_input.Text.Trim())
            {
                MessageBox.Show("你的新密码和旧密码相同\n请重新输入！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new_input.Text.Trim() != sure_input.Text.Trim())
            {
                MessageBox.Show("你输入的新密码两次不相同\n请重新输入！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (old_input.Text.Trim() != user.password.Trim())
            {
                MessageBox.Show("你输入的旧密码不正确\n请重新输入！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            query = new Query();

            try
            {
                if (query.UpdatePassword(id, sure_input.Text.Trim().ToString()))
                {
                    MessageBox.Show("更改成功!", "恭喜！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("更改失败！", "温馨提示:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
