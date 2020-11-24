using System;

namespace Exericio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {double desc = 0;
            double notaf;
            Console.WriteLine("Qual produto deseja comprar? \n");
            string prod = Console.ReadLine();
            Console.WriteLine($"Qual é a quantidade desejada? \n");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quantos custa cada {prod}? \n");
            double valor = double.Parse(Console.ReadLine());
            double total = quantidade * valor;

            if (prod == "") {Console.WriteLine("Algo errado");}            
            if (quantidade == 0) {Console.WriteLine("Algo errado");}            
            if (valor == 0) {Console.WriteLine("Algo errado");}

            else if (quantidade <= 5) { desc = total * 0.02; }
            else if (quantidade > 5 && quantidade <= 10) { desc = total * 0.03; }
            else { desc = total * 0.05; };

            notaf = total - desc;
            Console.WriteLine($"Sem desconto custou: R${total.ToString("N2")}"); 
            Console.WriteLine($"O desconto foi de: R${desc.ToString("N2")}");          
            Console.WriteLine($"Então ficou por: R${notaf.ToString("N2")}");

        }
        }
    }
}
