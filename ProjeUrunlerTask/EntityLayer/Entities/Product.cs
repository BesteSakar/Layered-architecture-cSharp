using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(40)]
        public string ProductName{ get; set; }

        public int stock { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
