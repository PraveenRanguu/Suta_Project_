using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Suta_Model;
using Suta_Project;
using Suta_Repo;

namespace Suta_Project.Controllers
{
    //[Route("api/[controller]")]
    // [ApiController]
    public class Controller2 : ControllerBase
    {


        private readonly Iservices2 _productService;
        public Controller2(Iservices2 studentService)
        {
            _productService = studentService;
        }

        [HttpGet, Route("api/Controller2/Getproducts")]
        public IEnumerable<productdetails> Getproducts1()
        {
            return _productService.Getproductdetails();
        }


        [HttpGet, Route("api/Controller2/Getproductsdetailswhenoriginalprice_greaterthen_offerprice")]
        public List<string> GetProducts2()
        {
            return _productService.GetProductdetails_whenoriginal_price_greaterthan_offer_price();
        }


        [HttpGet, Route("api/Controller2/GetProductswhenQuantitygreaterthanZero")]
        public IEnumerable<productdetails> GetProducts3()
        {
            return _productService.GetProductswhen_Quantity_greaterthan_Zero();
        }


        [HttpGet, Route("api/Controller2/product_finding")]
        public IEnumerable<productdetails> GetProducts3(int p_id)
        {
            
                return _productService.Select_product_id(p_id);
           
        }
    }

}


