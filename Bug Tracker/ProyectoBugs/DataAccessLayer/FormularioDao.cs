using BugTacker.DataAccessLayer;
using BugTacker.Entities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.DataAccessLayer
{
    class FormularioDao
    {
        public IList<Formulario> getFormularios()
          
        {
            List<Formulario> forms = new  List<Formulario>();

            var query = "select id_formulario,nombre,borrado from Formularios where borrado=0 order by nombre";
            var res = DBHelper.GetDBHelper().ConsultaSQL(query);
            


            foreach (DataRow row in res.Rows)
            {
                forms.Add(MappingFormulario(row));
            }
            return forms;
        
        }
        public IList<Formulario> findById(int id)
        {
            List<Formulario> forms = new List<Formulario>();

            var sql = "SELECT F.id_formulario,F.nombre,F.borrado FROM Permisos P, Formularios F WHERE P.borrado=0 AND P.id_formulario = F.id_formulario AND P.id_perfil = " + id.ToString();
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);
           foreach (DataRow row in res.Rows)
            {
                forms.Add(MappingFormulario(row));
            }

            return forms;


            
        }


        private Formulario MappingFormulario(DataRow row)
        {
            Formulario oForm = new Formulario
            {
                IdFormulario = Convert.ToInt32(row["id_formulario"].ToString()),
                Nombre = row["nombre"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oForm;
        }

    }
}
