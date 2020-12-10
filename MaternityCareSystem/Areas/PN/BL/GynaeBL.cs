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
    public class GynaeBL:VirtualCrud<GynaeForm>
    {
        public override GynaeForm Save(GynaeForm model, out OutParamModel outparam)
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
                  new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualDate",model.LastMenstrualDate ?? (object)DBNull.Value)
                 ,new SqlParameter("@History",model.History ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualBegin",model.LastMenstrualBegin ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualEnd",model.LastMenstrualEnd ?? (object)DBNull.Value)
                 ,new SqlParameter("@NumberOfDaysBleeding",model.NumberOfDaysBleeding )
                 ,new SqlParameter("@Dayss",model.Dayss ?? (object)DBNull.Value)
                 ,new SqlParameter("@BleedingCondition",model.BleedingCondition)
                 ,new SqlParameter("@Pain",model.Pain )
                 ,new SqlParameter("@PainNotes",model.PainNotes ?? (object)DBNull.Value)
                 ,new SqlParameter("@CycleHistory",model.CycleHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@Para",model.Para ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gravida",model.Gravida ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abortions",model.Abortions ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastBabyBorn",model.LastBabyBorn ?? (object)DBNull.Value)
                 ,new SqlParameter("@Infertility",model.Infertility )
                 ,new SqlParameter("@MarriedYears",model.MarriedYears ?? (object)DBNull.Value)
                 ,new SqlParameter("@Husband",model.Husband ?? (object)DBNull.Value)
                 ,new SqlParameter("@HistoryAndTestsWife",model.HistoryAndTestsWife ?? (object)DBNull.Value)
                 ,new SqlParameter("@OtherMedicalHistory",model.OtherMedicalHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentMedication",model.CurrentMedication ?? (object)DBNull.Value)
                 ,new SqlParameter("@ComplaintPain",model.ComplaintPain)
                 ,new SqlParameter("@ComplaintBleeding",model.ComplaintBleeding)
                 ,new SqlParameter("@ComplaintDischarge",model.ComplaintDischarge)
                 ,new SqlParameter("@ComplaintUrineBurning",model.ComplaintUrineBurning)
                 ,new SqlParameter("@ComplaintSeizures",model.ComplaintSeizures)
                 ,new SqlParameter("@ComplaintFits",model.ComplaintFits)
                ,_error
                ,_message
                ,_ID
            };
        string parms= "@PatientId,@LastMenstrualDate,@History,@LastMenstrualBegin,@LastMenstrualEnd,@NumberOfDaysBleeding,@Dayss,@BleedingCondition,@Pain,@PainNotes,@CycleHistory,@Para,@Gravida,@Abortions,@LastBabyBorn,@Infertility,@MarriedYears,@Husband,@HistoryAndTestsWife,@OtherMedicalHistory,@CurrentMedication,@ComplaintPain,@ComplaintBleeding,@ComplaintDischarge,@ComplaintUrineBurning,@ComplaintSeizures,@ComplaintFits";
            var res = db.Database.ExecuteSqlCommand("sp_GynaeForm_Insert "+parms+",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.GynaeFormId = (int)_ID.Value;

            }
            return model;
        }

        public override GynaeForm Update(GynaeForm model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
           {
                  new SqlParameter("@GynaeFormId",model.GynaeFormId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualDate",model.LastMenstrualDate ?? (object)DBNull.Value)
                 ,new SqlParameter("@History",model.History ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualBegin",model.LastMenstrualBegin ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualEnd",model.LastMenstrualEnd ?? (object)DBNull.Value)
                 ,new SqlParameter("@NumberOfDaysBleeding",model.NumberOfDaysBleeding )
                 ,new SqlParameter("@Dayss",model.Dayss ?? (object)DBNull.Value)
                 ,new SqlParameter("@BleedingCondition",model.BleedingCondition)
                 ,new SqlParameter("@Pain",model.Pain )
                 ,new SqlParameter("@PainNotes",model.PainNotes ?? (object)DBNull.Value)
                 ,new SqlParameter("@CycleHistory",model.CycleHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@Para",model.Para ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gravida",model.Gravida ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abortions",model.Abortions ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastBabyBorn",model.LastBabyBorn ?? (object)DBNull.Value)
                 ,new SqlParameter("@Infertility",model.Infertility )
                 ,new SqlParameter("@MarriedYears",model.MarriedYears ?? (object)DBNull.Value)
                 ,new SqlParameter("@Husband",model.Husband ?? (object)DBNull.Value)
                 ,new SqlParameter("@HistoryAndTestsWife",model.HistoryAndTestsWife ?? (object)DBNull.Value)
                 ,new SqlParameter("@OtherMedicalHistory",model.OtherMedicalHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentMedication",model.CurrentMedication ?? (object)DBNull.Value)
                 ,new SqlParameter("@ComplaintPain",model.ComplaintPain)
                 ,new SqlParameter("@ComplaintBleeding",model.ComplaintBleeding)
                 ,new SqlParameter("@ComplaintDischarge",model.ComplaintDischarge)
                 ,new SqlParameter("@ComplaintUrineBurning",model.ComplaintUrineBurning)
                 ,new SqlParameter("@ComplaintSeizures",model.ComplaintSeizures)
                 ,new SqlParameter("@ComplaintFits",model.ComplaintFits)
            };
            string parms = "@GynaeFormId,@PatientId,@LastMenstrualDate,@History,@LastMenstrualBegin,@LastMenstrualEnd,@NumberOfDaysBleeding,@Dayss,@BleedingCondition,@Pain,@PainNotes,@CycleHistory,@Para,@Gravida,@Abortions,@LastBabyBorn,@Infertility,@MarriedYears,@Husband,@HistoryAndTestsWife,@OtherMedicalHistory,@CurrentMedication,@ComplaintPain,@ComplaintBleeding,@ComplaintDischarge,@ComplaintUrineBurning,@ComplaintSeizures,@ComplaintFits";
            var res = db.Database.ExecuteSqlCommand("sp_GynaeForm_Update " + parms , parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }

        public override List<GynaeForm> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<GynaeForm>("exec sp_GynaeForm_SelectAll").ToList();
            return res;
        }
        public override GynaeForm SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<GynaeForm>("exec sp_GynaeForm_SelectByID @GynaeFormId", new SqlParameter("@GynaeFormId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override GynaeForm Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_GynaeForm_Delete @GynaeFormId", new SqlParameter("@GynaeFormId", ID));
            outparam.Error = result > 0 ? false : true;
            return new GynaeForm();
        }
    }
}