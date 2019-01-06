using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVC_project_dotnet.Models
{

    public class Items
    {

        [Key]
        public string ItemID { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        public string ItemDesc { get; set; }
        public byte[] ItemPicture { get; set; }
        public int Id { get; set; }


        public virtual TSNUser TSNUser { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }

    }
}