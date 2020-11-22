using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class AuthUser
    {
        
        public class LoginViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class RegisterDesktopViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
         
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
          
            public string Documento { get; set; }

            public List<string> Rol { get; set; }

          

        }
        public class ValidateUserViewModel  {
            public string UserName { get; set; }
            
        }
    }
}
