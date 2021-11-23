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

            [HttpGet, Route("api/Controller2/Getproduct")]
            public IEnumerable<productdetails> Getproduct()
            {
                return _productService.Getproductdetails();
            }
        }
    }


