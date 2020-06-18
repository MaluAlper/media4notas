using System;

namespace media4notas
{
    class Program
    {
    
        //Receba 4 notas, com somente uma casa decimal. Valide se todas estão entre 0.0 e 10.0. Se alguma delas 
        //não estiver, exiba “Digite somente notas entre 0 e 10.”. Caso todas as notas sejam válidas, calcule a
        // média aritmética das notas. Exiba uma mensagem no seguinte padrão: “Você ficou com média 7,5. Resultado: 
        //Aprovado”.
        //Resultados possíveis:
        //“Reprovado” para médias menores que 5.0
        //“Em recuperação” para médias entre 5.0 e 6.0
        //“Aprovado”, para médias acima de 6.0
      
      
      
     static void Main(string[] args)
{
    
            double nota1, nota2, nota3, nota4;
            string note1, note2, note3, note4;
            double notaFinal;
            
            Console.Write("Primeira nota:");
            note1 = Console.ReadLine();
            nota1 = double.Parse(note1);
            if (nota1>10 || nota1 <0){
               Console.WriteLine ("Valor inválido");
                            
                
                       }

            Console.Write("Segunda nota:");
            note2 = Console.ReadLine();
            nota2 = double.Parse(note2);

            Console.Write("Terceira nota:");
            note3 = Console.ReadLine();
            nota3 = double.Parse(note3);

            Console.Write("Quarta nota:");
            note4 = Console.ReadLine();
            nota4 = double.Parse(note4);

             notaFinal = (nota1 + nota2 + nota3 + nota4)/4;

             if(notaFinal < 5)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal + " Reprovado");
             }

             if(notaFinal >= 5 && notaFinal <=6)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal+ " Recuperação");
             }

             if(notaFinal > 6)
             {
                Console.WriteLine("Media de aproveitamento = " + notaFinal + " Nota final= " + notaFinal+ " Aprovado");
             }
            
       }
    }
}
