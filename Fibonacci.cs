public class Fibonacci{
    public bool pertenceAFibonacci(int numero){
        int a = 0;
        int b = 1;
        int fibo;

        if(numero == 0 || numero == 1){
            return true;
        }

        while(b < numero){
            fibo = a + b;
            a = b;
            b = fibo; 
        }

        if(b == numero)
        {
            return true;
        }else{
            return false;
        }


        
    }
}