using MaternityCareSystem.Areas.PN.DataModels;
using MaternityCareSystem.Domain;
using MaternityCareSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.BL
{
    public class PlanBL: VirtualCrud<PreNatal_Plan>
    {
        public override PreNatal_Plan Save(PreNatal_Plan model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();

            SqlParameter _error = new SqlParameter()
            {
                ParameterName = "@Error",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Bit

            };
            SqlParameter _message = new SqlParameter()
            {
                ParameterName = "@Message",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Size = 200
            };
            SqlParameter _ID = new SqlParameter()
            {
                ParameterName = "@ID",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
                Value = 0
            };
            SqlParameter[] parameters =
            {
                  new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@Notes", model.Notes ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var pat = db.Database.ExecuteSqlCommand("sp_PreNatal_Plan_Insert @PatientId,@Notes,@Error out,@Message out,@ID out"
            , parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalPlanId = (int)_ID.Value;
            }

            return model;
        }
        public override PreNatal_Plan Update(PreNatal_Plan model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                  new SqlParameter("@PreNatalPlanId", model.PreNatalPlanId)
                 ,new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@Notes", model.Notes ?? (object)DBNull.Value)

            };

            var res = db.Database.ExecuteSqlCommand("sp_PreNatal_Plan_Update @PreNatalPlanId,@PatientId,@Notes"
            , parameters);

            outparam.Error = res > 0 ? false : true;
            return model;

        }

        public override List<PreNatal_Plan> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Plan>("exec sp_PreNatal_Plan_SelectAll").ToList();
            return res;
        }

        public override PreNatal_Plan SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Plan>("exec sp_PreNatal_Plan_SelectByID @PreNatalPlanId", new SqlParameter("@PreNatalPlanId", ID)).ToList().FirstOrDefault();
            return res;
        }
        public override PreNatal_Plan Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_PreNatal_Plan_Delete @PreNatalPlanId", new SqlParameter("@PreNatalPlanId", ID));
            outparam.Error = res > 0 ? false : true;
            return new PreNatal_Plan();
        }
        public PreNatal_Plan PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Plan>("exec sp_PreNatal_Plan_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}