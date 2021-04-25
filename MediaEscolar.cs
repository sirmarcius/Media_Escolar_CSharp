
using System;
class MediaEscolar {
  static void Main() {
      
    Console.Write("Qual a primeira nota? ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Qual a segunda nota? ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("Qual a terceira nota? ");
    double n3 = double.Parse(Console.ReadLine());
    Console.Write("Qual a quarta nota? ");
    double n4 = double.Parse(Console.ReadLine());
    double S = (n1+n2+n3+n4)/4;
    
    Console.WriteLine("A média é: " + S);
    
    if (S>=7){
        Console.WriteLine("Aluno Aprovado!");
    } 
    else {
        Console.WriteLine("Aluno Reprovado");
    } 
    
      
  }
  
}
