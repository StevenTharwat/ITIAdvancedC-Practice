namespace D6.StudentDept
{
    public class StudentEventArgs : EventArgs
    {
        public string Message { get; set; }
        public StudentEventArgs(string message)
        {
            Message = message;
        }
    }
}