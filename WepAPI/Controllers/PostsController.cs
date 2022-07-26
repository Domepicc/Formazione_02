using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPI.Models;

namespace WepAPI.Controllers
{
    public class PostsController : ApiController
    {

        private readonly PostRepository _repository = new PostRepository();


        public IEnumerable<Post> Get()
        {

            return _repository.GetAll();
        }

   
        public Post Get(int id)
        {
            Request.CreateResponse(HttpStatusCode.Found);
            return _repository.Get(id);
        }

        public HttpResponseMessage Post(Post post)
        {
            _repository.Create(post);
            return Request.CreateResponse(HttpStatusCode.Created, post);

        }

        public HttpResponseMessage Delete(int id)
        {
            _repository.Delete(id);
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            return response;
        }

        //public HttpResponseMessage Put(int id, Post post) 
        //{ 
        //    post.Id = id; 
        //    _repository.Update(post); 
        //    var response = Request.CreateResponse(HttpStatusCode.NoContent); 
        //    string uri = Url.Link("DefaultApi", new { id = post.Id }); 
        //    response.Headers.Location = new Uri(uri); 
        //    return response; 
        //}
        //public HttpResponseMessage Delete(int id) 
        //{ 
        //    _repository.Delete(id); 
        //    var response = Request.CreateResponse(HttpStatusCode.NoContent); 
        //    return response; 
        //}
    }
}
