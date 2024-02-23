using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartPhoneController : Controller
    {
        private readonly ISmartPhoneRepository _smartPhoneRepository;
        private readonly IMapper _mapper;

        public SmartPhoneController(ISmartPhoneRepository smartPhoneRepository, IMapper mapper)
        {
            _smartPhoneRepository = smartPhoneRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SmartPhone>))]
        public IActionResult GetSmartPhones()
        {
            var smartphones = _mapper.Map<List<SmartPhoneDto>>(_smartPhoneRepository.GetSmartPhones());
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(smartphones);
        }

        [HttpGet("{smartPhoneId}")]
        [ProducesResponseType(200, Type = typeof(SmartPhone))]
        [ProducesResponseType(400)]
        public IActionResult GetSmartPhone(int smartPhoneId)
        {
            if(!_smartPhoneRepository.SmartPhonesExists(smartPhoneId))
                    return NotFound();

            var smartPhone = _mapper.Map<SmartPhoneDto>(_smartPhoneRepository.GetSmartPhone(smartPhoneId));

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(smartPhone);

        }

        [HttpGet("{smartPhoneId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetSmartPhoneRating(int smartPhoneId)
        {
            if (!_smartPhoneRepository.SmartPhonesExists(smartPhoneId))
                return NotFound();

            var rating = _smartPhoneRepository.GetSmartPhoneRating(smartPhoneId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(rating);

        }
    }
}
