using Sobreposicao_PalavraVirtual_Override_Base.Entities;
using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * POLIMORFISMO: 
            - Em programação orientada a objetos, polimorfismo é recurso que permite que variáveis de um mesmo tipo mais genérico possam
            apontar para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada tipo específico.
            
             EXEMPLO:
             */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            /*Duas variáveis do tipo Account, porém no momento de instância-las uma foi instanciado como Account e a outra com SavindsAccount,
            sendo criada então dois objetos diferentes na memória, porém o seu tipo é o mesmo (Account) e o comportamento de cada uma também
            será diferentes e isso é chamado de polimorfismo.*/

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            /*OBS.
             * IMPORTANTE ENTENDER:
             - A associação do tipo específico com o tipo genérico é feita em tempo de execução (upcasting).
            - O compilador não sabe para qual tipo específico a chamada do método Withdraw está sendo feita (ele só sabe que são duas variáveis tipo Account).
             */
        }
    }
}
