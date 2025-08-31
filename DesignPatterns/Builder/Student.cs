using System;

namespace DesignPatterns.Builder
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string UniversityName { get; private set; }
        public string Batch { get; private set; }
        public long Id { get; private set; }
        public int GradYear { get; private set; }
        public string PhNo { get; private set; }

        private Student(StudentBuilder builder)
        {
            Name = builder.Name;
            Age = builder.Age;
            UniversityName = builder.UniversityName;
            Batch = builder.Batch;
            Id = builder.Id;
            GradYear = builder.GradYear;
            PhNo = builder.PhNo;
        }

        public static StudentBuilder Builder()
        {
            return new StudentBuilder();
        }

        public class StudentBuilder
        {
            public string Name { get; private set; }
            public int Age { get; private set; }
            public string UniversityName { get; private set; }
            public string Batch { get; private set; }
            public long Id { get; private set; }
            public int GradYear { get; private set; }
            public string PhNo { get; private set; }

            public StudentBuilder SetName(string name)
            {
                Name = name;
                return this;
            }

            public StudentBuilder SetAge(int age)
            {
                Age = age;
                return this;
            }

            public StudentBuilder SetUniversityName(string universityName)
            {
                UniversityName = universityName;
                return this;
            }

            public StudentBuilder SetBatch(string batch)
            {
                Batch = batch;
                return this;
            }

            public StudentBuilder SetId(long id)
            {
                Id = id;
                return this;
            }

            public StudentBuilder SetGradYear(int gradYear)
            {
                GradYear = gradYear;
                return this;
            }

            public StudentBuilder SetPhNo(string phNo)
            {
                PhNo = phNo;
                return this;
            }

            public Student Build()
            {
                if (!Validate())
                {
                    throw new InvalidOperationException("Validation failed");
                }
                return new Student(this);
            }

            private bool Validate()
            {
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(UniversityName) || string.IsNullOrEmpty(Batch))
                {
                    throw new InvalidOperationException("Name, UniversityName, or Batch is null or empty");
                }
                return true;
            }
        }
    }
}
