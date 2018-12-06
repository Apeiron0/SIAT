using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAT.Modelos
{
    public class AlumnoModel
    {
        #region Propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime F_Nacimiento { get; set; }
        public DateTime F_Ingreso { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Notas { get; set; }
        public int Activo { get; set; }
        public int Edad
        {
            get { return calcularEdad(F_Nacimiento); }
        }

        #endregion



        private int calcularEdad(DateTime fNacimiento)
        {
            int age = 0;
            age = DateTime.Now.Year - fNacimiento.Year;
            if (DateTime.Now.DayOfYear < fNacimiento.DayOfYear)
                age = age - 1;

            return age;
        }

    }
}
