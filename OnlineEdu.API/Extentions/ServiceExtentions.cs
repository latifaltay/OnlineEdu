using OnlineEdu.Business.Abstract;
using OnlineEdu.Business.Concrete;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;
using OnlineEdu.DataAccess.Repositories;

namespace OnlineEdu.API.Extentions
{
    public static class ServiceExtentions
    {
        public static void AddServiceExtentions(this IServiceCollection Services) 
        {
            Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            Services.AddScoped<IBlogRepository, BlogRepository>();
            Services.AddScoped<IBlogService, BlogManager>();
            Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            Services.AddScoped<ICourseCategoryService, CourseCategoryManager>();

            Services.AddScoped<ICourseRepositorry, CourseRepository>();
            Services.AddScoped<ICourseService, CourseManager>();
        }
    }
}
