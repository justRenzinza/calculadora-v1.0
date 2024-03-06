using System;

namespace model
{
    public class Subtracao : Operacao
    {
        public int Calcular(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Calcular(int[] valores)
        {
            return 0;
        }
    }
}