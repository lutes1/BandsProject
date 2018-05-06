using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
    public class EquipmentTypevViewModel
    {
        public long EquipmentTypeId { get; set; }
        [StringLength(20)]
        [Display(Name = "Type")]
        public string Name { set; get; }
    }
}
