﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void ShowThongTin()
        {
            Console.WriteLine($"{Id} - {Name} - {Age}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }
    }
}
