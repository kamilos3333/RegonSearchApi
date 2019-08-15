using Microsoft.EntityFrameworkCore;
using RegonSearchApi.DAO.Service.Company.Interface;
using RegonSearchApi.Data;
using RegonSearchApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegonSearchApi.DAO.Service.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext db;

        public CompanyService(ApplicationDbContext db)
        {
            this.db = db;
        }

        //public CompanyTbl GetCompanyById(Guid Id)
        //{
        //    return db.Companies.Include(a => a.CompanyDetail).Include(a => a.CompanyDetail.City).Include(a => a.CompanyDetail.City.Voivodeship).FirstOrDefault(s => s.CompanyID == Id);
        //}

        public CompanyTbl GetCompanyByInfo(string info)
        {
            return db.Companies.Include(a => a.CompanyDetail).Include(a => a.CompanyDetail.City).Include(a => a.CompanyDetail.City.Voivodeship).FirstOrDefault(a => a.NIP == info || a.KRS == info || a.REGON == info);
        }

        public IEnumerable<CompanyTbl> ListAllCompany()
        {
            return db.Companies.ToList();
        }
    }
}
