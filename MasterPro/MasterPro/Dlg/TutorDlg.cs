using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterPro.Dlg;

namespace MasterPro.Dlg
{
    public partial class TutorDlg : Form
    {
        private Query query;
        private DataSet userDataSet;
        private DataSet scoreDataSet;

        private string id;

        private string select;

        public TutorDlg(string id, string select)
        {
            InitializeComponent();
            this.id = id;
            this.select = select; 
            if(this.select == "tutor")
            {
                this.Text = "研究生成绩管理系统--教师端";
                master_tabPage.Dispose();
                updateMasterView();
                updateScoreView();
            }
            else if(this.select == "master")
            {
                this.Text = "研究生成绩管理系统--学生端";
                tutor_master_tabPage.Dispose();
                tutor_score_tabPage.Dispose();
                updateScoreViewByMaster();
            }
        }

        private void updateMasterView()
        {
            query = new Query();
            userDataSet = query.ShowAllMaster();
            masterView.DataSource = userDataSet.Tables[0];
            masterView.Columns[0].HeaderCell.Value = "编号";
            masterView.Columns[1].HeaderCell.Value = "姓名";
            masterView.Columns[2].HeaderCell.Value = "密码";
            masterView.Columns[3].HeaderCell.Value = "角色";
        }

        private void updateScoreView()
        {
            query = new Query();
            scoreDataSet = query.ShowAllScore();
            scoreView.DataSource = scoreDataSet.Tables[0];
            scoreView.Columns[0].HeaderCell.Value = "学号";
            scoreView.Columns[1].HeaderCell.Value = "姓名";
            scoreView.Columns[2].HeaderCell.Value = "课程号";
            scoreView.Columns[3].HeaderCell.Value = "课程名";
            scoreView.Columns[4].HeaderCell.Value = "成绩";
        }

        private void updateScoreViewByMaster()
        {
            query = new Query();
            scoreDataSet = query.SelectOneMasterAndScore(id);
            scoreViewByMaster.DataSource = scoreDataSet.Tables[0];
            scoreViewByMaster.Columns[0].HeaderCell.Value = "学号";
            scoreViewByMaster.Columns[1].HeaderCell.Value = "姓名";
            scoreViewByMaster.Columns[2].HeaderCell.Value = "课程号";
            scoreViewByMaster.Columns[3].HeaderCell.Value = "课程名";
            scoreViewByMaster.Columns[4].HeaderCell.Value = "成绩";
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            AddMasterDlg addMaster = new AddMasterDlg();
            addMaster.ShowDialog();
            updateMasterView();
            updateScoreView();
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            string id = masterView.CurrentRow.Cells[0].Value.ToString();
            UpdateMasterDlg addMaster = new UpdateMasterDlg(id);
            addMaster.ShowDialog();
            updateMasterView();
            updateScoreView();
        }


        private void delStudentBtn_Click(object sender, EventArgs e)
        {
            string id = masterView.CurrentRow.Cells[0].Value.ToString();

            if (query.DeleteMasterInfo(id) == true)
            {
                MessageBox.Show("该生的记录已经删除！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //更新
                updateMasterView();
                updateScoreView();
            }
            else return;
        }

        private void selectStudentBtn_Click(object sender, EventArgs e)
        {
            SelectMasterDlg selectMasterDlg = new SelectMasterDlg();
            selectMasterDlg.MyEvent += new MyDelegate(Find);
            selectMasterDlg.Show();
        }

        private void Find(string id)
        {
            DataSet dataSet = query.SelectOneUser(id);
            if (dataSet.Tables[0].Rows.Count == 0)
                MessageBox.Show("抱歉，没有找到该生的信息!", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            masterView.DataSource = dataSet.Tables[0];
        }

        private void QuitBtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addScoreBtn_Click(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();
            AddScoreDlg addScoreDlg = new AddScoreDlg(id);
            addScoreDlg.ShowDialog();

            updateScoreView();
        }

        private void delScoreBtn_Click(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();

            if (query.DeleteScore(id) == true)
            {
                MessageBox.Show("该生的记录已经删除！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //更新
                updateScoreView();
            }
            else return;
        }

        private void selectScoreBtn_Click(object sender, EventArgs e)
        {
            SelecetScoreDlg selectScoreDlg = new SelecetScoreDlg();
            selectScoreDlg.MyEvent += new MyScoreDelegate(FindScore);
            selectScoreDlg.Show();

            updateScoreView();
        }

        private void FindScore(string id)
        {
            DataSet dataSet = query.SelectByScore(id);
            if (dataSet.Tables[0].Rows.Count == 0)
                MessageBox.Show("抱歉，没有找到该生的信息!", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            scoreView.DataSource = dataSet.Tables[0];
        }

        private void updateScoreBtn_Click(object sender, EventArgs e)
        {
            string id = scoreView.CurrentRow.Cells[0].Value.ToString();
            UpdateScoreDlg updateScoreDlg = new UpdateScoreDlg(id);
            updateScoreDlg.ShowDialog();

            updateScoreView();
        }

        private void QuitBtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectCourseBtn_Click(object sender, EventArgs e)
        {
            updateScoreViewByMaster();
        }

        private void updatePassWordBtn_Click(object sender, EventArgs e)
        {
            UpdatePasswordDlg updatePasswordDlg = new UpdatePasswordDlg(id);
            updatePasswordDlg.ShowDialog();

        }

        private void QuitBtn3_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
