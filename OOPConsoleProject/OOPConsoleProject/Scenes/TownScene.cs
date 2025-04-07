using OOPConsoleProject.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    internal class TownScene : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("장소 : 초보자의 마을");
            Console.WriteLine("활기찬 마을이다.");
            Console.WriteLine();
            Console.WriteLine("1. 필드로 나간다.");
            Console.WriteLine("어디로 가시겠습니까? : ");

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
                    Util.PressAnyKey("초보자의 마을에서 필드로 나갑니다.");
                    Game.ChangeScene("Field");
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
