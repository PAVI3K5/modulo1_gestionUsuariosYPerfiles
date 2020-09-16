using BugTacker.DataAccessLayer;
using BugTacker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.DataAccessLayer
{
    class PerfilDao
    {
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoPerfiles = new List<Perfil>();

            var strSql = "SELECT id_perfil, nombre from Perfiles where borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(MappingPerfil(row));
            }

            return listadoPerfiles;
        }

        internal bool Create(Perfil oPerfil)
        {
            string query = "DECLARE @idPerfil int;";
            query += "Insert INTO Perfiles (nombre, borrado) VALUES ('" + oPerfil.Nombre + "', 0);";

            return DBHelper.GetDBHelper().EjecutarSQL(query) > 0;
        }


        private Perfil MappingPerfil(DataRow row)
        {
            Perfil oPerfil = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString(),
            };

            return oPerfil;
        }
    }
}
