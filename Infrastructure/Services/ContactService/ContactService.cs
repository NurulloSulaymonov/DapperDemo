using Dapper;
using Npgsql;

public class ContactService
{

    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=dapper_demo;User Id=postgres;Password=12345;";
    public List<ContactDto> GetContacts()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM contacts ";
            var contacts = connection.Query<ContactDto>(sql).ToList();
            return contacts;
        }
    }

    public string GetInfo()
    {
        return "Hello world";
    }

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public int SubtractNumbers(int a, int b)
    {
        return a - b;
    }

    public int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

   
    public int DivideNumbers(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (System.Exception ex)
        {
            return 0;
        }

    }

}