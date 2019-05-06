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

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string NombreAlumno = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            string IdAlumno = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            DialogResult result = MessageBox.Show("Seguro que desea ELIMINAR a: " + NombreAlumno, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result==DialogResult.Yes)
            {
                AlumnoModel alumno = new AlumnoModel();
                alumno.eliminarAlumno(Convert.ToInt32(IdAlumno), NombreAlumno);
                LoadAlumnos();
            }            
        }
    }
}
