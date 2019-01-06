using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_project_dotnet.Models
{

    public class Item
    {

        [Key]
        public string ItemID { get; set; }

        public string ItemName { get; set; }

        public string ItemDesc { get; set; }
        public int Id { get; set; }


        public virtual TSNUser TSNUser { get; set; }



    }
}