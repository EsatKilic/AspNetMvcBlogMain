using App.Data.Entity;
using System.Collections.Generic;

namespace App.Business.Services.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Insert(User user);
        void Update(User user);
        void DeleteById(int id);
    }
}
