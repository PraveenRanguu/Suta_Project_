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


        [HttpGet, Route("api/Users")]
        public IEnumerable<Customerdetails> Getusers()
        {
            return _sutaService.GetCustomerdetails();
        }


        [HttpPost, Route("api/InsertUser/{Name}/{Password}/{Email}/{Phnno}/{Gender}")]
        public IEnumerable<Customerdetails> InsertUser(Customerdetails Student1)
        {
            if (_sutaService.InsertCustomer(Student1))
            {
                return _sutaService.GetCustomerdetails();
            }

            return Enumerable.Empty<Customerdetails>();
        }

        [HttpPost, Route("api/Login")]
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



        [HttpGet, Route("api/ForgotPassword")]
        public bool ForgotPWd(string Pwd, string email)
        {
            if (_sutaService.ForgotPassword(Pwd, email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost, Route("api/DeleteUser")]
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