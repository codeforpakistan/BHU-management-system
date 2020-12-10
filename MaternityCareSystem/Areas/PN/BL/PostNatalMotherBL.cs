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
    public class PostNatalMotherBL:VirtualCrud<PostNatal_MotherPhysicalExamination>
    {
        public override PostNatal_MotherPhysicalExamination Save(PostNatal_MotherPhysicalExamination model, out OutParamModel outparam)
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
                 ,new SqlParameter("@InfantDOB",model.InfantDOB ?? (object)DBNull.Value)
                 ,new SqlParameter("@DeliveryHospital",model.DeliveryHospital )
                 ,new SqlParameter("@DeliveryMaternityHome",model.DeliveryMaternityHome )
                 ,new SqlParameter("@DeliveryHome",model.DeliveryHome)
                 ,new SqlParameter("@DeliveryCondition",model.DeliveryCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@DeliveryTerm",model.DeliveryTerm ?? (object)DBNull.Value)
                 ,new SqlParameter("@SkilledBirthAttendant",model.SkilledBirthAttendant)
                 ,new SqlParameter("@Episiotomy",model.Episiotomy)
                 ,new SqlParameter("@InfantCondition",model.InfantCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@Notes",model.Notes ?? (object)DBNull.Value)
                 ,new SqlParameter("@Bleeding",model.Bleeding)
                 ,new SqlParameter("@Discharge",model.Discharge)
                 ,new SqlParameter("@DischargeType",model.DischargeType ?? (object)DBNull.Value)
                 ,new SqlParameter("@UrinationPain",model.UrinationPain)
                 ,new SqlParameter("@UrinationDifficulty",model.UrinationDifficulty)
                 ,new SqlParameter("@UrinationDifficultyType",model.UrinationDifficultyType ?? (object)DBNull.Value)
                 ,new SqlParameter("@Fever",model.Fever)
                 ,new SqlParameter("@Pain",model.Pain)
                 ,new SqlParameter("@PainAbdomen",model.PainAbdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@Appetite",model.Appetite)
                 ,new SqlParameter("@OtherConcerns",model.OtherConcerns ?? (object)DBNull.Value)
                 ,new SqlParameter("@TakePrenatalVitamins",model.TakePrenatalVitamins)
                 ,new SqlParameter("@OtherMedication",model.OtherMedication ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Heent",model.Heent ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur",model.HeartMurmur)
                 ,new SqlParameter("@HeartRate",model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm",model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen",model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSound",model.AbdomenBowelSound)
                 ,new SqlParameter("@FundalHeight",model.FundalHeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Tender",model.Tender ?? (object)DBNull.Value)
                 ,new SqlParameter("@Mass",model.Mass ?? (object)DBNull.Value)
                 ,new SqlParameter("@MassQuality",model.MassQuality ?? (object)DBNull.Value)
                 ,new SqlParameter("@BreastLeftNormal", model.BreastLeftNormal)
                 ,new SqlParameter("@BreastLeftAbnormal", model.BreastLeftAbnormal)
                 ,new SqlParameter("@BreastLeftMass", model.BreastLeftMass)
                 ,new SqlParameter("@BreastLeftErythema", model.BreastLeftErythema)
                 ,new SqlParameter("@BreastLeftTender", model.BreastLeftTender)
                 ,new SqlParameter("@BreastLeftDischargeMilk", model.BreastLeftDischargeMilk)
                 ,new SqlParameter("@BreastLeftPus", model.BreastLeftPus)
                 ,new SqlParameter("@BreastLeftOther", model.BreastLeftOther)
                 ,new SqlParameter("@BreastRightNormal", model.BreastRightNormal)
                 ,new SqlParameter("@BreastRightAbnormal", model.BreastRightAbnormal)
                 ,new SqlParameter("@BreastRightMass", model.BreastRightMass)
                 ,new SqlParameter("@BreastRightErythema", model.BreastRightErythema)
                 ,new SqlParameter("@BreastRightTender", model.BreastRightTender)
                 ,new SqlParameter("@BreastRightDischargeMilk", model.BreastRightDischargeMilk)
                 ,new SqlParameter("@BreastRightPus", model.BreastRightPus)
                 ,new SqlParameter("@BreastRightOther", model.BreastRightOther)
                 ,new SqlParameter("@CsectionIncisionWellHealed", model.CsectionIncisionWellHealed)
                 ,new SqlParameter("@CsectionIncisionNotwellhealed", model.CsectionIncisionNotwellhealed)
                 ,new SqlParameter("@CsectionIncisionOpening", model.CsectionIncisionOpening)
                 ,new SqlParameter("@WoundDischarge", model.WoundDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@VagExamNormal", model.VagExamNormal)
                 ,new SqlParameter("@VagExamBloodyDischarge", model.VagExamBloodyDischarge)
                 ,new SqlParameter("@VagExamNoDischarge", model.VagExamNoDischarge)
                 ,new SqlParameter("@VagExamTearHealing", model.VagExamTearHealing)
                 ,new SqlParameter("@VagExamNoHealing", model.VagExamNoHealing)
                 ,new SqlParameter("@VagExamSwollen", model.VagExamSwollen)
                 ,new SqlParameter("@VagExamTender", model.VagExamTender)
                 ,new SqlParameter("@VagExamNoTender", model.VagExamNoTender)
                 ,new SqlParameter("@LungsCondition", model.LungsCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@LungLeftWheezes", model.LungLeftWheezes)
                 ,new SqlParameter("@LungLeftRhonchi", model.LungLeftRhonchi)
                 ,new SqlParameter("@LungLeftRales", model.LungLeftRales)
                 ,new SqlParameter("@LungLeftPoorAirEntry", model.LungLeftPoorAirEntry)
                 ,new SqlParameter("@LungLeftOther", model.LungLeftOther)
                 ,new SqlParameter("@LungRightWheezes", model.LungRightWheezes)
                 ,new SqlParameter("@LungRightRhonchi", model.LungRightRhonchi)
                 ,new SqlParameter("@LungRightRales", model.LungRightRales)
                 ,new SqlParameter("@LungRightPoorAirEntry", model.LungRightPoorAirEntry)
                 ,new SqlParameter("@LungRightOther", model.LungRightOther)
                ,_error
                ,_message
                ,_ID
            };

            var parms = "@PatientId,@InfantDOB,@DeliveryHospital,@DeliveryMaternityHome,@DeliveryHome,@DeliveryCondition,@DeliveryTerm,@SkilledBirthAttendant,@Episiotomy,@InfantCondition,@Notes,@Bleeding,@Discharge,@DischargeType,@UrinationPain,@UrinationDifficulty,@UrinationDifficultyType,@Fever,@Pain,@PainAbdomen,@Appetite,@OtherConcerns,@TakePrenatalVitamins,@OtherMedication,@Weight,@Height,@Temperature,@Pulse,@BP,@Heent,@HeartMurmur,@HeartRate,@HeartRythm,@Abdomen,@AbdomenBowelSound,@FundalHeight,@Tender,@Mass,@MassQuality,@BreastLeftNormal,@BreastLeftAbnormal,@BreastLeftMass,@BreastLeftErythema,@BreastLeftTender,@BreastLeftDischargeMilk,@BreastLeftPus,@BreastLeftOther,@BreastRightNormal,@BreastRightAbnormal,@BreastRightMass,@BreastRightErythema,@BreastRightTender,@BreastRightDischargeMilk,@BreastRightPus,@BreastRightOther,@CsectionIncisionWellHealed,@CsectionIncisionNotwellhealed,@CsectionIncisionOpening,@WoundDischarge,@VagExamNormal,@VagExamBloodyDischarge,@VagExamNoDischarge,@VagExamTearHealing,@VagExamNoHealing,@VagExamSwollen,@VagExamTender,@VagExamNoTender,@LungsCondition,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftOther,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightOther";
            var res = db.Database.ExecuteSqlCommand("sp_PostNatal_MotherPE_Insert " + parms + ",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PostNatalMotherPhysicalExamId = (int)_ID.Value;

            }
            return model;
        }

        public override PostNatal_MotherPhysicalExamination Update(PostNatal_MotherPhysicalExamination model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
             {
                  new SqlParameter("@PostNatalMotherPhysicalExamId",model.PostNatalMotherPhysicalExamId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@InfantDOB",model.InfantDOB ?? (object)DBNull.Value)
                 ,new SqlParameter("@DeliveryHospital",model.DeliveryHospital )
                 ,new SqlParameter("@DeliveryMaternityHome",model.DeliveryMaternityHome )
                 ,new SqlParameter("@DeliveryHome",model.DeliveryHome)
                 ,new SqlParameter("@DeliveryCondition",model.DeliveryCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@DeliveryTerm",model.DeliveryTerm ?? (object)DBNull.Value)
                 ,new SqlParameter("@SkilledBirthAttendant",model.SkilledBirthAttendant)
                 ,new SqlParameter("@Episiotomy",model.Episiotomy)
                 ,new SqlParameter("@InfantCondition",model.InfantCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@Notes",model.Notes ?? (object)DBNull.Value)
                 ,new SqlParameter("@Bleeding",model.Bleeding)
                 ,new SqlParameter("@Discharge",model.Discharge)
                 ,new SqlParameter("@DischargeType",model.DischargeType ?? (object)DBNull.Value)
                 ,new SqlParameter("@UrinationPain",model.UrinationPain)
                 ,new SqlParameter("@UrinationDifficulty",model.UrinationDifficulty)
                 ,new SqlParameter("@UrinationDifficultyType",model.UrinationDifficultyType ?? (object)DBNull.Value)
                 ,new SqlParameter("@Fever",model.Fever)
                 ,new SqlParameter("@Pain",model.Pain)
                 ,new SqlParameter("@PainAbdomen",model.PainAbdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@Appetite",model.Appetite)
                 ,new SqlParameter("@OtherConcerns",model.OtherConcerns ?? (object)DBNull.Value)
                 ,new SqlParameter("@TakePrenatalVitamins",model.TakePrenatalVitamins)
                 ,new SqlParameter("@OtherMedication",model.OtherMedication ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Heent",model.Heent ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur",model.HeartMurmur)
                 ,new SqlParameter("@HeartRate",model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm",model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen",model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSound",model.AbdomenBowelSound)
                 ,new SqlParameter("@FundalHeight",model.FundalHeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Tender",model.Tender ?? (object)DBNull.Value)
                 ,new SqlParameter("@Mass",model.Mass ?? (object)DBNull.Value)
                 ,new SqlParameter("@MassQuality",model.MassQuality ?? (object)DBNull.Value)
                 ,new SqlParameter("@BreastLeftNormal", model.BreastLeftNormal)
                 ,new SqlParameter("@BreastLeftAbnormal", model.BreastLeftAbnormal)
                 ,new SqlParameter("@BreastLeftMass", model.BreastLeftMass)
                 ,new SqlParameter("@BreastLeftErythema", model.BreastLeftErythema)
                 ,new SqlParameter("@BreastLeftTender", model.BreastLeftTender)
                 ,new SqlParameter("@BreastLeftDischargeMilk", model.BreastLeftDischargeMilk)
                 ,new SqlParameter("@BreastLeftPus", model.BreastLeftPus)
                 ,new SqlParameter("@BreastLeftOther", model.BreastLeftOther)
                 ,new SqlParameter("@BreastRightNormal", model.BreastRightNormal)
                 ,new SqlParameter("@BreastRightAbnormal", model.BreastRightAbnormal)
                 ,new SqlParameter("@BreastRightMass", model.BreastRightMass)
                 ,new SqlParameter("@BreastRightErythema", model.BreastRightErythema)
                 ,new SqlParameter("@BreastRightTender", model.BreastRightTender)
                 ,new SqlParameter("@BreastRightDischargeMilk", model.BreastRightDischargeMilk)
                 ,new SqlParameter("@BreastRightPus", model.BreastRightPus)
                 ,new SqlParameter("@BreastRightOther", model.BreastRightOther)
                 ,new SqlParameter("@CsectionIncisionWellHealed", model.CsectionIncisionWellHealed)
                 ,new SqlParameter("@CsectionIncisionNotwellhealed", model.CsectionIncisionNotwellhealed)
                 ,new SqlParameter("@CsectionIncisionOpening", model.CsectionIncisionOpening)
                 ,new SqlParameter("@WoundDischarge", model.WoundDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@VagExamNormal", model.VagExamNormal)
                 ,new SqlParameter("@VagExamBloodyDischarge", model.VagExamBloodyDischarge)
                 ,new SqlParameter("@VagExamNoDischarge", model.VagExamNoDischarge)
                 ,new SqlParameter("@VagExamTearHealing", model.VagExamTearHealing)
                 ,new SqlParameter("@VagExamNoHealing", model.VagExamNoHealing)
                 ,new SqlParameter("@VagExamSwollen", model.VagExamSwollen)
                 ,new SqlParameter("@VagExamTender", model.VagExamTender)
                 ,new SqlParameter("@VagExamNoTender", model.VagExamNoTender)
                 ,new SqlParameter("@LungsCondition", model.LungsCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@LungLeftWheezes", model.LungLeftWheezes)
                 ,new SqlParameter("@LungLeftRhonchi", model.LungLeftRhonchi)
                 ,new SqlParameter("@LungLeftRales", model.LungLeftRales)
                 ,new SqlParameter("@LungLeftPoorAirEntry", model.LungLeftPoorAirEntry)
                 ,new SqlParameter("@LungLeftOther", model.LungLeftOther)
                 ,new SqlParameter("@LungRightWheezes", model.LungRightWheezes)
                 ,new SqlParameter("@LungRightRhonchi", model.LungRightRhonchi)
                 ,new SqlParameter("@LungRightRales", model.LungRightRales)
                 ,new SqlParameter("@LungRightPoorAirEntry", model.LungRightPoorAirEntry)
                 ,new SqlParameter("@LungRightOther", model.LungRightOther)
              
            };

            var parms = "@PostNatalMotherPhysicalExamId,@PatientId,@InfantDOB,@DeliveryHospital,@DeliveryMaternityHome,@DeliveryHome,@DeliveryCondition,@DeliveryTerm,@SkilledBirthAttendant,@Episiotomy,@InfantCondition,@Notes,@Bleeding,@Discharge,@DischargeType,@UrinationPain,@UrinationDifficulty,@UrinationDifficultyType,@Fever,@Pain,@PainAbdomen,@Appetite,@OtherConcerns,@TakePrenatalVitamins,@OtherMedication,@Weight,@Height,@Temperature,@Pulse,@BP,@Heent,@HeartMurmur,@HeartRate,@HeartRythm,@Abdomen,@AbdomenBowelSound,@FundalHeight,@Tender,@Mass,@MassQuality,@BreastLeftNormal,@BreastLeftAbnormal,@BreastLeftMass,@BreastLeftErythema,@BreastLeftTender,@BreastLeftDischargeMilk,@BreastLeftPus,@BreastLeftOther,@BreastRightNormal,@BreastRightAbnormal,@BreastRightMass,@BreastRightErythema,@BreastRightTender,@BreastRightDischargeMilk,@BreastRightPus,@BreastRightOther,@CsectionIncisionWellHealed,@CsectionIncisionNotwellhealed,@CsectionIncisionOpening,@WoundDischarge,@VagExamNormal,@VagExamBloodyDischarge,@VagExamNoDischarge,@VagExamTearHealing,@VagExamNoHealing,@VagExamSwollen,@VagExamTender,@VagExamNoTender,@LungsCondition,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftOther,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightOther";
            var res = db.Database.ExecuteSqlCommand("sp_PostNatal_MotherPE_Update " + parms, parameters);

            outparam.Error = res > 0 ? false : true;
           
            return model;
        }
        public override List<PostNatal_MotherPhysicalExamination> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PostNatal_MotherPhysicalExamination>("exec sp_PostNatal_MotherPE_SelectAll").ToList();
            return res;
        }
        public override PostNatal_MotherPhysicalExamination SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PostNatal_MotherPhysicalExamination>("exec sp_PostNatal_MotherPE_SelectByID @PostNatalMotherPhysicalExamId", new SqlParameter("@PostNatalMotherPhysicalExamId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override PostNatal_MotherPhysicalExamination Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_PostNatal_MotherPE_Delete @PostNatalMotherPhysicalExamId", new SqlParameter("@PostNatalMotherPhysicalExamId", ID));
            outparam.Error = result > 0 ? false : true;
            return new PostNatal_MotherPhysicalExamination();
        }
        public PostNatal_MotherPhysicalExamination PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PostNatal_MotherPhysicalExamination>("exec sp_PostNatal_MotherPE_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}