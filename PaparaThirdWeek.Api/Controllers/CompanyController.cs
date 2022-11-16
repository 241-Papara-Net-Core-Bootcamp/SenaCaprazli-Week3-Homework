using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.DTOs;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public IActionResult Post(Company company)
        {
            _companyService.Post(company);
            return Ok();
        }

        [HttpGet("Companies")]
        public IActionResult Get()
        {
            var result = _companyService.GetAll();
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Company company)
        {
            _companyService.Delete(company);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Company company)
        {
            _companyService.Update(company);
            return Ok();
        }
    }
}
