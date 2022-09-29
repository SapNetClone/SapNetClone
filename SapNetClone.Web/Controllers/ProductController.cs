using System.Data;
using Microsoft.AspNetCore.Mvc;
using SapNetClone.Application.Abstract.Repositories.ProductRepository;
using SapNetClone.Application.ViewModels.Product;
using SapNetClone.Entities.Classes.Product;
using SapNetCore.Persistance.Concrete.Repository.ProductRepository;


namespace SapNetClone.Web.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository,
            IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = _productReadRepository.GetAll().ToList();

            return View(data);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productWriteRepository.Remove(id);
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVM productVM)
        {
            if (!ModelState.IsValid)
            {
                return View(productVM);
            }

            Product _product = new();
            _product.CreatedDate = DateTime.Now;
            _product.Name = productVM.Name;
            _product.Description = productVM.Description;
            _product.Price = productVM.Price;
            _product.Active = true;

            await _productWriteRepository.AddAsync(_product);
            await _productWriteRepository.SaveAsync();
            
            return RedirectToAction("Index");
        }
    }
}