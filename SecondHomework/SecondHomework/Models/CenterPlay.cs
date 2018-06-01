using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 中派
    /// </summary>
    public class CenterPlay : BasePerform
    {
        public void Funny()
        {
            Console.WriteLine("中派中神通搞笑");
        }

        public override void DogCall()
        {
            Console.WriteLine("中派狗叫");
        }

        public override void PersonCall()
        {
            Console.WriteLine("中派人喊");
        }

        public override void WindCall()
        {
            Console.WriteLine("中派风吹");
        }

        public delegate void CenterDelegate();
        /// <summary>
        /// 开始事件
        /// </summary>
        public event CenterDelegate BeginEvent;

        /// <summary>
        /// 高潮事件
        /// </summary>
        public event CenterDelegate HighEvent;

        /// <summary>
        /// 结束事件
        /// </summary>
        public event CenterDelegate EndEvent;

        public void Show()
        {
            Start();
            BeginPlay();
            if (BeginEvent != null)
            {
                BeginEvent.Invoke();
            }

            DogCall();
            PersonCall();
            WindCall();
            Funny();
            if (HighEvent != null)
            {
                HighEvent.Invoke();
            }

            EndPlay();
            GetCharge();
            if (EndEvent != null)
            {
                EndEvent.Invoke();
            }
        }
    }
}
