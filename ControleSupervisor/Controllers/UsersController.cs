using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleSupervisor.IServices;
using ControleSupervisor.Models;
using ControleSupervisor.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleSupervisor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServicesUsers _services;
        public UsersController(IServicesUsers servicesUsers)
        {
            _services = servicesUsers;
        }

        [HttpGet("{id}")]
        public Users Get_User(int id)
        {

            return _services.GetUser(id);
        }

        [HttpPost]
        public Users Get_Login(Users user)
        {
            return _services.GetLogin(user.login, user.password);

        }

        [HttpHead]
        public List<Users> Get_listusuariogrupo(Users user)
        {
            return _services.ListaUsuarios(user.Id, user.idGroup);

        }


        [HttpPut("{id}")]
        public IEnumerable<string> Set_Salario([FromBody] double value, int id)
        {
            var result = _services.UpdateSalary(id, value);
            return new string[] { result.ToString(), "OK" };
        }
    }
}
