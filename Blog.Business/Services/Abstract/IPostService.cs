using App.Data.Entity;
using System.Collections.Generic;

namespace App.Business.Services.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        Post GetById(int id);
        void Insert(Post post);
        void Update(Post post);
        void DeleteById(int id);

    }
}
