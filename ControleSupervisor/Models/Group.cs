using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSupervisor.Models
{
    public class Group
    {
        public int IdGroup { get; set; }
        public string NameGroup { get; set; }

        public List<Group> groups = new List<Group>()
        {
            new Group { IdGroup = 1, NameGroup = "Supervisor" },
            new Group { IdGroup = 2, NameGroup = "Funcionário" },
            new Group { IdGroup = 3, NameGroup = "Líder" }
        };
        
    }
}
