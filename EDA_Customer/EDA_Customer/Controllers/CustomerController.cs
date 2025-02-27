using EDA_Customer.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDA_Customer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        public CustomerDBContext _customerDBContext { get; }

        public CustomerController(CustomerDBContext customerDBContext)
        {
            _customerDBContext = customerDBContext;
        }

        [HttpGet]
        [Route("/customers")]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return _customerDBContext.Customers.ToList();
        }

        [HttpGet]
        [Route("/products")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _customerDBContext.Products.ToList();
        }

        [HttpPost]
        public async Task PostCustomer(Customer customer)
        {
            _customerDBContext.Customers.Add(customer);
            await _customerDBContext.SaveChangesAsync();
        }
    }
}
