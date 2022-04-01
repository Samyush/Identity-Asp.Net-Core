namespace Identity_Asp.Net_Core.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? EmployeePhone { get; set; }
        public int? Age { get; set; }
    }
}
