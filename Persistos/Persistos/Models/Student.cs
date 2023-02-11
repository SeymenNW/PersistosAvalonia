using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistos.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public int Semester { get; set; }

        public Student() 
        { 

        }

       public Student(string name, string major, int semester)
        {
            Name = name;
            Major = major;
            Semester = semester;
        }


        public override string ToString()
        {
            return $"Name: {Name} | Major: {Major} | Semester: {Semester}";
        }



    }
}
