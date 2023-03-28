namespace MVVM_Playground.ViewModel;
public partial class BaseViewModel : ObservableObject
{
	[ObservableProperty]
	private ObservableCollection<Channel> channels;
	public BaseViewModel()
	{
		Channels = new ObservableCollection<Channel>()
		{
			new Channel() {
				Id = 1,
				FwVersion = "1.2.3",
				Counter = 0
			},
			new Channel() {
				Id = 2,
				FwVersion = "1.2.3",
				Counter = 0
			},
		};
		// Create a timer tick routine
		IDispatcherTimer tickTimer;
		tickTimer = Application.Current.Dispatcher.CreateTimer();
		tickTimer.Interval = TimeSpan.FromMilliseconds(1000);
		tickTimer.Tick += Timer_Tick;
		tickTimer.Start();
	}
	private void Timer_Tick(object sender, EventArgs e)
	{
		Channels[0].Counter += 1;
		Channels[1].Counter += 2;
	}
}
