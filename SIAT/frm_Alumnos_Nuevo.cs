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
    public partial class frm_Alumnos_Nuevo : Form
    {
        public frm_Alumnos_Nuevo()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)        {       

            Modelos.AlumnoModel alumno = new Modelos.AlumnoModel();
            alumno.Domicilio = txt_domicilio.Text;
            alumno.F_Ingreso = Convert.ToDateTime(txt_fIngreso.Text);
            alumno.F_Nacimiento = Convert.ToDateTime(txt_fNacimiento.Text);
            alumno.Nombre = txt_nombre.Text;
            alumno.Notas = txt_notas.Text;
            alumno.Telefono = txt_telefono.Text;

            try
            {
                alumno.guardarAlumno(alumno);
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }                  
            
            
            
        }
    }
}
