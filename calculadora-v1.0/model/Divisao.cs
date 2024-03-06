using System;
namespace model;

public class Divisao : Operacao{
    public int Calcular(int numero1, int numero2){
        if(numero2 == 0){
            throw new ArgumentException("Divisão por 0 não pode amigão!");
        }

        return numero1/numero2;
    }

    public int Calcular(int [] valores){
        return 0;
    }

}

