using ExemploFundamentos;
 
// class Solution {
//     public static void Main(string[] args) {
//         int n = int.Parse(Console.ReadLine());
//         int count = 0;
 
//         for (int i = 1; i <= n; i++) 
//         {
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//             if (n % i == 0) {
//                 count++;
//             }
//             if (count > 3) {
//                 Console.WriteLine(false);
//             }
//         }
//          Console.WriteLine(count == 3);
//     }
// }















// //Instancia de classe pessoa
// Pessoa p = new Pessoa();

// //Atribui nome e idade para pessoa
// p.Nome = "Hugo";
// p.Idade = 33;

// p.Apresentar();

























List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


Console.WriteLine($"Intes da minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

foreach(string item in listaString)
{
    Console.WriteLine($"Itens da Lista: {item}");
}

Console.WriteLine();
listaString.Add("SC");

Console.WriteLine("Adicionando SC");

foreach(string item in listaString)
{
    Console.WriteLine($"Itens da Lista: {item}");
}

// Console.WriteLine($"Intes da minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine();
// Console.WriteLine("Removendo MG");

// foreach(string item in listaString)
// {
//     Console.WriteLine($"Itens da Lista: {item}");
// }

// Console.WriteLine($"Intes da minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine();
// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição  n° {contador} - {listaString[contador]}");
// }

// Console.WriteLine();

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição  n° {contadorForeach} - {item}");
//     contadorForeach++;
// }




























// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }



















// Console.WriteLine();

// Console.WriteLine("Percorrendo Array com FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach}° - {valor}");
//     contadorForeach++;
// }




















// Calculadora calc = new Calculadora();

// calc.Somar(5, 5);















// string opcao;

// while(true)
// {
//   Console.WriteLine("Digite a sua opção: ");
//   Console.WriteLine("1 - Cadastrar Cliente");
//   Console.WriteLine("2 - Buscar Cliente");
//   Console.WriteLine("3 - Apagar Cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de Cliente");
//       break;

//     case "2":
//       Console.WriteLine("Busca de Cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar Cliente");
//       break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       Environment.Exit(0);
//       break;

//     default:
//       Console.WriteLine("Opção Inválida");
//       break;
//   }
//   Console.WriteLine();

// }






























// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Soma total é: {soma}");



























// using System;

// class DIO {

// static void Main(string[] args){

//         int n = int.Parse(Console.ReadLine());
//         int p = 1, s = 0;
//         while (n > 0){
//              int l = n % 10;
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//              p = p * l;
//              s = s + l;
//              n = n / 10;
//            }

//            Console.WriteLine(p-s);
//         }
//     }

























// Calculadora calc = new Calculadora();


// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     System.Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }





// calc.RaizQuadrada(49);









// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);



// int numero = 10;

// System.Console.WriteLine(numero);

// System.Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numero++;

// System.Console.WriteLine(numero);



















// calc.Somar(10, 30);
// calc.Subtrair(30, 10);
// calc.Dividir(30, 5);
// calc.Multiplicar(5, 5);
// calc.Potencia(3,3);



































// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }


























// Console.WriteLine("Digite uma letra; ");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }
















// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal.");
// }





























// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 11;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Não temos estoque.");
// }

























// string a = "15s";

// int b = 5;

// int.TryParse(a, out b);

// Console.WriteLine(b);