using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// 權杖資訊類別
    /// </summary>
    public class TokenClaim
    {
        public string UserID { get; set; }
        public string UserCode { get; set; }
        public string CompanyCode { get; set; }

        public string ProjectCode { get; set; }
    }
}
