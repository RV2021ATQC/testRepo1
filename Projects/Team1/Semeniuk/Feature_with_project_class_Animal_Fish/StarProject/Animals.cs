﻿using System;

namespace StarProject
{
    class Animals
    {
        //поле
        protected double _born_year;
        //властивість поля
        public virtual double born_year 
        { 
            set 
            {
                _born_year = value;
                Console.WriteLine($"Age of this animal is {Convert.ToInt32(DateTime.Now.Year) - _born_year}");
            }
            get
            {
                return _born_year;
            }
        }
        protected string _color;
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }
        //конструктор
        public Animals(double born_year, string color)
        {
            this.born_year = born_year;
            this.color = color;
        }
        //виведення повних років
        public int GetAge()
        {
            return (int)(Convert.ToInt32(DateTime.Now.Year) - this._born_year);
        }
        //перезаписана ф-ція ToString() що викликає Voice()
        public override string ToString()
        {
            return String.Format("Voice: {0}", Voice());
        }
        public string Voice()
        {
            return "Ruf";
        }
    }
}