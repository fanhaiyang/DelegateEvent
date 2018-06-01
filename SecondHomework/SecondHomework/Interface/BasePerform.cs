using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Interface
{
    /// <summary>
    /// 表演基类
    /// </summary>
    public abstract class BasePerform : ICharge
    {
        /// <summary>
        /// 人
        /// </summary>
        public string Person { get; set; }

        /// <summary>
        /// 桌子
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// 椅子
        /// </summary>
        public string Chair { get; set; }

        /// <summary>
        /// 扇子
        /// </summary>
        public string Fan { get; set; }

        /// <summary>
        /// 尺子
        /// </summary>
        public string Ruler { get; set; }

        /// <summary>
        /// 狗叫
        /// </summary>
        public abstract void DogCall();

        /// <summary>
        /// 人声
        /// </summary>
        public abstract void PersonCall();

        /// <summary>
        /// 风声
        /// </summary>
        public abstract void WindCall();

        public void Start()
        {
            Console.WriteLine("表演开始了......");
        }

        /// <summary>
        /// 开场白
        /// </summary>
        public virtual void BeginPlay()
        {
            Console.WriteLine("准备欣赏节目！");
        }

        public virtual void HighPlay()
        {
            Console.WriteLine("表演高潮部分！！！");
        }

        /// <summary>
        /// 结束语
        /// </summary>
        public virtual void EndPlay()
        {
            Console.WriteLine("表演结束了！");
        }

        /// <summary>
        /// 收费
        /// </summary>
        public void GetCharge()
        {
            Console.WriteLine("收费");
        }

        /// <summary>
        /// 夫起大呼
        /// </summary>
        public void ManCry()
        {
            Console.WriteLine("夫起大呼");
        }

        /// <summary>
        /// 妇亦起大呼
        /// </summary>
        public void WomanCry()
        {
            Console.WriteLine("妇亦起大呼");
        }

        /// <summary>
        /// 两儿齐哭
        /// </summary>
        public void ChildrenCry()
        {
            Console.WriteLine("两儿齐哭");
        }

        /// <summary>
        /// 百千人大呼
        /// </summary>
        public void AllPersonCry()
        {
            Console.WriteLine("俄而百千人大呼");
        }

        /// <summary>
        /// 百千儿哭
        /// </summary>
        public void AllChildrenCry()
        {
            Console.WriteLine("百千儿哭");
        }

        /// <summary>
        /// 百千犬吠
        /// </summary>
        public void AllDogCry()
        {
            Console.WriteLine("百千犬吠");
        }

        /// <summary>
        /// 火起
        /// </summary>
        public delegate void FireBreak();
        public event FireBreak Events;
        public int Temperature = 400;
        public int SetTemp(int temp)
        {
            return Temperature = temp;
        }

        /// <summary>
        /// 展示火起后的事件
        /// </summary>
        public virtual void ShowFireBreak()
        {
            if (Temperature >= 400)
            {
                EventInvoke();
            }
        }

        public void EventInvoke()
        {
            if (Events != null)
            {
                Console.WriteLine("火起");
                Events.Invoke();
            }
        }
    }
}
