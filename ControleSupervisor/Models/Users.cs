using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleSupervisor.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public double Salario { get; set; }
        public int idGroup { get; set; }

        public List<Users> userList  = new List<Users>() {

            new Users { Id = 1, login = "marcioandre", password = "marcio12", Nome = "Márcio André", Telefone = "(11) 123456789", idGroup = 1, Endereco = "Av. Franz Voeglei, 577 ap-73 bloco 2", Salario = 10000 },
            new Users { Id = 2, login = "andresilva", password = "andre12", Nome = "André Silva", Telefone = "(11) 123456789", idGroup = 2, Endereco = "Av. Paes de Barros, 91", Salario = 1400 },
            new Users { Id = 3, login = "beatrizoliv", password = "bia23", Nome = "Beatriz Oliveira", Telefone = "(11) 123456789", idGroup = 1, Endereco = "Av. Franz Voeglei, 577 ap-73 bloco 2", Salario = 10000 },
            new Users { Id = 4, login = "laisoliv", password = "marcio12", Nome = "Lais Oliveira", Telefone = "(11) 123456789", idGroup = 2, Endereco = "Av. Franz Voeglei, 303 ap-73 bloco 2", Salario = 1300 },
            new Users { Id = 5, login = "rosineide", password = "rosi12", Nome = "Rosineide Cordeiro", Telefone = "(11) 123456789", idGroup = 2, Endereco = "Av. Franz Voeglei, 450", Salario = 1200 },
            new Users { Id = 6, login = "luis12", password = "luis234", Nome = "Luis Melo", Telefone = "(11) 123456789", idGroup = 3, Endereco = "Av. Franz Voeglei, 577", Salario = 1100 },
            new Users { Id = 7, login = "marcos12", password = "marco12", Nome = "Marcos Pontes", Telefone = "(11) 123456789", idGroup = 3, Endereco = "Av. Franz Voeglei, 123 ", Salario = 990 },
            new Users { Id = 8, login = "teresa23", password = "ter123", Nome = "Teresa Cristina", Telefone = "(11) 123456789", idGroup = 3, Endereco = "Av. Franz Voeglei, 577 ap-73 bloco 2", Salario = 1000 },
            new Users { Id = 9, login = "junior12", password = "junior27", Nome = "Junior Pontes", Telefone = "(11) 123456789", idGroup = 2, Endereco = "Av. Franz Voeglei, 577 ap-73 bloco 2", Salario = 1850 },
            new Users { Id = 10, login = "mel234", password = "mel123", Nome = "Melaine Klain", Telefone = "(11) 123456789", idGroup = 2, Endereco = "Av. Franz Voeglei, 577 ap-73 bloco 2", Salario = 1250 }
        
        };       

    }
}
