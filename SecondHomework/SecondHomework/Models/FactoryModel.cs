using SecondHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework.Models
{
    /// <summary>
    /// 工厂类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FactoryModel
    {
        public void IniteFactory<T>(T model) where T : BasePerform, ICharge
        {
            Type type = typeof(T);
            BasePerform factory = (BasePerform)Activator.CreateInstance(type);

            foreach (var item in type.GetFields())
            {
                Console.WriteLine($"字段：{item.Name} = {item.GetValue(model)}");
            }
            foreach (var item in type.GetProperties())
            {
                Console.WriteLine($"属性：{item.Name} = {item.GetValue(model)}");
            }
            factory.Start();
            factory.BeginPlay();
            factory.DogCall();
            factory.PersonCall();
            factory.WindCall();
            factory.EndPlay();
            factory.GetCharge();
            Console.WriteLine("\n");
        }

        public delegate void ShowSkillDelegate();
        public event ShowSkillDelegate Skills;
        /// <summary>
        /// 技能展示
        /// </summary>
        public void ShowSkill()
        {
            Console.WriteLine("绝活马上开始了。。。");
            if (Skills != null)
            {
                Skills.Invoke();
            }

            Console.WriteLine("绝活表演结束，大家鼓掌！！");
        }
    }
}
