using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace School
{
    class loadTable
    {

        public static void load()
        {
            loadClass();
            loadDABIR();
            loadDabirLesson();
            loadExam();
            loadGPLesson();
            loadKarname();
            loadLesson();
            loadMeeting();
            loadParents();
            loadpoint();
            loadSTDLESSON();
            loadSTD();
            loadUsers();
        }
        public static void loadSTD(){
            string line;
            int s=0,t;
            string codeMeli = "", name = "", fname = "", address = "", postalcode = "", Bdate = "", phone = "", fatherName = "", classNo = "", picture = "", shenasname = "";   
            System.IO.StreamReader file = new System.IO.StreamReader("table/Student.txt");
            while ((line = file.ReadLine()) != null)
            {
              
                s = 0; t = 0;
                t=line.IndexOf("-");
                codeMeli = line.Substring(s,t);
                line = line.Substring(t + 1, line.Length-t-1);
                
                t = line.IndexOf("-");
                name = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                fname = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                address = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                postalcode = line.Substring(s,t);
                line = line.Substring(t + 1, line.Length - t - 1);
               
                t = line.IndexOf("-");
                Bdate = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);
               
                t = line.IndexOf("-");
                phone = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);
               
                t = line.IndexOf("-");
                fatherName = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);
               
              
                t = line.IndexOf("-");
                classNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);
         
                t = line.IndexOf("-");
                picture = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);


                shenasname = line.Substring(s, line.Length -s - 1);
                
                
                
                
                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO StudentTBL(codeMeli,name,fname,address,postalcode,Bdate,phone,fatherName,classNo,picture,shenasname)values(@id,@name,@fname,@address,@postalcode,@Bdate,@phone,@fatherName,@classNo,@picture,@shenasname)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                   exesql.Parameters.AddWithValue("@id", codeMeli);
                     exesql.Parameters.AddWithValue("@name", name);
                      exesql.Parameters.AddWithValue("@fname", fname);
                   
                    exesql.Parameters.AddWithValue("@address", address);
                    exesql.Parameters.AddWithValue("@postalcode",postalcode );
                    exesql.Parameters.AddWithValue("@Bdate",Bdate );
                    exesql.Parameters.AddWithValue("@phone", phone);
                    exesql.Parameters.AddWithValue("@fatherName",fatherName );
                    exesql.Parameters.AddWithValue("@classNo", classNo);
                    exesql.Parameters.AddWithValue("@picture",picture );
                    exesql.Parameters.AddWithValue("@shenasname",shenasname );
                    
                   exesql.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }
                
            }
            file.Close();
            
        }
        public static void loadDABIR()
        {
            string line;
            int s = 0, t;
            string ssn = "", shenasname = "", name = "", fname = "", address = "", postalCode = "", phone = "", Bdate = "", tahsilat = "", mobile = "", picture = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Dabir.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                ssn = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                shenasname = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                name = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                fname = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                address = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                postalCode = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                phone = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                Bdate = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);


                t = line.IndexOf("-");
                tahsilat = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                mobile = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);


                picture = line.Substring(s, line.Length - s );




                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO Dabir(ssn,shenasname,name,fname,address,postalCode,phone,Bdate,tahsilat,mobile,picture)values(@ssn,@shenasname,@name,@fname,@address,@postalCode,@phone,@Bdate,@tahsilat,@mobile,@picture)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssn",ssn);
                    exesql.Parameters.AddWithValue("@shenasname",shenasname);
                    exesql.Parameters.AddWithValue("@name",name);

                    exesql.Parameters.AddWithValue("@fname",fname);
                    exesql.Parameters.AddWithValue("@address",address);
                    exesql.Parameters.AddWithValue("@postalCode",postalCode);
                    exesql.Parameters.AddWithValue("@phone",phone);
                    exesql.Parameters.AddWithValue("@Bdate",Bdate);  
                    exesql.Parameters.AddWithValue("@tahsilat",tahsilat);
                    exesql.Parameters.AddWithValue("@mobile",mobile);
                    exesql.Parameters.AddWithValue("@picture", picture);

                    exesql.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadClass()
        {
            string line;
            int s = 0, t;
            string classNo = "", paye = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Class.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                classNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                paye = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO Class(classNo,paye)values(@classNo,@paye)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@classNo",classNo);
                    exesql.Parameters.AddWithValue("@paye", paye);
                    exesql.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadDabirLesson()
        {
            string line;
            int s = 0, t;
            string ssnDabirNoLesson="",ssnDabir="",LessonnNo="";
            System.IO.StreamReader file = new System.IO.StreamReader("table/DabirLesson.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                ssnDabirNoLesson = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                ssnDabir = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                LessonnNo = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO Class(ssnDabirNoLesson,ssnDabir,LessonnNo)values(@ssnDabirNoLesson,@ssnDabir,@LessonnNo)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssnDabirNoLesson",ssnDabirNoLesson);
                    exesql.Parameters.AddWithValue("@ssnDabir",ssnDabir);
                    exesql.Parameters.AddWithValue("@LessonnNo",LessonnNo);
                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadExam()
        {

            string line;
            int s = 0, t;
            string examNo = "", lessonName = "", date = "",time="";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Exam.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                examNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                lessonName = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                date = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                time = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO exam(examNo,lessonName,date,time)values(@examNo,@lessonName,@date,@time)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@examNo",examNo);
                    exesql.Parameters.AddWithValue("@lessonName",lessonName);
                    exesql.Parameters.AddWithValue("@date",date);
                    exesql.Parameters.AddWithValue("@time", time);
                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadGPLesson()
        {

            string line;
            int s = 0, t;
            string GPNo = "", ssnDabirManager = "", nameGroup = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/GPlesson.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                GPNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                ssnDabirManager = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

               

                nameGroup = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO GPLesson(GPNo,ssnDabirManager,nameGroup)values(@GPNo,@ssnDabirManager,@nameGroup)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@GPNo",GPNo);
                    exesql.Parameters.AddWithValue("@ssnDabirManager",ssnDabirManager);
                    exesql.Parameters.AddWithValue("@nameGroup",nameGroup);
                   
                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadKarname()
        {

            string line;
            int s = 0, t;
            string ssnStudent = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Karname.txt");
            while ((line = file.ReadLine()) != null)
            {


                ssnStudent = line;

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO karname(ssnStudent)values(@ssnStudent)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssnStudent", ssnStudent);
                   

                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadLesson()
        {

            string line;
            int s = 0, t;
            string lessonNO = "", GPNumber = "", lessonName = "", paye = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Lesson.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                lessonNO = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                GPNumber = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                lessonName = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                paye = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO Lesson(lessonNO,GPNumber,lessonName,paye)values(@lessonNO,@GPNumber,@lessonName,@paye)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@lessonNO", lessonNO);
                    exesql.Parameters.AddWithValue("@GPNumber", GPNumber);
                    exesql.Parameters.AddWithValue("@lessonName", lessonName);
                    exesql.Parameters.AddWithValue("@paye", paye);
                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadMeeting()
        {

            string line;
            int s = 0, t;
            string ssnDabir = "", ssnStudent = "", date = "", time = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Meeting.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                ssnDabir = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                ssnStudent = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                date = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                time = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO meeting(ssnDabir,ssnStudent,date,time)values(@ssnDabir,@ssnStudent,@date,@time)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssnDabir", ssnDabir);
                    exesql.Parameters.AddWithValue("@ssnStudent", ssnStudent);
                    exesql.Parameters.AddWithValue("@date", date);
                    exesql.Parameters.AddWithValue("@time", time);
                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadParents()
        {

            string line;
            int s = 0, t;
            string ssnStudent = "", motherMobile = "", fatherMobile = "", motherWorkAdress = "", fatherWorkAdress="";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Parents.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                ssnStudent = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                motherMobile = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                fatherMobile = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                motherWorkAdress = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                fatherWorkAdress = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO parents(ssnStudent,motherMobile,fatherMobile,motherWorkAdress,fatherWorkAdress)values(@ssnStudent,@motherMobile,@fatherMobile,@motherWorkAdress,@fatherWorkAdress)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssnStudent", ssnStudent);
                    exesql.Parameters.AddWithValue("@motherMobile", motherMobile);
                    exesql.Parameters.AddWithValue("@fatherMobile", fatherMobile);
                    exesql.Parameters.AddWithValue("@motherWorkAdress", motherWorkAdress);
                    exesql.Parameters.AddWithValue("@fatherWorkAdress", fatherWorkAdress);

                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadpoint()
        {

            string line;
            int s = 0, t;
            string examNo = "", lessonNo = "", ssnDabir = "", ssnStudent = "", point = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Point.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                examNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                lessonNo = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                ssnDabir = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                ssnStudent = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                point = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO point(examNo,lessonNo,ssnDabir,ssnStudent,point)values(@examNo,@lessonNo,@ssnDabir,@ssnStudent,@point)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@examNo", examNo);
                    exesql.Parameters.AddWithValue("@lessonNo", lessonNo);
                    exesql.Parameters.AddWithValue("@ssnDabir", ssnDabir);
                    exesql.Parameters.AddWithValue("@ssnStudent", ssnStudent);
                    exesql.Parameters.AddWithValue("@point", point);

                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadSTDLESSON()
        {

            string line;
            int s = 0, t;
            string ssnSTDnoles = "", weight = "", examNO = "", nolesson = "", ssnStd = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/STDLESSON.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                ssnSTDnoles = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                weight = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                examNO = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                nolesson = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                ssnStd = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO STDLESSON(ssnSTDnoles,weight,examNO,nolesson,ssnStd)values(@ssnSTDnoles,@weight,@examNO,@nolesson,@ssnStd)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@ssnSTDnoles", ssnSTDnoles);
                    exesql.Parameters.AddWithValue("@weight", weight);
                    exesql.Parameters.AddWithValue("@examNO", examNO);
                    exesql.Parameters.AddWithValue("@nolesson", nolesson);
                    exesql.Parameters.AddWithValue("@ssnStd", ssnStd);

                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
        public static void loadUsers()
        {

            string line;
            int s = 0, t;
            string username = "", password = "", semat = "";
            System.IO.StreamReader file = new System.IO.StreamReader("table/Users.txt");
            while ((line = file.ReadLine()) != null)
            {

                s = 0; t = 0;
                t = line.IndexOf("-");
                username = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);

                t = line.IndexOf("-");
                password = line.Substring(s, t);
                line = line.Substring(t + 1, line.Length - t - 1);



                semat = line.Substring(s, line.Length - s - 1);

                SqlConnection Cn = new SqlConnection(global::School.Properties.Settings.Default.SchoolConnectionString1);
                try
                {
                    string Sql = "INSERT INTO Users(username,password,semat)values(@username,@password,@semat)";

                    SqlCommand exesql = new SqlCommand(Sql, Cn);
                    Cn.Open();
                    exesql.Parameters.AddWithValue("@username", username);
                    exesql.Parameters.AddWithValue("@password", password);
                    exesql.Parameters.AddWithValue("@semat", semat);

                    exesql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Cn.Close();
                }

            }
            file.Close();
        }
    }
}