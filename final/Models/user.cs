namespace final.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            posts = new HashSet<posts>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "* must be filled")]
        [StringLength(50)]
        public string Full_name { get; set; }

        [Required(ErrorMessage = "* must be filled")]
        [StringLength(50)]
        public string User_name { get; set; }

        [Required(ErrorMessage = "* must be filled")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "invalid mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "* must be filled")]
        [StringLength(50)]
        public string password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "* must be filled")]
        [Compare("password", ErrorMessage = "Not Identical")]
        public string confirm_password { get; set; }
        [Required(ErrorMessage = "* must be filled")]
        [Range(13, 1000, ErrorMessage = "age must be atleast 13")]
        public int? age { get; set; }


        public string photo { get; set; }

        [StringLength(10)]
        public string gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<posts> posts { get; set; }
    }
}
