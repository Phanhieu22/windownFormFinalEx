using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_thuoc
{
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
        }

        public static string randomId(string k)
        {
            Random rm = new Random();
            return k + rm.Next(100000).ToString();
        }
        private void quảnLýKhoThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new QL_kho_thuoc();
            fr.MdiParent = this;
            fr.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new TK_khach_hang();
            fr.MdiParent = this;
            fr.Show();
        }

        private void FormMdi_Load(object sender, EventArgs e)
        {

        }
    }
}
