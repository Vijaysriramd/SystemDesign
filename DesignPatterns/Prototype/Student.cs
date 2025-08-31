namespace DesignPatterns.Prototype
{
    public class Student : IPrototype<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Batch { get; set; }

        public Student() { }

        public Student(Student student)
        {
            Name = student.Name;
            Age = student.Age;
            Batch = student.Batch;
        }

        public Student Clone()
        {
            return new Student(this);
        }
    }
}
