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
    public class UltrasoundBL:VirtualCrud<Ultrasound>
    {
        public override Ultrasound Save(Ultrasound model, out OutParamModel outparam)
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
                 ,new SqlParameter("@Date", model.Date ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualPeriod", model.LastMenstrualPeriod ?? (object)DBNull.Value)
                 ,new SqlParameter("@EDD", model.EDD ?? (object)DBNull.Value)
                 ,new SqlParameter("@EGA", model.EGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@Placenta", model.Placenta ?? (object)DBNull.Value)
                 ,new SqlParameter("@Grade", model.Grade ?? (object)DBNull.Value)
                 ,new SqlParameter("@Cord", model.Cord ?? (object)DBNull.Value)
                 ,new SqlParameter("@AmnioticFluidVolume", model.AmnioticFluidVolume ?? (object)DBNull.Value)
                 ,new SqlParameter("@AFI", model.AFI ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gender", model.Gender ?? (object)DBNull.Value)
                 ,new SqlParameter("@NoOfFetuses", model.NoOfFetuses ?? (object)DBNull.Value)
                 ,new SqlParameter("@Position", model.Position ?? (object)DBNull.Value)
                 ,new SqlParameter("@Breathing", model.Breathing)
                 ,new SqlParameter("@Movement", model.Movement)
                 ,new SqlParameter("@Face", model.Face ?? (object)DBNull.Value)
                 ,new SqlParameter("@Brain", model.Brain ?? (object)DBNull.Value)
                 ,new SqlParameter("@Spine", model.Spine ?? (object)DBNull.Value)
                 ,new SqlParameter("@Lungs", model.Lungs ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartChamber", model.HeartChamber )
                 ,new SqlParameter("@HeartCondition", model.HeartCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRate", model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@Stomach", model.Stomach ?? (object)DBNull.Value)
                 ,new SqlParameter("@CordInsertion", model.CordInsertion ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtLeftArms", model.ExtLeftArms ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtLeftLegs", model.ExtLeftLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtRightArms", model.ExtRightArms ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtRightLegs", model.ExtRightLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@CRL", model.CRL ?? (object)DBNull.Value)
                 ,new SqlParameter("@CRLEGA", model.CRLEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@FemurLength", model.FemurLength ?? (object)DBNull.Value)
                 ,new SqlParameter("@FemurLengthEGA", model.FemurLengthEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@BPD", model.BPD ?? (object)DBNull.Value)
                 ,new SqlParameter("@BPDEGA", model.BPDEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeadCircumference", model.HeadCircumference ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeadCircumferenceEGA", model.HeadCircumferenceEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdCircumference", model.AbdCircumference ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdEGA", model.AbdEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@EFetalWeight", model.EFetalWeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdFermurLength", model.ThirdFermurLength ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdBPD", model.ThirdBPD ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdEGA", model.ThirdEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdEstimatedFetalWeight", model.ThirdEstimatedFetalWeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Comments", model.Comments ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };
            var parms = "@PatientId,@Date,@LastMenstrualPeriod,@EDD,@EGA,@Placenta,@Grade,@Cord,@AmnioticFluidVolume,@AFI,@Gender,@NoOfFetuses,@Position,@Breathing,@Movement,@Face,@Brain,@Spine,@Lungs,@HeartChamber,@HeartCondition,@HeartRate,@Stomach,@CordInsertion,@ExtLeftArms,@ExtRightArms,@ExtLeftLegs,@ExtRightLegs,@CRL,@CRLEGA,@FemurLength,@FemurLengthEGA,@BPD,@BPDEGA,@HeadCircumference,@HeadCircumferenceEGA,@AbdCircumference,@AbdEGA,@EFetalWeight,@ThirdFermurLength,@ThirdBPD,@ThirdEGA,@ThirdEstimatedFetalWeight,@Comments";

            var res = db.Database.ExecuteSqlCommand("sp_Ultrasound_Insert " + parms + ",@Error out,@Message out,@ID out"
            , parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.UltrasoundId = (int)_ID.Value;
            }

            return model;
        }
        public override Ultrasound Update(Ultrasound model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                  new SqlParameter("@UltrasoundId", model.UltrasoundId)
                 ,new SqlParameter("@PatientId", model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@Date", model.Date ?? (object)DBNull.Value)
                 ,new SqlParameter("@LastMenstrualPeriod", model.LastMenstrualPeriod ?? (object)DBNull.Value)
                 ,new SqlParameter("@EDD", model.EDD ?? (object)DBNull.Value)
                 ,new SqlParameter("@EGA", model.EGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@Placenta", model.Placenta ?? (object)DBNull.Value)
                 ,new SqlParameter("@Grade", model.Grade ?? (object)DBNull.Value)
                 ,new SqlParameter("@Cord", model.Cord ?? (object)DBNull.Value)
                 ,new SqlParameter("@AmnioticFluidVolume", model.AmnioticFluidVolume ?? (object)DBNull.Value)
                 ,new SqlParameter("@AFI", model.AFI ?? (object)DBNull.Value)
                 ,new SqlParameter("@Gender", model.Gender ?? (object)DBNull.Value)
                 ,new SqlParameter("@NoOfFetuses", model.NoOfFetuses ?? (object)DBNull.Value)
                 ,new SqlParameter("@Position", model.Position ?? (object)DBNull.Value)
                 ,new SqlParameter("@Breathing", model.Breathing)
                 ,new SqlParameter("@Movement", model.Movement)
                 ,new SqlParameter("@Face", model.Face ?? (object)DBNull.Value)
                 ,new SqlParameter("@Brain", model.Brain ?? (object)DBNull.Value)
                 ,new SqlParameter("@Spine", model.Spine ?? (object)DBNull.Value)
                 ,new SqlParameter("@Lungs", model.Lungs ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartChamber", model.HeartChamber)
                 ,new SqlParameter("@HeartCondition", model.HeartCondition ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeartRate", model.HeartRate ?? (object)DBNull.Value)
                 ,new SqlParameter("@Stomach", model.Stomach ?? (object)DBNull.Value)
                 ,new SqlParameter("@CordInsertion", model.CordInsertion ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtLeftArms", model.ExtLeftArms ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtLeftLegs", model.ExtLeftLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtRightArms", model.ExtRightArms ?? (object)DBNull.Value)
                 ,new SqlParameter("@ExtRightLegs", model.ExtRightLegs ?? (object)DBNull.Value)
                 ,new SqlParameter("@CRL", model.CRL ?? (object)DBNull.Value)
                 ,new SqlParameter("@CRLEGA", model.CRLEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@FemurLength", model.FemurLength ?? (object)DBNull.Value)
                 ,new SqlParameter("@FemurLengthEGA", model.FemurLengthEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@BPD", model.BPD ?? (object)DBNull.Value)
                 ,new SqlParameter("@BPDEGA", model.BPDEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeadCircumference", model.HeadCircumference ?? (object)DBNull.Value)
                 ,new SqlParameter("@HeadCircumferenceEGA", model.HeadCircumferenceEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdCircumference", model.AbdCircumference ?? (object)DBNull.Value)
                 ,new SqlParameter("@AbdEGA", model.AbdEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@EFetalWeight", model.EFetalWeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdFermurLength", model.ThirdFermurLength ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdBPD", model.ThirdBPD ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdEGA", model.ThirdEGA ?? (object)DBNull.Value)
                 ,new SqlParameter("@ThirdEstimatedFetalWeight", model.ThirdEstimatedFetalWeight ?? (object)DBNull.Value)
                 ,new SqlParameter("@Comments", model.Comments ?? (object)DBNull.Value)

            };
            var parms = "@UltrasoundId,@PatientId,@Date,@LastMenstrualPeriod,@EDD,@EGA,@Placenta,@Grade,@Cord,@AmnioticFluidVolume,@AFI,@Gender,@NoOfFetuses,@Position,@Breathing,@Movement,@Face,@Brain,@Spine,@Lungs,@HeartChamber,@HeartCondition,@HeartRate,@Stomach,@CordInsertion,@ExtLeftArms,@ExtRightArms,@ExtLeftLegs,@ExtRightLegs,@CRL,@CRLEGA,@FemurLength,@FemurLengthEGA,@BPD,@BPDEGA,@HeadCircumference,@HeadCircumferenceEGA,@AbdCircumference,@AbdEGA,@EFetalWeight,@ThirdFermurLength,@ThirdBPD,@ThirdEGA,@ThirdEstimatedFetalWeight,@Comments";
            var res = db.Database.ExecuteSqlCommand("sp_Ultrasound_Update " + parms, parameters);

            outparam.Error = res > 0 ? false : true;
            return model;

        }

        public override List<Ultrasound> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Ultrasound>("exec sp_Ultrasound_SelectAll").ToList();
            return res;
        }

        public override Ultrasound SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Ultrasound>("exec sp_Ultrasound_SelectByID @UltrasoundId", new SqlParameter("@UltrasoundId", ID)).ToList().FirstOrDefault();
            return res;
        }
        public override Ultrasound Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.ExecuteSqlCommand("sp_Ultrasound_Delete @UltrasoundId", new SqlParameter("@UltrasoundId", ID));
            outparam.Error = res > 0 ? false : true;
            return new Ultrasound();
        }
    }
}