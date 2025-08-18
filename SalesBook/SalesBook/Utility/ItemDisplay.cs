using SalesBook;
namespace SalesBook.Utility;

public class ItemDisplay
{
	public Item? _item {get; set; }
	public int _frequency {get; set; } = 0 ;
	public bool _increase {get; set; } = true;
	public int _count {get; set; } = 0;
	public ItemDisplay(Item item, int frequency){
		_item = item;
		_frequency = frequency;
	}
	public ItemDisplay(){}
	public void ChangeState(){
	       	_increase = !_increase;
	}
	public void IncreaseCount()=> _count++;
	public void DecreaseCount() => _count-= 1;

}
