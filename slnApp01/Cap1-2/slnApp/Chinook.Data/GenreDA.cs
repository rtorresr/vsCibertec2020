using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class GenreDA : BaseConnection
    {
        public int Count()
        {
            var retorno = 0;
            var sql = "SELECT COUNT(1) FROM Genre NOLOCK;";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;
                dbConnection.Open();

                retorno = (int)cmd.ExecuteScalar();
            }

            return retorno;
        }

        public List<Genre> Gets()
        {
            var retorno = new List<Genre>();
            var sql = "SELECT GenreId,Name FROM Genre NOLOCK;";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;
                dbConnection.Open();

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var genre = new Genre();
                    indice = reader.GetOrdinal("GenreId");
                    genre.GenreId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    genre.Name = reader.GetString(indice);

                    retorno.Add(genre);
                }
            }

            return retorno;
        }
    }
}
