﻿using ConsoleApp1.StrategyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class Archer : IBattleUnit
    {
        IRangeWeapon rWeapon;
        IMleeWeapon mWeapon;

        public Archer(IRangeWeapon rWeapon, IMleeWeapon mWeapon)
        {
            this.rWeapon = rWeapon;
            this.mWeapon = mWeapon;
        }

        public void Attack(double dmg)
        {
            throw new NotImplementedException();
        }
        //class Archer : BattleUnit
        //{
        //    private int _arrows;
        //    private int _minRangeDamage;
        //    private int _maxRangeDamage;

        //    public Archer(string name) : base(name, 45, 0, "shooter", 7, 1, 2)
        //    {
        //        _arrows = 5;
        //        _minRangeDamage = 7;
        //        _maxRangeDamage = 12;
        //    }

        //    public double RangeAttack(Random rnd)
        //    {
        //        if (_arrows > 0)
        //        {
        //            double currentDamage = Convert.ToDouble(rnd.Next(_minRangeDamage, _maxRangeDamage));
        //            return currentDamage;
        //        }
        //        else
        //        {
        //            return MleeAttack(rnd);
        //        }

        //    }
        //}
    }
