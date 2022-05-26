namespace ToDoWebAppMay2022.Data.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ParentListId { get; set; }

        public ToDoList? ParentList { get; set; }
    }
}
