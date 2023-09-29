using Microsoft.Data.Sqlite;

public static class ServicesCollectionExtensions
{
    public static WebApplicationBuilder AddPersistence (this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("SqliteConnectionString")
         ?? "DataSource = Todo.db";

         builder.Services.AddSqlite<TodoDb>(connectionString);

         builder.Services.AddScoped(_=> new SqliteConnection(connectionString));

         return builder;
    }
}