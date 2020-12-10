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
    public class SpecBL: VirtualCrud<Specialization>
    {
        public override Specialization Save(Specialization model, out OutParamModel outparam)
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
                 new SqlParameter("@Name",model.Name ?? (object)DBNull.Value)
                ,_error
                ,_message
                ,_ID
            };

            var spec = db.Database.ExecuteSqlCommand("sp_Specialization_Insert @Name,@Error out,@Message out,@ID out", parameters);

            outparam.Error = (bool)_error.Value;
            outparam.Message = _message.Value.ToString();
            if (!outparam.Error)
            {
                outparam.IDInt32 = (int)_ID.Value;
                model.SpecializationId = (int)_ID.Value;
              
            }
            return model;
        }
        public override List<Specialization> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var specs = db.Database.SqlQuery<Specialization>("exec sp_Specialization_SelectAll").ToList();
            return specs;
        }
        public override Specialization Delete(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var spec = db.Database.ExecuteSqlCommand("sp_Specialization_Delete @Id", new SqlParameter("@Id",ID));
            outparam.Error = spec > 0 ? false : true;
            return new Specialization();
        }
        public override Specialization SelectByID(int ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var specs = db.Database.SqlQuery<Specialization>("exec sp_Specialization_SelectByID @Id",new SqlParameter("@Id",ID)).ToList().FirstOrDefault();
            return specs;
        }
        public override Specialization Update(Specialization entity, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var spec = db.Database.ExecuteSqlCommand("sp_Specialization_Update @Id,@Name", new SqlParameter("@Id",entity.SpecializationId),new SqlParameter("@Name",entity.Name));
            outparam.Error = spec > 0 ? false : true;
            return entity;
        }

        public List<Specialization> SpecDDL(out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<Specialization>("exec sp_Specializations_Dropdown").ToList();
            return res;
        }
    }
}