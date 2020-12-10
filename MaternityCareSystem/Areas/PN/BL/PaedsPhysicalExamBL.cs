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
    public class PaedsPhysicalExamBL : VirtualCrud<Paeds_PhysicalExamination>
    {
        public override Paeds_PhysicalExamination Save(Paeds_PhysicalExamination model, out OutParamModel outparam)
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
                 ,new SqlParameter("@DOB",model.DOB ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@WeightPercentile",model.WeightPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeightPercentile",model.HeightPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@HC",model.HC ?? (object)DBNull.Value)
                 ,new SqlParameter("@HCPercentile",model.HCPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@Oxygen",model.Oxygen ?? (object)DBNull.Value)
                 ,new SqlParameter("@RR",model.RR ?? (object)DBNull.Value)
                 ,new SqlParameter("@Alert", model.Alert)
                 ,new SqlParameter("@ListLess", model.ListLess)
                 ,new SqlParameter("@Jaundice", model.Jaundice)
                 ,new SqlParameter("@Active", model.Active)
                 ,new SqlParameter("@Agitated", model.Agitated)
                 ,new SqlParameter("@Pale", model.Pale)
                 ,new SqlParameter("@Smiling", model.Smiling)
                 ,new SqlParameter("@Convulsions", model.Convulsions)
                 ,new SqlParameter("@Crying", model.Crying)
                 ,new SqlParameter("@NonResponse", model.NonResponse)
                 ,new SqlParameter("@Lethargic", model.Lethargic)
                 ,new SqlParameter("@ColorPink", model.ColorPink)
                 ,new SqlParameter("@Other", model.Other)
                 ,new SqlParameter("@Head",model.Head ?? (object)DBNull.Value)
                 ,new SqlParameter("@AntFontAnelle",model.AntFontAnelle ?? (object)DBNull.Value)
                 ,new SqlParameter("@PostFontAnelle",model.PostFontAnelle ?? (object)DBNull.Value)
                 ,new SqlParameter("@Sutures",model.Sutures ?? (object)DBNull.Value)
                 ,new SqlParameter("@Cephalohematoma", model.Cephalohematoma)
                 
                 ,new SqlParameter("@HeadOther", model.HeadOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyePupils", model.EyePupils ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeSclera", model.EyeSclera ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeConjuctiva", model.EyeConjuctiva ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeDischargeLeft", model.EyeDischargeLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeDischargeRight", model.EyeDischargeRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeRedReflex", model.EyeRedReflex)
                 ,new SqlParameter("@EyeOther", model.EyeOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@EarPennaeLeft", model.EarPennaeLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarPennaeRight", model.EarPennaeRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarPennaeNotes", model.EarPennaeNotes ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarCanalLeft", model.EarCanalLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarCanalRight", model.EarCanalRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarDischarge", model.EarDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarOther", model.EarOther ?? (object)DBNull.Value)
     
                 ,new SqlParameter("@Mouth", model.Mouth ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthGums", model.MouthGums ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthTeeth", model.MouthTeeth ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthOther", model.MouthOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@Throat", model.Throat ?? (object)DBNull.Value)
                 ,new SqlParameter("@Tonsils", model.Tonsils ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThroatOther", model.ThroatOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@Nose", model.Nose ?? (object)DBNull.Value)
                 ,new SqlParameter("@NoseDischarge", model.NoseDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@Neck", model.Neck ?? (object)DBNull.Value)
                 ,new SqlParameter("@SwollenLymphNode", model.SwollenLymphNode ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckLeft", model.NeckLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckRight", model.NeckRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckOther", model.NeckOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@TMLeftNormal", model.TMLeftNormal)
                 ,new SqlParameter("@TMLeftWhite", model.TMLeftWhite)
                 ,new SqlParameter("@TMLeftRed", model.TMLeftRed)
                 ,new SqlParameter("@TMLeftYellow", model.TMLeftYellow)
                 ,new SqlParameter("@TMLeftBulging", model.TMLeftBulging)
                 ,new SqlParameter("@TMLeftMobile", model.TMLeftMobile)
                 ,new SqlParameter("@TMLeftNonMobile", model.TMLeftNonMobile)
                 ,new SqlParameter("@TMLeftRaptured", model.TMLeftRaptured)
                 ,new SqlParameter("@TMLeftOther", model.TMLeftOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@TMRightNormal", model.TMRightNormal)
                 ,new SqlParameter("@TMRightWhite", model.TMRightWhite)
                 ,new SqlParameter("@TMRightRed", model.TMRightRed)
                 ,new SqlParameter("@TMRightYellow", model.TMRightYellow)
                 ,new SqlParameter("@TMRightBulging", model.TMRightBulging)
                 ,new SqlParameter("@TMRightMobile", model.TMRightMobile)
                 ,new SqlParameter("@TMRightNonMobile", model.TMRightNonMobile)
                 ,new SqlParameter("@TMRightRaptured", model.TMRightRaptured)
                 ,new SqlParameter("@TMDischarge", model.TMDischarge ?? (object)DBNull.Value)         
                 ,new SqlParameter("@TMRightOther", model.TMRightOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@LungsRespiration", model.LungsRespiration ?? (object)DBNull.Value)
                 ,new SqlParameter("@LungLeftWheezes", model.LungLeftWheezes)
                 ,new SqlParameter("@LungLeftRhonchi", model.LungLeftRhonchi)
                 ,new SqlParameter("@LungLeftRales", model.LungLeftRales)
                 ,new SqlParameter("@LungLeftPoorAirEntry", model.LungLeftPoorAirEntry)
                 ,new SqlParameter("@LungLeftDiminshed", model.LungLeftDiminshed)
                
                 ,new SqlParameter("@LungRightWheezes", model.LungRightWheezes)
                 ,new SqlParameter("@LungRightRhonchi", model.LungRightRhonchi)
                 ,new SqlParameter("@LungRightRales", model.LungRightRales)
                 ,new SqlParameter("@LungRightPoorAirEntry", model.LungRightPoorAirEntry)
                 ,new SqlParameter("@LungRightDiminished", model.LungRightDiminished)
                 ,new SqlParameter("@LungOther", model.LungOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@HeartMurmur", model.HeartMurmur)
                 ,new SqlParameter("@MurmurRate", model.MurmurRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRate", model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm", model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartOther", model.HeartOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@AbdAbdomen", model.AbdAbdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdTender", model.AbdTender ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdMassQuality", model.AbdMassQuality ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdRebound", model.AbdRebound)
                 ,new SqlParameter("@AbdUmbilicalHernia", model.AbdUmbilicalHernia ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdInguinalHernialLeft", model.AbdInguinalHernialLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdInguinalHernialRight", model.AbdInguinalHernialRight ?? (object)DBNull.Value)
                 
                 ,new SqlParameter("@UmbClean", model.UmbClean ?? (object)DBNull.Value)
                 ,new SqlParameter("@UmdDishcharge", model.UmdDishcharge ?? (object)DBNull.Value)
                 ,new SqlParameter("@UmbOther", model.UmbOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@GentMale", model.GentMale ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentHydrocele", model.GentHydrocele)
                 ,new SqlParameter("@GentUndescendedLeft", model.GentUndescendedLeft)
                 ,new SqlParameter("@GentUndescendedRight", model.GentUndescendedRight)
                 ,new SqlParameter("@GentHerniaLeft", model.GentHerniaLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentHerniaRight", model.GentHerniaRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentPenis", model.GentPenis ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMicro", model.GentMicro)
                 ,new SqlParameter("@GentMeatus", model.GentMeatus ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentDishcharge", model.GentDishcharge ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMaleOther", model.GentMaleOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentFemale", model.GentFemale ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentLabia", model.GentLabia ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentUrethra", model.GentUrethra ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentDischarge", model.GentDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMassLeft", model.GentMassLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMassRight", model.GentMassRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentSize", model.GentSize ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentOtherFemale", model.GentOtherFemale ?? (object)DBNull.Value)

                 ,new SqlParameter("@MuscArmsLegs", model.MuscArmsLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@MuscLeftWeekness", model.MuscLeftWeekness)
                 ,new SqlParameter("@MuscLeftSwelling", model.MuscLeftSwelling)
                 ,new SqlParameter("@MuscLeftToneIncDec", model.MuscLeftToneIncDec)
                 ,new SqlParameter("@MuscLeftTender", model.MuscLeftTender)
                 ,new SqlParameter("@MuscLeftImmobile", model.MuscLeftImmobile)
                 ,new SqlParameter("@MuscLeftDecStrength", model.MuscLeftDecStrength)
                 ,new SqlParameter("@MuscRightWeekness", model.MuscRightWeekness)
                 ,new SqlParameter("@MuscRightSwelling", model.MuscRightSwelling)
                 ,new SqlParameter("@MuscRightToneIncDec", model.MuscRightToneIncDec)
                 ,new SqlParameter("@MuscRightTender", model.MuscRightTender)
                 ,new SqlParameter("@MuscRightImmobile", model.MuscRightImmobile)
                 ,new SqlParameter("@MuscRightDecStrength",model.MuscRightDecStrength)
                 ,new SqlParameter("@MuscLaceration",model.MuscLaceration)
                 ,new SqlParameter("@MuscBruise",model.MuscBruise)
                 ,new SqlParameter("@MuscOther", model.MuscOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@FeetHandSymmetry", model.FeetHandSymmetry ?? (object)DBNull.Value)
                 ,new SqlParameter("@FeetHandLeftWeekness", model.FeetHandLeftWeekness )
                 ,new SqlParameter("@FeetHandLeftSwelling", model.FeetHandLeftSwelling )
                 ,new SqlParameter("@FeetHandLeftTender", model.FeetHandLeftTender )
                 ,new SqlParameter("@FeetHandLeftImmobile", model.FeetHandLeftImmobile )
                 ,new SqlParameter("@FeetHandLeftDecStrength", model.FeetHandLeftDecStrength )
                 ,new SqlParameter("@FeetHandLeftLaceration", model.FeetHandLeftLaceration )
                 ,new SqlParameter("@FeetHandLeftBruise", model.FeetHandLeftBruise )
                 ,new SqlParameter("@FeetHandRightWeekness", model.FeetHandRightWeekness )
                 ,new SqlParameter("@FeetHandRightSwelling", model.FeetHandRightSwelling )
                 ,new SqlParameter("@FeetHandRightTender", model.FeetHandRightTender )
                 ,new SqlParameter("@FeetHandRightImmobile", model.FeetHandRightImmobile )
                 ,new SqlParameter("@FeetHandRightDecStrength", model.FeetHandRightDecStrength )
                 ,new SqlParameter("@FeetHandRightLaceration", model.FeetHandRightLaceration )
                 ,new SqlParameter("@FeetHandRightBruise", model.FeetHandRightBruise)
                 ,new SqlParameter("@FeetHandAbleToWalk", model.FeetHandAbleToWalk)
                 ,new SqlParameter("@FeetToes", model.FeetToes ?? (object)DBNull.Value)
                 ,new SqlParameter("@FeetOther", model.FeetOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@NeuroAwake", model.NeuroAwake)
                 ,new SqlParameter("@NeuroAlert", model.NeuroAlert)
                 ,new SqlParameter("@NeuroActive", model.NeuroActive)
                 ,new SqlParameter("@NeuroDecConsciousness", model.NeuroDecConsciousness)
                 ,new SqlParameter("@NeuroAgitated", model.NeuroAgitated)
                 ,new SqlParameter("@NeuroConvelsions", model.NeuroConvelsions)
                 ,new SqlParameter("@NeuroListLess", model.NeuroListLess)
                 ,new SqlParameter("@NeuroLethargic", model.NeuroLethargic)
                 ,new SqlParameter("@NeuroAQAppropriately", model.NeuroAQAppropriately)
                 ,new SqlParameter("@NeuroReflexLeft", model.NeuroReflexLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroReflexRight", model.NeuroReflexRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroDevelopment", model.NeuroDevelopment ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroMotor", model.NeuroMotor)
                 ,new SqlParameter("@NeuroLanguage", model.NeuroLanguage)
                 ,new SqlParameter("@NeuroSocial", model.NeuroSocial)
                 ,new SqlParameter("@NeuroOther", model.NeuroOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@Skin", model.Skin ?? (object)DBNull.Value)
                 ,new SqlParameter("@RashFlate", model.RashFlate)
                 ,new SqlParameter("@RashRaised", model.RashRaised)
                 ,new SqlParameter("@RashErythema", model.RashErythema)
                 ,new SqlParameter("@RashMacules", model.RashMacules)
                 ,new SqlParameter("@RashPapules", model.RashPapules)
                 ,new SqlParameter("@RashPetechiae", model.RashPetechiae)
                 ,new SqlParameter("@RashSize", model.RashSize  ?? (object)DBNull.Value)
                 ,new SqlParameter("@RashOther", model.RashOther  ?? (object)DBNull.Value)
                 ,_error
                ,_message
                ,_ID
            };

            var parms = "@PatientId,@DOB,@Temperature,@BP,@Pulse,@Weight,@WeightPercentile,@Height,@HeightPercentile,@HC,@HCPercentile,@Oxygen,@RR,@Alert,@ListLess,@Jaundice,@Active,@Agitated,@Pale,@Smiling,@Convulsions,@Crying,@NonResponse,@Lethargic,@ColorPink,@Other,@Head,@AntFontAnelle,@PostFontAnelle,@Sutures,@Cephalohematoma,@HeadOther,@EyePupils,@EyeSclera,@EyeConjuctiva,@EyeDischargeLeft,@EyeDischargeRight,@EyeRedReflex,@EyeOther,@EarPennaeLeft,@EarPennaeRight,@EarPennaeNotes,@EarCanalLeft,@EarCanalRight,@EarDischarge,@EarOther,@Mouth,@MouthGums,@MouthTeeth,@MouthOther,@Throat,@Tonsils,@ThroatOther,@Nose,@NoseDischarge,@Neck,@SwollenLymphNode,@NeckLeft,@NeckRight,@NeckOther,@TMLeftNormal,@TMLeftWhite,@TMLeftRed,@TMLeftYellow,@TMLeftBulging,@TMLeftMobile,@TMLeftNonMobile,@TMLeftRaptured,@TMLeftOther,@TMRightNormal,@TMRightWhite,@TMRightRed,@TMRightYellow,@TMRightBulging,@TMRightMobile,@TMRightNonMobile,@TMRightRaptured,@TMDischarge,@TMRightOther,@LungsRespiration,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftDiminshed,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightDiminished,@LungOther,@HeartMurmur,@MurmurRate,@HeartRate,@HeartRythm,@HeartOther,@AbdAbdomen,@AbdTender,@AbdMassQuality,@AbdRebound,@AbdUmbilicalHernia,@AbdInguinalHernialLeft,@AbdInguinalHernialRight,@UmbClean,@UmdDishcharge,@UmbOther,@GentMale,@GentHydrocele,@GentUndescendedLeft,@GentUndescendedRight,@GentHerniaLeft,@GentHerniaRight,@GentPenis,@GentMicro,@GentMeatus,@GentDishcharge,@GentMaleOther,@GentFemale,@GentLabia,@GentUrethra,@GentDischarge,@GentMassLeft,@GentMassRight,@GentSize,@GentOtherFemale,@MuscArmsLegs,@MuscLeftWeekness,@MuscLeftSwelling,@MuscLeftToneIncDec,@MuscLeftTender,@MuscLeftImmobile,@MuscLeftDecStrength,@MuscRightWeekness,@MuscRightSwelling,@MuscRightToneIncDec,@MuscRightTender,@MuscRightImmobile,@MuscRightDecStrength,@MuscLaceration,@MuscBruise,@MuscOther,@FeetHandSymmetry,@FeetHandLeftWeekness,@FeetHandLeftSwelling,@FeetHandLeftTender,@FeetHandLeftImmobile,@FeetHandLeftDecStrength,@FeetHandLeftLaceration,@FeetHandLeftBruise,@FeetHandRightWeekness,@FeetHandRightSwelling,@FeetHandRightTender,@FeetHandRightImmobile,@FeetHandRightDecStrength,@FeetHandRightLaceration,@FeetHandRightBruise,@FeetHandAbleToWalk,@FeetToes,@FeetOther,@NeuroAwake,@NeuroAlert,@NeuroActive,@NeuroDecConsciousness,@NeuroAgitated,@NeuroConvelsions,@NeuroListLess,@NeuroLethargic,@NeuroAQAppropriately,@NeuroReflexLeft,@NeuroReflexRight,@NeuroDevelopment,@NeuroMotor,@NeuroLanguage,@NeuroSocial,@NeuroOther,@Skin,@RashFlate,@RashRaised,@RashErythema,@RashMacules,@RashPapules,@RashPetechiae,@RashSize,@RashOther";
            var res = db.Database.ExecuteSqlCommand("sp_Paeds_PhysicalExamination_Insert " + parms + ",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PaedsExamId = (int)_ID.Value;

            }
            return model;
        }

        public override Paeds_PhysicalExamination Update(Paeds_PhysicalExamination model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
          
            SqlParameter[] parameters =
            {
                  new SqlParameter("@PaedsExamId",model.PaedsExamId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@DOB",model.DOB ?? (object)DBNull.Value)
                 ,new SqlParameter("@Temperature",model.Temperature ?? (object)DBNull.Value)
                 ,new SqlParameter("@BP",model.BP ?? (object)DBNull.Value)
                 ,new SqlParameter("@Pulse",model.Pulse ?? (object)DBNull.Value)
                 ,new SqlParameter("@Weight",model.Weight ?? (object)DBNull.Value)
                 ,new SqlParameter("@WeightPercentile",model.WeightPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@Height",model.Height ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeightPercentile",model.HeightPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@HC",model.HC ?? (object)DBNull.Value)
                 ,new SqlParameter("@HCPercentile",model.HCPercentile ?? (object)DBNull.Value)
                 ,new SqlParameter("@Oxygen",model.Oxygen ?? (object)DBNull.Value)
                 ,new SqlParameter("@RR",model.RR ?? (object)DBNull.Value)
                 ,new SqlParameter("@Alert", model.Alert)
                 ,new SqlParameter("@ListLess", model.ListLess)
                 ,new SqlParameter("@Jaundice", model.Jaundice)
                 ,new SqlParameter("@Active", model.Active)
                 ,new SqlParameter("@Agitated", model.Agitated)
                 ,new SqlParameter("@Pale", model.Pale)
                 ,new SqlParameter("@Smiling", model.Smiling)
                 ,new SqlParameter("@Convulsions", model.Convulsions)
                 ,new SqlParameter("@Crying", model.Crying)
                 ,new SqlParameter("@NonResponse", model.NonResponse)
                 ,new SqlParameter("@Lethargic", model.Lethargic)
                 ,new SqlParameter("@ColorPink", model.ColorPink)
                 ,new SqlParameter("@Other", model.Other)
                 ,new SqlParameter("@Head",model.Head ?? (object)DBNull.Value)
                 ,new SqlParameter("@AntFontAnelle",model.AntFontAnelle ?? (object)DBNull.Value)
                 ,new SqlParameter("@PostFontAnelle",model.PostFontAnelle ?? (object)DBNull.Value)
                 ,new SqlParameter("@Sutures",model.Sutures ?? (object)DBNull.Value)
                 ,new SqlParameter("@Cephalohematoma", model.Cephalohematoma)

                 ,new SqlParameter("@HeadOther", model.HeadOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyePupils", model.EyePupils ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeSclera", model.EyeSclera ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeConjuctiva", model.EyeConjuctiva ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeDischargeLeft", model.EyeDischargeLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeDischargeRight", model.EyeDischargeRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EyeRedReflex", model.EyeRedReflex)
                 ,new SqlParameter("@EyeOther", model.EyeOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@EarPennaeLeft", model.EarPennaeLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarPennaeRight", model.EarPennaeRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarPennaeNotes", model.EarPennaeNotes ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarCanalLeft", model.EarCanalLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarCanalRight", model.EarCanalRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarDischarge", model.EarDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@EarOther", model.EarOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@Mouth", model.Mouth ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthGums", model.MouthGums ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthTeeth", model.MouthTeeth ?? (object)DBNull.Value)
                 ,new SqlParameter("@MouthOther", model.MouthOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@Throat", model.Throat ?? (object)DBNull.Value)
                 ,new SqlParameter("@Tonsils", model.Tonsils ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThroatOther", model.ThroatOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@Nose", model.Nose ?? (object)DBNull.Value)
                 ,new SqlParameter("@NoseDischarge", model.NoseDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@Neck", model.Neck ?? (object)DBNull.Value)
                 ,new SqlParameter("@SwollenLymphNode", model.SwollenLymphNode ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckLeft", model.NeckLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckRight", model.NeckRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeckOther", model.NeckOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@TMLeftNormal", model.TMLeftNormal)
                 ,new SqlParameter("@TMLeftWhite", model.TMLeftWhite)
                 ,new SqlParameter("@TMLeftRed", model.TMLeftRed)
                 ,new SqlParameter("@TMLeftYellow", model.TMLeftYellow)
                 ,new SqlParameter("@TMLeftBulging", model.TMLeftBulging)
                 ,new SqlParameter("@TMLeftMobile", model.TMLeftMobile)
                 ,new SqlParameter("@TMLeftNonMobile", model.TMLeftNonMobile)
                 ,new SqlParameter("@TMLeftRaptured", model.TMLeftRaptured)
                 ,new SqlParameter("@TMLeftOther", model.TMLeftOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@TMRightNormal", model.TMRightNormal)
                 ,new SqlParameter("@TMRightWhite", model.TMRightWhite)
                 ,new SqlParameter("@TMRightRed", model.TMRightRed)
                 ,new SqlParameter("@TMRightYellow", model.TMRightYellow)
                 ,new SqlParameter("@TMRightBulging", model.TMRightBulging)
                 ,new SqlParameter("@TMRightMobile", model.TMRightMobile)
                 ,new SqlParameter("@TMRightNonMobile", model.TMRightNonMobile)
                 ,new SqlParameter("@TMRightRaptured", model.TMRightRaptured)
                 ,new SqlParameter("@TMDischarge", model.TMDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@TMRightOther", model.TMRightOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@LungsRespiration", model.LungsRespiration ?? (object)DBNull.Value)
                 ,new SqlParameter("@LungLeftWheezes", model.LungLeftWheezes)
                 ,new SqlParameter("@LungLeftRhonchi", model.LungLeftRhonchi)
                 ,new SqlParameter("@LungLeftRales", model.LungLeftRales)
                 ,new SqlParameter("@LungLeftPoorAirEntry", model.LungLeftPoorAirEntry)
                 ,new SqlParameter("@LungLeftDiminshed", model.LungLeftDiminshed)

                 ,new SqlParameter("@LungRightWheezes", model.LungRightWheezes)
                 ,new SqlParameter("@LungRightRhonchi", model.LungRightRhonchi)
                 ,new SqlParameter("@LungRightRales", model.LungRightRales)
                 ,new SqlParameter("@LungRightPoorAirEntry", model.LungRightPoorAirEntry)
                 ,new SqlParameter("@LungRightDiminished", model.LungRightDiminished)
                 ,new SqlParameter("@LungOther", model.LungOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@HeartMurmur", model.HeartMurmur)
                 ,new SqlParameter("@MurmurRate", model.MurmurRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRate", model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRythm", model.HeartRythm ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartOther", model.HeartOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@AbdAbdomen", model.AbdAbdomen ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdTender", model.AbdTender ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdMassQuality", model.AbdMassQuality ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdRebound", model.AbdRebound)
                 ,new SqlParameter("@AbdUmbilicalHernia", model.AbdUmbilicalHernia ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdInguinalHernialLeft", model.AbdInguinalHernialLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdInguinalHernialRight", model.AbdInguinalHernialRight ?? (object)DBNull.Value)

                 ,new SqlParameter("@UmbClean", model.UmbClean ?? (object)DBNull.Value)
                 ,new SqlParameter("@UmdDishcharge", model.UmdDishcharge ?? (object)DBNull.Value)
                 ,new SqlParameter("@UmbOther", model.UmbOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@GentMale", model.GentMale ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentHydrocele", model.GentHydrocele)
                 ,new SqlParameter("@GentUndescendedLeft", model.GentUndescendedLeft)
                 ,new SqlParameter("@GentUndescendedRight", model.GentUndescendedRight)
                 ,new SqlParameter("@GentHerniaLeft", model.GentHerniaLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentHerniaRight", model.GentHerniaRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentPenis", model.GentPenis ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMicro", model.GentMicro)
                 ,new SqlParameter("@GentMeatus", model.GentMeatus ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentDishcharge", model.GentDishcharge ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMaleOther", model.GentMaleOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentFemale", model.GentFemale ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentLabia", model.GentLabia ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentUrethra", model.GentUrethra ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentDischarge", model.GentDischarge ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMassLeft", model.GentMassLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentMassRight", model.GentMassRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentSize", model.GentSize ?? (object)DBNull.Value)
                 ,new SqlParameter("@GentOtherFemale", model.GentOtherFemale ?? (object)DBNull.Value)

                 ,new SqlParameter("@MuscArmsLegs", model.MuscArmsLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@MuscLeftWeekness", model.MuscLeftWeekness)
                 ,new SqlParameter("@MuscLeftSwelling", model.MuscLeftSwelling)
                 ,new SqlParameter("@MuscLeftToneIncDec", model.MuscLeftToneIncDec)
                 ,new SqlParameter("@MuscLeftTender", model.MuscLeftTender)
                 ,new SqlParameter("@MuscLeftImmobile", model.MuscLeftImmobile)
                 ,new SqlParameter("@MuscLeftDecStrength", model.MuscLeftDecStrength)
                 ,new SqlParameter("@MuscRightWeekness", model.MuscRightWeekness)
                 ,new SqlParameter("@MuscRightSwelling", model.MuscRightSwelling)
                 ,new SqlParameter("@MuscRightToneIncDec", model.MuscRightToneIncDec)
                 ,new SqlParameter("@MuscRightTender", model.MuscRightTender)
                 ,new SqlParameter("@MuscRightImmobile", model.MuscRightImmobile)
                 ,new SqlParameter("@MuscRightDecStrength",model.MuscRightDecStrength)
                 ,new SqlParameter("@MuscLaceration",model.MuscLaceration)
                 ,new SqlParameter("@MuscBruise",model.MuscBruise)
                 ,new SqlParameter("@MuscOther", model.MuscOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@FeetHandSymmetry", model.FeetHandSymmetry ?? (object)DBNull.Value)
                 ,new SqlParameter("@FeetHandLeftWeekness", model.FeetHandLeftWeekness )
                 ,new SqlParameter("@FeetHandLeftSwelling", model.FeetHandLeftSwelling )
                 ,new SqlParameter("@FeetHandLeftTender", model.FeetHandLeftTender )
                 ,new SqlParameter("@FeetHandLeftImmobile", model.FeetHandLeftImmobile )
                 ,new SqlParameter("@FeetHandLeftDecStrength", model.FeetHandLeftDecStrength )
                 ,new SqlParameter("@FeetHandLeftLaceration", model.FeetHandLeftLaceration )
                 ,new SqlParameter("@FeetHandLeftBruise", model.FeetHandLeftBruise )
                 ,new SqlParameter("@FeetHandRightWeekness", model.FeetHandRightWeekness )
                 ,new SqlParameter("@FeetHandRightSwelling", model.FeetHandRightSwelling )
                 ,new SqlParameter("@FeetHandRightTender", model.FeetHandRightTender )
                 ,new SqlParameter("@FeetHandRightImmobile", model.FeetHandRightImmobile )
                 ,new SqlParameter("@FeetHandRightDecStrength", model.FeetHandRightDecStrength )
                 ,new SqlParameter("@FeetHandRightLaceration", model.FeetHandRightLaceration )
                 ,new SqlParameter("@FeetHandRightBruise", model.FeetHandRightBruise)
                 ,new SqlParameter("@FeetHandAbleToWalk", model.FeetHandAbleToWalk)
                 ,new SqlParameter("@FeetToes", model.FeetToes ?? (object)DBNull.Value)
                 ,new SqlParameter("@FeetOther", model.FeetOther ?? (object)DBNull.Value)

                 ,new SqlParameter("@NeuroAwake", model.NeuroAwake)
                 ,new SqlParameter("@NeuroAlert", model.NeuroAlert)
                 ,new SqlParameter("@NeuroActive", model.NeuroActive)
                 ,new SqlParameter("@NeuroDecConsciousness", model.NeuroDecConsciousness)
                 ,new SqlParameter("@NeuroAgitated", model.NeuroAgitated)
                 ,new SqlParameter("@NeuroConvelsions", model.NeuroConvelsions)
                 ,new SqlParameter("@NeuroListLess", model.NeuroListLess)
                 ,new SqlParameter("@NeuroLethargic", model.NeuroLethargic)
                 ,new SqlParameter("@NeuroAQAppropriately", model.NeuroAQAppropriately)
                 ,new SqlParameter("@NeuroReflexLeft", model.NeuroReflexLeft ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroReflexRight", model.NeuroReflexRight ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroDevelopment", model.NeuroDevelopment ?? (object)DBNull.Value)
                 ,new SqlParameter("@NeuroMotor", model.NeuroMotor)
                 ,new SqlParameter("@NeuroLanguage", model.NeuroLanguage)
                 ,new SqlParameter("@NeuroSocial", model.NeuroSocial)
                 ,new SqlParameter("@NeuroOther", model.NeuroOther ?? (object)DBNull.Value)
                 ,new SqlParameter("@Skin", model.Skin ?? (object)DBNull.Value)
                 ,new SqlParameter("@RashFlate", model.RashFlate)
                 ,new SqlParameter("@RashRaised", model.RashRaised)
                 ,new SqlParameter("@RashErythema", model.RashErythema)
                 ,new SqlParameter("@RashMacules", model.RashMacules)
                 ,new SqlParameter("@RashPapules", model.RashPapules)
                 ,new SqlParameter("@RashPetechiae", model.RashPetechiae)
                 ,new SqlParameter("@RashSize", model.RashSize  ?? (object)DBNull.Value)
                 ,new SqlParameter("@RashOther", model.RashOther  ?? (object)DBNull.Value)

            };

            var parms = "PaedsExamId,@PatientId,@DOB,@Temperature,@BP,@Pulse,@Weight,@WeightPercentile,@Height,@HeightPercentile,@HC,@HCPercentile,@Oxygen,@RR,@Alert,@ListLess,@Jaundice,@Active,@Agitated,@Pale,@Smiling,@Convulsions,@Crying,@NonResponse,@Lethargic,@ColorPink,@Other,@Head,@AntFontAnelle,@PostFontAnelle,@Sutures,@Cephalohematoma,@HeadOther,@EyePupils,@EyeSclera,@EyeConjuctiva,@EyeDischargeLeft,@EyeDischargeRight,@EyeRedReflex,@EyeOther,@EarPennaeLeft,@EarPennaeRight,@EarPennaeNotes,@EarCanalLeft,@EarCanalRight,@EarDischarge,@EarOther,@Mouth,@MouthGums,@MouthTeeth,@MouthOther,@Throat,@Tonsils,@ThroatOther,@Nose,@NoseDischarge,@Neck,@SwollenLymphNode,@NeckLeft,@NeckRight,@NeckOther,@TMLeftNormal,@TMLeftWhite,@TMLeftRed,@TMLeftYellow,@TMLeftBulging,@TMLeftMobile,@TMLeftNonMobile,@TMLeftRaptured,@TMLeftOther,@TMRightNormal,@TMRightWhite,@TMRightRed,@TMRightYellow,@TMRightBulging,@TMRightMobile,@TMRightNonMobile,@TMRightRaptured,@TMDischarge,@TMRightOther,@LungsRespiration,@LungLeftWheezes,@LungLeftRhonchi,@LungLeftRales,@LungLeftPoorAirEntry,@LungLeftDiminshed,@LungRightWheezes,@LungRightRhonchi,@LungRightRales,@LungRightPoorAirEntry,@LungRightDiminished,@LungOther,@HeartMurmur,@MurmurRate,@HeartRate,@HeartRythm,@HeartOther,@AbdAbdomen,@AbdTender,@AbdMassQuality,@AbdRebound,@AbdUmbilicalHernia,@AbdInguinalHernialLeft,@AbdInguinalHernialRight,@UmbClean,@UmdDishcharge,@UmbOther,@GentMale,@GentHydrocele,@GentUndescendedLeft,@GentUndescendedRight,@GentHerniaLeft,@GentHerniaRight,@GentPenis,@GentMicro,@GentMeatus,@GentDishcharge,@GentMaleOther,@GentFemale,@GentLabia,@GentUrethra,@GentDischarge,@GentMassLeft,@GentMassRight,@GentSize,@GentOtherFemale,@MuscArmsLegs,@MuscLeftWeekness,@MuscLeftSwelling,@MuscLeftToneIncDec,@MuscLeftTender,@MuscLeftImmobile,@MuscLeftDecStrength,@MuscRightWeekness,@MuscRightSwelling,@MuscRightToneIncDec,@MuscRightTender,@MuscRightImmobile,@MuscRightDecStrength,@MuscLaceration,@MuscBruise,@MuscOther,@FeetHandSymmetry,@FeetHandLeftWeekness,@FeetHandLeftSwelling,@FeetHandLeftTender,@FeetHandLeftImmobile,@FeetHandLeftDecStrength,@FeetHandLeftLaceration,@FeetHandLeftBruise,@FeetHandRightWeekness,@FeetHandRightSwelling,@FeetHandRightTender,@FeetHandRightImmobile,@FeetHandRightDecStrength,@FeetHandRightLaceration,@FeetHandRightBruise,@FeetHandAbleToWalk,@FeetToes,@FeetOther,@NeuroAwake,@NeuroAlert,@NeuroActive,@NeuroDecConsciousness,@NeuroAgitated,@NeuroConvelsions,@NeuroListLess,@NeuroLethargic,@NeuroAQAppropriately,@NeuroReflexLeft,@NeuroReflexRight,@NeuroDevelopment,@NeuroMotor,@NeuroLanguage,@NeuroSocial,@NeuroOther,@Skin,@RashFlate,@RashRaised,@RashErythema,@RashMacules,@RashPapules,@RashPetechiae,@RashSize,@RashOther";
            var res = db.Database.ExecuteSqlCommand("sp_Paeds_PhysicalExamination_Update " + parms, parameters);

            outparam.Error = res > 0 ? false : true;
          
            return model;
        }

        public override List<Paeds_PhysicalExamination> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Paeds_PhysicalExamination>("exec sp_Paeds_PhysicalExamination_SelectAll").ToList();
            return res;
        }
        public override Paeds_PhysicalExamination SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<Paeds_PhysicalExamination>("exec sp_Paeds_PhysicalExamination_SelectByID @PaedsExamId", new SqlParameter("@PaedsExamId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override Paeds_PhysicalExamination Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_Paeds_PhysicalExamination_Delete @PaedsExamId", new SqlParameter("@PaedsExamId", ID));
            outparam.Error = result > 0 ? false : true;
            return new Paeds_PhysicalExamination();
        }
        public Paeds_PhysicalExamination PopulateByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Paeds_PhysicalExamination>("exec sp_Paeds_PhysicalExamination_Populate @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList().FirstOrDefault();
            return res;
        }
    }
}