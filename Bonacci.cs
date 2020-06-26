namespace Recursividade_25
{
    public class Bonacci
    {
        public void GerarSequenciaDeFibonacci(int num1, int num2, int vezes){
            if (vezes > 0)
            {
                System.Console.WriteLine(num1);
                GerarSequenciaDeFibonacci( num2 , num1 + num2 , vezes -1);
            }
        }
        public int GerarFatorial(int num)
        {
            if(num == 1){
                return 1;
            }
            else
            {
                return num*GerarFatorial(num - 1);
            }
        }
        public void GerarSequenciaDeTribonacci(int num1, int num2, int num3, int vezes)
        {
            if(vezes > 0)
            {
                System.Console.WriteLine(num1);
               GerarSequenciaDeTribonacci( num2, num3 , num1 + num2 + num3 , vezes -1);
            }
        }
    }
}