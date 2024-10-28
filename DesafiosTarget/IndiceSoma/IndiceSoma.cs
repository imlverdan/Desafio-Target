namespace IndiceSoma
{
    public class IndiceSoma
    {
        static void Main(string[] args)
        {
            int indice = 12;
            int soma = 0;
            int k = 1;

            while (k < indice)
            {
                k++;
                soma = soma + k;
                
            }
            Console.WriteLine($"O valor final da soma é {soma}");
        }
    }
}
