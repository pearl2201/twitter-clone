using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Twitter.Domain.Entities;


public class Retweet
{
    public Tweet Tweet { get; set; }

    public User Author { get; set; }

    public Guid TweetId { get; set; }

    public Guid AuthorId { get; set; }
}