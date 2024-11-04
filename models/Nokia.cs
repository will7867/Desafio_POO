using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.models
{
    public class Nokia:SmartPhone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){

        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando aplicativp: {nomeApp} no Nokia");
        }
    }
}