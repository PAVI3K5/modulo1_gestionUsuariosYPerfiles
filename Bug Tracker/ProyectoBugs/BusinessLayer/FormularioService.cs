using BugTacker.Entities;
using ProyectoBugs.DataAccessLayer;
using ProyectoBugs.GUILayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.BusinessLayer
{
    class FormularioService
    {
        FormularioDao oFormularioDao = new FormularioDao();
        public IList<Formulario> obtenerFormularios(int id)
        {
            return oFormularioDao.findById(id);
        }

        public IList<Formulario> recuperarTodos()
        {
            return oFormularioDao.GetAll();
        }
        public IList<Formulario> recuperarTodosConBorrados()
        {
            return oFormularioDao.GetAllWithErased();
        }

        internal bool CrearFormulario(Formulario oForm)
        {
            return oFormularioDao.Create(oForm);
        }
        public bool borrarFormulario(Formulario oForm)
        {
            return oFormularioDao.delete(oForm);
        }
        public bool actualizarFormulario(Formulario oForm)
        {
            return oFormularioDao.update(oForm);

        }


        public IList<Formulario> buscarFormulario(string filtro)
        {
            return oFormularioDao.filtrarFormularios(filtro);
        }

        public IList<Formulario> buscarFormularioConBorrados(string filtro)
        {
            return oFormularioDao.filtrarFormulariosConBorrados(filtro);
        }
    }
}
