using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Director_of_Entry_AND_Exit.Business_Layer
{
    class Cls_login
    {
        public DataTable login(string ID, String PWD)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.selectData("SP_LODIN", param);
            dal.close();

            return Dt;
        }

        public void EDIT_NEW_USER(string ID_USER, string PWD_USER, string USER_TYAP,
                                    int Salary_USER, float Hours_of_work_USER, string Full_Name_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@PWD_USER", SqlDbType.VarChar, 50);
            param[1].Value = PWD_USER;

            param[2] = new SqlParameter("@USER_TYAP", SqlDbType.VarChar, 50);
            param[2].Value = USER_TYAP;

            param[3] = new SqlParameter("@Salary_USER", SqlDbType.Int);
            param[3].Value = Salary_USER;

            param[4] = new SqlParameter("@Hours_of_work_USER", SqlDbType.Float);
            param[4].Value = Hours_of_work_USER;

            param[5] = new SqlParameter("@Full_Name_USER", SqlDbType.VarChar, 50);
            param[5].Value = Full_Name_USER;

            dal.executeCommand("EDIT_NEW_USER", param);
            dal.close();
        }

        public void ADD_NEW_USER(string ID_USER, string PWD_USER, string USER_TYAP,
                                    int Salary_USER, float Hours_of_work_USER, string Full_Name_USER, int ID_Working_time , int ID_Sections)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@PWD_USER", SqlDbType.VarChar, 50);
            param[1].Value = PWD_USER;

            param[2] = new SqlParameter("@USER_TYAP", SqlDbType.VarChar, 50);
            param[2].Value = USER_TYAP;

            param[3] = new SqlParameter("@Salary_USER", SqlDbType.Int);
            param[3].Value = Salary_USER;

            param[4] = new SqlParameter("@Hours_of_work_USER", SqlDbType.Float);
            param[4].Value = Hours_of_work_USER;

            param[5] = new SqlParameter("@Full_Name_USER", SqlDbType.VarChar, 50);
            param[5].Value = Full_Name_USER;

            param[6] = new SqlParameter("@ID_Working_time", SqlDbType.Int);
            param[6].Value = ID_Working_time;

            param[7] = new SqlParameter("@ID_Sections", SqlDbType.Int);
            param[7].Value = ID_Sections;

            dal.executeCommand("ADD_NEW_USER", param);
            dal.close();
        }

        public DataTable get_Full_Name_USER(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Full_Name_USER", param);
            dal.close();

            return Dt;
        }

        public void get_Full_Name_USERr(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dal.executeCommand("get_Full_Name_USER", param);
            dal.close();
        }

        
    }
}
