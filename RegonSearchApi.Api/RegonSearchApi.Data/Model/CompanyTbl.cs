using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegonSearchApi.Data.Model
{
    public class CompanyTbl
    {
            [Key]
            public Guid CompanyID { get; set; }
        public Guid CompanyDetailID { get; set; }
            public string CompanyName { get; set; }
            public string REGON { get; set; }
            public string KRS { get; set; }
            public string NIP { get; set; }

            public virtual CompanyDetailTbl CompanyDetail { get; set; }
    }
}
