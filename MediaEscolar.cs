using System;
class MediaEscolar {
  static void Main(string[] args) {
    
    // Recebe a primeira nota
    Console.Write("Qual a primeira nota? ");
    double n1 = double.Parse(Console.ReadLine());
    // Recebe a segunda nota
    Console.Write("Qual a segunda nota? ");
    double n2 = double.Parse(Console.ReadLine());
     // Recebe a terceira nota
    Console.Write("Qual a terceira nota? ");
    double n3 = double.Parse(Console.ReadLine());
    // Recebe a quarta nota
    Console.Write("Qual a quarta nota? ");
    double n4 = double.Parse(Console.ReadLine());
    // Calcula a média
    double S = (n1+n2+n3+n4)/4;
    Console.WriteLine("A média é: " + S);
    // Condiciona a situação do aluno, de acordo com sua média
    if (S>=7){
        Console.WriteLine("Aluno Aprovado!");
    } 
    else {
        Console.WriteLine("Aluno Reprovado");
    } 
    
  }
  
}
