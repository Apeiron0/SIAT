using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAT
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }

            frm_Alumnos alumnos = new frm_Alumnos();
            alumnos.MdiParent = this;
            alumnos.Width = panel2.Width;
            alumnos.Height = panel1.Height;
            splashScreenManager1.CloseWaitForm();
            alumnos.Show();
        }
    }
}
