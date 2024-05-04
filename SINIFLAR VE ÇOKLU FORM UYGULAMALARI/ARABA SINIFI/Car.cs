using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABA_SINIFI
{
    public class Car
    {
        private int _year;
        private string _make;
        private int _speed;

        public Car(string make, int year)
        {
            _make = make;
            _year = year;
            _speed = 0;
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void Accelarate()
        {
            _speed += 5;
        }

        public void Break()
        {
            _speed -= 5;
        }
    }
}
