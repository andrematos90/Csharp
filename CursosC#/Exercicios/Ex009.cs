/*Você foi designado para criar um programa em C# que lida com dados de estudantes em uma sala de aula. O programa deve usar um array unidimensional para armazenar as idades dos estudantes.

Aqui estão os requisitos do exercício:

Crie um array unidimensional para armazenar as idades de 10 estudantes. Inicialize o array com valores de idade padrão (por exemplo, 18, 19, 20, etc.).

Permita que o usuário insira as idades dos estudantes. Certifique-se de validar que as idades inseridas são números inteiros válidos e estão dentro de um intervalo razoável (por exemplo, entre 18 e 30 anos).

Calcule a média das idades dos estudantes e exiba-a na tela.

Encontre e exiba a idade mais alta e a idade mais baixa entre os estudantes.

Classifique o array de idades em ordem crescente e exiba-o na tela.

Peça ao usuário para procurar uma idade específica e, em seguida, informe se essa idade está presente no array.

Permita que o usuário insira uma nova idade e adicione-a ao array. Em seguida, atualize a média das idades.

Exiba o array atualizado.*/


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex009
    {
        public static void Executar()
        {

            int[] ageStudents = new int[10];

            int average = 0;
            int sum = 0;
            int highestAge = 0;
            int lowestAge = int.MaxValue;
            string userInput = "";
            int convertido = 0;
            bool ok = false;
            
            Console.WriteLine("input the ages: ");

            for(int i = 0; i < ageStudents.Length; i++)
            {
                
                ageStudents[i] = int.Parse(Console.ReadLine());
                sum += ageStudents[i];

                if (ageStudents[i] > highestAge)
                {
                    highestAge = ageStudents[i];
                    
                }

                if(ageStudents[i] < lowestAge) 
                {
                    lowestAge = ageStudents[i];
                }


            }

            average = sum / ageStudents.Length;

            Console.WriteLine($"Average: {average} years old");
            Console.WriteLine($"HighestAge: {highestAge}");
            Console.WriteLine($"LowestAge: {lowestAge}");


            Array.Sort(ageStudents);

            Console.WriteLine("in order: ");

            foreach(int item in ageStudents)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Do you want to search for an age?Provide the age, or type N for no: ");
            userInput = Console.ReadLine().ToUpper();

            if (userInput != "N") 
            {

                convertido = int.Parse(userInput);
                foreach (int item in ageStudents)
                {
                    if(convertido == item)
                    {
                        ok = true;
                    }
                  
                }

            }

            if (ok)
            {
                Console.WriteLine("It's between the ages.");
            }
            else
            {
                Console.WriteLine("It's not among the ages.");
            }

        }
    }
}
