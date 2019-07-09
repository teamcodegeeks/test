using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
    public class CustomerController : Controller
    {
        // GET: Customer
       /* public ActionResult Load()
        {
            Customer obj = new Customer { CustomerCode = "1001", CustomerName = "Noble" };
            return View("Customer",obj);
        }*/
        public ActionResult Enter()
        {
            return View("EnterCustomer", new Customer());
        }
        public ActionResult Submit( Customer obj)
        {
            if (ModelState.IsValid)
            {
                return View("Customer", obj);
            }
            else
            {
                return View("EnterCustomer",obj);
            }
        }
    }
}
