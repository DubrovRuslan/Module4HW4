namespace Module4HW4.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
