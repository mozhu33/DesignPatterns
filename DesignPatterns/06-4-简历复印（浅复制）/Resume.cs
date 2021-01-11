using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_4_简历复印_浅复制_
{
    public class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;

        private WorkExperience work;
        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea, string company)
        {
           work.WorkDate = timeArea;
            work.Company = company;
        }

        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"工作经历：{work.WorkDate} {work.Company}");
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
