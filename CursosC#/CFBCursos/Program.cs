using System;
using System.Collections.Generic;

using CFBCursos.Aula01;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new Central(new Dictionary<string, Action>() {
                {"Aula 01", Aula01.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}