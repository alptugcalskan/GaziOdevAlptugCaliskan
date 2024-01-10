namespace GaziÖdevAlptugCalıskan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            Console.WriteLine("Bir dil seçiniz/Select a language(English/Türkçe)");
            string cev = Console.ReadLine().ToUpper();
            Random rnd = new Random();
            if (cev == "English")
            {
                a = "Enter the starting number:";
                b = "Enter the ending number:";
                c = "Enter the count of numbers:";

            }
            else
            {
                a = "Başlangıç sayısını gir:";
                b = "Bitiş sayısı gir:";
                c = "Sayı adeti gir:";
            }

            Console.WriteLine(a);
            int başlangıç = int.Parse(Console.ReadLine());
            Console.WriteLine(b);
            int bitiş = int.Parse(Console.ReadLine());

            Console.WriteLine(c);
            int adet = int.Parse(Console.ReadLine());


            int[] numbers = new int[adet];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(başlangıç, bitiş);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == num)
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
