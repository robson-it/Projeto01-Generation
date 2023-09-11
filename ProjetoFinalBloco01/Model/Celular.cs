using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco01.Model
{
    public abstract class Celular
    {

        private int codigoCelular; 
        private string modelo;
        private string fabricante;
        private string sistemaOperacional;
        private string cor;
        private string descricao;
        private int imei;
        private decimal preco;

        public Celular()
        {

        }

        public Celular(int codigoCelular, string modelo, string fabricante, string sistemaOperacional, string cor, string descricao, int imei, decimal preco)
        {
            this.codigoCelular = codigoCelular;
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.sistemaOperacional = sistemaOperacional;
            this.cor = cor;
            this.descricao = descricao;
            this.imei = imei;
            this.preco = preco;
        }

        
        public int getCodigoCelular() {  return codigoCelular; }
        public string getModelo() {  return modelo; }
        public string getFabricante() {  return fabricante; }
        public string getSistemaOperacional() { return sistemaOperacional; }
        public string getCor() { return cor; }
        public string getDescricao() {  return descricao; }
        public int getImei() { return imei; }
        public decimal getPreco() { return preco; }


        public void setCodigoCelular(int codigoCelular) {this.codigoCelular = codigoCelular; }
        public void setModelo(string modelo) { this.modelo = modelo; }
        public void setFabricante(string fabricante) { this.fabricante = fabricante; }
        public void setSistemaOperacional(string sistemaOperacional) { this.sistemaOperacional = sistemaOperacional; }
        public void setCor(string cor) { this.cor = cor; }
        public void setDescricao(string descricao) { this.descricao = descricao; }
        public void setImei(int imei) { this.imei = imei; }
        public void setPreco(decimal preco) { this.preco = preco; }

        public virtual void visualizarAparelho()
        {

            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                             *++ Dados do aparelho ++*                            ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Modelo: {this.getModelo()}                                                   ");
            Console.WriteLine($"    Fabricante: {this.getFabricante()}                                           ");
            Console.WriteLine($"    Sistema Operacional: {this.getSistemaOperacional()}                          ");
            Console.WriteLine($"    Cor: {this.getCor()}                                                         ");
            Console.WriteLine($"    Descrição: {this.getDescricao()}                                             ");
            Console.WriteLine($"    Preço: {this.getPreco().ToString("C")}                                       ");
        }
    }
}
