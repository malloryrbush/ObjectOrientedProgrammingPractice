using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Cat
    {
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Cat()
        {
            //DEFAULT CONTRUCTOR
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    }
}