using LscWebApp.Constant;
using LscWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LscServices
{
    public class GetEmployeeData : IGetEmployeeData
    {
        public List<EmployeeDataModel> GetAllEmployeeData()
        {
            List<EmployeeDataModel> employeeDataModels = new List<EmployeeDataModel>();

            SqlConnection connection = new SqlConnection(LscConstant.ConnectionString);
            {
                    connection.Open();
                    SqlDataAdapter daAuthors = new SqlDataAdapter("Select * from [dbo].[tblSaggezian]", connection);

                    DataSet dataSet = new DataSet();
                    daAuthors.Fill(dataSet);

                    DataTable tblSaggezian;
                    tblSaggezian = dataSet.Tables[0];

                    foreach (DataRow drCurrent in tblSaggezian.Rows)
                    {
                        EmployeeDataModel mode = new EmployeeDataModel();
                        mode.Age = Convert.ToInt32(drCurrent["Age"]);
                        mode.Designation = (drCurrent["Designation"]).ToString();
                        mode.Name = (drCurrent["Name"]).ToString();
                        employeeDataModels.Add(mode);
                    }

                    connection.Close();
            }

            return employeeDataModels;
        }
    }
}
