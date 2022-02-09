﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Map
    {

        public static char[,] mapArray = new char[,]//temp map also remember to create border
        {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',','#','#','#','#','#','#','#','#','#','#',',','#'},
            {'#',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',',','},
            {'#',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',','#'},
            {'#',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#',',','#'},
            {'#',',',',',',','#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',','#',',',',',',',',','#','#','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',','#',',','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',','#','#','#',',',',',',',',',',',',',',',',',',',',','#'},
            {'#',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',',','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
        };

        public void Update() //future use
        {
            
        }

        public void isWall(GameCharacter character) //future implementation
        {
            //if (Map.mapArray[y, x] == '#') //if I leave boundaries, it crashes because it's checking y and x vs map coordinates
            //{
            //    character.y = character.priorPositionY;
            //    character.x = character.priorPositionX;
            //}
        }

        public void Draw()
        {
            for (int mapY = 0; mapY <= 11; mapY++)
            {
                for (int mapX = 0; mapX <= 21; mapX++)
                {
                    Console.Write(mapArray[mapY, mapX]);
                }
                Console.WriteLine("");
            }
        }
    }
}
