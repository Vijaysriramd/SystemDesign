using System;

namespace DesignPatterns.Builder
{
    public class Client
    {
        public static void Demo()
        {
            var student = Student.Builder()
                .SetName("John Doe")
                .SetAge(25)
                .SetUniversityName("MIT")
                .SetBatch("2023")
                .SetId(12345)
                .SetGradYear(2023)
                .SetPhNo("123-456-7890")
                .Build();

            Console.WriteLine($"Student: {student.Name}, Age: {student.Age}, University: {student.UniversityName}");
        }
    }
}
