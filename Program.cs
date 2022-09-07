using System;

namespace md07_CadernoExercicios_04
{
    class Program
    {
        /*
         3. Faça um programa com uma função que solicita a digitação da idade de um
            nadador. Classifique-o em uma das seguintes categorias:
            - Infantil A = 5 a 7 anos
            - Infantil B = 8 a 11 anos
            - Juvenil A = 12 a 13 anos
            - Juvenil B = 14 a 17 anos
            - Adultos = Maiores de 18 anos
        4. Refazer o exercício 3 de forma que o método receba a idade por parâmetro.
                        */
        public static int idade;
        public static string classCateg;

        public static void classificarCategorias()
        {
            Console.WriteLine("Digite a idade do nadador:");
            idade = Convert.ToInt32(Console.ReadLine());
            //Infantil A = 5 a 7 anos
            if (idade >= 5 && idade <= 7)
            {
                classCateg = "Infantil A";
            }
            //- Infantil B = 8 a 11 anos
            else if (idade >= 8 && idade <= 11)
            {
                classCateg = "Infantil B";
            }
            //-Juvenil A = 12 a 13 anos
            else if (idade >= 12 && idade <= 13)
            {
                classCateg = "Juvenil A";
            }
            // -Juvenil B = 14 a 17 anos
            else if (idade >= 14 && idade <= 17)
            {
                classCateg = "Juvenil B";
            }
            //- Adultos = Maiores de 18 anos
            else if (idade >= 18)
            {
                classCateg = "Adultos";
            }
            else
            {
                classCateg = "Esta idade (" + idade + " anos) " +
                    "não pode participar de campionatos. ";
            }
        }
        public static void retornoCategoria()
        {
            if (idade < 5)
            {
                Console.WriteLine(classCateg);

            }
            else
            {
                Console.WriteLine("De acordo com a idade digitada, a " +
                    "classificação do nadador é " + classCateg);
            }
        }
        static void Main(string[] args)

        {
            string sair = "1";
            do
            {
                classificarCategorias();
                retornoCategoria();

                Console.WriteLine("\nDigite qualquer tecla " +
                    "para sair ou 1 para continuar");
                sair = Console.ReadLine();
            } while (sair.Equals("1"));
        }
    }
}
