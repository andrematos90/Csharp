using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula21;
  class LoopDoWhile
    {
    public static void Executar(){

        string password = "12345";
        int attempts = 3;
        string enteredByTheUser;

        do
        {

            Console.Write("Enter the Password:");
            enteredByTheUser = Console.ReadLine();
            Console.WriteLine("Wrong Password!");

            attempts--;
        } while (enteredByTheUser != password);


        Console.Clear();
        Console.WriteLine("Correct Password! Access Granted! ");

    }
}
