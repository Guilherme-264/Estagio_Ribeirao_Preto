public class verificarString{
    public int contador;
    
    public void verificar(){
        contador = 0;
        
        Console.WriteLine("Escreva uma palavra/frase: ");
        string frase = Console.ReadLine();
        string fraseVerificar = frase.ToLower();
        Console.WriteLine(fraseVerificar);

        foreach (char letra in frase)
        {
            if (letra.Equals('a')){
            contador ++;         
            }  
        }

        if(contador == 0){
            Console.WriteLine("A frase escrita não tem a letra 'a'.");
        }else
        {
            Console.WriteLine($"A letra 'a' aparece {contador} vezes na palavra/frase escrita.");
        }
    }
}