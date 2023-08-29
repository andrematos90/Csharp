using System;
using System.Collections.Generic;
using CFBCursos.Aula01;
//using CFBCursos.Aula02;
using CFBCursos.Aula03;
using CFBCursos.Aula04;
using CFBCursos.Aula05;
using CFBCursos.Aula06;
using CFBCursos.Aula07;
using CFBCursos.Aula08;
using CFBCursos.Aula09;
using CFBCursos.Aula10;
using CFBCursos.Aula11;
using CFBCursos.Aula12;
using CFBCursos.Aula13;
using CFBCursos.Aula14;

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
                {"Aula 05 - Operadores e Operações", OperadoresEOperacoes.Executar },
                {"Aula 06 - Formatando a Saída No Console",  FormatandoSaidaNoConsole.Executar },
                {"Aula 07 - Constantes",  Constantes.Executar },
                {"Aula 08 - Lendo Valores do Teclado",  LendoValoresDoTeclado.Executar },
                {"Aula 09 - Operações de Bitwise",  OperadoresDeBitwise.Executar },
                {"Aula 10 - Enumeradores (Enum)", Enumeradores.Executar },
                {"Aula 11 - Conversões de Tipo (typecast)", Typecast.Executar },
                {"Aula 12 - Condicional If", CondicionalIf.Executar },
                {"Aula 13 - Condicional If/Else", CondicionalIfElse.Executar },
                {"Aula 14 - If Aninhado", IfAninhado.Executar }

            });

            central.SelecionarEExecutar();
        }
    }
}