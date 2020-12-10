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
    public class StepOneBL:VirtualCrud<PreNatal_Step1>
    {
        public override PreNatal_Step1 Save(PreNatal_Step1 model, out OutParamModel outparam)
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
                  new SqlParameter("@PatientId", model.PatientId)
                 ,new SqlParameter("@LastMestrualDate", model.LastMestrualDate ?? (object)DBNull.Value)
                 ,new SqlParameter("@EDD", model.EDD ?? (object)DBNull.Value)
                 ,new SqlParameter("@Para", model.Para ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gravida", model.Gravida ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abortions", model.Abortions)
                 ,new SqlParameter("@LastBabyBorn", model.LastBabyBorn ?? (object)DBNull.Value)
                 ,new SqlParameter("@EGA", model.EGA ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var res = db.Database.ExecuteSqlCommand("sp_PreNatalStep1_Insert @PatientId,@LastMestrualDate,@EDD,@Para,@Gravida,@Abortions,@LastBabyBorn,@EGA,@Error out,@Message out,@ID out"
            , parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalStep1Id = (int)_ID.Value;
            }

            return model;
        }
        public override PreNatal_Step1 Update(PreNatal_Step1 model, out OutParamModel outparam)
        {
            SqlParameter[] parameters =
            {
                  new SqlParameter("@PreNatalStep1Id", model.PreNatalStep1Id)
                 ,new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMestrualDate", model.LastMestrualDate ?? (object)DBNull.Value)
                 ,new SqlParameter("@EDD", model.EDD ?? (object)DBNull.Value)
                 ,new SqlParameter("@Para", model.Para ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gravida", model.Gravida ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abortions", model.Abortions ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastBabyBorn", model.LastBabyBorn ?? (object)DBNull.Value)
                 ,new SqlParameter("@EGA", model.EGA ?? (object)DBNull.Value)
               
            };
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_PreNatalStep1_Update @PreNatalStep1Id,@PatientId,@LastMestrualDate,@EDD,@Para,@Gravida,@Abortions,@LastBabyBorn,@EGA", parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }
        public override List<PreNatal_Step1> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PreNatal_Step1>("exec sp_PrenatalStep1_SelectAll").ToList();
            return result;
        }
       
        
        public override PreNatal_Step1 SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Step1>("exec sp_PreNatalStep1_SelectByID @Id", new SqlParameter("@Id", ID)).ToList().FirstOrDefault();
            return res;
        }
        public override PreNatal_Step1 Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_PreNatalStep1_Delete @Id", new SqlParameter("@Id", ID));
            outparam.Error = res > 0 ? false : true;
            return new PreNatal_Step1();
        }
        public List<PreNatal_Step1> PtDropDown(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var patients = db.Database.SqlQuery<PreNatal_Step1>("exec sp_Patient_Dropdown").ToList();
            return patients;
        }

    }
}