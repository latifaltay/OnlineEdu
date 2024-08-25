using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.MessageDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetById {id}")]
        public IActionResult GetById(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("Delete {id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj Alanı Silindi!");
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateMessageDto createMessageDto)
        {
            var newValue = _mapper.Map<Message>(createMessageDto);
            _messageService.TCreate(newValue);
            return Ok("Mesaj Alanı Oluşturuldu");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(value);
            return Ok("Mesaj Alanı Güncellendi!");
        }
    }
}
