using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 东派
    /// </summary>
    public class EastPlay : BasePerform
    {
        /// <summary>
        /// 东邪
        /// </summary>
        public string EastEvil;
        public string EastPalyer { get; set; }

        /// <summary>
        /// 吹箫
        /// </summary>
        public void PlayFlute()
        {
            Console.WriteLine("东派东邪吹箫");
        }

        public override void DogCall()
        {
            Console.WriteLine("东派狗叫");
        }

        public override void PersonCall()
        {
            Console.WriteLine("东派人喊");
        }

        public override void WindCall()
        {
            Console.WriteLine("东派风吹");
        }
    }
}
