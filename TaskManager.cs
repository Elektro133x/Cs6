
using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<string> tasks = new List<string>();

    public void AddTask(string task)
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            tasks.Add(task);
            Console.WriteLine("Задача добавлена!");
        }
        else
        {
            Console.WriteLine("Задача не может быть пустой.");
        }
    }
}
