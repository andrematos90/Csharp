﻿using System;
using System.Collections.Generic;
using CoderBR.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar}, 
                { "Inferência de Tipos - Fundamentos", Inferência_de_Tipo.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolação_de_Strings.Executar},
                {"Notação Ponto - Fundamentos", Notacao_Ponto.Executar},
                {"Lendo Dados no Console - Fundamentos", Lendo_Dados_no_Console.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}