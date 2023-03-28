namespace MVVM_Playground.Model;
public partial class Channel : ObservableObject
{
	[ObservableProperty]
	public byte id;
	[ObservableProperty]
	private string fwVersion;
	[ObservableProperty]
	private int counter;
}
