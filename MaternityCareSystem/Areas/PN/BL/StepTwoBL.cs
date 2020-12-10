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
    public class StepTwoBL:VirtualCrud<PreNatal_Step2>
    {
        public override PreNatal_Step2 Save(PreNatal_Step2 model, out OutParamModel outparam)
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
                 ,new SqlParameter("@DateOfDelivery", model.DateOfDelivery ?? (object)DBNull.Value)
                 ,new SqlParameter("@CompBleeding", model.CompBleeding)
                 ,new SqlParameter("@CompBP", model.CompBP)
                 ,new SqlParameter("@CompStillBirth", model.CompStillBirth)
                 ,new SqlParameter("@CompHeavyBleeding", model.CompHeavyBleeding)
                 ,new SqlParameter("@CompKidneyProblem", model.CompKidneyProblem)
                 ,new SqlParameter("@CompAnemia", model.CompAnemia)
                 ,new SqlParameter("@CompCSection", model.CompCSection)
                 ,new SqlParameter("@CompEclampsia", model.CompEclampsia)
                 ,new SqlParameter("@CompFever", model.CompFever)
                 ,new SqlParameter("@CompForcepsVaccum", model.CompForcepsVaccum)
                 ,new SqlParameter("@CompPreEcplampsia", model.CompPreEcplampsia)
                 ,new SqlParameter("@CompTwins", model.CompTwins)
                 ,new SqlParameter("@CompTear", model.CompTear)
                 ,new SqlParameter("@CompSugar", model.CompSugar)
                 ,new SqlParameter("@CompTetanusImmunization", model.CompTetanusImmunization)
                 ,new SqlParameter("@homeDelivery", model.homeDelivery)
                 ,new SqlParameter("@MaternityHomeDelivery", model.MaternityHomeDelivery)
                 ,new SqlParameter("@HospitalDelivery", model.HospitalDelivery)
                 ,new SqlParameter("@Notes", model.Notes ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var res = db.Database.ExecuteSqlCommand("sp_PreNatalStep2_Insert @PatientId,@DateOfDelivery,@CompBleeding,@CompBP,@CompStillBirth,@CompHeavyBleeding,@CompKidneyProblem,@CompAnemia,@CompCSection,@CompEclampsia,@CompFever,@CompForcepsVaccum,@CompPreEcplampsia,@CompTwins,@CompTear,@CompSugar,@CompTetanusImmunization,@homeDelivery,@MaternityHomeDelivery,@HospitalDelivery,@Notes,@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalStep2Id = (int)_ID.Value;
            }
            return model;
        }
        public override PreNatal_Step2 Update(PreNatal_Step2 model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
         {
                  new SqlParameter("@PreNatalStep2Id", model.PreNatalStep2Id)
                 ,new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@DateOfDelivery", model.DateOfDelivery ?? (object)DBNull.Value)
                 ,new SqlParameter("@CompBleeding", model.CompBleeding)
                 ,new SqlParameter("@CompBP", model.CompBP)
                 ,new SqlParameter("@CompStillBirth", model.CompStillBirth)
                 ,new SqlParameter("@CompHeavyBleeding", model.CompHeavyBleeding)
                 ,new SqlParameter("@CompKidneyProblem", model.CompKidneyProblem)
                 ,new SqlParameter("@CompAnemia", model.CompAnemia)
                 ,new SqlParameter("@CompCSection", model.CompCSection)
                 ,new SqlParameter("@CompEclampsia", model.CompEclampsia)
                 ,new SqlParameter("@CompFever", model.CompFever)
                 ,new SqlParameter("@CompForcepsVaccum", model.CompForcepsVaccum)
                 ,new SqlParameter("@CompPreEcplampsia", model.CompPreEcplampsia)
                 ,new SqlParameter("@CompTwins", model.CompTwins)
                 ,new SqlParameter("@CompTear", model.CompTear)
                 ,new SqlParameter("@CompSugar", model.CompSugar)
                 ,new SqlParameter("@CompTetanusImmunization", model.CompTetanusImmunization)
                 ,new SqlParameter("@homeDelivery", model.homeDelivery)
                 ,new SqlParameter("@MaternityHomeDelivery", model.MaternityHomeDelivery)
                 ,new SqlParameter("@HospitalDelivery", model.HospitalDelivery)
                 ,new SqlParameter("@Notes", model.Notes ?? (object)DBNull.Value)

            };

            var res = db.Database.ExecuteSqlCommand("sp_PreNatalStep2_Update @PreNatalStep2Id,@PatientId,@DateOfDelivery,@CompBleeding,@CompBP,@CompStillBirth,@CompHeavyBleeding,@CompKidneyProblem,@CompAnemia,@CompCSection,@CompEclampsia,@CompFever,@CompForcepsVaccum,@CompPreEcplampsia,@CompTwins,@CompTear,@CompSugar,@CompTetanusImmunization,@homeDelivery,@MaternityHomeDelivery,@HospitalDelivery,@Notes", parameters);
            outparam.Error = res > 0 ? false : true;


            return model;
        }
        public override List<PreNatal_Step2> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var specs = db.Database.SqlQuery<PreNatal_Step2>("exec sp_PrenatalStep2_SelectAll").ToList();
            return specs;
        }

        public override PreNatal_Step2 SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var model = db.Database.SqlQuery<PreNatal_Step2>("exec sp_PreNatalStep2_SelectByID @PreNatalStep2Id", new SqlParameter("@PreNatalStep2Id", ID)).ToList().FirstOrDefault();
            return model;
        }
        public override PreNatal_Step2 Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var spec = db.Database.ExecuteSqlCommand("sp_PreNatalStep2_Delete @PreNatalStep2Id", new SqlParameter("@PreNatalStep2Id", ID));
            outparam.Error = spec > 0 ? false : true;
            return new PreNatal_Step2();
        }
        public PreNatal_Step2 PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Step2>("exec sp_PreNataStep2_PoplateByMRNo @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}