using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bands.WEB.Models.ViewModels;

namespace Bands.WEB.Models.ManageViewModels
{
	public class IndexViewModel
	{
		[Phone]
		[Display(Name = "Phone number")]
		public string PhoneNumber { get; set; }

		public string StatusMessage { get; set; }

		public MusicianViewModel MusicianViewModel { get; set; }
	}
}
