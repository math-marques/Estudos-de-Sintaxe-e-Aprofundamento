//Console.WriteLine("Aulinha número 1 = ARRAYS");
///* Um array é um conjunto de elementos de mesmo tipo de dados com tamanho fixo. Um array de uma dimensão é conhecido como
// * VETOR. já um array com mais de uma dimensão é conhecido como MATRIZ
// */

////declarei o array
//int[] numeros;
////aloquei memória
//numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

//string[] nomes = new string[5] {"Ana", "Beatriz", "Souza", "Correia", "Marques"};

//// pra acessar os elementos do array, a gente usa o índice
////                   |-----------|-----------|-----------|-----------|
////                   0           1           2           3           4

//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);
//Console.WriteLine(nomes[2]);
//Console.WriteLine(nomes[3]);
//Console.WriteLine(nomes[4]);
//Console.WriteLine(nomes[5]);

//// percorrendo os elementos (length) usando for
////  inicialização/   condição/      iteração
//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
//}
//// usando foreach (n preciso usar o índice

//foreach(int numero in numeros)
//{
//    Console.WriteLine(numero);
//} //classes de array fornece metodos pra mim manipular, criar, pesquisr, etc..

//string[] nomes2 = { "Ana", "Beatriz", "Souza", "Correia", "Marques" };
//Console.WriteLine("exibindo array original");

//foreach(var nome in nomes2)
//{
//    Console.WriteLine(nome);
//}

//////////////////////////////////////////EXERCICIO\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

//Console.WriteLine("\nEscreva o nome de cinco alunos e suas notas para que eu armazene em arrays:\n");

//string?[] nomes = new string[5];
//double[] notas = new double[5];

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"digite o nome do {i +1} aluno:\n");
//    string? nome = Console.ReadLine();
//    nomes[i] = nome;
//}
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"digite a nota do aluno {i+1}:\n");
//    double nota = Convert.ToDouble(Console.ReadLine());
//    notas[i] = nota;
//}
//foreach (string nome in nomes)
//{
//    Console.WriteLine("\n"+nome);
//}

//var somaNotas = 0.0;
//var totalNotas = notas.Count();
//foreach (double nota in notas)
//{
//    somaNotas += nota;
//    Console.WriteLine("\n" + nota);

//}
//Console.WriteLine("\nmedia: " + somaNotas/totalNotas);
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//a diferença de um array para um arraylist é que o ARRAY tem tamanho limitado. O Length dele tem um limite. Já o ArrayList é dinamico

List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};
//usando Predicado como função --> referenciando o método da classe static
var fruta1 = frutas.Find(Procura);

// usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\n expressão lambda: {fruta2}");

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"FindLast: {fruta3}");

var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"FindIndex: {fruta4} e item = {frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"indice {fruta5} and item= {frutas[fruta5]}");

var fruta6 = frutas.FindAll(i => i.Contains('n'));
foreach (var item in fruta6)
    {
    Console.WriteLine($"{item}");
} 

Console.ReadKey();

static bool Procura (string item)
{
    return item.Contains("n");
}

//Console.ReadKey();  
//public class Aluno
//{
//    public string? Nome { get; set; }
//    public double Nota { get; set; }
//}
