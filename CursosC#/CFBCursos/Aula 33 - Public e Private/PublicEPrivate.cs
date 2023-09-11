using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula33
{
    public class Animal
    {
        public string espécie;
        private string nome;

        public Animal()
        {
            this.espécie = "Cachorro";
            this.nome = "Simba";

        }

        public string getNomeAnimal()
        {
            return nome;
        }

        public void setNomeAnimal(string n)
        {
            nome = n;
        }
    }


    class PublicEPrivate
    {
        public static void Executar()
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.espécie); // acessa direto a propriedade pública
           
            animal.setNomeAnimal("bin"); // setando valor através do método setter que acessa propredade privada da classe Animal
            Console.WriteLine(animal.getNomeAnimal()); //acessando propriedade privada através do método get

        }
    }
}
