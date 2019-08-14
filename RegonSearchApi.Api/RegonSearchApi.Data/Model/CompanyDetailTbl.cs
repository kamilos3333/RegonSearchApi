using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegonSearchApi.Data.Model
{
    public class CompanyDetailTbl
    {
        [Key]
        public Guid CompanyDetailID { get; set; }
        public Guid CompanyID { get; set; }
        public Guid CityID { get; set; }
        public string Adress { get; set; }

        public virtual CompanyTbl Company { get; set; }
        public virtual CityTbl City { get; set; }
    }
}
