using MasterPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MasterPro
{
    class Query
    {
        DataPool dataPool;

        public Query()
        {
            dataPool = new DataPool();
        }

        public DataSet ShowAllUser()
        {
            string sql = "select * from userInfo order by u_id asc";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet ShowAllMaster()
        {
            string sql = "select * from userInfo where u_role = 'master' order by u_id asc";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        

        public DataSet ShowAllScore()
        {
            string sql = "select masterInfo.m_id, m_name, c_id, c_name, score from masterInfo, master_course where masterInfo.m_id = master_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectOneUser(string id)
        {
            string sql = "select * from userInfo where u_id = '" + id + "'";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectOneMasterAndScore(string id)
        {
            string sql = "select masterInfo.m_id, m_name, c_id, c_name, score from masterInfo, master_course where masterInfo.m_id = '" + id + "' and masterInfo.m_id = master_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }

        public DataSet SelectByScore(string score)
        {
            string sql = "select masterInfo.m_id, m_name, c_id, c_name, score from masterInfo, master_course where score = " + score + " and masterInfo.m_id = master_course.m_id";
            DataSet dataSet = dataPool.GetData(sql, "user");
            return dataSet;
        }


        public bool isUser(string id)
        {
            bool result = false;

            string sql = "select u_name from userInfo where u_id = '" + id + "'";
            DataSet dataSet = dataPool.GetData(sql, "user");
            if (dataSet.Tables[0].Rows[0][0].ToString().Trim() != "")
                result = true;

            return result;
        }

        public bool AddMaster(User user)
        {
            bool result = false;
            bool insertUserInfoResult = false;
            bool insertMasterInfoResult = false;
            //bug
            bool insertCourseInfoResult = true;
            bool insertMaster_CourseInfoResult = false;

            string user_sql = "insert into userInfo ([u_id],[u_name],[u_password],[u_role]) values('"
                    + user.id + "','" + user.name + "','"
                    + user.password + "','" + user.role + "')";

            if (dataPool.CommandExe(user_sql) == true)
                insertUserInfoResult = true;

            string master_sql = "insert into masterInfo ([m_id],[m_name]) values('"
                    + user.id + "','" + user.name + "')";

            if (dataPool.CommandExe(master_sql) == true)
                insertMasterInfoResult = true;

            //string course_sql = "insert into courseInfo ([c_id],[c_name]) values('0','001')";

            //if (dataPool.CommandExe(course_sql) == true)
            //    insertCourseInfoResult = true;

            string master_course_sql = "insert into master_course ([m_id]) values('"
                    + user.id + "')";

            if (dataPool.CommandExe(master_course_sql) == true)
                insertMaster_CourseInfoResult = true;

            if (insertUserInfoResult && insertMasterInfoResult &&
                insertCourseInfoResult && insertMaster_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdateMasterInfo(User user)
        {
            bool result = false;
            bool updateUserInfoResult = false;
            bool updateMasterInfoResult = false;


            string user_sql = "update userInfo set u_name = '" + user.name +
                "',u_password = '" + user.password + 
                "' where u_id = '" + user.id + "'";
            if (dataPool.CommandExe(user_sql) == true)
                updateUserInfoResult = true;

            string master_sql = "update masterInfo set m_name = '" + user.name +
                "' where m_id = '" + user.id + "'";
            if (dataPool.CommandExe(master_sql) == true)
                updateMasterInfoResult = true;

            if (updateUserInfoResult && updateMasterInfoResult)
                result = true;

            return result;
        }

        public bool DeleteMasterInfo(string id)
        {
            bool result = false;
            bool deleteMasterInfoResult = false;
            bool deleteUserResult = false;
            bool deleteMaster_CourseInfoResult = false;

            string master_course_sql = "delete from master_course where m_id = '" + id + "'";
            if (dataPool.CommandExe(master_course_sql) == true)
                deleteMaster_CourseInfoResult = true;

            string master_sql = "delete from masterInfo where m_Id = '" + id + "'";
            if (dataPool.CommandExe(master_sql) == true)
                deleteMasterInfoResult = true;

            string user_sql = "delete from userInfo where u_id = '" + id + "'";
            if (dataPool.CommandExe(user_sql) == true)
                deleteUserResult = true;

            if (deleteUserResult && deleteMasterInfoResult && deleteMaster_CourseInfoResult)
                result = true;
            return result;
        }

        public bool DeleteScore(string id)
        {
            bool result = false;

            string sql = "update master_course set c_id = '0', c_name = '0', score = 0" + 
                " where m_id = '" + id + "'";
            if (dataPool.CommandExe(sql) == true)
                result = true;

            return result;
        }

        public bool ADDScoreInfo(Master master)
        {
            bool result = false;
            //bug
            bool updateCourseInfoResult = true;
            bool updateMaster_CourseInfoResult = false;


            //string user_sql = "update courseInfo set c_id = '" + master.c_id +
            //    "',c_name = '" + master.c_name +
            //    "' where u_id = '" + user.id + "'";
            //if (dataPool.CommandExe(user_sql) == true)
            //    updateUserInfoResult = true;

            string master_course_sql = "update master_course set c_id = '" + master.c_id +
                "',c_name = '" + master.c_name +
                "',score = " + master.score +
                " where m_id = '" + master.id + "'";
            if (dataPool.CommandExe(master_course_sql) == true)
                updateMaster_CourseInfoResult = true;

            if (updateCourseInfoResult && updateMaster_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdateScoreInfo(Master master)
        {
            bool result = false;
            //bug
            bool updateCourseInfoResult = true;
            bool updateMaster_CourseInfoResult = false;


            //string user_sql = "update courseInfo set c_id = '" + master.c_id +
            //    "',c_name = '" + master.c_name +
            //    "' where u_id = '" + user.id + "'";
            //if (dataPool.CommandExe(user_sql) == true)
            //    updateUserInfoResult = true;

            string master_course_sql = "update master_course set score = " + master.score +
                " where m_id = '" + master.id + "'";
            if (dataPool.CommandExe(master_course_sql) == true)
                updateMaster_CourseInfoResult = true;

            if (updateCourseInfoResult && updateMaster_CourseInfoResult)
                result = true;

            return result;
        }

        public bool UpdatePassword(string id, string password)
        {
            bool result = false;

            string sql = "update userInfo set u_password = '" + password +
                "' where u_id = '" + id + "'";
            if (dataPool.CommandExe(sql) == true)
                result = true;

            return result;
        }

    }
}
