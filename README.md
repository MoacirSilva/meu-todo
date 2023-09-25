# meu-todo

Api use Entity Framework to create a in-memory database for study purposes.

branch
us-001 - api with lambda expressions in endpoints
example: app.MapGet("/todoitems", async (TodoDb db) => await db.Todos.ToListAsync());

