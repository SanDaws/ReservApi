using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservApi.DTOs.Request;
using ReservApi.Repositories;

namespace ReservApi.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : Base
    {
        public LoginController(IEmployeeRepository productRepositories) : base(productRepositories)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto productDtodto){
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }
            
            
            var loged=await _Services.Login(productDtodto);
            return Ok(loged);   

        }
        
    }
}