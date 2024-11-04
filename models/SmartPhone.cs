using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.models
{
    public abstract class SmartPhone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public SmartPhone(string numero, string modelo, string imei, int memoria){
               Numero = numero;
               Modelo = modelo;
               IMEI = imei;
               Memoria = memoria;

        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

         public abstract void InstalarAplicativo(string nomeApp);
    }
}