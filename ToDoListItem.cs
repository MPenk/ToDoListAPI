using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class ToDoListItem
    {
        public static List<ToDoListItem> toDoItems = new List<ToDoListItem>();

        public string TaskName { get; set; }

        public ToDoListItem(string taskName)
        {
            this.TaskName = taskName;
        }
        static public void RemoveTask(int id)
        {
            if (id > toDoItems.Count - 1 || id < 0 || toDoItems.Count==0)
                throw new ArgumentOutOfRangeException("Wrong ID!");
            toDoItems.RemoveAt(id);
        }

        static public void AddTask(string taskName)
        {
            toDoItems.Add(new ToDoListItem(taskName));
        }

        static public List<ToDoListItem> GetTasks()
        {
            return toDoItems;
        }

        static public ToDoListItem GetTask(int id)
        {
            if (id > toDoItems.Count - 1 || id < 0 || toDoItems.Count == 0)
                throw new ArgumentOutOfRangeException("Wrong ID!");
            return toDoItems[id];
        }
    }
}
