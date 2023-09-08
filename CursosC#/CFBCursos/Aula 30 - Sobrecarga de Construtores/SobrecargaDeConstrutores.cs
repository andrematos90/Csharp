using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CFBCursos.Aula30
{
    class SobreCargaDeMetodosConstrutores
    {

        class Carro
        {
            public string marca;
            public string modelo;
            public int ano;
            public bool importado;

            public Carro()
            {
                marca = "Marca indefinida";
                modelo = "Modelo Desconhecido";
                ano = 0000;
                importado = false;
            }

            public Carro(string m)
            {
                marca = m;
                modelo = "Modelo Desconhecido";
                ano = 0000;
                importado = false;
            }

            public Carro(string m, string mo)
            {
                marca = m;
                modelo = mo;
                ano = 0000;
                importado = false;

            }

            public Carro(string m, string mo, int an)
            {
                marca = m;
                modelo = mo;
                ano = an;
                importado = false;
            }

            public Carro(string m, string mo, int an, bool imp)
            {
                marca = m;
                modelo = mo;
                ano = an;
                importado = imp;
            }


            public void info()
            {
                Console.WriteLine($"Marca do veículo: {marca}");
                Console.WriteLine($"Modelo do veículo: {modelo}");
                Console.WriteLine($"Ano de Fabricação: {ano}");
                Console.WriteLine($"Importado: {(importado ? "sim" : "não")}");
                Console.WriteLine();

            }

        }
        public static void Executar()
        {

            Carro carro1 = new Carro();
            Carro carro2 = new Carro("Renault");
            Carro carro3 = new Carro("Fusca", "Volkswagen");
            Carro carro4 = new Carro("Saveiro", "Volkswagen", 2016);
            Carro carro5 = new Carro("Malibu", "Chevrolet", 2010, true);


            carro1.info();
            carro2.info();
            carro3.info();
            carro4.info();
            carro5.info();

        }
    }
}
