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
    public class DoctorBL:VirtualCrud<DoctorInfo>
    {
        public override DoctorInfo Save(DoctorInfo model, out OutParamModel outparam)
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
                 new SqlParameter("@DoctorName",model.DoctorName ?? (object)DBNull.Value)
                ,new SqlParameter("@Phone",model.Phone ?? (object)DBNull.Value)
                ,new SqlParameter("@IsAvailable",model.IsAvailable)
                ,new SqlParameter("@Address",model.Address ?? (object)DBNull.Value)
                ,new SqlParameter("@SpecializationId",model.SpecializationId ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var parms = "@DoctorName,@Phone,@IsAvailable,@Address,@SpecializationId";
            var res = db.Database.ExecuteSqlCommand("sp_DoctorInfo_Insert "+parms+",@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.DoctorId = (int)_ID.Value;

            }
            return model;
        }
        public override DoctorInfo Update(DoctorInfo model, out OutParamModel outparam)
        {
            
            SqlParameter[] parameters =
           {
                 new SqlParameter("@DoctorId",model.DoctorId)
                ,new SqlParameter("@DoctorName",model.DoctorName ?? (object)DBNull.Value)
                ,new SqlParameter("@Phone",model.Phone ?? (object)DBNull.Value)
                ,new SqlParameter("@IsAvailable",model.IsAvailable)
                ,new SqlParameter("@Address",model.Address ?? (object)DBNull.Value)
                ,new SqlParameter("@SpecializationId",model.SpecializationId ?? (object)DBNull.Value)
             
            };
            var parms = "@DoctorId,@DoctorName,@Phone,@IsAvailable,@Address,@SpecializationId";
            var res = db.Database.ExecuteSqlCommand("sp_DoctorInfo_Update " + parms, parameters);
            outparam = new OutParamModel();
            outparam.Error = res > 0 ? false : true;
            return model;
        }

        public override List<DoctorInfo> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<DoctorInfo>("Exec sp_DoctorInfo_SelectAll").ToList();
            return res;
        }

        public override DoctorInfo SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<DoctorInfo>("sp_DoctorInfo_SelectByID @DoctorId", new SqlParameter("@DoctorId", ID)).ToList().FirstOrDefault();
            return res;
        }

        public override DoctorInfo Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var result = db.Database.ExecuteSqlCommand("sp_DoctorInfo_Delete @DoctorId", new SqlParameter("@DoctorId", ID));
            outparam.Error = result > 0 ? false : true;
            return new DoctorInfo();
        }
    }
}