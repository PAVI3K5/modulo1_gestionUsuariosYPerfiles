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
        FormularioDao formularioDao = new FormularioDao();
        public IList<Formulario> obtenerFormularios(int id)
        {
            return formularioDao.findById(id);
        }

        public IList<Formulario> obtenerTodosLosFormularios()
        {
            return formularioDao.getFormularios();
        }
    }
}
