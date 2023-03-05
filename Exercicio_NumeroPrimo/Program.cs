internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio numero primo

        double num;
        int cont=0;
      
        Console.WriteLine("digite um numero: ");
        num = int.Parse(Console.ReadLine());
           
        if (num > 0)
        {

            for (int i = 1; i <= num; i++)
            {
                    
                if ((num%i) == 0)
                {
                    cont++;
                }
                if (cont > 2)
                {
                    break;
                }
                
            }
                
            if (cont > 2)
            {
                Console.WriteLine("numero nao primo");
            }
            else
            {
                Console.WriteLine("numero primo");
            }
        }
    }
}