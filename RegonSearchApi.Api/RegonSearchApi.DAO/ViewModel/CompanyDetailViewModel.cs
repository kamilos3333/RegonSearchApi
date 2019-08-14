using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegonSearchApi.DAO.ViewModel
{
    public class CompanyDetailViewModel
    {
        public Guid CompanyID { get; set; }
        
        public string CompanyName { get; set; }
        
        public string REGON { get; set; }
        
        public string KRS { get; set; }
        
        public string NIP { get; set; }
        
        public string Adress { get; set; }
        
        public string City { get; set; }
        
        public string Voivodeship { get; set; }
    }
}
