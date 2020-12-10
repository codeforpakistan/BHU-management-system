using MaternityCareSystem.Domain;
using MaternityCareSystem.Models;
using MaternityCareSystem.Models.ProcModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.BL
{
    public class ChartsBL: VirtualCrud<Charts>
    {
        public List<Charts> GetAll(string condition, out OutParamModel outparam)
        {
            outparam = new OutParamModel();

            var result = db.Database.SqlQuery<Charts>("sp_GrowthChart @Condition", new SqlParameter("@Condition", condition)).ToList();
            return result;
        }
        public DataSet GetDataSet(string storedProcedureName, params object[] parameters)
        {
            DataSet dataSet = new DataSet();
            var connection = db.Database.Connection;
            SqlCommand command = new SqlCommand(storedProcedureName, (SqlConnection)connection);
            connection.Open();
            foreach (SqlParameter param in parameters)
            {
                command.Parameters.Add(param);
            }
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dataSet);
            connection.Close();
            return dataSet;
        }
    }
}