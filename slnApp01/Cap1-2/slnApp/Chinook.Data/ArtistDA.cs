using Chinook.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class ArtistDA : BaseConnection
    {
        public int Count() {
            var retorno = 0;
            var sql = "SELECT COUNT(1) FROM Artist NOLOCK;";

            using (var dbConnection = this.getConnection()) {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;
                dbConnection.Open();

                retorno = (int)cmd.ExecuteScalar();
            }

            return retorno;
        }

        public List<Artist> Gets()
        {
            var retorno = new List<Artist>();
            var sql = "SELECT ArtistId,Name FROM Artist NOLOCK;";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;
                dbConnection.Open();

                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var artist = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    artist.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    artist.Name = reader.GetString(indice);

                    retorno.Add(artist);
                }
            }

            return retorno;
        }

        public List<Artist> Gets(string filterByName)
        {
            var retorno = new List<Artist>();
            var sql = "SELECT ArtistId,Name FROM Artist NOLOCK WHERE Name LIKE @name";

            using (var dbConnection = this.getConnection())
            {
                retorno = dbConnection.Query<List<Artist>>(sql, new { name = filterByName}).SingleOrDefault();
                //IDbCommand cmd = new SqlCommand(sql);
                //cmd.Connection = dbConnection;

                //cmd.Parameters.Add(new SqlParameter("@name", filterByName));

                //dbConnection.Open();

                //var reader = cmd.ExecuteReader();
                //var indice = 0;
                //while (reader.Read())
                //{
                //    var artist = new Artist();
                //    indice = reader.GetOrdinal("ArtistId");
                //    artist.ArtistId = reader.GetInt32(indice);

                //    indice = reader.GetOrdinal("Name");
                //    artist.Name = reader.GetString(indice);

                //    retorno.Add(artist);
                //}
            }

            return retorno;
        }

        public List<Artist> GetsSP(string filterByName)
        {
            var retorno = new List<Artist>();
            var sql = "usp_GetArtist";

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
                    var artist = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    artist.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    artist.Name = reader.GetString(indice);

                    retorno.Add(artist);
                }
            }

            return retorno;
        }

        public int Insert(Artist entity)
        {
            var retorno = 0;
            var sql = "INSERT INTO Artist(Name) VALUES (@name); SELECT SCOPE_IDENTITY();";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@name", entity.Name));

                dbConnection.Open();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return retorno;
        }

        public int InsertSP(Artist entity)
        {
            var retorno = 0;
            var sql = "usp_InsertArtist";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@name", entity.Name));

                dbConnection.Open();

                retorno = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return retorno;
        }

        public int InsertSPTXLocal(Artist entity)
        {
            var retorno = 0;
            var sql = "usp_InsertArtist";

            using (var dbConnection = this.getConnection())
            {
                dbConnection.Open();
                var transaccion = dbConnection.BeginTransaction();

                try
                {
                    IDbCommand cmd = new SqlCommand(sql);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaccion;
                    cmd.Connection = dbConnection;

                    cmd.Parameters.Add(new SqlParameter("@name", entity.Name));
                    retorno = Convert.ToInt32(cmd.ExecuteScalar());

                    transaccion.Commit();
                } catch(Exception ex)
                {
                    transaccion.Rollback();
                }
            }

            return retorno;
        }

        public int Update(Artist entity)
        {
            var retorno = 0;
            var sql = "UPDATE Artist SET Name = @name WHERE ArtistId = @id";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@name", entity.Name));
                cmd.Parameters.Add(new SqlParameter("@id", entity.ArtistId));

                dbConnection.Open();

                retorno = Convert.ToInt32(cmd.ExecuteNonQuery());
            }

            return retorno;
        }

        public int UpdateSP(Artist entity)
        {
            var retorno = 0;
            var sql = "usp_UpdateArtist";

            using (var dbConnection = this.getConnection())
            {
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = dbConnection;

                cmd.Parameters.Add(new SqlParameter("@id", entity.ArtistId));
                cmd.Parameters.Add(new SqlParameter("@name", entity.Name));                

                dbConnection.Open();

                retorno = Convert.ToInt32(cmd.ExecuteNonQuery());
            }

            return retorno;
        }        
    }
}
