using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_5_简历复印_深复制_
{
    public class WorkExperience:ICloneable
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

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
