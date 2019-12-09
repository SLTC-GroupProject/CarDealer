using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarDealers.Models.Models
{
    public class RolePermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("RoleId")]
        public Role ParentRole { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("PermissionId")]
        public Permission ParentPermission { get; set; }
        public int PermissionId { get; set; }
    }
}
