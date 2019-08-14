using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegonSearchApi.Data.Model
{
    public class CityTbl
    {
        [Key]
        public Guid CityID { get; set; }
        public Guid VoivodeshipID { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<CompanyDetailTbl> CompanyDetailsList { get; set; }
        public virtual VoivodeshipTbl Voivodeship { get; set; }
    }
}
