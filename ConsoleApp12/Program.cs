using ConsoleApp12;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello, World!");


        WriteLine("Выберите команду");


        while (true)
        {
            var command = Console.ReadLine().ToLower().Split(' ');
            Controller s = new Controller();
            switch (command[0])
            {

                case "добавить":
                    s.AddGood(command[1], float.Parse(command[2]), float.Parse(command[3]), command[4]);
                    break;
                case "список":
                    Console.WriteLine(s.GetGoods());
                    break;

                case "сохранить":
                    s.SaveList();
                    break;
                case "открыть":
                    s.OpenList();
                    break;

                default:
                    WriteLine("Ошибка в комане");
                    break;

            }
        }

    }
}