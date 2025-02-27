using NUnit.Framework;
using System.Data.SqlClient;

[TestFixture]
public class TestInputValidation {
    [Test]
    public void TestForSQLInjection() {
        // Example SQL Injection test
        string maliciousInput = "'; DROP TABLE Users; --";
        Assert.Throws<InvalidOperationException>(() => AddUser(maliciousInput, "test@example.com"));
    }

    private void AddUser(string username, string email) {
        // Simulate adding a user to the database
        if (username.Contains(";") || username.Contains("--")) {
            throw new InvalidOperationException("SQL Injection detected!");
        }
        // Add user to the database logic here
    }

    private string SanitizeInput(string input) {
        // Simple sanitization logic for demonstration purposes
        return input.Replace("<", "&lt;").Replace(">", "&gt;");
    }

    [Test]
    public void TestForXSS() {
        // Example XSS test
        string xssScript = "<script>alert('XSS');</script>";
        string sanitizedInput = SanitizeInput(xssScript);
        Assert.That(sanitizedInput, Is.Not.EqualTo(xssScript));
    }
}
