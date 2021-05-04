using System;

namespace testcsharp
{

    public class Student
    {
        public int age;
        public String name;
    }

    public class Student_with_attributes
    {

        public int Age { get; set; }
        public String Name { get; set; }
        public Student_with_attributes(String name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}