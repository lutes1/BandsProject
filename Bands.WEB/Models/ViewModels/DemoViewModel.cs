using System.ComponentModel.DataAnnotations;

namespace Bands.WEB.Models.ViewModels
{
	public class DemoViewModel
	{
		[StringLength(20)]
		public string Name { get; set; }
		[StringLength(200)]
		public string Link { get; set; }

	}
}
