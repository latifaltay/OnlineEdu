using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Concrete
{
    public class CourseManager : GenericManager<Course>, ICourseService
    {
        private readonly ICourseRepositorry _courseRepositorry;
        public CourseManager(IRepository<Course> _repository, ICourseRepositorry courseRepositorry) : base(_repository)
        {
            _courseRepositorry = courseRepositorry;
        }

        public void TDontShowOnHome(int id)
        {
            _courseRepositorry.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseRepositorry.ShowOnHome(id);
        }
    }
}
