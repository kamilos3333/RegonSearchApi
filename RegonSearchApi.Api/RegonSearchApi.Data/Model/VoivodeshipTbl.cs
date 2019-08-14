using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegonSearchApi.Data.Model
{
    public class VoivodeshipTbl
    {
        [Key]
        public Guid VoivodeshipID { get; set; }
        public string NameVoivodeship { get; set; }

        public ICollection<CityTbl> CitiesList { get; set; }
    }
}
