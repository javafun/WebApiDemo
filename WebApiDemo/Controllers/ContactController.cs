using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class ContactController : ApiController
    {
        private IContactRepository _repository;
        public ContactController(IContactRepository repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Post(Contact contact)
        {
            int id = _repository.Create(contact);

            var response = new HttpResponseMessage(HttpStatusCode.Created);

            //response.Headers.Location = new Uri("/api/Contact/" + id);

            return response;
        }

    }
}
