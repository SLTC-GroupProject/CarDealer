using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealers.DataManager.Dto;
using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertistmentController : ControllerBase
    {
        private IAdvertistmentRepository _advertistmentRepository;

        public AdvertistmentController(IAdvertistmentRepository advertistmentRepository)
        {
            _advertistmentRepository = advertistmentRepository;
        }


        [HttpGet("{AdvertistmentId}", Name = "GetAdvertistment")]
        public IActionResult GetAdvertistment(int AdvertistmentId)
        {
            if (!_advertistmentRepository.AdvertistmentExists(AdvertistmentId))
            {
                return NotFound("Advertistment doesn't exsist");
            }
            var Ad = _advertistmentRepository.GetAdvertistment(AdvertistmentId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var advertistmentDto = new AdvertistmentDto
            {
                AdTitle = Ad.AdTitle,
                AdPrice = Ad.AdPrice,
                AdImage = Ad.AdImage,
                LocationId = Ad.LocationId,
                CategoryId = Ad.CategoryId,
                BrandId = Ad.BrandId,
                ModelId = Ad.ModelId,
            };
            return Ok(advertistmentDto);
        }


        [HttpGet]
        public IActionResult GetAdvertistment()
        {
            var Advertistments = _advertistmentRepository.GetAdvertistment();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var AdvertistmentDto = new List<AdvertistmentDto>();

            foreach (var Ad in Advertistments)
            {
                AdvertistmentDto.Add(new AdvertistmentDto
                {
                    AdTitle = Ad.AdTitle,
                    AdPrice = Ad.AdPrice,
                    AdImage = Ad.AdImage,
                    LocationId = Ad.LocationId,
                    CategoryId = Ad.CategoryId,
                    BrandId = Ad.BrandId,
                    ModelId = Ad.ModelId,
                });

            }
            return Ok(AdvertistmentDto);
        }
    }
       
}