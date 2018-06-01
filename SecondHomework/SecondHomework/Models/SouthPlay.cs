using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 南派
    /// </summary>
    public class SouthPlay : BasePerform
    {
        /// <summary>
        /// 南帝
        /// </summary>
        public string SouthEmperor;
        public string SouthPalyer { get; set; }

        /// <summary>
        /// 舞剑
        /// </summary>
        public void PlayBlade()
        {
            Console.WriteLine("南派南帝舞剑");
        }

        public override void BeginPlay()
        {
            Console.WriteLine("南派表演者段智兴开始表演");
        }

        public override void ShowFireBreak()
        {
            if (Temperature >= 800)
            {
                EventInvoke();
            }
        }

        public override void DogCall()
        {
            Console.WriteLine("南派狗叫");
        }

        public override void PersonCall()
        {
            Console.WriteLine("南派人喊");
        }

        public override void WindCall()
        {
            Console.WriteLine("南派风吹");
        }
    }
}
