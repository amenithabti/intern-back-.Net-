using Backend_App.Data;
using Backend_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormateurController : ControllerBase
    {
        private readonly ApplicationContext _applicationContext;

        public FormateurController(ApplicationContext applicationContext){
           _applicationContext = applicationContext;   
        }
       
        [HttpPost]
        [Route("addTrainer")]
        public IActionResult addformateur(Formateur body)
        {
            Formateur formateur = new Formateur();
            formateur.fullname = body.fullname;
            formateur.email = body.email;
            formateur.phonenumber = body.phonenumber;
            formateur.UserId = body.UserId;
            _applicationContext.formateurs.Add(formateur);
            _applicationContext.SaveChanges();
            return Ok(new { msg = "trainer added" });

        }

    }
}
