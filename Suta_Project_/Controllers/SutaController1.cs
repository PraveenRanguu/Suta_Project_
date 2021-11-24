using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Suta_ConnectionString;
using Suta_Model;
using Suta_Project;
using Suta_Repo;


namespace Suta_Project.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class SutaController1 : ControllerBase
    {
        private readonly IsutaServices _sutaService;
        public SutaController1(IsutaServices sutaaService)
        {
            _sutaService = sutaaService;
        }


        [HttpGet, Route("api/Suta/Getusers")]
        public IEnumerable<Customerdetails> Getusers()
        {
            return _sutaService.GetCustomerdetails();
        }


        [HttpPost, Route("api/Suta/InsertUser")]
        public IEnumerable<Customerdetails> InsertUser(Customerdetails Student1)
        {
            if (_sutaService.InsertCustomer(Student1))
            {
                return _sutaService.GetCustomerdetails();
            }

            return Enumerable.Empty<Customerdetails>();
        }

        [HttpPost, Route("api/Suta/Suta_Login")]
        public bool Suta_Login(string Email, string Password1)
        {
            if (_sutaService.user_Login(Email, Password1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        [HttpGet, Route("api/Suta/ForgotPWd")]
        public string ForgotPWd(string email)
        {
            return _sutaService.ForgotPassword(email);
        }

        [HttpPatch, Route("api/Suta/delete")]
        public bool delete(string Name)
        {
            if (_sutaService.DeleteUser(Name))
            {
                return true;
            }
            else
            {
                return false;
            }





        }


    }
}