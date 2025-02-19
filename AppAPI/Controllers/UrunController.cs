﻿using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Entities;
using CoreLayer.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunService _service;
        private readonly IMapper _mapper;
        public UrunController(IUrunService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Add(UrunDto urunDto)
        {
            var urun = _mapper.Map<Urun>(urunDto);
            await _service.AddAsync(urun);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _service.getAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Find(int id)
        {
            return Ok(_mapper.Map<UrunDto>(await _service.getByIdAsync(id)));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Remove(await _service.getByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UrunDto urunDto)
        {
            var urun = _mapper.Map<Urun>(urunDto);
            await _service.Update(urun);
            return Ok();
        }
    }
}
