using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPro
{
    class User
    {
        public string id { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public string role { get; set; }
    }

    class Master : User
    {
        public string c_id { get; set; }

        public string c_name { get; set; }

        public string score { get; set; }

        public string sexy { get; set; }

        public string college { get; set; }

        public string dept { get; set; }

    }

    class Tutor : User
    {
        public string sexy { get; set; }

        public string title { get; set; }

        public string college { get; set; }
    }

    class Course
    {
        public string id{ get; set; }

        public string name{ get; set; }

        public string teacher{ get; set; }

        public string kind{ get; set; }
    }

    class Master_Course
    {
        public string m_id{ get; set; }

        public string c_id{ get; set; }

        public string t_id{ get; set; }

        public string score{ get; set; }

        public string teacher{ get; set; }
    }



}
