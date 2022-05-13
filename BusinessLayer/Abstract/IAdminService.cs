using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IAdminService
    {
        List<admin> GetList();
        void adminAdd(admin admin);
        admin GetByID(int id);
        void adminDelete(admin admin);
        void adminUpdate(admin admin);
    }
}
