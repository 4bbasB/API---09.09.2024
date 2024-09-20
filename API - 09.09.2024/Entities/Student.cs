namespace API___09._09._2024.Entities
{
    public class Student: BaseEntity
    {
        public int GroupId { get; set; }
        public string Fullname { get; set; }
        public double Grade { get; set; }
        public Group Group { get; set; }
    }
}
