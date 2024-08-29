using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface ICourseCategoryService:IGenericService<CourseCategory>
    {
        public void TShowOnHome(int id);
        public void TDontShowOnHome(int id);

    }
}
