using System.Collections.Generic;
using System.Web.Http;
using MongDbSample.Repository;
using MongDbSample.Data;
using MongDbSample.Data.Model;

namespace MongDbSample.Controllers
{
    [RoutePrefix("ProductCatalog")]
    public class ProductCatalogController : ApiController
    {
        private IRepository _repository = null;

        public ProductCatalogController()
        {
            _repository = new ProductRepository();
        }
        [Route("GetAllProducts")]
        public IEnumerable<Products> Get()
        {
            return _repository.GetProducts();
        }

        [Route("GetAllProducts/{id}")]
        public Products Get(string id)
        {
            return _repository.GetById(id);
        }

        [Route("AddProduct")]
        public void Post([FromBody]Products product)
        {
            _repository.AddProduct(product);
        }

        [Route("UpdateProduct")]
        public void Put([FromBody]Products product)
        {
            _repository.Update(product);
        }

        [Route("DeleteProduct/{id}")]
        [AcceptVerbs("POST","PUT")]
        public void Delete([FromUri]string id)
        {
            _repository.Remove(id);
        }
    }
}
