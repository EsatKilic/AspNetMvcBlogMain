using App.Data.Entity;
using System.Collections.Generic;

namespace App.Business.Services.Abstract
{
    public interface ISettingService
    {
        List<Setting> GetAll();
        Setting GetById(int id);
        void Insert(Setting setting);
        void Update(Setting setting);
        void DeleteById(int id);
    }
}
