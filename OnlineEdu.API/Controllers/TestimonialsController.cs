using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.TestimonialDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonial, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var values = _testimonial.TGetList();
            return Ok(values);
        }

        [HttpGet("GetById {id}")]
        public IActionResult GetById(int id)
        {
            var value = _testimonial.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("Delete {id}")]
        public IActionResult Delete(int id)
        {
            _testimonial.TDelete(id);
            return Ok("Referans Alanı Silindi!");
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonial.TCreate(newValue);
            return Ok("Referans Alanı Oluşturuldu");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonial.TUpdate(value);
            return Ok("Referans Alanı Güncellendi!");
        }
    }
}
