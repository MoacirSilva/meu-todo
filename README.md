# meu-todo

Api use Entity Framework to create a in-memory database for study purposes.

<b>branch</b></br>
<b>us-001</b> - api with lambda expressions in endpoints </br>
example: app.MapGet("/todoitems", async (TodoDb db) =>
  await db.Todos.ToListAsync());

<b>us-001</b> - api using mapgroup concepts in endpoints </br>
example: var todoItems = app.MapGroup("/todoitems");</br>
todoItems.MapGet("/", async (TodoDb db) =>
    await db.Todos.ToListAsync());


