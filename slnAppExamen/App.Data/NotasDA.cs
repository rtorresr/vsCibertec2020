using App.Entities;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace App.Data
{

    public class NotasDA : BaseConnection
    {
        public int InsertDp(Notas entity)
        {
            var retorno = 0;
            var sql = "INSERT INTO [dbo].[Notas] ([AlumnoID],[CursoID],[Nota]) VALUES (@AlumnoID,@CursoID,@Nota)  SELECT SCOPE_IDENTITY()";
            using (var dbConnection = this.getConnection())
            {
                retorno = dbConnection.Query<int>(sql,
                   new { AlumnoID = entity.AlumnoID, CursoID = entity.CursoID, Nota = entity.Nota }
                   ).Single();
            }

            return retorno;
        }

        public List<NotasD> GetAllSPDp(string filterGrado, string filterCurso)
        {
            var retorno = new List<NotasD>();
            var sql = "usp_GetNotas";
            using (var dbConnection = this.getConnection())
            {
                retorno = dbConnection.Query<NotasD>(sql, new { Grado = filterGrado, Curso = filterCurso },
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }

            return retorno;
        }
    }
}
