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
    public class LabTestBL:VirtualCrud<PreNatal_LabTest>
    {
        public override PreNatal_LabTest Save(PreNatal_LabTest model, out OutParamModel outparam)
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
                 new SqlParameter("@PatientId",model.PatientId  ?? (object)DBNull.Value)
                ,new SqlParameter("@CurrentEgaWeek",model.CurrentEgaWeek ?? (object)DBNull.Value)
                ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@Hgb",model.Hgb ?? (object)DBNull.Value)
                ,new SqlParameter("@BloodGroup",model.BloodGroup ?? (object)DBNull.Value)
                ,new SqlParameter("@HepB",model.HepB)
                ,new SqlParameter("@Protein",model.Protein ?? (object)DBNull.Value)
                ,new SqlParameter("@Glucose",model.Glucose ?? (object)DBNull.Value)
                ,new SqlParameter("@BloodSugar",model.BloodSugar ?? (object)DBNull.Value)
                ,new SqlParameter("@WBC",model.WBC ?? (object)DBNull.Value)
                ,new SqlParameter("@GramStain",model.GramStain ?? (object)DBNull.Value)
                ,new SqlParameter("@Keytone",model.Keytone ?? (object)DBNull.Value)
                ,new SqlParameter("@Blood",model.Blood ?? (object)DBNull.Value)
                ,new SqlParameter("@Nitrite",model.Nitrite)
                ,new SqlParameter("@SpecificGravity",model.SpecificGravity ?? (object)DBNull.Value)
                ,new SqlParameter("@PrenatalUltrasound",model.PrenatalUltrasound ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };
            var paramss = "@PatientId,@CurrentEgaWeek,@VisitNo,@CheckupOf,@Hgb,@BloodGroup,@HepB,@Protein,@Glucose,@BloodSugar,@WBC,@GramStain,@Keytone,@Blood,@Nitrite,@SpecificGravity,@PrenatalUltrasound";
            var spec = db.Database.ExecuteSqlCommand("sp_Labtest_Insert "+paramss+",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.TestId = (int)_ID.Value;
            }
            return model;

        }

        public override PreNatal_LabTest Update(PreNatal_LabTest model, out OutParamModel outparam)
        {
            SqlParameter[] parameters =
          {
                 new SqlParameter("@TestId",model.TestId)
                ,new SqlParameter("@PatientId",model.PatientId  ?? (object)DBNull.Value)
                ,new SqlParameter("@CurrentEgaWeek",model.CurrentEgaWeek ?? (object)DBNull.Value)
                ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                ,new SqlParameter("@CheckupOf",model.CheckupOf ?? (object)DBNull.Value)
                ,new SqlParameter("@Hgb",model.Hgb ?? (object)DBNull.Value)
                ,new SqlParameter("@BloodGroup",model.BloodGroup ?? (object)DBNull.Value)
                ,new SqlParameter("@HepB",model.HepB)
                ,new SqlParameter("@Protein",model.Protein ?? (object)DBNull.Value)
                ,new SqlParameter("@Glucose",model.Glucose ?? (object)DBNull.Value)
                ,new SqlParameter("@BloodSugar",model.BloodSugar ?? (object)DBNull.Value)
                ,new SqlParameter("@WBC",model.WBC ?? (object)DBNull.Value)
                ,new SqlParameter("@GramStain",model.GramStain ?? (object)DBNull.Value)
                ,new SqlParameter("@Keytone",model.Keytone ?? (object)DBNull.Value)
                ,new SqlParameter("@Blood",model.Blood ?? (object)DBNull.Value)
                ,new SqlParameter("@Nitrite",model.Nitrite)
                ,new SqlParameter("@SpecificGravity",model.SpecificGravity ?? (object)DBNull.Value)
                ,new SqlParameter("@PrenatalUltrasound",model.PrenatalUltrasound ?? (object)DBNull.Value)

            };
            var paramss = "@TestId,@PatientId,@CurrentEgaWeek,@VisitNo,@CheckupOf,@Hgb,@BloodGroup,@HepB,@Protein,@Glucose,@BloodSugar,@WBC,@GramStain,@Keytone,@Blood,@Nitrite,@SpecificGravity,@PrenatalUltrasound";

            outparam = new OutParamModel();
            var labTest = db.Database.ExecuteSqlCommand("sp_Labtest_Update " + paramss,parameters);
            outparam.Error = labTest > 0 ? false : true;
            return model;
        }

        public override List<PreNatal_LabTest> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var lt = db.Database.SqlQuery<PreNatal_LabTest>("exec sp_Labtest_SelectAll").ToList();
            return lt;
        }
        public override PreNatal_LabTest SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var model = db.Database.SqlQuery<PreNatal_LabTest>("exec sp_Labtest_SelectByID @TestId", new SqlParameter("@TestId", ID)).ToList().FirstOrDefault();
            return model;
        }

        public override PreNatal_LabTest Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var spec = db.Database.ExecuteSqlCommand("sp_Labtest_Delete @TestId", new SqlParameter("@TestId", ID));
            outparam.Error = spec > 0 ? false : true;
            return new PreNatal_LabTest();
        }
        public PreNatal_LabTest PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_LabTest>("exec sp_Labtest_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}