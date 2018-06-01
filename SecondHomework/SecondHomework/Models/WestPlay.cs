using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 西派
    /// </summary>
    public class WestPlay : BasePerform
    {
        /// <summary>
        /// 西毒
        /// </summary>
        public string WestDrug;
        public string WestPalyer { get; set; }

        /// <summary>
        /// 放毒
        /// </summary>
        public void PlayDrug()
        {
            Console.WriteLine("西派西毒放毒");
        }

        public override void BeginPlay()
        {
            Console.WriteLine("西派表演者欧阳锋开始表演");
        }

        public override void EndPlay()
        {
            Console.WriteLine("西派表演者欧阳锋表演结束");
        }

        public override void DogCall()
        {
            Console.WriteLine("西派狗叫");
        }

        public override void PersonCall()
        {
            Console.WriteLine("西派人喊");
        }

        public override void WindCall()
        {
            Console.WriteLine("西派风吹");
        }
    }
}
