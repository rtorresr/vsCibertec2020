using App.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class AlumnoDA : BaseConnection
    {
        public List<Alumno> GetAllADO(string filterByName)
        {
            var retorno = new List<Alumno>();
            var sql = "usp_GetAlumno";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@name", filterByName));

                dbConnection.Open();

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var alumno = new Alumno();
                    indice = reader.GetOrdinal("AlumnoID");
                    alumno.AlumnoID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Nombres");
                    alumno.Nombres = reader.GetString(indice);

                    indice = reader.GetOrdinal("Apellidos");
                    alumno.Apellidos = reader.GetString(indice);

                    indice = reader.GetOrdinal("Direccion");
                    alumno.Direccion = reader.GetString(indice);

                    indice = reader.GetOrdinal("Sexo");
                    alumno.Sexo = reader.GetString(indice);

                    indice = reader.GetOrdinal("FechaNacimiento");
                    alumno.FechaNacimiento = reader.GetDateTime(indice);

                    retorno.Add(alumno);
                }
            }

            return retorno;
        }

        public int InsertADO(Alumno entity)
        {
            var retorno = 0;
            var sql = "usp_InsertAlumno";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@Nombres", entity.Nombres));
                cmd.Parameters.Add(new SqlParameter("@Apellidos", entity.Apellidos));
                cmd.Parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
                cmd.Parameters.Add(new SqlParameter("@Sexo", entity.Sexo));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", entity.FechaNacimiento));

                dbConnection.Open();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return retorno;
        }

    }
}
