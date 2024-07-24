using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_System : IManagement
    {
        DAL_System DALSystem = DAL_System.Instance;
        private static BUS_System instance;
        public static object obj = new object();
        public static BUS_System Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        instance = new BUS_System();
                    }
                }
                return instance;
            }
        }

        public DataTable getElements(string table)
        {
            string sql = "SELECT * FROM " + table;
            DataTable dt = new DataTable();
            dt = DALSystem.makeGetElements(sql);
            return dt;
        }
        public DataTable sort(string result, string table, string bySome)
        {
            string sql = "SELECT * FROM " + table + " ORDER BY " + bySome + " ";
            DataTable dt = new DataTable();
            if (result.CompareTo("theo tên a-z") == 0 || result.CompareTo("theo lương tăng dần") == 0 ||
                result.CompareTo("theo điểm tăng dần") == 0)
            {
                sql += "ASC";
                dt = DALSystem.makeSort(sql);
            }
            if (result.CompareTo("theo tên z-a") == 0 || result.CompareTo("theo lương giảm dần") == 0 ||
                result.CompareTo("theo điểm giảm dần") == 0)
            {
                sql += "DESC";
                dt = DALSystem.makeSort(sql);
            }
            
            
            return dt;
        }



        public bool addTeacher(string id, string cccd, string fullName, DateTime birth, string address,
            string phone, string salary, string subjectId)
        {

            var sql = "INSERT INTO TEACHER VALUES (@id,@cccd,@name,@birth,@address,@phone,@salary,@subjectId)";
            SqlParameter[] parameters =
            {
            new SqlParameter("@id",id),
            new SqlParameter("@cccd",cccd),
            new SqlParameter("@name", fullName),
            new SqlParameter("@birth",birth),
            new SqlParameter("@address",address),
            new SqlParameter("@phone",phone),
            new SqlParameter("@salary",salary),
            new SqlParameter("@subjectId",subjectId)
            };
            return DALSystem.execute(sql, parameters);
        }
        public bool updateTeacher(string id, string cccd, string fullName, DateTime birth, string address,
            string phone, string salary, string subjectId)
        {

            var sql = "UPDATE TEACHER SET CCCD = @cccd , FULLNAME = @name , BIRTH = @bir , ADDRESSS = @add , PHONE = @phone ," +
                " SALARY = @salary, SUBJECTID = @subjectId WHERE ID = @id";
            SqlParameter[] p =
            {
            new SqlParameter("@cccd",cccd),
            new SqlParameter("@name",fullName),
            new SqlParameter("@bir",birth),
            new SqlParameter("@add",address),
            new SqlParameter("@phone",phone),
            new SqlParameter("@salary",salary),
            new SqlParameter("@subjectId",subjectId),
            new SqlParameter("@id",id)
            };
            return DALSystem.execute(sql, p);
        }
        public bool removeElement(string id, string table)
        {
            var sql = "DELETE FROM " + table + " WHERE ID = @id";
            SqlParameter[] p =
            {
                new SqlParameter("@id",id)
            };
            return DALSystem.execute(sql, p);
        }
        public bool addCourse(string id, string name, string teacherId)
        {
            var sql = "INSERT INTO COURSE VALUES (@id,@name,@teacherId)";
            SqlParameter[] p =
            {
            new SqlParameter("@id",id),
            new SqlParameter("@name",name),
            new SqlParameter("@teacherId",teacherId)
            };
            return DALSystem.execute(sql, p);
        }
        public bool updateCourse(string id, string name, string teacherId)
        {
            var sql = "UPDATE COURSE SET COURSENAME = @name , HOMEROOMTEACHERID = @teacherId WHERE ID = @id";
            SqlParameter[] p =
            {
            new SqlParameter("@name",name),
            new SqlParameter("@teacherId",teacherId),
            new SqlParameter("@id",id)
            };
            return DALSystem.execute(sql, p);
        }
        public bool addStudent(string id, string cccd, string fullName, DateTime bir, string address
            , string phone, string schoolYear, string courseId)
        {
            var sql = "INSERT INTO STUDENT " +
                "VALUES (@id,@cccd,@name,@bir,@add,@phone,@school,@courseId)";
            SqlParameter[] p =
            {
            new SqlParameter("@id",id),
            new SqlParameter("@cccd",cccd),
            new SqlParameter("@name",fullName),
            new SqlParameter("@bir",bir),
            new SqlParameter("@add",address),
            new SqlParameter("@phone",phone),
            new SqlParameter("@school",schoolYear),
            new SqlParameter("@courseId",courseId)
            };
            return DALSystem.execute(sql, p);
        }
        public bool updateStudent(string id, string cccd, string fullName, DateTime bir, string address
            , string phone, string schoolYear, string courseId)
        {
            var sql = "UPDATE STUDENT SET CCCD = @cccd , FULLNAME = @name , BIRTH = @bir ,ADDRESSS = @add , PHONE = @phone ," +
                " SCHOOLYEAR = @school , COURSEID = @courseId WHERE ID = @id";
            SqlParameter[] p =
            {
            new SqlParameter ("@cccd",cccd),
            new SqlParameter("@name",fullName),
            new SqlParameter("@bir",bir),
            new SqlParameter("@add",address),
            new SqlParameter("@phone",phone),
            new SqlParameter("@school",schoolYear),
            new SqlParameter("@courseId",courseId),
            new SqlParameter("@id",id)
            };
            return DALSystem.execute(sql, p);
        }
        public bool addGradeList(string id, float math, float liter, float eng, float phy, float chem, float his, float geo,float avg)
        {
            var sql = "INSERT INTO GRADELIST VALUES (@id,@math,@liter,@eng,@phy,@chem,@his,@geo,@avg)";
            SqlParameter[] p =
            {
            new SqlParameter("@id",id),
            new SqlParameter("@math",math),
            new SqlParameter("@liter",liter),
            new SqlParameter("@eng",eng),
            new SqlParameter("@phy",phy),
            new SqlParameter("@chem",chem),
            new SqlParameter("@his",his),
            new SqlParameter("@geo",geo),
            new SqlParameter("@avg",avg)
            };
            return DALSystem.execute(sql, p);
        }
       
        public bool updateGradeList(string id , float math , float liter , float eng , float phy, float chem , float his , float geo ,float avg)
        {
            var sql = "UPDATE GRADELIST SET MATH = @math, LITERATURE = @liter,ENGLISH = @eng," +
                "PHYSICAL = @phy,CHEMISTRY = @chem,HISTORY = @his,GEOGRAPHYY = @geo, AVGGRADE = @avg WHERE ID = @id";
            SqlParameter[] p =
            {
                new SqlParameter ("@id",id),
                new SqlParameter ("@math",math),
                new SqlParameter("@liter",liter),
                new SqlParameter("@eng",eng),
                new SqlParameter("@phy",phy),
                new SqlParameter("@chem",chem),
                new SqlParameter("@his",his),
                new SqlParameter("@geo",geo),
                new SqlParameter("@avg",avg)
            };
            return DALSystem.execute (sql, p);
        }
        public bool checkLegal(List<string> strings)
        {
            foreach(var i in  strings)
            {
                if(i.CompareTo("") == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isNums(List<string> list)
        {
            foreach(var i in list)
            {
                float temp;
                bool check = float.TryParse(i,out temp);
                if (!check)
                {
                    return false;
                }
            }
            return true;
        }
        public DataTable getElementsById(string result,string table,string idColumn)
        {
            var sql = "SELECT ID,FULLNAME,ADDRESSS,PHONE FROM "+table+" WHERE "+idColumn+" = "+result;
            return DALSystem.makeGetElements(sql);
        }
        public DataTable getTeacherIdFromCourse(string courseId)
        {
            var sql = "SELECT HOMEROOMTEACHERID FROM COURSE WHERE ID = "+courseId;
            return DALSystem.makeGetElements(sql);
        }
        public DataTable findElements(string name ,string nameColumn, string table)
        {
            var sql = "SELECT * FROM "+table+" WHERE "+nameColumn+" LIKE N'%"+name+"%'";
            return DALSystem.makeGetElements(sql);
        }
        
    }
}
