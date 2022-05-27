namespace ToDoWebAppMay2022.Data.Entities
{
    public class ToDoList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string OwnerId { get; set; }

        public AppUser? Owner { get; set; }
        public List<ToDoItem>? Items { get; set; } = default!;
    }
}
