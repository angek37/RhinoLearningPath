using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EjemploDeploy.Domain.Abstract;
using EjemploDeploy.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;

namespace EjemploDeploy.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.Products;
        }

        [HttpPost]
        [HttpPut]
        public HttpResponseMessage Post([FromBody] Product product)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                _repository.Save(product);
                response.StatusCode = HttpStatusCode.OK;
                return response;
            }
            catch (Exception e)
            {
                response.ReasonPhrase = e.Message;
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }
        }


        [Route("{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response.StatusCode = HttpStatusCode.OK;
                _repository.Delete(id);
                return response;
            }
            catch (Exception e)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.ReasonPhrase = e.Message;
                return response;
            }
        }
    }
}