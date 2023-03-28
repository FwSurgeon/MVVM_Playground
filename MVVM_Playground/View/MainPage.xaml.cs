namespace MVVM_Playground.View;

public partial class MainPage : ContentPage
{
	public MainPage(BaseViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}
