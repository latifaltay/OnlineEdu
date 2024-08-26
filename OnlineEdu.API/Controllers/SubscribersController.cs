using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetById {id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("Delete {id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Takipçi Alanı Silindi!");
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateSubscriberDto createSubscriberDto)
        {
            var newValue = _mapper.Map<Subscriber>(createSubscriberDto);
            _subscriberService.TCreate(newValue);
            return Ok("Takipçi Alanı Oluşturuldu");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateSubscriberDto updateSubscriberDto)
        {
            var value = _mapper.Map<Subscriber>(updateSubscriberDto);
            _subscriberService.TUpdate(value);
            return Ok("Takipçi Alanı Güncellendi!");
        }
    }
}
