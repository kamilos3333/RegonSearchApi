using RegonSearchApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegonSearchApi.DAO.Service.Company.Interface
{
    public interface ICompanyService
    {
        IEnumerable<CompanyTbl> ListAllCompany();
        CompanyTbl GetCompanyById(Guid Id);
    }
}
