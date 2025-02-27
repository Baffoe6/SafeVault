// DatabaseConnection.cs
using Microsoft.Data.SqlClient;

public class DatabaseConnection {
    private string connectionString;

    public DatabaseConnection(string connectionString) {
        this.connectionString = connectionString;
    }

    public void AddUser(string username, string email) {
        using (SqlConnection connection = new SqlConnection(connectionString)) {
            string query = "INSERT INTO Users (Username, Email) VALUES (@Username, @Email)";
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
