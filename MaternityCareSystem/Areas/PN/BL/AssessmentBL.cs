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
    public class AssessmentBL:VirtualCrud<PreNatal_Assessment>
    {
        public override PreNatal_Assessment Save(PreNatal_Assessment model, out OutParamModel outparam)
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

            var pat = db.Database.ExecuteSqlCommand("sp_PreNatal_Assessment_Insert @PatientId,@Notes,@Error out,@Message out,@ID out"
            , parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.AssessmentId = (int)_ID.Value;
            }

            return model;
        }
        public override PreNatal_Assessment Update(PreNatal_Assessment model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                  new SqlParameter("@AssessmentId", model.AssessmentId)
                 ,new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@Notes", model.Notes ?? (object)DBNull.Value)
              
            };

            var res = db.Database.ExecuteSqlCommand("sp_PreNatal_Assessment_Update @AssessmentId,@PatientId,@Notes"
            , parameters);

            outparam.Error = res > 0 ? false : true;
            return model;

        }

        public override List<PreNatal_Assessment> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Assessment>("exec sp_PreNatal_Assessment_SelectAll").ToList();
            return res;
        }
      
        public override PreNatal_Assessment SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Assessment>("exec sp_PreNatal_Assessment_SelectByID @AssessmentId", new SqlParameter("@AssessmentId", ID)).ToList().FirstOrDefault();
            return res;
        }
        public override PreNatal_Assessment Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_PreNatal_Assessment_Delete @AssessmentId", new SqlParameter("@AssessmentId", ID));
            outparam.Error = res > 0 ? false : true;
            return new PreNatal_Assessment();
        }

        public PreNatal_Assessment PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Assessment>("exec sp_PreNatal_Assessment_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}