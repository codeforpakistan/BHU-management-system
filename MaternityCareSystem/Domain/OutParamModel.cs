using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Domain
{
    public class OutParamModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public Int64 IDInt64 { get; set; }
        public int IDInt32 { get; set; }
        public string VarcharID { get; set; }
        public string SMSPin { get; set; }
        public string EmailPin { get; set; }
        public int TotalRecords { get; set; }
    }
}