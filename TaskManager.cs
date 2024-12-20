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

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count) {
            tasks.RemoveAt(index);
            Console.WriteLine("Задача удалена!");
        }
        else
        {
            Console.WriteLine("Неверный индекс.");
        }
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {tasks[i]}")
            }
        }
    }
}