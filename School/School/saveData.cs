using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace School
{
    class saveData
    {
        public static void save()
        {
            saveClass();
            saveDBR();
            saveDabirLesson();
            saveExam();
            saveGPLesson();
            saveKarname();
            saveLesson();
            savemeeting();
            saveParents();
            savepoint();
            saveSTDLESSON();
            saveSTD();
            saveUsers();
        }

        public static void saveSTD()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM StudentTBL ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Student.txt");
                while (sqlReader.Read())
                {
                    file.Write(sqlReader["codeMeli"]);
                    file.Write("-");
                    file.Write(sqlReader["name"]);
                    file.Write("-");
                    file.Write(sqlReader["fname"]);
                    file.Write("-");
                    file.Write(sqlReader["address"]);
                    file.Write("-");
                    file.Write(sqlReader["postalcode"]);
                    file.Write("-");
                    file.Write(sqlReader["Bdate"]);
                    file.Write("-");
                    file.Write(sqlReader["phone"]);
                    file.Write("-");
                    file.Write(sqlReader["fatherName"]);
                    file.Write("-");
                    file.Write(sqlReader["classNo"]);
                    file.Write("-");
                    file.Write(sqlReader["picture"]);
                    file.Write("-");
                    file.Write(sqlReader["shenasname"]);
                   
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        public static void saveDBR()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Dabir ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Dabir.txt");
                while (sqlReader.Read())
                {
                   
                    file.Write(sqlReader["ssn"]);
                    file.Write("-");
                    file.Write(sqlReader["shenasname"]);
                    file.Write("-");
                    file.Write(sqlReader["name"]);
                    file.Write("-");
                    file.Write(sqlReader["fname"]);
                    file.Write("-");
                    file.Write(sqlReader["address"]);
                    file.Write("-");
                    file.Write(sqlReader["postalCode"]);
                    file.Write("-");
                    file.Write(sqlReader["phone"]);
                    file.Write("-");
                    file.Write(sqlReader["Bdate"]);
                    file.Write("-");
                    file.Write(sqlReader["tahsilat"]);
                    file.Write("-");
                    file.Write(sqlReader["mobile"]);
                    file.Write("-");
                    file.Write(sqlReader["picture"]);

                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveClass()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Class ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Class.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["classNO"]);
                    file.Write("-");
                    file.Write(sqlReader["paye"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveDabirLesson()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM DabirLesson ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/DabirLesson.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["ssnDabirNoLesson"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnDabir"]);
                    file.Write("-");
                    file.Write(sqlReader["LessonnNo"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveExam()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM exam ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Exam.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["examNo"]);
                    file.Write("-");
                    file.Write(sqlReader["lessonName"]);
                    file.Write("-");
                    file.Write(sqlReader["date"]);
                    file.Write("-");
                      file.Write(sqlReader["time"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveGPLesson()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM GPLesson ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/GPlesson.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["GPNo"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnDabirManager"]);
                    file.Write("-");
                    file.Write(sqlReader["nameGroup"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveKarname(){
        System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM karname ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Karname.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["ssnStudent"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveLesson()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Lesson ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Lesson.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["lessonNo"]);
                    file.Write("-");
                    file.Write(sqlReader["GPNumber"]);
                    file.Write("-");
                    file.Write(sqlReader["lessonName"]);
                    file.Write("-");
                    file.Write(sqlReader["paye"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void savemeeting()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM meeting ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Meeting.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["ssnDabir"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnStudent"]);
                    file.Write("-");
                    file.Write(sqlReader["date"]);
                    file.Write("-");
                    file.Write(sqlReader["time"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

         
            }
        }
        public static void saveParents()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM parents ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Parents.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["ssnStudent"]);
                    file.Write("-");
                    file.Write(sqlReader["motherMobile"]);
                    file.Write("-");
                    file.Write(sqlReader["fatherMobile"]);
                    file.Write("-");
                    file.Write(sqlReader["motherWorkAdress"]);
                    file.Write("-");
                    file.Write(sqlReader["fatherWorkAdress"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void savepoint()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM point ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Point.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["examNo"]);
                    file.Write("-");
                    file.Write(sqlReader["lessonNo"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnDabir"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnStudent"]);
                    file.Write("-");
                    file.Write(sqlReader["point"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveSTDLESSON()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM STDLESSON ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/STDLESSON.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["ssnSTDnoLes"]);
                    file.Write("-");
                    file.Write(sqlReader["weight"]);
                    file.Write("-");
                    file.Write(sqlReader["examNo"]);
                    file.Write("-");
                    file.Write(sqlReader["nolesson"]);
                    file.Write("-");
                    file.Write(sqlReader["ssnStd"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public static void saveUsers()
        {
            System.IO.StreamWriter file = null;
            SqlConnection sqlcon = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
            try
            {

                string Query = "SELECT * FROM Users ";
                SqlCommand sqlcom = new SqlCommand(Query, sqlcon);
                sqlcon.Open();

                SqlDataReader sqlReader = sqlcom.ExecuteReader();

                file = new System.IO.StreamWriter("table/Users.txt");
                while (sqlReader.Read())
                {

                    file.Write(sqlReader["username"]);
                    file.Write("-");
                    file.Write(sqlReader["password"]);
                    file.Write("-");
                    file.Write(sqlReader["semat"]);
                    file.Write('\n');
                }
                sqlReader.Close();
                file.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
