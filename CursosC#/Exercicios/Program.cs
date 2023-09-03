using System;
using System.Collections.Generic;

using Exercicios;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Exercício 001 - Média Simples", Ex001.Executar},
                {"Exercício 002 - Escopo de Variáveis", Ex002.Executar},
                {"Exercício 003 - Escopo de Variáveis e Matrizes", Ex003.Executar},
                {"Exercício 004 - Formataçao de Strings", Ex004.Executar},
                {"Exercício 005 - Enumeradores", Ex005.Executar},
                {"Exercício 006 - Conversões de Tipo", Ex006.Executar},
                {"Exercício 007 - Switch", Ex007.Executar},
                {"Exercício 008 - GoTo", Ex008.Executar},
                {"Exercício 009 - Arrays Unidimensionais", Ex009.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}