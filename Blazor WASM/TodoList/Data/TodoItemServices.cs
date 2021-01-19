using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TodoList.Data
{
    public class TodoItemServices
    {
        private List<TodoItem> todos;
        private string _file = "Data\\todo.json";

        public List<TodoItem> GetTodos()
        {
            if (File.Exists(_file))
            {
                using var file = File.OpenText(_file);
                var serializer = new JsonSerializer();
                todos = serializer.Deserialize(file, typeof(List<TodoItem>)) as List<TodoItem>;
            }
            return todos;
        }

        public void SaveChanges()
        {
            using var file = File.CreateText(_file);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, todos);
        }
    }
}
