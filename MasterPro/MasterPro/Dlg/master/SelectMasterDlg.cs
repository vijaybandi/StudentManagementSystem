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
    public delegate void MyDelegate(string id);

    public partial class SelectMasterDlg : Form
    {
        public event MyDelegate MyEvent;

        public SelectMasterDlg()
        {
            InitializeComponent();
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            MyEvent(id_input.Text.Trim());
            Close();
        }
    }
}
