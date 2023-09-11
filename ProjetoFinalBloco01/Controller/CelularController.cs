using ProjetoFinalBloco01.Model;
using ProjetoFinalBloco01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoFinalBloco01.Controller
{
    public class CelularController : ICelularRepository
    {
        private readonly List<Celular> listaCelulares = new List<Celular>();
        private int numeroCodigoCelular = 1;

        public void AtualizarAparelho(Celular celular)
        {
            var buscarCelular = BuscarAparelho(celular.getCodigoCelular());
            if (buscarCelular is not null)
            {
                var indice = listaCelulares.IndexOf(buscarCelular);
                listaCelulares[indice] = celular;
                Console.Clear();
                Console.WriteLine($"\nO aparelho celular (Código: {celular.getCodigoCelular()}) foi atualizado com sucesso!");
            }
        }

        public void CadastrarAparelho(Celular celular)
        {
            listaCelulares.Add(celular);
            Console.Clear();
            Console.WriteLine($"\nO aparelho celular (Código: {celular.getCodigoCelular()}) foi cadastrado com sucesso!");
        }

        public void DeletarAparelho(int codigoAparelho)
        {
            var celular = BuscarAparelho(codigoAparelho);

            if (celular is not null)
            {
                if (listaCelulares.Remove(celular))
                {
                    Console.Clear();
                    Console.WriteLine($"\nO aparelho celular (Código: {celular.getCodigoCelular()}) foi removido com sucesso!");
                };
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nO aparelho celular (Código: {celular.getCodigoCelular()}) não foi encontrado!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

        }

        public void ListarAparelhos()
        {
            foreach (var celular in listaCelulares) {
                celular.visualizarAparelho();
            }
        }

        public Celular? BuscarAparelho(int codigoAparelho) {

            foreach (var celular in listaCelulares) { 
                if(celular.getCodigoCelular() == codigoAparelho)
                {
                    return celular;
                }  
            }
            return null;
        }

        public int GerarCodigoCelular()
        {
            return numeroCodigoCelular++;
        }
    }
}
