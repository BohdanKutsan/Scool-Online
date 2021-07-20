using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repository
{
   public interface ITypeOfUserRepository
    {
        void Add<TypeOfUser>(TypeOfUser typeOfUser);
        void Delete<TypeOfUser>(TypeOfUser typeOfUser);
        Task<bool> SaveAll();
        Task<IEnumerable<TypeOfUser>> GetTypeOfUsers();
        Task<TypeOfUser> GetTypeOfUser(int id);
    }
}
