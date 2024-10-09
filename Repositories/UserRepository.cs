using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTI.Models;

namespace KTI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>{
             new UserModel{Id=123,Name="Shiva",Password="rahasia",
             FavoriteColor="Red",Role="Admin",GoogleId="12345678"}
         };
         public UserModel? GetByGoogleId(string googleId)
         {
             throw new NotImplementedException();
         }

         public UserModel? GetByUsernameAndPassword(string username, string password)
         {
             var user = users.SingleOrDefault(u=>u.Name == username && password == "rahasia");
             return user;
         }
        public UserModel? getByGoogleId(string googleId)
        {
            throw new NotImplementedException();
        }

        public UserModel? getByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}