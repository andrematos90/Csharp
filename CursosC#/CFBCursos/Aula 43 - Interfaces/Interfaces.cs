using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula43
{
    class Interfaces
    {
        //classes que usarem essa interface terão que obrigatoriamente implementar esses métodos
        public interface Veiculo
        {
            
            void ligar();
            void desligar();
            void info();
        }

        public interface Combate
        {
            void disparar();
        }

        class Carro : Veiculo ,Combate
        {
            public bool ligado;
            private int municao;
            public Carro()
            {
                setMunicao(100);

            }
            public void setMunicao(int qtde)
            {
                this.municao = qtde;
            }
            public void ligar()
            {
                this.ligado = true;

            }

            public void desligar()
            {
                this.ligado = false;

            }

            public void info()
            {

            }

            public void disparar()
            {
                

            }
        }


       
        public static void Executar()
        {

        }
    }
}

/*
 
*somente métodos existem em interfaces 
*classes que usarem uma inteface obrigatoriamente terão que implementar seus métodos
*
*/
