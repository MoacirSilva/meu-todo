# meu-todo

Api use Entity Framework to create a in-memory database for study purposes.

branch
us-001 - api with lambda expressions in endpoints </br>
example: app.MapGet("/todoitems", async (TodoDb db) =>
  await db.Todos.ToListAsync());

us-002 - api using mapgroup concepts in endpoints
example: var todoItems = app.MapGroup("/todoitems");
todoItems.MapGet("/", async (TodoDb db) =>
    await db.Todos.ToListAsync());


