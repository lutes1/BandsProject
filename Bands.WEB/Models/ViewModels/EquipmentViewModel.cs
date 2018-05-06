using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bands.WEB.Models.ViewModels
{
	public class EquipmentViewModel
	{
		public long EquipmentId { get; set; }
        [Required]
		[StringLength(20)]
		public string EquipmentName { get; set; }
	    [Required]
        [StringLength(30)]
        public string EquipmentModel { get; set; }
	    [Required]
        [StringLength(20)]
		public string EquipmentType { get; set; }
	}
}
