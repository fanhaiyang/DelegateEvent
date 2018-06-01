using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondHomework.Models;
using static SecondHomework.Interface.BasePerform;
using static SecondHomework.Models.FactoryModel;

namespace SecondHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2
            FactoryModel factory = new FactoryModel();

            factory.IniteFactory<EastPlay>(new EastPlay { Person = "老黄", Table = "桌子", Chair = "椅子", Fan = "扇子", Ruler = "尺子", EastEvil = "东邪", EastPalyer = "黄药师" });
            factory.IniteFactory<SouthPlay>(new SouthPlay { SouthEmperor = "南帝", SouthPalyer = "段智兴" });
            factory.IniteFactory<WestPlay>(new WestPlay { WestDrug = "西毒", WestPalyer = "欧阳锋" });
            factory.IniteFactory<NorthPlay>(new NorthPlay { NorthBeggar = "北丐", NorthPaly = "洪七公" });

            //3
            Console.WriteLine("\n----------------第三题----------------");
            factory.Skills += new ShowSkillDelegate(new EastPlay().PlayFlute);
            factory.Skills += new ShowSkillDelegate(new SouthPlay().PlayBlade);
            factory.Skills += new ShowSkillDelegate(new WestPlay().PlayDrug);
            factory.Skills += () => { new NorthPlay().EatChicken(); };
            //factory.Skills += new FactoryModel.ShowSkillDelegate(new NorthPlay().EatChicken);
            factory.ShowSkill();

            //4
            Console.WriteLine("\n----------------第四题----------------");
            Console.WriteLine("南派");
            SouthPlay southPlay = new SouthPlay();
            southPlay.SetTemp(900);
            southPlay.Events += () => { new SouthPlay().ManCry(); };
            southPlay.Events += () => { new SouthPlay().WomanCry(); };
            southPlay.Events += () => { new SouthPlay().ChildrenCry(); };
            southPlay.Events += () => { new SouthPlay().AllPersonCry(); };
            southPlay.Events += () => { new SouthPlay().AllChildrenCry(); };
            southPlay.Events += () => { new SouthPlay().AllDogCry(); };
            southPlay.ShowFireBreak();

            Console.WriteLine("\n北派");
            NorthPlay northPlay = new NorthPlay();
            northPlay.SetTemp(1200);
            northPlay.Events += () => { new NorthPlay().WomanCry(); };
            northPlay.Events += () => { new NorthPlay().ChildrenCry(); };
            northPlay.ShowFireBreak();

            //5
            Console.WriteLine("\n----------------第五题----------------");
            Console.WriteLine("中派");
            CenterPlay centerPlay = new CenterPlay();
            centerPlay.BeginEvent += () => { Console.WriteLine("中派独有搞笑开场白！！"); };
            centerPlay.HighEvent += () => { new CenterPlay().HighPlay(); };
            centerPlay.EndEvent += () => { Console.WriteLine("中派独有搞笑结束！！"); };
            centerPlay.Show();


            Console.ReadKey();
        }
    }
}
