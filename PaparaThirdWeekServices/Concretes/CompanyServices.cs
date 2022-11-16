using PaparaThirdWeek.Data.Abstracts;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;

using PaparaThirdWeek.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PaparaThirdWeek.Services.Concretes
{
    public class CompanyServices : ICompanyService
    {
        private readonly IRepository<Company> _companyRepository;
        private readonly IMapper _mapper;

        public CompanyServices(IRepository<Company> companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public void Post(Company company)
        {
            
          var map = _mapper.Map<Company>(company);
            _companyRepository.Add(map);
            
        }

       

        public IEnumerable<Company> GetAll()
        {
            return _companyRepository.Get().ToList();
        }

        public void Update(Company company)
        {
            var map = _mapper.Map<Company>(company);
            _companyRepository.Update(map);
        }

        public void Delete(Company company)
        {
            var map = _mapper.Map<Company>(company);
            _companyRepository.Remove(map);
        }
    }
}
