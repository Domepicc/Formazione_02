using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
 

namespace WepAPI.Models
{
    public class PostRepository
    {
        List<Post> Posts = new List<Post>();

        Post post1 = new Post(1, "desc", new DateTime(2000, 10, 10));
        Post post2 = new Post(2, "desc", new DateTime(2000, 10, 10));

        public PostRepository()
        {
            Posts.Add(post1);
            Posts.Add(post2);
        }
        

        public List<Post> GetAll()
        {
            
            return Posts;
        }

        public Post Get(int id)
        {
            return Posts.Where(x => x.Id == id).FirstOrDefault();
        }

        public Post Create (Post post)
        {
            Posts.Add(post);
            return post;
        }

        public Post Delete (int id)
        {
            Post post = Posts.Where(x => x.Id == id).FirstOrDefault();
            Posts.Remove(post);
            return post;
        }


    }
}