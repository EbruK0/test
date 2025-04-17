namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            string[] part = input.Split(' ');
            int[] numbers = new int[part.Length];
                int sum = 0;
            
            for (int i = 0; i < part.Length; i++)
            {
                numbers[i] = int.Parse(part[i]);
                sum += numbers[i];
            }
            Console.WriteLine($"Сумата на елементите: {part}");
            Console.WriteLine($"Най-голям елемент: {part}");
            Console.WriteLine($"Числото 9 се среща {part} пъти");    
        }
    }
}
