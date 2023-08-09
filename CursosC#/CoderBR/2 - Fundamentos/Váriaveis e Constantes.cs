using System;


namespace CoderBR.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine("AREA:" + area);

        }
    }
}