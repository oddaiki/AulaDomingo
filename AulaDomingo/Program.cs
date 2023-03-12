using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDomingo
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            double idade;
            double meses = 12;
            double maioridade = 18;
            string nome;

            Console.WriteLine("Qual o seu nome? ");
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Quantos anos você tem? ");
            idade = Convert.ToDouble(Console.ReadLine());
     
        if (idade >= maioridade)
        {
                Console.WriteLine("Boa! " + nome + " ! já é de maior");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(nome + " Falta(m) " + (maioridade - idade) + " anos e " +
                    meses + " meses para completar a maioridade");
                Console.WriteLine("Por isso não poderá dirigir ou beber");
                Console.ReadLine();
            }
        
        }
    }
}
