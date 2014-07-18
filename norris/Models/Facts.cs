﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace norris.Models
{
    public class Fact
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Views { get; set; }

    }
    public class Discussion
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Votes { get; set; }
        public int Views { get; set; }
    }
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string USER_EMAIL { get; set; }
        public int FACT_ID { get; set; }
        public DateTime Date { get; set; }
    }
    public class DiscussionPost
    {
        public int ID { get; set; }
        [Required]
        public int DiscussionID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Author { get; set; }
        public int Votes { get; set; }
        public DateTime Date { get; set; }
    }
    public class FactContext : DbContext
    {
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<DiscussionPost> DiscussionPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

}