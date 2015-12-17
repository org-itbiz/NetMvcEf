using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Framework.Models
{
    public class MemberT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int No { get; set; }

        [Required(ErrorMessage = "ID is must be Required.")]
        public virtual string Id { get; set; }
        public virtual string BlogUrl { get; set; }
        public virtual int Level { get; set; }
        public virtual string Status { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string CellPhone { get; set; }
        public virtual string Url { get; set; }
        public virtual string SnsType { get; set; }
        public virtual string SnsId { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
    }
}