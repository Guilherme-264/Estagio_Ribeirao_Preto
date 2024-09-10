// //1 sequencia de fibonacci
Fibonacci fibonacci = new Fibonacci();
Console.WriteLine("digite umnúmero para ver se ele pertence a sequencia de Fibonacci: ");
int numero = int.Parse(Console.ReadLine());
bool fibo = fibonacci.pertenceAFibonacci(numero);

if(fibo)
{
    Console.WriteLine($"O número {numero} pertence a sequencia de Fibonacci");
}else
{
    Console.WriteLine($"O número {numero} não pertence a sequencia de Fibonacci");
}


//2 verificando se existe a letra a na string
verificarString verifica =  new verificarString();
verifica.verificar();

//3 qual é a soma
QualEASoma calcular = new QualEASoma();
Console.WriteLine(calcular.soma());
