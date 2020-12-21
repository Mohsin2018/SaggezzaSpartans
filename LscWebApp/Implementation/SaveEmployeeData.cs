using LscWebApp.Constant;
using LscWebApp.Models;
using System.Data.SqlClient;

namespace LscWebApp
{
    public class SaveEmployeeData : ISaveEmployeeData
    {
        public void SaveAllEmployeeData(EmployeeDataModel employeeDataModel)
        {
            SqlConnection conn = new SqlConnection(LscConstant.ConnectionString);
            {
                SqlCommand cmd = new SqlCommand("exec [dbo].[InsertData]   @Name, @Designation, @Age", conn);
                {
                    cmd.Parameters.AddWithValue("@Name", employeeDataModel.Name);
                    cmd.Parameters.AddWithValue("@Designation", employeeDataModel.Designation);
                    cmd.Parameters.AddWithValue("@Age", employeeDataModel.Age);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
