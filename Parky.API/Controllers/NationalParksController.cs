using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parky.API.Models.DTO;
using Parky.API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParksController : Controller
    {
        private readonly INationalParkRepository _nrepo;
        private readonly IMapper _mapper;
        
        public NationalParksController(INationalParkRepository nrepo, IMapper mapper)
        {
            _nrepo = nrepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetNationalParks()
        {
            var objList = _nrepo.GetNationalParks();
            var objDTO = new List<NationalParkDto>();

            foreach (var obj in objList)
            {
                objDTO.Add(_mapper.Map<NationalParkDto>(obj));
            }
            return Ok(objDTO);
        }

        [HttpGet("{nationalParkId:int}")]
        public ActionResult GetNationalPark(int nationalParkId)
        {
            var objPark = _nrepo.GetNationalPark(nationalParkId);
            var objDto = _mapper.Map<NationalParkDto>(objPark);
            return Ok(objDto);
        }
    }
}
