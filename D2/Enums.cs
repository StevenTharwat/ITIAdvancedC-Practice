namespace D2
{
    public enum Gender
    {
        Male,
        Female
    }

    [Flags]
    public enum secLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
}
