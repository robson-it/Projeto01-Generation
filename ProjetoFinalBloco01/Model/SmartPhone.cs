using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalBloco01.Model
{
    public class SmartPhone : Celular
    {
        private bool leitorBiometrico;
        private string frequenciaRedeMovel;

        public SmartPhone(int codigoCelular, string modelo, string fabricante, string sistemaOperacional, string cor, string descricao, int imei, decimal preco, bool leitorBiometrico, string frequenciaRedeMovel) 
                         : base(codigoCelular, modelo, fabricante, sistemaOperacional, cor, descricao, imei, preco)
        {
            this.leitorBiometrico = leitorBiometrico;
            this.frequenciaRedeMovel = frequenciaRedeMovel;
        }

        public bool getLeitorBiometrico() { return this.leitorBiometrico; }
        public string getFrequenciaRedeMovel() { return this.frequenciaRedeMovel; }

        public void setLeitorBiometrico(bool leitorBiometrico) { this.leitorBiometrico = leitorBiometrico; }
        public void setFrequenciaRedeMovel(string frequenciaRedeMovel) { this.frequenciaRedeMovel = frequenciaRedeMovel; }

        public override void visualizarAparelho()
        {
            base.visualizarAparelho();
            Console.WriteLine($"    Possúi leitor biométrico?: {((this.getLeitorBiometrico())? "Sim" : "Não" )}  ");
            Console.WriteLine($"    Tecnologia de internet (3G / 4G / 5G): {getFrequenciaRedeMovel()}            ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
