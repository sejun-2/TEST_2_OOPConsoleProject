using OOPConsoleProject.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    internal class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("타이틀 씬");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 종료");
        }
        public override void Input()
        {
            Console.WriteLine("입력 : ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                // 게임 시작
            }
            else if (input == "2")
            {
                // 게임 종료
            }
        }
        public override void Update()
        {
        }
        public override void Result()
        {
        }
    
    
    }
}
