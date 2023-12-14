using System.ComponentModel.DataAnnotations.Schema;

namespace FileUploader.Entities
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = string.Empty;
    }
}
