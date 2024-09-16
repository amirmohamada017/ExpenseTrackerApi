using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApi.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string PasswordHash { get; set; }
    public string Email { get; set; }
}