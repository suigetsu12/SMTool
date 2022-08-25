using SM.Forms.Forms.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.Forms.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mtConfiguration_Click(object sender, EventArgs e)
        {
            frmConfiguration frm = new frmConfiguration();
            frm.ShowDialog();
        }

        private void mtSQLConfiguration_Click(object sender, EventArgs e)
        {
            frmSQL frm = new frmSQL();
            frm.ShowDialog();
        }

        private void mtServers_Click(object sender, EventArgs e)
        {
            frmServer frm = new frmServer();
            frm.ShowDialog();
        }
    }
}
