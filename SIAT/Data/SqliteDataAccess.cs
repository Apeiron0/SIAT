using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAT.Modelos;
using System.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;
using Dapper;

namespace SIAT.Data
{
    public class SqliteDataAccess
    {
        public static List<AlumnoModel> LoadAlumnos()
        {
            using(IDbConnection cnn=new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AlumnoModel>("Select * from Alumnos where Activo=1", new DynamicParameters());                
                return output.ToList();
            }
        }
        public String SaveAlumno(AlumnoModel alumno)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand insert = new SQLiteCommand("Insert into Alumnos(Nombre, F_Nacimiento, F_Ingreso, Domicilio, Telefono, Notas) " +
                    "values ('"+alumno.Nombre+"','"+alumno.F_Nacimiento+"','"+@alumno.F_Ingreso+"','"+@alumno.Domicilio+"','"+alumno.Telefono+"','"+alumno.Notas+"')",cnn);                                
                try
                {
                    insert.ExecuteNonQuery();
                    return null;
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    cnn.Close();
                }
                
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
