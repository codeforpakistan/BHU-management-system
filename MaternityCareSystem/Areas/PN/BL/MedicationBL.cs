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
    public class MedicationBL:VirtualCrud<PreNatal_Medication>
    {
        public override PreNatal_Medication Save(PreNatal_Medication model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();

            SqlParameter _error = new SqlParameter
            {
                ParameterName = "@Error",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType=System.Data.SqlDbType.Bit
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
                 new SqlParameter("@PatientId",model.PatientId)
                ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@PreNatalVitamins",model.PreNatalVitamins)
                ,new SqlParameter("@TT",model.TT)
                ,new SqlParameter("@Calcium",model.Calcium)
                ,new SqlParameter("@HepBVaccine",model.HepBVaccine)
                ,new SqlParameter("@ReviewDangerSigns",model.ReviewDangerSigns)
                ,new SqlParameter("@Advice",model.Advice ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };
            
            var spec = db.Database.ExecuteSqlCommand("sp_Medication_Insert @PatientId,@VisitNo,@CheckupOf,@PreNatalVitamins,@TT,@Calcium,@HepBVaccine,@ReviewDangerSigns,@Advice,@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalMedicationId = (int)_ID.Value;

            }
            return model;

        }

        public override PreNatal_Medication Update(PreNatal_Medication model, out OutParamModel outparam)
        {
            SqlParameter[] parameters =
          {
                 new SqlParameter("@PreNatalMedicationId",model.PreNatalMedicationId)
                ,new SqlParameter("@PatientId",model.PatientId)
                ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@PreNatalVitamins",model.PreNatalVitamins)
                ,new SqlParameter("@TT",model.TT)
                ,new SqlParameter("@Calcium",model.Calcium)
                ,new SqlParameter("@HepBVaccine",model.HepBVaccine)
                ,new SqlParameter("@ReviewDangerSigns",model.ReviewDangerSigns)
                ,new SqlParameter("@Advice",model.Advice ?? (object)DBNull.Value)
            
            };
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_Medication_Update @PreNatalMedicationId,@PatientId,@VisitNo,@CheckupOf,@PreNatalVitamins,@TT ,@Calcium,@HepBVaccine,@ReviewDangerSigns,@Advice", parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }


        public override List<PreNatal_Medication> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PreNatal_Medication>("Exec sp_Medication_SelectAll").ToList();
            return result;
        }
        public override PreNatal_Medication SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PreNatal_Medication>("sp_Medication_SelectByID @PreNatalMedicationId", new SqlParameter("@PreNatalMedicationId", ID)).ToList().FirstOrDefault();
            return result;
            

        }
        public override PreNatal_Medication Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_Medication_Delete @PreNatalMedicationId", new SqlParameter("@PreNatalMedicationId", ID));
            outparam.Error = result > 0 ? false : true;
            return new PreNatal_Medication();
        }
        public PreNatal_Medication PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Medication>("exec sp_Medication_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}