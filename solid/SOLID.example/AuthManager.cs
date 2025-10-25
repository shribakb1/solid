using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SOLID.example
{
    public class AuthManager
    {
        public void Login()
        {

        }

        public void Logout()
        {

        }

        public Boolean IsCurrentUserAuthenticated()
        {
            return true;
        }
        public Employee GetCurrentLoggedInUser()
        {
            return new Employee();
        }
    }
}
