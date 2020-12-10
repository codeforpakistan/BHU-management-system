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
    public class CouncelBL:VirtualCrud<PreNatal_Counsel>
    {
        public override PreNatal_Counsel Save(PreNatal_Counsel model, out OutParamModel outparam)
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
                 new SqlParameter("@PatientId",model.PatientId)
                ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@DangerSigns",model.DangerSigns)
                ,new SqlParameter("@Hgb",model.Hgb)
                ,new SqlParameter("@Protein",model.Protein)
                ,new SqlParameter("@NextVisitDate",model.NextVisitDate ?? (object)DBNull.Value)
                ,new SqlParameter("@NextVisitNotes",model.NextVisitNotes ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var spec = db.Database.ExecuteSqlCommand("sp_Councel_Insert @PatientId,@VisitNo,@CheckupOf,@DangerSigns,@Hgb,@Protein,@NextVisitDate,@NextVisitNotes,@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalcounselId = (int)_ID.Value;
               
            }
            return model;

        }
        public override PreNatal_Counsel Update(PreNatal_Counsel model, out OutParamModel outparam)
        {
            SqlParameter[] parameters =
             {
                 new SqlParameter("@PreNatalcounselId",model.PreNatalcounselId)
                ,new SqlParameter("@PatientId",model.PatientId  ?? (object)DBNull.Value)
                ,new SqlParameter("@VisitNo",model.VisitNo  ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@DangerSigns",model.DangerSigns)
                ,new SqlParameter("@Hgb",model.Hgb)
                ,new SqlParameter("@Protein",model.Protein)
                ,new SqlParameter("@NextVisitDate",model.NextVisitDate  ?? (object)DBNull.Value)
                ,new SqlParameter("@NextVisitNotes",model.NextVisitNotes  ?? (object)DBNull.Value)
       
            };
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_Councel_Update @PreNatalcounselId,@PatientId,@VisitNo,@CheckupOf,@DangerSigns,@Hgb,@Protein,@NextVisitDate,@NextVisitNotes", parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }

        public override List<PreNatal_Counsel> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Counsel>("Exec sp_Councel_SelectAll").ToList();
            return res;
        }

        public override PreNatal_Counsel SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Counsel>("sp_Councel_SelectByID @PreNatalcounselId", new SqlParameter("@PreNatalcounselId", ID)).ToList().FirstOrDefault();
            return res;
        }

        public override PreNatal_Counsel Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_Councel_SelectByID @PreNatalcounselId", new SqlParameter("@PreNatalcounselId", ID));
            outparam.Error = result > 0 ? false : true;
            return new PreNatal_Counsel();
        }
        public PreNatal_Counsel PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_Counsel>("exec sp_Councel_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}