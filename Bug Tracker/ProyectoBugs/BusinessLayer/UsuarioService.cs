    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTacker.DataAccessLayer;
using BugTacker.Entities;

namespace BugTacker.BusinessLayer
{
    public class UsuarioService
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> recuperarTodos()
        {
            return oUsuarioDao.GetAll();
        }

        public Usuario ValidarUsuario(string usuario, string password)
        {
            Usuario userLogin = oUsuarioDao.GetUsuario(usuario);

            if (userLogin != null)
            { 
                if (userLogin.Password != null && userLogin.Password.Equals(password))
                {
                    return userLogin;
                }
            }
            return null;
        }

        public Usuario recuperarUsuario(string nombreUsuario)
        {
            return oUsuarioDao.GetUsuario(nombreUsuario);
        }
    }
}
