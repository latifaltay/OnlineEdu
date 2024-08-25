﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.AboutDtos;
using OnlineEdu.DTO.DTOs.CourseDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetById {id}")]
        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("Delete {id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs Alanı Silindi!");
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TCreate(newValue);
            return Ok("Kurs Alanı Oluşturuldu");
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(value);
            return Ok("Kurs Alanı Güncellendi!");
        }
    }
}
