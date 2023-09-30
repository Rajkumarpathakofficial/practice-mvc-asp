using System.ComponentModel.DataAnnotations;

namespace Demo.Entites
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Range(1,100)]
        public int Roll { get; set; }
    }
}
