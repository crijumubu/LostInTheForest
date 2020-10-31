﻿using FirstFantasy_FinalExam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_FinalExam.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        public abstract string attack();
        public string ShowInformation()
        {
            return "This is a weapon";
        }
    }
}
