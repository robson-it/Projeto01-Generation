using ProjetoFinalBloco01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco01.Repository
{
    internal interface ICelularRepository
    {

        public void ListarAparelhos();
        public void CadastrarAparelho(Celular celular);
        public void DeletarAparelho(int codigo);
        public void AtualizarAparelho(Celular celular);

    }
}
