using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Director_of_Entry_AND_Exit.Business_Layer
{
    class Cls_Entry_AND_Exit
    {
        public void ADD_TIMING(string ID_USER, string Entry, string Text_1,
                               string Exit_, string Text_2, string subtract, string Date)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@Entry", SqlDbType.VarChar, 50);
            param[0].Value = Entry;

            param[1] = new SqlParameter("@Text_1", SqlDbType.VarChar, 50);
            param[1].Value = Text_1;

            param[2] = new SqlParameter("@Exit_", SqlDbType.VarChar, 50);
            param[2].Value = Exit_;

            param[3] = new SqlParameter("@Text_2", SqlDbType.VarChar, 50);
            param[3].Value = Text_2;

            param[4] = new SqlParameter("@subtract", SqlDbType.VarChar, 50);
            param[4].Value = subtract;

            param[5] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[5].Value = ID_USER;

            param[6] = new SqlParameter("@Date", SqlDbType.VarChar, 50);
            param[6].Value = Date;

            dal.executeCommand("add_timing_", param);
            dal.close();
        }

        public DataTable Get_all_and_shawIt()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Get_all_and_shawIt", null);
            dal.close();

            return Dt;
        }

        public DataTable Get_all_and_shawIt_USER()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Get_all_and_shawIt_USER", null);
            dal.close();

            return Dt;
        }

        public DataTable Search(String ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search", param);
            dal.close();

            return Dt;
        }

        public DataTable Search_between_date(string ID_USER, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_between_date", param);
            dal.close();

            return Dt;
        }

        public DataTable Search_USER(String ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_USER", param);
            dal.close();

            return Dt;
        }

        public void Delete(int ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Entry", SqlDbType.Int);
            param[0].Value = ID;

            dal.executeCommand("Delete", param);
            dal.close();
        }

        public void Delete_USER(string ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            dal.executeCommand("Delete_USER", param);
            dal.close();
        }

        public void delete_Salary(int ID_Salary)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Salary", SqlDbType.Int);
            param[0].Value = ID_Salary;

            dal.executeCommand("delete_Salary", param);
            dal.close();
        }

        public void add_Entry_TableE(string ID_USER, DateTime Date_Entry, int Entry_H,
                               int Entry_M, int Entry_S, string Text_Entry, String Entry_T, string Full_Name_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@Date_Entry", SqlDbType.DateTime);
            param[1].Value = Date_Entry;

            param[2] = new SqlParameter("@Entry_H", SqlDbType.Int);
            param[2].Value = Entry_H;

            param[3] = new SqlParameter("@Entry_M", SqlDbType.Int);
            param[3].Value = Entry_M;

            param[4] = new SqlParameter("@Entry_S", SqlDbType.Int);
            param[4].Value = Entry_S;

            param[5] = new SqlParameter("@Text_Entry", SqlDbType.VarChar, 50);
            param[5].Value = Text_Entry;

            param[6] = new SqlParameter("@Entry_T", SqlDbType.VarChar, 50);
            param[6].Value = Entry_T;

            param[7] = new SqlParameter("@Full_Name_USER", SqlDbType.VarChar, 50);
            param[7].Value = Full_Name_USER;

            dal.executeCommand("add_Entry_TableE", param);
            dal.close();
        }

        public void add_Exit_TableE(string ID_USER, DateTime Date_Exit, int Exit_H,
                               int Exit_M, int Exit_S, string Text_Exit, int ID_Entry, String Exit_T,
                                double subtract_H, double subtract_M, double subtract_S, string Full_Name_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[12];


            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@Date_Exit", SqlDbType.DateTime);
            param[1].Value = Date_Exit;

            param[2] = new SqlParameter("@Exit_H", SqlDbType.Int);
            param[2].Value = Exit_H;

            param[3] = new SqlParameter("@Exit_M", SqlDbType.Int);
            param[3].Value = Exit_M;

            param[4] = new SqlParameter("@Exit_S", SqlDbType.Int);
            param[4].Value = Exit_S;

            param[5] = new SqlParameter("@Text_Exit", SqlDbType.VarChar, 50);
            param[5].Value = Text_Exit;

            param[6] = new SqlParameter("@ID_Entry", SqlDbType.Int);
            param[6].Value = ID_Entry;

            param[7] = new SqlParameter("@Exit_T", SqlDbType.VarChar, 50);
            param[7].Value = Exit_T;

            param[8] = new SqlParameter("@subtract_H", SqlDbType.Int);
            param[8].Value = subtract_H;

            param[9] = new SqlParameter("@subtract_M", SqlDbType.Int);
            param[9].Value = subtract_M;

            param[10] = new SqlParameter("@subtract_S", SqlDbType.Int);
            param[10].Value = subtract_S;

            param[11] = new SqlParameter("@Full_Name_USER", SqlDbType.VarChar, 50);
            param[11].Value = Full_Name_USER;


            dal.executeCommand("add_Exit_TableE", param);
            dal.close();
        }

        public DataTable get_ID_Entry(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_ID_Entry", param);
            dal.close();

            return Dt;
        }

        public DataTable get_ID_USER()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_ID_USER", null);
            dal.close();

            return Dt;
        }

        public DataTable get_ID_USER11()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_ID_USER11", null);
            dal.close();

            return Dt;
        }

        public DataTable get_Sections_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Sections_Table", null);
            dal.close();

            return Dt;
        }

        public DataTable gget_Sections_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            //SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("gget_Sections_Table", null);
            dal.close();

            return Dt;
        }

        public DataTable get_Working_time_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Working_time_Table", null);
            dal.close();

            return Dt;
        }

        public DataTable gget_Working_time_Table()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("gget_Working_time_Table", null);
            dal.close();

            return Dt;
        }
        public DataTable Get_and_shawIt_USER_list()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Get_and_shawIt_USER_list", null);
            dal.close();

            return Dt;
        }

        public DataTable verify_User_Id(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("verify_User_Id", param);
            dal.close();

            return Dt;
        }

        public DataTable verify_Name_Working_time(string id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();

            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            Dt = dal.selectData("verify_Name_Working_time", param);
            dal.close();

            return Dt;
        }

        public void add_Bonus_and_Discaunt_salary(string ID_user, string Full_name_user, DateTime Date_Salary,
                               int Salary_USER, int Bonus_Salary, int Discaunt_Salary, string text_Salary, string State__Salary)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[8];


            param[0] = new SqlParameter("@ID_user", SqlDbType.VarChar, 50);
            param[0].Value = ID_user;

            param[1] = new SqlParameter("@Full_name_user", SqlDbType.VarChar, 50);
            param[1].Value = Full_name_user;

            param[2] = new SqlParameter("@Date_Salary", SqlDbType.Date);
            param[2].Value = Date_Salary;

            param[3] = new SqlParameter("@Salary_USER", SqlDbType.Int);
            param[3].Value = Salary_USER;

            param[4] = new SqlParameter("@Bonus_Salary", SqlDbType.Int);
            param[4].Value = Bonus_Salary;

            param[5] = new SqlParameter("@Discaunt_Salary", SqlDbType.Int);
            param[5].Value = Discaunt_Salary;

            param[6] = new SqlParameter("@text_Salary", SqlDbType.VarChar, 50);
            param[6].Value = text_Salary;

            param[7] = new SqlParameter("@State__Salary", SqlDbType.VarChar, 50);
            param[7].Value = State__Salary;

            dal.executeCommand("add_Bonus_and_Discaunt_salary", param);
            dal.close();
        }

        

        public DataTable get_Salary_Table(String ID_USER )
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Salary_Table", param);
            dal.close();

            return Dt;
        }

        public DataTable Sum_Date_EntryAndDate_between_date(String ID_USER, string date1, string date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.VarChar, 50);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.VarChar, 50);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Date_EntryAndDate_between_date", param);
            dal.close();

            return Dt;
        }

        public DataTable Sum_Date_EntryAndDate(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Date_EntryAndDate", param);
            dal.close();

            return Dt;
        }

        public DataTable get_SalaryOfM(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_SalaryOfh", param);
            dal.close();

            return Dt;
        }

        public DataTable Sum_Bonus_Salary(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Bonus_Salary", param);
            dal.close();

            return Dt;
        }
        public void EDIT_Salary_Table(int ID_Salary, int Bonus_Salary, int Discaunt_Salary, String Text_Salary)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@ID_Salary", SqlDbType.Int);
            param[0].Value = ID_Salary;

            param[1] = new SqlParameter("@Bonus_Salary", SqlDbType.Int);
            param[1].Value = Bonus_Salary;

            param[2] = new SqlParameter("@Discaunt_Salary", SqlDbType.Int);
            param[2].Value = Discaunt_Salary;

            param[3] = new SqlParameter("@Text_Salary", SqlDbType.VarChar, 50);
            param[3].Value = Text_Salary;

            dal.executeCommand("EDIT_Salary_Table", param);
            dal.close();
        }

        public DataTable Sum_Discaunt_Salary(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Discaunt_Salary", param);
            dal.close();

            return Dt;
        }

        public DataTable Search_Salary(string ID_USER, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_Salary", param);
            dal.close();

            return Dt;
        }
        public DataTable Search_Salary_Text(String ID_USER, String ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[1].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_Salary_Text", param);
            dal.close();

            return Dt;
        }
        public DataTable Sum_Bonus_Salary_Between_two_dates(string ID_USER, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Bonus_Salary_Between_two_dates", param);
            dal.close();

            return Dt;
        }
        public DataTable Sum_Discaunt_Salary_Between_two_dates(string ID_USER, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Sum_Discaunt_Salary_Between_two_dates", param);
            dal.close();

            return Dt;
        }

        public void add_Messege_Table(string Full_Name_USER, DateTime Date_Message, string To_Massage,
                               string Text_Message, int Flat_Message)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@Full_Name_USER", SqlDbType.VarChar, 50);
            param[0].Value = Full_Name_USER;

            param[1] = new SqlParameter("@Date_Message", SqlDbType.DateTime);
            param[1].Value = Date_Message;

            param[2] = new SqlParameter("@To_Massage", SqlDbType.VarChar, 50);
            param[2].Value = To_Massage;

            param[3] = new SqlParameter("@Text_Message", SqlDbType.Text);
            param[3].Value = Text_Message;

            param[4] = new SqlParameter("@Flat_Message", SqlDbType.Int);
            param[4].Value = Flat_Message;

            dal.executeCommand("add_Messege_Table", param);
            dal.close();
        }

        public DataTable get_Messege_Table(String ID_USER)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Messege_Table", param);
            dal.close();

            return Dt;
        }

        public void add_Settings_table(string Name_Sett, string Address_Sett, int phone_Sett,
                              int Cellphone1_Sett, int Cellphone2_Sett, byte[] Ima_Sett)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@Name_Sett", SqlDbType.VarChar, 50);
            param[0].Value = Name_Sett;

            param[1] = new SqlParameter("@Address_Sett", SqlDbType.VarChar, 50);
            param[1].Value = Address_Sett;

            param[2] = new SqlParameter("@phone_Sett", SqlDbType.Int);
            param[2].Value = phone_Sett;

            param[3] = new SqlParameter("@Cellphone1_Sett", SqlDbType.Int);
            param[3].Value = Cellphone1_Sett;

            param[4] = new SqlParameter("@Cellphone2_Sett", SqlDbType.Int);
            param[4].Value = Cellphone2_Sett;

            param[5] = new SqlParameter("@Ima_Sett", SqlDbType.Image);
            param[5].Value = Ima_Sett;

            dal.executeCommand("add_Settings_table", param);
            dal.close();
        }

        public DataTable Search_Table(string ID_USER, DateTime date1, DateTime date2)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@date1", SqlDbType.Date);
            param[1].Value = date1;

            param[2] = new SqlParameter("@date2", SqlDbType.Date);
            param[2].Value = date2;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("Search_Table", param);
            dal.close();

            return Dt;
        }

        public void Add_Working_time(string Name_Working_time, string From_Working_time, string to_Working_time, string total_hours_Working_time, 
            DateTime total_hours_Working_timeDT, string Holidays_Working_time)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Name_Working_time", SqlDbType.VarChar, 50);
            param[0].Value = Name_Working_time;

            param[1] = new SqlParameter("@From_Working_time", SqlDbType.VarChar, 50);
            param[1].Value = From_Working_time;

            param[2] = new SqlParameter("@to_Working_time", SqlDbType.VarChar, 50);
            param[2].Value = to_Working_time;

            param[3] = new SqlParameter("@total_hours_Working_time", SqlDbType.VarChar, 50);
            param[3].Value = total_hours_Working_time;

            param[4] = new SqlParameter("@total_hours_Working_timeDT", SqlDbType.DateTime);
            param[4].Value = total_hours_Working_timeDT;

            param[5] = new SqlParameter("@Holidays_Working_time", SqlDbType.VarChar, 50);
            param[5].Value = Holidays_Working_time;

            

            dal.executeCommand("Add_Working_time", param);
            dal.close();
        }

        public DataTable get_Name_Working_time()
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[2];

            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_Name_Working_time", null);
            dal.close();

            return Dt;
        }

        public void Add_distribution(string ID_USER_distribution, string Name_Working_time_distribution)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_USER_distribution", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER_distribution;

            param[1] = new SqlParameter("@Name_Working_time_distribution", SqlDbType.VarChar, 50);
            param[1].Value = Name_Working_time_distribution;

            dal.executeCommand("Add_distribution", param);
            dal.close();
        }

        public void ADD_Sections_Table(string Name_Sections)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name_Sections", SqlDbType.VarChar, 50);
            param[0].Value = Name_Sections;

            dal.executeCommand("ADD_Sections_Table", param);
            dal.close();
        }

        public void Delete_Sections(int id)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dal.executeCommand("Delete_Sections", param);
            dal.close();
        }

        public DataTable GET_Working_time_Table_ID(int ID)
        {
            Data_Access_Layer.DAL dal = new Data_Access_Layer.DAL();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = dal.selectData("GET_Working_time_Table_ID", param);
            dal.close();

            return Dt;
        }
    }  
}
