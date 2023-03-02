using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class BMICalculator : ContentPage
{
	public BMICalculator()
	{
		InitializeComponent();
		this.BindingContext = new BMICalculatorModel();

    }
}