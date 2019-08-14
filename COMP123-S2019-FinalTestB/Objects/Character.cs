﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Student Name: Harbin Ramo
 * Student ID  : 301046044
 * Description : This is the Character class used in character creation
 *               This is also the Data container for the application 
 */

namespace COMP123_S2019_FinalTestB.Objects
{
    public class Character
    {
        //Character Names
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> FirstNameList;
        public List<string> LastNameList;
        public List<string> InventoryList;

        //Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        //Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        //Character Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipments
        public List<Item> Inventory;

        //Constructor
        public Character()
        {
            this.Inventory = new List<Item>();
            this.FirstNameList = new List<string>();
            this.LastNameList = new List<string>();
        }
    }
}
