
//Console.WriteLine("## Argumentos Nomeados/Opcionais ##\n");

//Console.WriteLine("Informe o Destino:\n");
//var destino= Console.ReadLine();

//Console.WriteLine("Informe o Título:\n");
//var titulo = Console.ReadLine();

//Console.WriteLine("Informe o Assunto:\n");
//var assunto = Console.ReadLine();

//Email email = new();
//email.Enviar(destino);
//email.Enviar(destino, titulo);
//email.Enviar(destino, titulo, assunto);
//email.Enviar(destino, assunto);

//Console.ReadKey();

//public class Email
//{
//public void Enviar (string destino = "padrão", string titulo = "padrão", string assunto = "padrão")
//{
//Console.WriteLine($"\n{destino} - {titulo} \n Assunto: {assunto}");
//}
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine(" ### Exercicio 4 prático ###\n");

//Console.WriteLine("explicar o parâmetro OUT");

//Carro carro = new("Sedan");

//Console.ReadKey();

//public class Carro
//{
//    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
//    {
//        potencia += 7;
//        velocidade = potencia * 1.75;
//        return potencia;
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*Console.WriteLine(" ### Parâmetros Opcionais e Argumentos Nomeados ###\n");

Console.WriteLine("\nUsing argumentos nomeados e parametros opcionais \n");
Console.WriteLine("sem informar o parametro opcional Ano");

Ford ford = new();
ford.ExibirInfo(Modelo: "Ford KA", Montadora:"Amaroka", Marca: "fordismo", Potencia:3050);

Console.ReadKey();

public class Ford
{
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    }
}*/

/*
   argumentos nomeados são aqueles nos quais, ao serem atribuidos seus devidos valores após criação da classe e instanciação, são indicados de acordo com o parâmetro pré-definido no método. 
  os métodos apresentam parâmetros nos quais se esperam que determinados tipos de dados. Ao argumentar no objeto esses que foram parametrizados, é possível inserí-los na ordem do que está no método, ou não, bastando NOMEÀ-LOS.
  exemplo: 
  criei uma classe chamada email >> método Enviar(string assunto, string endereco, string titulo) >> nesse sentido, eu posso tanto passar como argumento nessa ordem (assunto, endereco e titulo) como referenciar como assunto: "tal tal tal", titulo:"teste")
 
  já os argumentos opcionais estão relacionados a um valor padrao que defino ao passar os parâmetros dos métodos. seguindo o exemplo supracitado:
criei uma classe chamada email >> método Enviar(string assunto = "Padrão", string endereco = "Padrão", string titulo = "Padrão") >> nesse sentido, eu não preciso informar todos os parametros. O que eu não informar, estará sendo apresentado como padrão
o valor que chumbei no código.
 
 */
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*Console.WriteLine("MÉTODOS ESTÁTICOS (STATIC)");
// não dependem de um objeto para serem acessados. Pertencem a classe e ñ ao objeto


var soma = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2) 
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("MEMBROS ESTÁTICOS");
// tbm não pertencem à instancia da classe (objeto) e sim a classe propriamente dita

Cliente.Nome = "teste";
// eu n preciso fazer um: Cliente cliente = new(); e depois --> cliente.Nome("teste"); / eu referencio pelo nome da classe
Console.ReadKey();

public class Cliente
{
    public static string? Nome;
    public static int Idade;

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;

    }
} */
/*Console.WriteLine("Campos estáticos - exercício\n");

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 10;
c1.Nome = "Ana Beatriz";
//c1.Juros = 3.99f;
ContaCorrente.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Ana Correia";
//c2.Juros = 4.99f;
ContaCorrente.Juros = 4.99f;

Console.WriteLine($"Cliente: {c1.Nome} - Jurons Anual: {c1.JurosAnual()}");
Console.WriteLine($"Cliente: {c2.Nome} - Jurons Anual: {c2.JurosAnual()}");

Console.ReadLine();
public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}*/
// a palavra STATIC pode ser atribuida ao método, ou ao campo, ou à classe...serve para desacoplar a dependência de acessar aos parâmetros e não precisar instanciar a classe.

//Console.WriteLine("exercício prático 6");

//Carro carro = new();
//carro.Nome = "teste";
//Carro.ValorIPVA = 3;

//Console.ReadKey();

//public class Carro
//{
//    public string? Nome;
//    public static int ValorIPVA;

//    public static int ObterValorIpva(int IPVA)
//    {
//        return ValorIPVA + 4;
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine("\n### Construtor estático ###\n");

//Pessoa p1 = new("Ana Beatriz", 20);

//Console.WriteLine(p1.Nome + " - " + p1.Idade);
//Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);


//Console.ReadKey();


//public class Pessoa
//{
//    public static int IdadeMinima; //campo
//    public string Nome { get; set; } = string.Empty; //prop
//    public int Idade { get; set; }

//    public Pessoa(string nome, int idade)
//    {
//        Console.WriteLine("\nExecutando o construtor parametrizado");
//        Nome = nome;
//        Idade = idade;
//    }
//    public Pessoa() { }
//    static Pessoa()
//    {
//        Console.WriteLine("\nExecutando o construtor estático");
//        Console.WriteLine("Inicializando o campo IdadeMinima");
//        IdadeMinima = 18;
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//using System.Globalization;

//Console.WriteLine("Propriedades");


//Produto produtoObject = new();
//produtoObject.Nome = "Fita isolante";
//produtoObject.Preco = 5;
//produtoObject.Desconto = 0.35;
//produtoObject.PrecoFinal = produtoObject.Preco - produtoObject.Preco * produtoObject.Desconto;
//produtoObject.EstoqueMinimo = 5;

//produtoObject.Exibir();

//Console.ReadKey();

//public class Produto
//{
//    public string? Nome { get; set; }
//    public double Preco { get; set; }
//    public double Desconto { get; set; }
//    public double PrecoFinal { get; set; }
//    public double EstoqueMinimo { get; set; }

//    public void Exibir()
//    {
//        Console.WriteLine($"{Nome} " +
//                          $"\n{Preco.ToString("c")} " +
//                          $"\n{Desconto} " +
//                          $"\n{PrecoFinal.ToString("c")} " +
//                          $"\n{EstoqueMinimo}");
//    }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("exercicio pratico 7");

//Console.ReadKey();

//public class Carro
//{
//    public int ano;
//    public int Ano 
//    {
//        get { return ano; }
//        set 
//        {
//            if (value < 2000)
//                ano = 2000;
//            else if (value > 2022)
//                ano = 2022;
//            else 
//                ano = value;
//        }
//    }
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Description { get; set; }
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("### Structs ###\n");

//Cliente cliente = new();
//cliente.Nome = "Aninha";
//cliente.Idade = 21;
//Console.WriteLine($"{cliente.Nome} e {cliente.Idade}");

//Console.ReadKey();

//public struct Cliente
//{
//public string? Nome { get; set; }
//public int Idade { get; set; }
//public Cliente(string? nome, int idade)
//{
//Nome = nome;
//Idade = idade;
//}
//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("### ENUM ###");

//Console.WriteLine($"{Categorias.Espiritualidade} - \t{(int)Categorias.Espiritualidade}");
//Console.WriteLine($"{Categorias.Tecnologia} - \t\t{(int)Categorias.Tecnologia}");
//Console.WriteLine($"{Categorias.JiuJitsu} - \t\t{(int)Categorias.JiuJitsu}");
//Console.WriteLine($"{Categorias.Futebol} - \t\t{(int)Categorias.Futebol}");
//Console.WriteLine($"{Categorias.Musica} - \t\t{(int)Categorias.Musica}");
//Console.WriteLine($"{Categorias.Geek} - \t\t\t{(int)Categorias.Geek}");

//Console.WriteLine("\nSelecione a Categoria teclando o seu valor:");
//int valor = Convert.ToInt32(Console.ReadLine());
//var nomeCategoriaEnum = (Categorias)valor;

//Console.WriteLine($"Você escolheu a categoria {valor}, que é a categoria {nomeCategoriaEnum} ");

//Console.ReadKey();

//enum Categorias
//{
//    Espiritualidade,
//    Tecnologia,
//    JiuJitsu,
//    Futebol,
//    Musica,
//    Geek,

//}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//using Estudos;
//
//Console.WriteLine("escolha a cor do carro:");
//
//Console.WriteLine($"{CarroEnum.Cinza} - {(int)CarroEnum.Cinza}");
//Console.WriteLine($"{CarroEnum.Vermelho} - {(int)CarroEnum.Vermelho}");
//Console.WriteLine($"{CarroEnum.Azul} - {(int)CarroEnum.Azul}");
//Console.WriteLine($"{CarroEnum.Preto} - {(int)CarroEnum.Preto}");
//Console.WriteLine($"{CarroEnum.Branco} - {(int)CarroEnum.Branco}");
//Console.WriteLine($"{CarroEnum.Prata} - {(int)CarroEnum.Prata}");
//
//
//Console.WriteLine("qual cor vc quer?");
//int IdCor = Convert.ToInt32(Console.ReadLine());
//var CorDoCarro = (CarroEnum)IdCor;
//
//Console.WriteLine($"a cor escolhida foi {CorDoCarro} e o id da cor é {IdCor}");
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//aprendendo a usar o bloquinho de Try-Catch

////Console.WriteLine("diga o valor de x:\n");
////int x = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("diga o valor de y:");
////int y = Convert.ToInt32(Console.ReadLine());

////try
////{
////    int z = x / y;
////    Console.WriteLine($"{x} dividido por {y} = {z}");

////}
////catch (Exception)
////{
////    Console.WriteLine("dividir numero por zero é bronca, negao...\n\n\n");
////    throw;
////}
////Console.ReadKey();

// ---> learning about array, now...
/* arrays são um conjunto de elementos de mesmo tipo de dados e de tamanho fixo. Array de uma dimensão é um VETOR
 *                                                                               Array com mais de uma dimensão é uma Matriz
 */
int[] numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
