﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMain
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student {StudentName = "Frank"};

                context.Students.Add(student);

                context.SaveChanges();
            }
        }
    }
}
