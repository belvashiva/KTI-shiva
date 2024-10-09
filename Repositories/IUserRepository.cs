using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTI.Models;

namespace KTI.Repositories
{
    public interface IUserRepository
    {
        UserModel? GetByUsernameAndPassword(string username,string password);
        UserModel? GetByGoogleId(string googleId);
    }
}