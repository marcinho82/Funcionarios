using ControleSupervisor.IServices;
using ControleSupervisor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ControleSupervisor.Services
{
    public class ServicesUsersControls : IServicesUsers
    {
        Users users = new Users();
        UsersEmployees employees = new UsersEmployees();
        public List<Users> ListaUsuarios(int idUser, int IdGroup)
        {
            var listgroup = from s in users.userList join g in employees.usersEmployees on s.Id equals g.IdUser
                            where g.IdUser == idUser && s.idGroup == IdGroup
                            select s;
            return listgroup.ToList();

        }


        public Users GetUser(int id)
        {           
            return users.userList.Where(x => x.Id == id).FirstOrDefault();
        }


        public Users GetLogin(string login, string password)
        {
            return users.userList.Where(x => x.login.Contains(login) && x.password.Contains(password)).FirstOrDefault();
        }

        public double UpdateSalary(int id, double salary)
        {
            double result = 0;
            var usersSalario = users.userList.Where(x => x.Id == id).FirstOrDefault();
            var total = (usersSalario.Salario * 0.05) + usersSalario.Salario;
             if (total >= salary)
            {
                usersSalario.Salario = salary;
                result = salary;
            }
            else
            {
                result = usersSalario.Salario;
            }

            return result;
        }



    }
}
