using System;
using System.ComponentModel.DataAnnotations;
namespace Twitter.Domain.Entities;

public class Tweet
{
    public Guid Id { get; set; }

    public User Author { get; set; }

    public string Text { get; set; }

    public string Media { get; set; }


}