namespace D6.StudentDept
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Student> Students { get; private set; } = [];

        public Department(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            //if student removed tell me 
            student.RemoveStudent += OnStudentRemove;
        }
        public void removeStudent(Student student)
        {
            Students.Remove(student);
            //i no longer intersted wit that 
            student.RemoveStudent -= OnStudentRemove;
        }
        void OnStudentRemove(Object? obj, StudentEventArgs e)
        {
            if (obj == null) return;
            Student std = (Student) obj;
            removeStudent(std);
            Console.WriteLine($"student {std.Name} has been removed because {e.Message}");
        }
    }
}
