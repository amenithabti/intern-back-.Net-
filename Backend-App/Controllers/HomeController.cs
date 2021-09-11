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

        public HomeController(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return BadRequest();
        }
        public string HashagePassword(string password) {
            byte[] encData_byte = new byte[password.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        [HttpPost]
        [Route("signup")]

        public IActionResult SignUp(User userBody) {
            User user = new User();
            user.FullName = userBody.FullName;
            user.username = userBody.username;
            user.password = HashagePassword(userBody.password);
            _applicationContext.users.Add(user);
            _applicationContext.SaveChanges();
             return Ok(new { msg ="user added" });
        }

        [HttpGet]
        [Route("users")]
        public IActionResult getAllUser(){
            List<User> listuser = _applicationContext.users.ToList();
            return Ok(listuser);
        }

        [HttpPost]
        [Route("login")]

        public IActionResult login(string username , string password) {
            var user = _applicationContext.users.FirstOrDefault(x => x.username == username && HashagePassword(x.password) == password);
            if (user !=null ) {
                return  Ok(new { msg=" User successfully logged in"});
            }
           return BadRequest();
        }







        
    }

}

