# meu-todo

Api use Entity Framework to create a in-memory database for study purposes.

<b>branch</b></br>
<b>us-001</b> - api with lambda expressions in endpoints </br>
example: app.MapGet("/todoitems", async (TodoDb db) =>
  await db.Todos.ToListAsync());

<b>us-002</b> - api using mapgroup concepts in endpoints </br>
example: var todoItems = app.MapGroup("/todoitems");</br>
todoItems.MapGet("/", async (TodoDb db) =>
    await db.Todos.ToListAsync());

<b>us-003</b> - api using typedresults concepts in endpoints </br>
example: var todoItems = app.MapGroup("/todoitems");</br>
todoItems.MapGet("/",GetAllTodos);</br>
app.Run();</br>
static async Task<IResult> GetAllTodos(TodoDb db)
{
    return TypedResults.Ok( await db.Todos.ToArrayAsync());
}

<b>us-004</b> - api using DTO concepts </br>
example: public TodoItemDTO() {}</br>
    public TodoItemDTO(Todo todoItem)</br>
    {</br>
        (Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);</br>
    }</br>
    static async Task<IResult> GetAllTodos(TodoDb db)</br>
    {</br>
      return TypedResults.Ok( await db.Todos.Select(x => new TodoItemDTO(x)).ToArrayAsync());</br>
    }


