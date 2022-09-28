using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.ProductRepository;


namespace SapNetClone.Web.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductReadRepository ProductReadRepository;
        readonly IProductWriteRepository ProductWriteRepository;
        public ProductController(IProductReadRepository ProductReadRepository,IProductWriteRepository ProductWriteRepository)
        {
            this.ProductReadRepository = ProductReadRepository;
            this.ProductWriteRepository = ProductWriteRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = ProductReadRepository.GetAll().ToList();
           
            return View(data);
        }
      
        public async Task<IActionResult> Delete(int id)
        {
            var result = await ProductWriteRepository.Remove(id);
            if (result)
            {
                return Ok("Success");
            }
            //await ProductWriteRepository.SaveAsync();
            return Ok("Error");
        }

        public IActionResult Detail()
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit()
        {
            throw new NotImplementedException();
        }
    }
}
