using System;

class Program
{
    public static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();

        while (true)
        {
            Console.WriteLine("Введите задачу (или exit для выхода):");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add":
                    Console.WriteLine("Введите задачу:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Укажите сложность:");
                    string difficulty = Console.ReadLine();
                    
                    manager.AddTask(name, difficulty);

                    break;  
                case "delete":
                    Console.WriteLine("Введите индекс задачи для удаления:");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        manager.RemoveTask(index);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                    break;
                case "view":
                    manager.ViewTasks();
                    break;        
                case "exit":
                    return;
                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;        
            }
        }
    }
}