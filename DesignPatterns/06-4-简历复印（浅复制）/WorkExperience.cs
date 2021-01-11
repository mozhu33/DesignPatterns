using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_4_简历复印_浅复制_
{
    public class WorkExperience
    {
        private string workDate;
        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }

        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
}
