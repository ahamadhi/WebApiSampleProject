using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSampleProject.Models;
namespace WebApiSampleProject.Controllers
{
    public class CustomerController : ApiController
    {
        IList< Customer > Customers = new List<Customer>()
        {
            new Customer()
                {
                    CustomerId=1 ,CustomerName= "ABC Joinery", CustomerAddress= "12 Ascott Street, Dundee", InsurerName = "Aviva"
                },
                new Customer()
                {
                    CustomerId = 2 , CustomerName = "XYZ Plumbing", CustomerAddress = "24 Fleet Street, Glasgow", InsurerName = "Allianz"
                },
                new Customer()
                {
                   CustomerId = 3,  CustomerName = "Fast Taxis",CustomerAddress = "324b Bank Street, Aberdeen", InsurerName = "Aviva"
                },
                new Customer()
                {
                   CustomerId = 4 , CustomerName= "Fast Taxis", CustomerAddress = "324b Bank Street, Aberdeen", InsurerName = "QBE"
                },
        };
        public IList<Customer> GetAllCustomers()
        {
            //Return list of all Customers  
            return Customers;
        }
        public Customer GetCustomerDetails(int id)
        {
            //Return a single Customer detail  
            var customer = Customers.FirstOrDefault(e => e.CustomerId == id);
            if (customer == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return customer;
        }
    }
}