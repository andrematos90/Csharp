using System;
using System.Collections.Generic;

using Exercicios;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Exercício 001 - Média Simples", Ex001.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}