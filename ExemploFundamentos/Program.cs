using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Tayna";
pessoa1.Idade = 34;
pessoa1.Apresentar();






//loop for

// for (int i = 0; i<5; i++)
// {
// Console.WriteLine(i);
// }

//menu interativo

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu) 
// {
//     Console.Clear();
//     Console.WriteLine ("Digite sua opção:");
//     Console.WriteLine ("1 - Cadastrar cliente");
//     Console.WriteLine ("2 - Buscar cliente");
//     Console.WriteLine ("3 - Apagar cliente");
//     Console.WriteLine ("4 - Encerrar");

//     opcao = Console.ReadLine()!;
    
//     switch(opcao)
//     {
//     case "1":
//     Console.WriteLine ("Cadastro de cliente");
//     break;

//     case "2":
//     Console.WriteLine ("Busca de cliente");
//     break;
    
//     case "3":
//     Console.WriteLine ("Apagar cliente");
//     break;
     
//     case "4":
//     Console.WriteLine ("Encerrar");
//     exibirMenu = false;
// //     // Environment.Exit(0);
//     break;

//     default:
//     Console.WriteLine ("Opção inválida");
//     break;
//    }
// }

//Console.WriteLine("Hello, World!");

//& Do While
//The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

// Um programa para somar números que forem digitados na tela. Se digitar, o programa dá a soma total

//int soma = 0, numero = 0;

//do
// {
//     Console.WriteLine ("Digite um número (0 para parar)");
//     numero = Convert.ToInt32 (Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine ($"Total da soma dos números digitados é: {soma}");

//& Loop WHILE!
//* Precisa de apenas uma condição. Porém, deve tomar cuidado p/ não gerar algo infinito.

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine ($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//      contador++;
//  }

//& Interrompendo fluxo de execução: BREAK
// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine ($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

// if (contador == 6)
// {
//     break; 
// }

// }

//& Loop FOR!

// int numero = 5;

// for (int contador = 0; contador <= 500 ; contador++)
// {
//     Console.WriteLine ($"{numero} x {contador} = {numero * contador}");
// }


//^ Calculadora

// Calculadora calc = new Calculadora ();

// calc.Somar (10, 30);
// calc.Subtrair (10,30);
// calc.Multiplicar (10,30);
// calc.Dividir (10,30);
// calc.Potencia (3,3);
// calc.Seno (30);
//calc.RaizQuadrada (9);


//^ Incremento e decremento

// int numeroIncremento = 10;

// Console.WriteLine ("Incrementando o 10");
// numero = numero + 1 ;
// numeroIncremento++;

// Console.WriteLine (numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine ("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine (numeroDecremento);


//^ NOT

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde) 
// {
//     Console.WriteLine ("Vou pedalar!");

// } else {
//     Console.WriteLine ("Não vou pedalar");
// }


//^ AND

//* Precisa das 2 condições para o código pegar.

// bool possuiPresencaMinima = true;
// double media = 8.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine ("Aprovado!");
// }
// else 
// {
//     Console.WriteLine ("Reprovado!");
// }


//^ Operador OR

//* Uma condição OU outra para o código pegar

// bool ehMaiordeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiordeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine ("Entrada negada");
// }

//& SWITCH CASE 

//Dizer se a letra digitada é uma vogal.
// Console.WriteLine ("Digite uma letra");
// string letra = Console.ReadLine()!;

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine ("Vogal");
//     break;

//     default:
//     Console.WriteLine ("Não é uma vogal");
//     break;
// }

// if (letra == "a" ||
// letra == "e" ||
// letra == "i" ||
// letra == "o" ||
// letra == "u")
// { 
//     Console.WriteLine ("Vogal");
// }
// else 
// {
//     Console.WriteLine ("Não é vogal");
// }

//* Sem usar switch case, o código fica bem repetitivo:
// if (letra == "a")
// {
//     Console.WriteLine ("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine ("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine ("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine ("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine ("Vogal");
// }
// else {
//     Console.WriteLine ("Não é vogal");
// }


//&Condicionais :)

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

// Console.WriteLine ($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine ($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine ($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// { 
// Console.WriteLine ("Venda Inválida");
// }
// else if (possivelVenda)
// {
// Console.WriteLine ("Venda realizada com sucesso");
// }
// else {
// Console.WriteLine ("Desculpe, não temos a quantidade desejada em estoque.");
// }

// if (quantidadeEmEstoque >= quantidadeCompra)
// { 
// Console.WriteLine ("Compra realizada com sucesso");
// }
// else {
// Console.WriteLine ("Desculpe, não temos a quantidade desejada em estoque.");
// }


//&Convertendo de forma segura

//string a = "15-";
//int b = 0;
//int.TryParse (a, out int b); 

//Console.WriteLine (b);
//Console.WriteLine ("Conversão concluída com sucesso");

//&Cast Implícito

// int a = 5;
// double b = a;

//long a = long.MaxValue;
//int b = Convert.ToInt32(a);
// um long não vai converter pra um int, pois long é maior que int

//int a = int.MaxValue;
//long b = a;

//Console.WriteLine (b);


//&Convertendo para String

//int inteiro = 5;
//string a = inteiro.ToString();

//Console.WriteLine(a); 


//&Convertendo operadores de atribuição:

//Cast / Casting:
//int a = Convert.ToInt32 (null);
//int a = Convert.ToInt32 ("5");
//int a = int.Parse ("5c"); -- vai dar erro

//Há uma diferença de como o Parse e o Convert fazem tratamento de valores nulos
//O parse não aceita nulo e irá encerrar o seu programa
// É preferível usar Convert, para a aplicação não parar

//Console.WriteLine (a);


//^Atribuição:

//int a = 20;
//int b = 30; 

//int c = a + b;

//c = c + 5;
//c += 5;

//c = c - 5;
//c -= 5;

//Console.WriteLine(c);

//^DateTime:

//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine (dataAtual);
//Console.WriteLine (dataAtual.ToString("dd/MM/yyyy HH:mm"));

//^Tipos:

// string apresentacao = "Olá, seja bem vindo(a)";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine (apresentacao);
// Console.WriteLine ("Valor da variável quantidade: " + quantidade);
// Console.WriteLine ("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine ("Valor da variável preco: " + preco);
// Console.WriteLine ("Valor da variável condicao: " + condicao);

//Pessoa pessoa1 = new Pessoa ();
//pessoa1.Nome = "Tayná";
//pessoa1.Idade = 33;
//pessoa1.Apresentar();
