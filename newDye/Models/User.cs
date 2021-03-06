//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newDye.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Payements = new HashSet<Payements>();
        }
    
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("ConfirmPassword")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public Nullable<int> CardINFO { get; set; }
    
        public virtual CardINFO CardINFO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payements> Payements { get; set; }
    }
}
