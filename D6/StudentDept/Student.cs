namespace D6.StudentDept
{
    internal class Student
    {
        public string Name { get; set; }
        public int AbsCount { get; private set; }
        public int SubjectFail { get; private set; }
        public event EventHandler<StudentEventArgs>? RemoveStudent;
        public Student(string name)
        {
            Name = name;
        }

        public void IncreaseAbsCount()
        {
            AbsCount++;
            if (AbsCount > 3)
            {
                StudentEventArgs eventArgs = new("your Abs is more than 3 times");
                RemoveStudent?.Invoke(this, eventArgs);
            }
        }

        public void Fail()
        {
            SubjectFail++;
            if (SubjectFail > 1)
            {
                StudentEventArgs eventArgs = new("fail in more than one subject");
                RemoveStudent?.Invoke(this, eventArgs);
            }
        }

    }
}
