namespace model;

public class Calculadora{

    public int Calcular(string operacao, int numero1, int numero2){
        Operacao op = null;
        
        if (operacao.Equals("soma")){
            Console.WriteLine($"Operacação digitada: {operacao}");
            op = new Somar();
        }

        // n ta entrando nos elif, ou vai pro soma ou vai pro iff (op = null);

        else if (operacao.Equals("divisao")){
            Console.WriteLine($"Operacação digitada: {operacao}");
            op = new Divisao();
        }

        else if (operacao.Equals("subtracao")){
            Console.WriteLine($"Operacação digitada: {operacao}");
            op = new Subtracao();
        }

        else if (operacao.Equals("multiplicacao")){
            Console.WriteLine($"Operacação digitada: {operacao}");
            op = new Multiplicacao();
        }

        if (op != null){
            return op.Calcular(numero1, numero2);
        }
        else{
            Console.WriteLine("Operação não reconhecida!");
            return 0; 
        }
        

    }
}
