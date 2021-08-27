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
    public class HomeController : ControllerBase
    {
        private readonly ApplicationContext _applicationContext;


        public HomeController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return BadRequest();
        }

        [HttpPost]
        [Route("signup")]

        public IActionResult SignUp(string username, string password)
        {

            User user = new User();
            user.username = username;
            user.password = password;
            _applicationContext.users.Add(user);
            _applicationContext.SaveChanges();

            return Ok("user added");
        }

        [HttpGet]
        [Route("users")]
        public IActionResult getAllUser()
        {
            var listuser = _applicationContext.users.ToList();
            return Ok(listuser);

        }

        [HttpGet]
        [Route("login")]

        public IActionResult login(string username , string password)
        {

            var user = _applicationContext.users.FirstOrDefault(x => x.username == username && x.password == password);
            if (user !=null ) {
                return  Ok(" User successfully logged in");
            }

            return BadRequest();
        }
    }

}

