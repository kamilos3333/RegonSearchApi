using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RegonSearchApi.DAO.Service.Company.Interface;
using RegonSearchApi.DAO.ViewModel;
using RegonSearchApi.Data.Model;

namespace RegonSearchApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICompanyService companyService;
        private readonly IMapper mapper;

        public ValuesController(ICompanyService companyService, IMapper mapper)
        {
            this.companyService = companyService;
            this.mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CompanyTbl>> Get()
        {
            var list = companyService.ListAllCompany();
            return Ok(mapper.Map<IEnumerable<CompanyListViewModel>>(list));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<CompanyTbl> Get(Guid id)
        {
            var value = companyService.GetCompanyById(id);
            return Ok(mapper.Map<CompanyDetailViewModel>(value));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
