using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIAT.Modelos;
using SIAT.Data;

namespace SIAT
{
    public partial class frm_Alumnos : Form
    {
        List<AlumnoModel> ListAlumnos = new List<AlumnoModel>();

        public frm_Alumnos()
        {
            InitializeComponent();
        }
        private void LoadAlumnos()
        {
            ListAlumnos = SqliteDataAccess.LoadAlumnos();
            gridControl1.DataSource = null;
            gridControl1.DataSource = ListAlumnos;
        }

        private void frm_Alumnos_Load(object sender, EventArgs e)
        {
            LoadAlumnos();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Alumnos_Nuevo alumnos_Nuevo = new frm_Alumnos_Nuevo();
            alumnos_Nuevo.ShowDialog();
            LoadAlumnos();
        }
    }
}
