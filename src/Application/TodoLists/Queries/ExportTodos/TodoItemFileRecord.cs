using NetCoreCleanArchitecture.Application.Common.Mappings;
using NetCoreCleanArchitecture.Domain.Entities;

namespace NetCoreCleanArchitecture.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
