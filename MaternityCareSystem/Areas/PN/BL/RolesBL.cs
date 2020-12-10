using MaternityCareSystem.Domain;
using MaternityCareSystem.Models;
using MaternityCareSystem.Models.ProcModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MaternityCareSystem.Areas.PN.BL
{
    public class RolesBL:VirtualCrud<RolesViewModel>
    {
        public override List<RolesViewModel> SelectAll(out OutParamModel outparam)
        {
            outparam = new OutParamModel();

            var result = db.Database.SqlQuery<RolesViewModel>("sp_Roles_SelectAll").ToList();
            return result;
        }
        public override RolesViewModel SelectByID(string ID, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            var res = db.Database.SqlQuery<RolesViewModel>("exec sp_Roles_SelectByID @ID", new SqlParameter("@ID", ID)).ToList().FirstOrDefault();
            return res;
        }
        public override RolesViewModel Update(RolesViewModel model, out OutParamModel outparam)
        {
            outparam = new OutParamModel();
            SqlParameter[] parameters =
            {
                  new SqlParameter("@Id", model.Id)
                 ,new SqlParameter("@Role", model.Role ?? (object)DBNull.Value)
                 ,new SqlParameter("@UserName", model.UserName ?? (object)DBNull.Value)
                 ,new SqlParameter("@Email", model.Email ?? (object)DBNull.Value)
                 ,new SqlParameter("@IsLocked", model.IsLocked)

            };

            var res = db.Database.ExecuteSqlCommand("sp_Roles_Update @Id,@Role,@UserName,@Email,@IsLocked", parameters);

            outparam.Error = res > 0 ? false : true;
            return model;
        }

        public bool UserIsLock(string userName)
        {
            var res = db.Database.SqlQuery<ApplicationUser>("exec sp_Roles_IsLoked @UserName", new SqlParameter("@UserName", userName)).ToList().FirstOrDefault();
            if (res != null)
            { 
                
            if (res.IsLocked == true)
                return false;
            else
                    return true;

            }
            else
                return true;
        }

    }
}