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
    public class GynaePhysicalExamBL:VirtualCrud<Gynae_PhysicalExamination>
    {
        public override Gynae_PhysicalExamination Save(Gynae_PhysicalExamination model, out OutParamModel outparam)
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
                 ,new SqlParameter("@Weight", model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height", model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature", model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse", model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP", model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Thyroid", model.Thyroid ?? (object)DBNull.Value)
                 ,new SqlParameter("@Size", model.Size ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur", model.HeartMurmur)
                 ,new SqlParameter("@HeartRate", model.HeartRate  ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm", model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen", model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSound", model.AbdomenBowelSound)
                 ,new SqlParameter("@VaginalExamination", model.VaginalExamination ?? (object)DBNull.Value)
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
                 ,new SqlParameter("@SpeculumExam", model.SpeculumExam ?? (object)DBNull.Value)
                 ,new SqlParameter("@CarvixAppearance", model.CarvixAppearance ?? (object)DBNull.Value)
                 ,new SqlParameter("@MotionTenderness", model.MotionTenderness ?? (object)DBNull.Value)
                 ,new SqlParameter("@Uterus", model.Uterus ?? (object)DBNull.Value)
                 ,new SqlParameter("@UterusNl", model.UterusNl ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaLeft", model.AdnexaLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaRight", model.AdnexaRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaDescription", model.AdnexaDescription ?? (object)DBNull.Value)
                 ,new SqlParameter("@lungscondition", model.lungscondition ?? (object)DBNull.Value)
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

            var parms = "@PatientId,@Weight,@Height,@Temperature,@Pulse,@BP,@Thyroid,@Size,@HeartMurmur,@HeartRate,@HeartRythm,@Abdomen,@AbdomenBowelSound,@VaginalExamination,@BreastLeftNormal,@BreastLeftAbnormal,@BreastLeftMass,@BreastLeftErythema,@BreastLeftTender,@BreastLeftDischargeMilk,@BreastLeftPus,@BreastLeftOther,@BreastRightNormal,@BreastRightAbnormal,@BreastRightMass,@BreastRightErythema,@BreastRightTender,@BreastRightDischargeMilk,@BreastRightPus,@BreastRightOther,@SpeculumExam,@CarvixAppearance,@MotionTenderness,@Uterus,@UterusNl,@AdnexaLeft,@AdnexaRight,@AdnexaDescription,@lungscondition,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftOther,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightOther";
            var res = db.Database.ExecuteSqlCommand("sp_Gynae_PhysicalExamination_Insert " + parms + ",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.GynaePhysicalExamId = (int)_ID.Value;

            }
            return model;
        }
        public override Gynae_PhysicalExamination Update(Gynae_PhysicalExamination model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
         
            SqlParameter[] parameters =
           {
                  new SqlParameter("@GynaePhysicalExamId",model.GynaePhysicalExamId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight", model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height", model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature", model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse", model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP", model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Thyroid", model.Thyroid ?? (object)DBNull.Value)
                 ,new SqlParameter("@Size", model.Size ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartMurmur", model.HeartMurmur)
                 ,new SqlParameter("@HeartRate", model.HeartRate  ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm", model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@Abdomen", model.Abdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdomenBowelSound", model.AbdomenBowelSound)
                 ,new SqlParameter("@VaginalExamination", model.VaginalExamination ?? (object)DBNull.Value)
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
                 ,new SqlParameter("@SpeculumExam", model.SpeculumExam ?? (object)DBNull.Value)
                 ,new SqlParameter("@CarvixAppearance", model.CarvixAppearance ?? (object)DBNull.Value)
                 ,new SqlParameter("@MotionTenderness", model.MotionTenderness ?? (object)DBNull.Value)
                 ,new SqlParameter("@Uterus", model.Uterus ?? (object)DBNull.Value)
                 ,new SqlParameter("@UterusNl", model.UterusNl ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaLeft", model.AdnexaLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaRight", model.AdnexaRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@AdnexaDescription", model.AdnexaDescription ?? (object)DBNull.Value)
                 ,new SqlParameter("@lungscondition", model.lungscondition ?? (object)DBNull.Value)
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

            var parms = "@GynaePhysicalExamId,@PatientId,@Weight,@Height,@Temperature,@Pulse,@BP,@Thyroid,@Size,@HeartMurmur,@HeartRate,@HeartRythm,@Abdomen,@AbdomenBowelSound,@VaginalExamination,@BreastLeftNormal,@BreastLeftAbnormal,@BreastLeftMass,@BreastLeftErythema,@BreastLeftTender,@BreastLeftDischargeMilk,@BreastLeftPus,@BreastLeftOther,@BreastRightNormal,@BreastRightAbnormal,@BreastRightMass,@BreastRightErythema,@BreastRightTender,@BreastRightDischargeMilk,@BreastRightPus,@BreastRightOther,@SpeculumExam,@CarvixAppearance,@MotionTenderness,@Uterus,@UterusNl,@AdnexaLeft,@AdnexaRight,@AdnexaDescription,@lungscondition,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftOther,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightOther";
            var res = db.Database.ExecuteSqlCommand("sp_Gynae_PhysicalExamination_Update " + parms, parameters);

            outparam.Error = res > 0 ? false : true;
            return model;
        }
        public override List<Gynae_PhysicalExamination> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Gynae_PhysicalExamination>("exec sp_Gynae_PhysicalExamination_SelectAll").ToList();
            return res;
        }
        public override Gynae_PhysicalExamination SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<Gynae_PhysicalExamination>("exec sp_Gynae_PhysicalExamination_SelectByID @GynaePhysicalExamId", new SqlParameter("@GynaePhysicalExamId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override Gynae_PhysicalExamination Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_Gynae_PhysicalExamination_Delete @GynaePhysicalExamId", new SqlParameter("@GynaePhysicalExamId", ID));
            outparam.Error = result > 0 ? false : true;
            return new Gynae_PhysicalExamination();
        }

        public Gynae_PhysicalExamination PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Gynae_PhysicalExamination>("exec sp_Gynae_PhysicalExamination_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}