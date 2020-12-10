using MaternityCareSystem.Models;
using MaternityCareSystem.Areas.PN.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MaternityCareSystem.Domain;
using System.Data.SqlClient;

namespace MaternityCareSystem.Areas.PN.BL
{
    public class PreNatalPhysicalExaminationBL:VirtualCrud<PreNatal_PhysicalExamination>
    {
        public override PreNatal_PhysicalExamination Save(PreNatal_PhysicalExamination model, out OutParamModel outparam)
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
                 ,new SqlParameter("@PreNatalVisitId",model.PreNatalVisitId ?? (object)DBNull.Value)
                 ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentEGAWeek",model.CurrentEGAWeek ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@GeneralAppearance",model.GeneralAppearance ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur",model.HeartMurmur)
                 ,new SqlParameter("@HeartRate",model.HeartRate)
                 ,new SqlParameter("@Lungs",model.Lungs ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen",model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSounds",model.AbdomenBowelSounds)
                 ,new SqlParameter("@FundalHeight",model.FundalHeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@AppropriateForGestationalAge",model.AppropriateForGestationalAge )
                 ,new SqlParameter("@SmallForGestationalAge",model.SmallForGestationalAge )
                 ,new SqlParameter("@LargeForGestationalAge",model.LargeForGestationalAge)
                 ,new SqlParameter("@VagExamNone",model.VagExamNone)
                 ,new SqlParameter("@VagExamMass",model.VagExamMass )
                 ,new SqlParameter("@VagExamTender",model.VagExamTender)
                 ,new SqlParameter("@VagDischargeYellow",model.VagDischargeYellow)
                 ,new SqlParameter("@VagDischargeWhite",model.VagDischargeWhite)
                 ,new SqlParameter("@VagDischargeGreen",model.VagDischargeGreen)
                 ,new SqlParameter("@VagDischargeBleeding",model.VagDischargeBleeding)
                 ,new SqlParameter("@VagDischargeNone",model.VagDischargeNone)
                 ,new SqlParameter("@ComplaintPain",model.ComplaintPain)
                 ,new SqlParameter("@ComplaintBleeding",model.ComplaintBleeding)
                 ,new SqlParameter("@ComplaintDischarge",model.ComplaintDischarge)
                 ,new SqlParameter("@ComplaintUrineBurning",model.ComplaintUrineBurning)
                 ,new SqlParameter("@ComplaintSeizures",model.ComplaintSeizures)
                 ,new SqlParameter("@ComplaintFits",model.ComplaintFits)
                 ,new SqlParameter("@ComplaintFever",model.ComplaintFever)
                 ,new SqlParameter("@PreNataVisit1Notes",model.PreNataVisit1Notes ?? (object)DBNull.Value)
                 ,new SqlParameter("@BirthingKit",model.BirthingKit)
                 ,new SqlParameter("@FetalPosition",model.FetalPosition ?? (object)DBNull.Value)
                 ,new SqlParameter("@FetalMovement",model.FetalMovement)
                 ,new SqlParameter("@Edema",model.Edema ?? (object)DBNull.Value)

                ,_error
                ,_message
                ,_ID
            };

            var parms = "@PatientId,@PreNatalVisitId,@VisitNo,@CurrentEGAWeek,@Weight,@Height,@Temperature,@Pulse,@BP,@GeneralAppearance,@HeartMurmur,@HeartRate,@Lungs,@Abdomen,@AbdomenBowelSounds,@FundalHeight,@AppropriateForGestationalAge,@SmallForGestationalAge,@LargeForGestationalAge,@VagExamNone,@VagExamMass,@VagExamTender,@VagDischargeYellow,@VagDischargeWhite,@VagDischargeGreen,@VagDischargeBleeding,@VagDischargeNone,@ComplaintPain,@ComplaintBleeding,@ComplaintDischarge,@ComplaintUrineBurning,@ComplaintSeizures,@ComplaintFits,@ComplaintFever,@PreNataVisit1Notes,@BirthingKit,@FetalPosition,@FetalMovement,@Edema";
            var res = db.Database.ExecuteSqlCommand("PreNatal_PhysicalExamination_Insert "+ parms + ",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PreNatalPhysicalExamId = (int)_ID.Value;

            }
            return model;
        }

        public override PreNatal_PhysicalExamination Update(PreNatal_PhysicalExamination model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
           {
                  new SqlParameter("@PreNatalPhysicalExamId",model.PreNatalPhysicalExamId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@PreNatalVisitId",model.PreNatalVisitId ?? (object)DBNull.Value)
                 ,new SqlParameter("@VisitNo",model.VisitNo ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentEGAWeek",model.CurrentEGAWeek ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@GeneralAppearance",model.GeneralAppearance ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur",model.HeartMurmur)
                 ,new SqlParameter("@HeartRate",model.HeartRate)
                 ,new SqlParameter("@Lungs",model.Lungs ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen",model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSounds",model.AbdomenBowelSounds)
                 ,new SqlParameter("@FundalHeight",model.FundalHeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@AppropriateForGestationalAge",model.AppropriateForGestationalAge )
                 ,new SqlParameter("@SmallForGestationalAge",model.SmallForGestationalAge )
                 ,new SqlParameter("@LargeForGestationalAge",model.LargeForGestationalAge)
                 ,new SqlParameter("@VagExamNone",model.VagExamNone)
                 ,new SqlParameter("@VagExamMass",model.VagExamMass )
                 ,new SqlParameter("@VagExamTender",model.VagExamTender)
                 ,new SqlParameter("@VagDischargeYellow",model.VagDischargeYellow)
                 ,new SqlParameter("@VagDischargeWhite",model.VagDischargeWhite)
                 ,new SqlParameter("@VagDischargeGreen",model.VagDischargeGreen)
                 ,new SqlParameter("@VagDischargeBleeding",model.VagDischargeBleeding)
                 ,new SqlParameter("@VagDischargeNone",model.VagDischargeNone)
                 ,new SqlParameter("@ComplaintPain",model.ComplaintPain)
                 ,new SqlParameter("@ComplaintBleeding",model.ComplaintBleeding)
                 ,new SqlParameter("@ComplaintDischarge",model.ComplaintDischarge)
                 ,new SqlParameter("@ComplaintUrineBurning",model.ComplaintUrineBurning)
                 ,new SqlParameter("@ComplaintSeizures",model.ComplaintSeizures)
                 ,new SqlParameter("@ComplaintFits",model.ComplaintFits)
                 ,new SqlParameter("@ComplaintFever",model.ComplaintFever)
                 ,new SqlParameter("@PreNataVisit1Notes",model.PreNataVisit1Notes ?? (object)DBNull.Value)
                 ,new SqlParameter("@BirthingKit",model.BirthingKit)
                 ,new SqlParameter("@FetalPosition",model.FetalPosition ?? (object)DBNull.Value)
                 ,new SqlParameter("@FetalMovement",model.FetalMovement)
                 ,new SqlParameter("@Edema",model.Edema ?? (object)DBNull.Value)

            };

            var parms = "@PreNatalPhysicalExamId,@PatientId,@PreNatalVisitId,@VisitNo,@CurrentEGAWeek,@Weight,@Height,@Temperature,@Pulse,@BP,@GeneralAppearance,@HeartMurmur,@HeartRate,@Lungs,@Abdomen,@AbdomenBowelSounds,@FundalHeight,@AppropriateForGestationalAge,@SmallForGestationalAge,@LargeForGestationalAge,@VagExamNone,@VagExamMass,@VagExamTender,@VagDischargeYellow,@VagDischargeWhite,@VagDischargeGreen,@VagDischargeBleeding,@VagDischargeNone,@ComplaintPain,@ComplaintBleeding,@ComplaintDischarge,@ComplaintUrineBurning,@ComplaintSeizures,@ComplaintFits,@ComplaintFever,@PreNataVisit1Notes,@BirthingKit,@FetalPosition,@FetalMovement,@Edema";
            var res = db.Database.ExecuteSqlCommand("PreNatal_PhysicalExamination_Update " + parms  , parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }

        public override List<PreNatal_PhysicalExamination> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_PhysicalExamination>("exec PreNatal_PhysicalExamination_SelectAll").ToList();
            return res;
        }
        public override PreNatal_PhysicalExamination SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PreNatal_PhysicalExamination>("exec PreNatal_PhysicalExamination_SelectByID @PreNatalPhysicalExamId", new SqlParameter("@PreNatalPhysicalExamId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override PreNatal_PhysicalExamination Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("PreNatal_PhysicalExamination_Delete @PreNatalPhysicalExamId", new SqlParameter("@PreNatalPhysicalExamId", ID));
            outparam.Error = result > 0 ? false : true;
            return new PreNatal_PhysicalExamination();
        }
        public PreNatal_PhysicalExamination PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PreNatal_PhysicalExamination>("exec PreNatal_PhysicalExamination_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}