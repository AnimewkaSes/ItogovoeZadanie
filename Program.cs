using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа по форматированию массива строк в новый");
        string r = ("1234567890!#h:-)(+$%^&*=+");
        string[] arrString = {"Hello", "2", "world", ":-)"};
        Console.Write("Текущий массив: [");
        for (int i = 0; i < arrString.Length; i++)
        {
            Console.Write(" {0} ", arrString[i]);
        }
        Console.Write("]");
        
        
        if (arrString.Contains(r))
        {
            Console.WriteLine(string.Format("{0}"),r);
        }
    }
}