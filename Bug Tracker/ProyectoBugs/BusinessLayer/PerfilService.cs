using BugTacker.Entities;
using ProyectoBugs.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBugs.BusinessLayer
{
    class PerfilService
    {
        private PerfilDao oPerfilDao;
        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }

        public IList<Perfil> recuperarTodos()
        {
            return oPerfilDao.GetAll();
        }

        internal bool CrearPerfil(Perfil oPerfil)
        {
            return oPerfilDao.Create(oPerfil);
        }
    }
}
