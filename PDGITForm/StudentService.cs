using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDGIT1730
{
   public class StudentService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentInfoDBConnectionString"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
      
        public bool Insert(student studentInfo) {
            try
            {
                cmd = new SqlCommand("insert into [StudentInfo](StuName,StuRoll,StuAge,Gender) values(@StuName,@StuRoll,@StuAge,@Gender)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@StuName", studentInfo.Name);
                cmd.Parameters.AddWithValue("@StuRoll", studentInfo.Roll);
                cmd.Parameters.AddWithValue("@StuAge", studentInfo.Age);
                cmd.Parameters.AddWithValue("@Gender", studentInfo.Gender);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return true;
            }


        }
    }
}
