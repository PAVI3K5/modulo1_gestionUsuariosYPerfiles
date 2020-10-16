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

        internal bool Create(Formulario oForm)
        {
            //Si el registro no existe en la tabla, lo creo.
            string query = "IF NOT EXISTS (select 1 from Formularios Where nombre = '" + oForm.Nombre + "')";
            query += "Insert INTO Formularios (nombre, borrado) VALUES ('" + oForm.Nombre + "', 0);";

            return DBHelper.GetDBHelper().EjecutarSQL(query) > 0;
        }

        public bool delete(Formulario oForm)
        {
            //IMPORTANTE: en vez de hacer un delete, hacemos UPDATE porque es BORRADO LÓGICO 
            String query = "UPDATE Formularios SET borrado = '1' WHERE id_formulario=" + oForm.IdFormulario;
            return DBHelper.GetDBHelper().EjecutarSQL(query) != 0;

        }

        public bool update(Formulario oForm)
        {

            string query = "UPDATE Formularios SET nombre ='" + oForm.Nombre + "' where id_formulario=" + oForm.IdFormulario;
            return DBHelper.GetDBHelper().EjecutarSQL(query) != 0;

        }

        public IList<Formulario> GetAll()
        {
            List<Formulario> listadoFormulario = new List<Formulario>();

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSP("SP_CONSULTAR_FORMULARIOS");

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFormulario.Add(MappingFormulario(row));
            }

            return listadoFormulario;
        }

        public IList<Formulario> GetAllWithErased()
        {
            List<Formulario> listadoFormularios = new List<Formulario>();

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSP("SP_CONSULTAR_FORMULARIOS_CON_BORRADO");

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFormularios.Add(MappingFormulario(row));
            }

            return listadoFormularios;
        }

        public IList<Formulario> filtrarFormularios(string filtro)
        {
            List<Formulario> listadoFormularios = new List<Formulario>();

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultarSPConParametros("FILTRAR_FORMULARIOS_POR_NOMBRE", new object[] { filtro });

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFormularios.Add(MappingFormulario(row));
            }

            return listadoFormularios;
        }

        internal IList<Formulario> filtrarFormulariosConBorrados(object filtro)
        {
            List<Formulario> listadoFormularios = new List<Formulario>();

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultarSPConParametros("FILTRAR_FORMULARIOS_POR_NOMBRE_CON_BORRADOS", new object[] { filtro });

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoFormularios.Add(MappingFormulario(row));
            }

            return listadoFormularios;
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
