using System;
using System.ComponentModel.DataAnnotations;
namespace Twitter.Domain.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string HashedPassword { get; set; } = string.Empty;

    public string Avatar { get; set; } = "https://res.cloudinary.com/twitter-clone-media/image/upload/v1597737557/user_wt3nrc.png";

    public string Cover { get; set; } = string.Empty;

    public string Bio { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

}