namespace DesignPatterns.Prototype
{
    public class IntelligentStudent : Student
    {
        public int Iq { get; set; }

        public IntelligentStudent() { }

        public IntelligentStudent(IntelligentStudent student) : base(student)
        {
            Iq = student.Iq;
        }

        public new IntelligentStudent Clone()
        {
            return new IntelligentStudent(this);
        }
    }
}
