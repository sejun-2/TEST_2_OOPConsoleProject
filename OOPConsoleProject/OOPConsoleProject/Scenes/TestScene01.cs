using OOPConsoleProject.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    internal class TestScene01 : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("테스트 씬 01");
            Console.WriteLine();
            Console.WriteLine("1. 테스트 2씬으로 이동");
            Console.WriteLine("2. 테스트 3씬으로 이동");
            Console.Write("선택지를 입력하세요 : ");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;  // true는 키 입력 키를 화면에 표시하지 않음
        }

        public override void Update()
        {
            
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("테스트 씬 01에서 테스트 씬 2로 이동합니다.");
                    Game.ChangeScene("Test2");
                    break;
                case ConsoleKey.D2:
                    Util.PressAnyKey("테스트 씬 01에서 테스트 씬 3로 이동합니다.");
                    Game.ChangeScene("Test3");
                    break;
                case ConsoleKey.Escape:
                    Game.End();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

    }
}
