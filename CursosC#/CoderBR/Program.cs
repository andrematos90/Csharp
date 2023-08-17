﻿using System;
using System.Collections.Generic;
using CoderBR.Fundamentos;
using CoderBR.EstruturaDeControle;
using CoderBR.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                { "Inferência de Tipos - Fundamentos", Inferência_de_Tipo.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolação_de_Strings.Executar},
                {"Notação Ponto - Fundamentos", Notacao_Ponto.Executar},
                {"Formatação de Números - Fundamentos", Formatando_Numeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", Operadores_Aritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", Operadores_Relacionais.Executar},
                {"Operadores Lógicos - Fundamentos", Operadores_Logicos.Executar },
                {"Operadores de Atribuição - Fundamentos", Operadores_DeAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", Operadores_Unarios.Executar },
                {"Operador Ternário - Fundamentos", Operador_Ternario.Executar },

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar },
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIF_Else.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSWitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DoWHile - Estruturas de Controle", DoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                
                //Classes e Métodos
                 {"Classes e Objetos - Classes e Métodos", ClasseEObjetos.Executar },
                 {"Métodos - Classes e Métodos", Metodos.Executar },
            }); 

            central.SelecionarEExecutar();
        }
    }
}