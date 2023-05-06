using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoDienTu
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaff ft = new FormStaff();
            ft.ShowDialog();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDevice fd = new FormDevice();
            fd.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClient fc = new FormClient();
            fc.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fh = new FormLogin();
            fh.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fh = new FormLogin();
            fh.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
