using TesteMVVM.Models;
using TesteMVVM.ViewModel;

namespace TesteMVVM.View;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		
		BindingContext = new ProductViewModel();

	}
}