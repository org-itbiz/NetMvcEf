using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net.Framework.Models
{
    public class MemberT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [Required(ErrorMessage = "ID is must be Required.")]
        public virtual string MemberNm { get; set; }
        public virtual string AppId { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
    }
}