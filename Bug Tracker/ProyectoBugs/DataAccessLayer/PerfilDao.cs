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

            var strSql = "SELECT id_perfil, nombre from Perfiles where borrado=0 order by nombre";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(MappingPerfil(row));
            }

            return listadoPerfiles;
        }
        public IList<Perfil> filtrarPerfiles(string filtro)
        {
            List<Perfil> listadoPerfiles = new List<Perfil>();

            var strSql = "SELECT  id_perfil,nombre from Perfiles where borrado=0 and NOMBRE LIKE '" + filtro + "%' ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoPerfiles.Add(MappingPerfil(row));
            }

            return listadoPerfiles;
        }

        internal bool Create(Perfil oPerfil)
        {
            //Si el registro no existe en la tabla, lo creo.
            string query = "IF NOT EXISTS (select 1 from Perfiles Where nombre = '"+oPerfil.Nombre+"')";
            query += "Insert INTO Perfiles (nombre, borrado) VALUES ('" + oPerfil.Nombre + "', 0);";

            return DBHelper.GetDBHelper().EjecutarSQL(query) > 0;
        }

        public bool delete(Perfil oPerfil)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String query = "UPDATE Perfiles SET borrado = '1' WHERE id_perfil=" + oPerfil.IdPerfil;
            return DBHelper.GetDBHelper().EjecutarSQL(query) != 0;

        }

        public bool update(Perfil oPerfil)
        {

            string query = "UPDATE Perfiles SET nombre ='"+ oPerfil.Nombre+"' where id_perfil=" +oPerfil.IdPerfil;
            return DBHelper.GetDBHelper().EjecutarSQL(query) != 0;

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
