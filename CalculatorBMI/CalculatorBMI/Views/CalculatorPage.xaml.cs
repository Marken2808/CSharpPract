using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculatorBMI.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();
		this.BindingContext = new ViewModels.CalculatorViewModel();
	}
}
