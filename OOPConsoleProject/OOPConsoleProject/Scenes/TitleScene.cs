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
            Console.WriteLine("계속하려면 아무키나 누르세요..");
        }
        public override void Input()
        {
            Console.ReadKey(true);  // true는 키 입력 키를 화면에 표시하지 않음

        }
        public override void Update()
        {
        }
        public override void Result()
        {
            Game.ChangeScene("Test1");
        }
    
    
    }
}
