namespace TestCleanArchitecture.domain.model
{
    internal class Todo
    {
        int userId { get; set; }
        int id { get; set; }
        string title { get; set; }
        bool completed { get; set; }
    }
}
