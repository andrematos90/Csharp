using System;
using System.Collections.Generic;
using CFBCursos.Aula01;
//using CFBCursos.Aula02;
using CFBCursos.Aula03;
using CFBCursos.Aula04;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new Central(new Dictionary<string, Action>() {
                {"Aula 01 - Primeiro Programa Padrão C# Puro", PrimeiroProgramaPadraoCsharpPuro.Executar},
                {"Aula 02 - Primeiro Programa Padrao .Net", PrimeiroProgramaPadraodotNet.Executar },
                {"Aula 03 - Variáveis", Variaveis.Executar },
                {"Aula 04 - Escopo De Variáveis", EscopoDeVariaveis.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}