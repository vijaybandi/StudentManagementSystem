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
    public delegate void MyScoreDelegate(string score);

    public partial class SelecetScoreDlg : Form
    {
        public SelecetScoreDlg()
        {
            InitializeComponent();
        }

        public MyScoreDelegate MyEvent;

        private void SureBtn_Click(object sender, EventArgs e)
        {
            MyEvent(score_input.Text.Trim());
            Close();
        }
    }
}
