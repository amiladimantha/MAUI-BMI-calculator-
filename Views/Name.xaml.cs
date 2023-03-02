using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class EmpName : ContentPage
{
	public EmpName()
	{
		InitializeComponent();
		this.BindingContext = new NameModel();

	}
}