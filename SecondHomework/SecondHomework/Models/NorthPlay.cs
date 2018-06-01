using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 北派
    /// </summary>
    public class NorthPlay : BasePerform
    {
        /// <summary>
        /// 北丐
        /// </summary>
        public string NorthBeggar;
        public string NorthPaly { get; set; }

        /// <summary>
        /// 吃鸡
        /// </summary>
        public void EatChicken()
        {
            Console.WriteLine("北派北丐吃鸡");
        }

        public override void EndPlay()
        {
            Console.WriteLine("北派表演者洪七公表演结束");
        }

        public override void ShowFireBreak()
        {
            if (Temperature >= 1000)
            {
                EventInvoke();
            }
        }
        public override void DogCall()
        {
            Console.WriteLine("北派狗叫");
        }

        public override void PersonCall()
        {
            Console.WriteLine("北派人喊");
        }

        public override void WindCall()
        {
            Console.WriteLine("北派风吹");
        }
    }
}
