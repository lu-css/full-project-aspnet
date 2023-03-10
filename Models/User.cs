using System.ComponentModel.DataAnnotations;

namespace tcc.Models;

public class User
{
    public int UserId { get; set; }
    public string? FullName { get; set; }

    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
