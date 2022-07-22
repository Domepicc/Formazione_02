using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        
        public Post (int id, string titolo, DateTime date)
        {
            Id = id;
            Title = titolo;
            Date = date;
        }
    }
}