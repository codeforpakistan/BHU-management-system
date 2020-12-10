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
    public class PatientBL : VirtualCrud<PatientInfo>
    {
        public override PatientInfo Save(PatientInfo model, out OutParamModel outparam)
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
                 new SqlParameter("@PatientName",model.PatientName ?? (object)DBNull.Value)
                ,new SqlParameter("@DOB",model.DOB ?? (object)DBNull.Value)
                ,new SqlParameter("@PatientAge",model.PatientAge ?? (object)DBNull.Value)
                ,new SqlParameter("@GuardianRelation",model.GuardianRelation ?? (object)DBNull.Value)
                ,new SqlParameter("@Gender", model.Gender ?? (object)DBNull.Value)
                ,new SqlParameter("@ContactNumber",model.ContactNumber ?? (object)DBNull.Value)
                ,new SqlParameter("@CNIC",model.CNIC ?? (object)DBNull.Value)
                ,new SqlParameter("@Address",model.Address ?? (object)DBNull.Value)
                ,_message
                ,_error
                ,_ID
            };

            var pat = db.Database.ExecuteSqlCommand("sp_Patient_Insert @PatientName,@DOB,@PatientAge,@GuardianRelation,@Gender,@ContactNumber,@CNIC,@Address,@Message out, @Error out,@ID out"
             , parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.PatientId = (int)_ID.Value;
            }

            return model;
        }

        public List<PatientInfo> SelectAll(int pageNo, int pageSize, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter _TotalRecords = new SqlParameter()
            {
                ParameterName = "@TotalRecords",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int

            };
            SqlParameter[] parameters =
              {
                 new SqlParameter("@PageNumber",pageNo)
                ,new SqlParameter("@PageSize",pageSize)
                ,_TotalRecords
            };
            var result = db.Database.SqlQuery<PatientInfo>("exec sp_Patient_SelectAll @PageNumber,@PageSize,@TotalRecords out", parameters).ToList();
            outparam.TotalRecords = (int)_TotalRecords.Value;
            return result;
        }
        public override PatientInfo Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_Patient_Delete @Id", new SqlParameter("@Id", ID));
            outparam.Error = result > 0 ? false : true;
            return new PatientInfo();
        }
        public override PatientInfo SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.SqlQuery<PatientInfo>("exec sp_Patient_SelectByID @Id", new SqlParameter("@Id", ID)).ToList().FirstOrDefault();
            return result;
        }
        public override PatientInfo Update(PatientInfo model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                 new SqlParameter("@PatientId",model.PatientId)
                ,new SqlParameter("@PatientName",model.PatientName ?? (object)DBNull.Value)
                ,new SqlParameter("@DOB",model.DOB ?? (object)DBNull.Value)
                ,new SqlParameter("@PatientAge",model.PatientAge ?? (object)DBNull.Value)
                ,new SqlParameter("@GuardianRelation",model.GuardianRelation ?? (object)DBNull.Value)
                ,new SqlParameter("@Gender", model.Gender ?? (object)DBNull.Value)
                ,new SqlParameter("@ContactNumber",model.ContactNumber ?? (object)DBNull.Value)
                ,new SqlParameter("@CNIC",model.CNIC ?? (object)DBNull.Value)
                ,new SqlParameter("@Address",model.Address ?? (object)DBNull.Value)
            };
            var result = db.Database.ExecuteSqlCommand("sp_Patient_Update @PatientId,@PatientName,@DOB,@PatientAge,@GuardianRelation,@Gender,@ContactNumber,@CNIC,@Address", parameters);
            outparam.Error = result > 0 ? false : true;
            return model;
        }

        public List<PatientInfo> SeachPatientByMrNumber(int mrNumber, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var patients = db.Database.SqlQuery<PatientInfo>("exec sp_Patient_Search @MrNumber", new SqlParameter("@MrNumber", mrNumber)).ToList();
            return patients;
        }
    }
}