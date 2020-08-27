using NetCoreCleanArchitecture.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace NetCoreCleanArchitecture.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
