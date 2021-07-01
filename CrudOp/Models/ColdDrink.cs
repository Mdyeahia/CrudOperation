using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOp.Models
{
    public class ColdDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int intColdDrinksId { get; set; }

        public string strColdDrinksName { get; set; }
        public decimal numQuantity { get; set; }
        public decimal numUnitPrice { get; set; }
    }
}
