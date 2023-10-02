﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
using CFBCursos.Aula15;
using CFBCursos.Aula16;
using CFBCursos.Aula17;
using CFBCursos.Aula18;
using CFBCursos.Aula19;
using CFBCursos.Aula20;
using CFBCursos.Aula21;
using CFBCursos.Aula22;
using CFBCursos.Aula23;
using CFBCursos.Aula24;
using CFBCursos.Aula25;
using CFBCursos.Aula26;
using CFBCursos.Aula27;
using CFBCursos.Aula28;
using CFBCursos.Aula29;
using CFBCursos.Aula30;
using CFBCursos.Aula31;
using CFBCursos.Aula32;
using CFBCursos.Aula33;
using CFBCursos.Aula34;
using CFBCursos.Aula35;
using CFBCursos.Aula36;
using CFBCursos.Aula37;
using CFBCursos.Aula38;
using CFBCursos.Aula39;
using CFBCursos.Aula40;
using CFBCursos.Aula41;
using CFBCursos.Aula42;
using CFBCursos.Aula43;
using CFBCursos.Aula44;
using CFBCursos.Aula45;
using CFBCursos.Aula46;
using CFBCursos.Aula47;
using CFBCursos.Aula48;
using CFBCursos.Aula49;
using CFBCursos.Aula50;
using CFBCursos.Aula51;
using CFBCursos.Aula52;
using CFBCursos.Aula53;
using CFBCursos.Aula54;
using CFBCursos.Aula55;
using CFBCursos.Aula56;
using CFBCursos.Aula57;
using CFBCursos.Aula58;

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
                {"Aula 14 - If Aninhado", IfAninhado.Executar },
                {"Aula 15 - Switch Case", SwitchCase.Executar },
                {"Aula 16 - GoTo", GoTo.Executar },
                {"Aula 17 - Arrays/Vetores", Arrays.Executar },
                {"Aula 18 - Arrays Bidimensionais (Matrizes)", ArraysMatrizes.Executar },
                {"Aula 19 - Loop For", LoopFor.Executar },
                {"Aula 20 - Loop While", LoopWhile.Executar },
                {"Aula 21 - Loop Do While", LoopDoWhile.Executar },
                {"Aula 22 - Loop ForEach", LoopForEach.Executar },
                {"Aula 23 - Métodos de Arrays", MetodosDeArray.Executar },
                {"Aula 24 - Métodos", Metodos.Executar },
                {"Aula 25 - Passagem por Valor e Por Referência", PassagemPorValorEReferencia.Executar },
                {"Aula 26 -  Argumento Out", ArgumentoOut.Executar },
                {"Aula 27 -  Argumento Params", ArgumentoParams.Executar },
                {"Aula 28 - Classes e Objetos", ClassesEObjetos.Executar },
                {"Aula 29 - Métodos Construtor e Destrutor", ConstrutorEDestrutor.Executar },
                {"Aula 30 - SobreCarga de Métodos Construtores", SobreCargaDeMetodosConstrutores.Executar },
                {"Aula 31 - Classes Static", ClassesStatic.Executar },
                {"Aula 32 - This", OperadorThis.Executar },
                {"Aula 33 - Public VS Private", PublicEPrivate.Executar },
                {"Aula 34 - Herança", Herança.Executar},
                {"Aula 35 - Cadeia de Herança e Construtor da Classe Base", CadeiaHerançaConstrutorClasseBase.Executar},
                {"Aula 36 - Membros Protected", MembrosProtected.Executar},
                {"Aula 37 - Ordem de Exeução de Construrores", OrdemExecuçãoConstrutores.Executar },
                {"Aula 38 - Métodos Virtuais", MétodosVirtuais.Executar },
                {"Aula 39 - Classes e Métodos Abstratos", MétodosAbstratos.Executar },
                {"Aula 40 - Classes Sealed", ClassesSealed.Executar },
                {"Aula 41 - Acessors Get e Set", AcessorsGetESet.Executar },
                {"Aula 42 - Indexadores de Classe", IndexadoresDeClasse.Executar },
                {"Aula 43 - Interfaces", Interfaces.Executar },
                {"Aula 44 - Struct", Struct.Executar },
                {"Aula 45 - Arrays de Estruturas", ArraysDeEstruturas.Executar },
                {"Aula 46 - Métodos que Retornam Objetos",  MetodosQueRetornamObjetos.Executar },
                {"Aula 47 - Sobrecarga de Métodos",  SobrecargaDeMetodos.Executar },
                {"Aula 48 - Recursividade",  Recursividade.Executar },
                {"Aula 49 - Métodos e Váriaveis Estáticos", MetodosEVariaveisEstaticos.Executar },
                {"Aula 50 - Delegates", Delegates.Executar },
                {"Aula 51 - Argumentos de Entrada do Programa", ArgumentosDeEntradaDoPrograma.Executar },
                {"Aula 52 - Try Catch Finally -  parte 1", TryCatchFinally.Executar },
                {"Aula 53 - Try Catch Finally - parte 2", Finally.Executar },
                {"Aula 54 - NameSpcaces", NameSpaces.Executar },
                {"Aula 55 - Coleção Dictionary", ColecaoDictionary.Executar },
                {"Aula 56 - Coleção LinkedList", ColecaoLinkedList.Executar },
                {"Aula 57 - Coleção List - parte1", ColecaoList1.Executar },
                {"Aula 58 - Coleção List - parte2", ColecaoList2.Executar },




            });

            central.SelecionarEExecutar();
        } 
    }
}