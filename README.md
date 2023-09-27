# my-todo

Api use Entity Framework to create a in-memory database for study purposes.

## Branch
### us-001
Api with lambda expressions in endpoints </br>
example: 
```csharp
app.MapGet("/todoitems", async (TodoDb db) =>
  await db.Todos.ToListAsync());
```
### us-002
Api using mapgroup concepts in endpoints </br>
example: 
```csharp
var todoItems = app.MapGroup("/todoitems");</br>
todoItems.MapGet("/", async (TodoDb db) =>
    await db.Todos.ToListAsync());
```
### us-003
Api using typedresults concepts in endpoints </br>
example: 
```csharp
var todoItems = app.MapGroup("/todoitems");</br>
todoItems.MapGet("/",GetAllTodos);</br>
app.Run();</br>
static async Task<IResult> GetAllTodos(TodoDb db)
{
    return TypedResults.Ok( await db.Todos.ToArrayAsync());
}
```
### us-004
Api using DTO concepts </br>
example:
```csharp
    public TodoItemDTO() {}
    public TodoItemDTO(Todo todoItem)
    {
        (Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
    }
    static async Task<IResult> GetAllTodos(TodoDb db)
    {
      return TypedResults.Ok( await db.Todos.Select(x => new TodoItemDTO(x)).ToArrayAsync());
    }
```


