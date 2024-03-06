using model;
namespace controller;

public class ControladorCalculadora{
    public int calcular(string operacao, int a, int b){
        Calculadora calc = new Calculadora();
        return calc.Calcular(operacao, a, b);
    }
}