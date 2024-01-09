namespace sonhaftaodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
















            Random rnd = new Random();

            Console.WriteLine("İlk Sayıyı Giriniz:");
            int baslangic = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            int bitis = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı adetini girin:");
            int count = int.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(baslangic, bitis);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int a = 0; a < i; a++)
                {
                    if (numbers[a] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
























        }
    }
}