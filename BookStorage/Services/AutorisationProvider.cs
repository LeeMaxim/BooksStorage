using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BookStorage.Models;
namespace BookStorage.Services
{
    public class AutorisationProvider
    {
        private UserProvider _UserProvider;
        public User Me { get; private set; } = null;

        public AutorisationProvider(UserProvider userProvider)
        {
            _UserProvider = userProvider;
        }

        public bool VerifyPassword(User user, string rawPassword)
        {
            if (user == null)
                return false;

            var byres = Encoding.UTF8.GetBytes(rawPassword);
            var h = new HMACSHA256(byres);
            var hash = h.ComputeHash(byres);
            var password = Convert.ToBase64String(hash);

            return user.Password == password;
        }

        public User SignIn(string login, string password)
        {
            var user = _UserProvider.Get(login);

            if(user != null && VerifyPassword(user, password))
            {
                Me = user;
                Me.Password = string.Empty;
            }

            return Me;
        }
    }
}
