using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoc1.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet("GetResponse")]
        public IActionResult GetResponse()
        {
            return Ok("Return Success");
        }
        /// <summary>
        /// thi is api for get all customer
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCustomer")]
        public IEnumerable<Customer> GetAllCustomer()
        {

            var CustomerList = new List<Customer>()
            {

            new Customer(){CustomerId = 1 , CustomerName = "AlaaEldeen1" , CustomerBrithDate = new DateTime(04/05/1991)},
            new Customer(){CustomerId = 2 , CustomerName = "AlaaEldeen2" , CustomerBrithDate = new DateTime(04/04/1991)},
            new Customer(){CustomerId = 3 , CustomerName = "AlaaEldeen3" , CustomerBrithDate = new DateTime(04/03/1991)},
            new Customer(){CustomerId = 4 , CustomerName = "AlaaEldeen4" , CustomerBrithDate = new DateTime(04/02/1991)},
            new Customer(){CustomerId = 5 , CustomerName = "AlaaEldeen5" , CustomerBrithDate = new DateTime(04/01/1991)}

            };

            return CustomerList;

        }
        [HttpPost("SaveCustomer")]
        public IEnumerable<Customer> SaveCustomer(Customer customer)
        {
            var CustomerList = new List<Customer>()
            {

            new Customer(){CustomerId = 1 , CustomerName = "AlaaEldeen1" , CustomerBrithDate = new DateTime(04/05/1991)},
            new Customer(){CustomerId = 2 , CustomerName = "AlaaEldeen2" , CustomerBrithDate = new DateTime(04/04/1991)},
            new Customer(){CustomerId = 3 , CustomerName = "AlaaEldeen3" , CustomerBrithDate = new DateTime(04/03/1991)},
            new Customer(){CustomerId = 4 , CustomerName = "AlaaEldeen4" , CustomerBrithDate = new DateTime(04/02/1991)},
            new Customer(){CustomerId = 5 , CustomerName = "AlaaEldeen5" , CustomerBrithDate = new DateTime(04/01/1991)}

            };

            CustomerList.Add(customer);
            return CustomerList;
        }
        [HttpDelete("DeleteCustomer")]
        public IEnumerable<Customer> DeleteCustomer(int Id)
        {

            var CustomerList = new List<Customer>()
            {

            new Customer(){CustomerId = 1 , CustomerName = "AlaaEldeen1" , CustomerBrithDate = new DateTime(04/05/1991)},
            new Customer(){CustomerId = 2 , CustomerName = "AlaaEldeen2" , CustomerBrithDate = new DateTime(04/04/1991)},
            new Customer(){CustomerId = 3 , CustomerName = "AlaaEldeen3" , CustomerBrithDate = new DateTime(04/03/1991)},
            new Customer(){CustomerId = 4 , CustomerName = "AlaaEldeen4" , CustomerBrithDate = new DateTime(04/02/1991)},
            new Customer(){CustomerId = 5 , CustomerName = "AlaaEldeen5" , CustomerBrithDate = new DateTime(04/01/1991)}

            };

            var Customer = CustomerList.SingleOrDefault(x=>x.CustomerId == Id);
            CustomerList.Remove(Customer);
            return CustomerList;
        }

    }
}
