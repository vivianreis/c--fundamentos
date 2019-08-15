using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Model;

namespace Business
{
    public class UsuarioModel
    {

        public Usuario UsuarioLogado
        {
            get
            {
                Usuario usr = new Usuario();
                    usr.Login = "admin";
                    usr.Nome = "administrador";

                return usr;
            }
        }
        public bool Logar(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
