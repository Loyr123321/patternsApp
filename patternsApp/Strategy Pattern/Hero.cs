﻿using patternsApp.Strategy_Pattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsApp.Strategy_Pattern
{
    internal class Hero
    {
        private readonly string _name;
        private IWeapons? _weapon;
        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapons weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>");

            if (_weapon is null)
            {
                Console.WriteLine($"{_name} can't attack. Set a weapon");
                return;
            }
            Console.WriteLine($"{_name} stands menacingly");
            Console.Write($"{_name} ");
            
            _weapon.Shoot();

            Console.WriteLine($"{_name} ceases to stand menacingly");
        }
    }
}
