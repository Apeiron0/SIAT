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
                var output = cnn.Query<AlumnoModel>("Select * from Alumnos", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveAlumno(AlumnoModel alumno)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
            }

        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
