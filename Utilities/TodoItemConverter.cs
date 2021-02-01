using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListWebApi.Models;

namespace TodoListWebApi.Utilities
{
    public class TodoItemConverter : ITodoItemConverter
    {
        public TodoItemDTO ItemToDTO(TodoItem item)
        {
            return new TodoItemDTO { Id = item.Id, Name = item.Name, IsComplete = item.IsComplete };
        }

        public TodoItem DTOToItem(TodoItemDTO itemDTO)
        {
            return new TodoItem { Id = itemDTO.Id, Name = itemDTO.Name, IsComplete = itemDTO.IsComplete, Secret = "" };
        }
    }
}
