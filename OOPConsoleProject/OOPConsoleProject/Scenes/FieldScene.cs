using OOPConsoleProject.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    internal class FieldScene : BaseScene
    {   
        private ConsoleKey input;

        private string[] mapData;
        private bool[,] map;

        public FieldScene()
        {
            mapData = new string[]
            {
                "########",
                "#   #  #",
                "#   #  #",
                "#   #  #",
                "#      #",
                "########"
            };

            map = new bool[6, 8];
            for (int y = 0; y < map.GetLength(0); y++)  // map.GetLength(0) -> map[y,x] 의 y 길이 
            {
                for (int x = 0; x < map.GetLength(1); x++)  // map.GetLength(1) -> map[y,x] 의 x 길이 
                {
                    map[y,x] = mapData[y][x] == '#' ? false : true;
                }
            }

            Game.Player.position = new Vector2(1, 1); // 플레이어의 시작 위치 설정
            Game.Player.map = map; // 플레이어의 맵 설정

        }
        public override void Render()
        {
            PrintMap();
            Game.Player.Print(); // 플레이어의 위치를 출력
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;  // true는 키 입력 키를 화면에 표시하지 않음
        }
        public override void Update()
        {
            Game.Player.Move(input); // 플레이어 이동
        }
        public override void Result()
        {
            //foreach(GameObject gameObject in Game.GameObjects)
            //{
            //    if (Game.Player.position == go.position)
            //    {
            //        go.Interact(Game.Player); // 상호작용
            //    }
            //}
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0); // 커서를 맵의 시작 위치로 이동

            for (int y = 0; y < map.GetLength(0); y++)  // map.GetLength(0) -> map[y,x] 의 y 길이 
            {
                for (int x = 0; x < map.GetLength(1); x++)  // map.GetLength(1) -> map[y,x] 의 x 길이 
                {
                    Console.Write(map[y, x] ? " " : "#");
                }
                Console.WriteLine();
            }
        }
    
    }
}
