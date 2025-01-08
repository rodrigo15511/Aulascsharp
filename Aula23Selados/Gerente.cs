using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula23Selados
{
    public sealed class Gerente : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario base:" + salario * 1.5);
        }
        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerente trabalhando");
        }
    }
}    