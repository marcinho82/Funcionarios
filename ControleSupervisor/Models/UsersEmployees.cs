using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSupervisor.Models
{
    public class UsersEmployees
    {
        public int IdUser { get; set; }
        public int IdUserEmploy { get; set; }

        public List<UsersEmployees> usersEmployees = new List<UsersEmployees>() {
            
            new UsersEmployees { IdUser = 1, IdUserEmploy = 2 },
            new UsersEmployees { IdUser = 1, IdUserEmploy = 4 },
            new UsersEmployees { IdUser = 1, IdUserEmploy = 5 },
            new UsersEmployees { IdUser = 3, IdUserEmploy = 1 },
            new UsersEmployees { IdUser = 3, IdUserEmploy = 6 }

        };        
    }
}
