using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleController
{
    /// <summary>
    /// Controller for login operations.
    /// </summary>
    public static class LoginController
    {
        /// <summary>
        /// Logins the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        ///   <c>true</c> if login is successful; otherwise, <c>false</c>.
        /// </returns>
        public static bool Login(string user, string password)
        {
            // hacer validacion contra archivo.
            return user == "admin" && password == "admin";
        }
    }
}
