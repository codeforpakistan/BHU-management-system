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
    public class PaedsBL:VirtualCrud<PaedsForm>
    {

        public override PaedsForm Save(PaedsForm model, out OutParamModel outparam)
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
                 ,new SqlParameter("@ChiefComplaint",model.ChiefComplaint ?? (object)DBNull.Value)
                 ,new SqlParameter("@IllnessHistory",model.IllnessHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentMedication",model.CurrentMedication ?? (object)DBNull.Value)
                 ,new SqlParameter("@BCG",model.BCG)
                 ,new SqlParameter("@PolioDate1",model.PolioDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate2",model.PolioDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate3",model.PolioDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate4",model.PolioDate4 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate1",model.DPTDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate2",model.DPTDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate3",model.DPTDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate4",model.DPTDate4 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate1",model.HepBDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate2",model.HepBDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate3",model.HepBDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate1",model.HepADate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate2",model.HepADate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate3",model.HepADate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@Other",model.Other ?? (object)DBNull.Value)
                 ,new SqlParameter("@OtherDate",model.OtherDate ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };
            var parms = "@PatientId,@ChiefComplaint,@IllnessHistory,@CurrentMedication,@BCG,@PolioDate1,@PolioDate2,@PolioDate3,@PolioDate4,@DPTDate1,@DPTDate2,@DPTDate3,@DPTDate4,@HepBDate1,@HepBDate2,@HepBDate3,@HepADate1,@HepADate2,@HepADate3,@Other,@OtherDate";
            var res = db.Database.ExecuteSqlCommand("sp_PaedsForm_Insert "+ parms + ",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PaedsFormId = (int)_ID.Value;

            }
            return model;
        }

        public override PaedsForm Update(PaedsForm model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                  new SqlParameter("@PaedsFormId",model.PaedsFormId)
                 ,new SqlParameter("@PatientId",model.PatientId ?? (object)DBNull.Value)
                 ,new SqlParameter("@ChiefComplaint",model.ChiefComplaint ?? (object)DBNull.Value)
                 ,new SqlParameter("@IllnessHistory",model.IllnessHistory ?? (object)DBNull.Value)
                 ,new SqlParameter("@CurrentMedication",model.CurrentMedication ?? (object)DBNull.Value)
                  ,new SqlParameter("@BCG",model.BCG)
                 ,new SqlParameter("@PolioDate1",model.PolioDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate2",model.PolioDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate3",model.PolioDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@PolioDate4",model.PolioDate4 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate1",model.DPTDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate2",model.DPTDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate3",model.DPTDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@DPTDate4",model.DPTDate4 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate1",model.HepBDate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate2",model.HepBDate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepBDate3",model.HepBDate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate1",model.HepADate1 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate2",model.HepADate2 ?? (object)DBNull.Value)
                 ,new SqlParameter("@HepADate3",model.HepADate3 ?? (object)DBNull.Value)
                 ,new SqlParameter("@Other",model.Other ?? (object)DBNull.Value)
                 ,new SqlParameter("@OtherDate",model.OtherDate ?? (object)DBNull.Value)

            };
            var parms = "@PaedsFormId,@PatientId,@ChiefComplaint,@IllnessHistory,@CurrentMedication,@BCG,@PolioDate1,@PolioDate2,@PolioDate3,@PolioDate4,@DPTDate1,@DPTDate2,@DPTDate3,@DPTDate4,@HepBDate1,@HepBDate2,@HepBDate3,@HepADate1,@HepADate2,@HepADate3,@Other,@OtherDate";
            var res = db.Database.ExecuteSqlCommand("sp_PaedsForm_Update "+ parms, parameters);
            outparam.Error = res > 0 ? false : true;
            return model;
        }
        public override List<PaedsForm> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<PaedsForm>("exec sp_PaedsForm_SelectAll").ToList();
            return res;
        }
        public override PaedsForm SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PaedsForm>("exec sp_PaedsForm_SelectByID @PaedsFormId", new SqlParameter("@PaedsFormId", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override PaedsForm Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_PaedsForm_Delete @PaedsFormId", new SqlParameter("@PaedsFormId", ID));
            outparam.Error = result > 0 ? false : true;
            return new PaedsForm();
        }
    }
}