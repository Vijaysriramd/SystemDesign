using System;

namespace DesignPatterns.Prototype
{
    public class Client
    {
        public static void Demo()
        {
            var student = new Student
            {
                Name = "John Doe",
                Age = 20,
                Batch = "2023"
            };

            var clonedStudent = student.Clone();
            clonedStudent.Name = "Jane Doe";

            Console.WriteLine($"Original: {student.Name}, Age: {student.Age}");
            Console.WriteLine($"Cloned: {clonedStudent.Name}, Age: {clonedStudent.Age}");

            var intelligentStudent = new IntelligentStudent
            {
                Name = "Smart Student",
                Age = 22,
                Batch = "2023",
                Iq = 150
            };

            var clonedIntelligentStudent = intelligentStudent.Clone();
            Console.WriteLine($"Intelligent Student IQ: {intelligentStudent.Iq}");
            Console.WriteLine($"Cloned Intelligent Student IQ: {clonedIntelligentStudent.Iq}");
        }
    }
}
