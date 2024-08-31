using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.CourseDtos;
using OnlineEdu.WebUI.Helpers;
using OnlineEdu.WebUI.ViewComponents.Home;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeCourseComponent  : ViewComponent
    {
        private readonly HttpClient _clinet = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _clinet.GetFromJsonAsync<List<ResultCourseDto>>("Courses/GetActiveCourses");
            return View(values);
        }
    }
}