using System.ComponentModel.DataAnnotations;
using System.Text;
namespace SalesBook;

public class Item
{	[Key]
	public int Id {get; set;}
	[Required(ErrorMessage="Every created item must have a name")]
	[Display(Name="Name of Item")]
	public string ItemName {get; set;} = string.Empty;
	private string? _abbreviation;
	public string? Abbreviation {
		get {
			return _abbreviation; 
		} 
		
		set {
		StringBuilder sb = new StringBuilder();
		string[] words = this.ItemName.Split();
		foreach(var word in words){
			if(words.Length > 1)
			{
				sb.Append(word[0]);
			} else {
				sb.Append(word.Substring(0,3));
			}
		}
		_abbreviation = sb.ToString().ToUpper();
	} }
	[Display(Name="Type of Packaging")]
	public string PackageType {get; set;} = string.Empty;
	[Required(ErrorMessage="The number of items in a package is required")]
	[Display(Name="Quantity Per Box/Palette")]
	public int ItemQuantityPerPackage {get; set; } 
	[Required(ErrorMessage="The cost of purchasing this item is required. This cost is the purchasing cost + transportation per unit")]
	[Display(Name="Purchase Cost")]
	public decimal CostPerPackage {get; set; } = 0.0M;
	[Required]
	[Display(Name="Carton/Palette Price")]
	public decimal PricePerPackage {get; set; } = 0.0M ;
	[Required]
	[Display(Name="Retail Price")]
	public decimal PricePerUnit {get; set; } = 0.0M;

	public DateTime CreatedAt {get; set; } = DateTime.Now ;
	public DateTime UpdatedAt {get; set; } = DateTime.Now;

	public ICollection<ItemTicket> ItemTickets {get; set; } = [];
}
public class ItemDTO {
[Required(ErrorMessage="Every created item must have a name")]
        [Display(Name="Name of Item")]
        public string ItemName {get; set;} = string.Empty;
        [Display(Name="Type of Packaging")]
        public string PackageType {get; set;} = string.Empty;
        [Required(ErrorMessage="The number of items in a package is required")]
        [Display(Name="Quantity Per Box/Palette")]
        public int ItemQuantityPerPackage {get; set; }
        [Required(ErrorMessage="The cost of purchasing this item is required. This cost is the purchasing cost + transportation per unit")]
        [Display(Name="Purchase Cost")]
        public decimal CostPerPackage {get; set; } = 0.0M;
        [Required]
        [Display(Name="Carton/Palette Price")]
        public decimal PricePerPackage {get; set; } = 0.0M ;
        [Required]
        [Display(Name="Retail Price")]
        public decimal PricePerUnit {get; set; } = 0.0M;

}
