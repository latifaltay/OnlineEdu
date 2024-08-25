using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BannerDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetById {id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("Delete {id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Banner Alanı Silindi!");
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok("Banner Alanı Oluşturuldu");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(value);
            return Ok("Banner Alanı Güncellendi!");
        }
    }
}
