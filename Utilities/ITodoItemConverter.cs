using TodoListWebApi.Models;

namespace TodoListWebApi.Utilities
{
    public interface ITodoItemConverter
    {
        TodoItem DTOToItem(TodoItemDTO itemDTO);
        TodoItemDTO ItemToDTO(TodoItem item);
    }
}