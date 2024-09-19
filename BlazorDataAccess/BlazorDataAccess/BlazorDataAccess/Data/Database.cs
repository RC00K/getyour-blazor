using Microsoft.Data.Sqlite;

namespace BlazorDataAccess.Data;

public class Database
{
    private readonly SqliteConnection _connection;

    public Database(SqliteConnection connection)
    {
        _connection = connection;
    }

    public async Task InitializeDatabaseAsync()
    {
        using var command = _connection.CreateCommand();
        command.CommandText = @"
                CREATE TABLE IF NOT EXISTS People (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    FirstName TEXT NOT NULL, 
                    LastName TEXT NOT NULL, 
                    Age INTEGER NOT NULL
                );
            ";
        await command.ExecuteNonQueryAsync();
    }
}
