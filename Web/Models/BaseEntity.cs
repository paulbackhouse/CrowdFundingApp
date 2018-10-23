using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Web.Models
{
    /// <summary>
    /// domain driven design
    /// </summary>
    /// <typeparam name="TEntityKey">Type that an entity should use as a KEY (indexed value)</typeparam>
    public class BaseEntity<TEntityKey> where TEntityKey : struct
    {
        // TODO: DATA: If NoSql solution prefered, refactor accordingly (i.e. mongoDb)
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TEntityKey Id { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime Updated { get; set; } = DateTime.UtcNow;

    }
}
