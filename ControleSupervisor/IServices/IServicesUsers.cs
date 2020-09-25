using ControleSupervisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSupervisor.IServices
{
   public interface IServicesUsers
   {
        List<Users> ListaUsuarios(int idUser, int IdGroup);
        Users GetUser(int id);
        Users GetLogin(string login, string password);
        double UpdateSalary(int id, double salary);
   }
}
