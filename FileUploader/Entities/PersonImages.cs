using System.ComponentModel.DataAnnotations.Schema;

namespace FileUploader.Entities
{
    [Table("person_images")]
    public class PersonImages
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
        [Column("personid")]
        public Guid PersonId { get; set; }
        public Person Person { get; set; } = new Person();
        
    }
}
