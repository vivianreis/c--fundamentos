using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MontatoraBLL
    {
        public void Salvar(MontadoraModel model)
        {
            if ( model.Id == 0)
            {
                Adicionar(model);
                return;
            }
        }
        private void Adicionar(MontadoraModel model)
        {

        }

        private void Alterar(MontadoraModel model)
        {

        }

        public void Remover(MontadoraModel model)
        {

        }
    }
}
