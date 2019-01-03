using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_project_dotnet.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        
        public string ItemID { get; set; }
        [StringLength(100)]
        public string ItemName { get; set; }
        [StringLength(255)]
        public string ItemDesc { get; set; }

    }
}