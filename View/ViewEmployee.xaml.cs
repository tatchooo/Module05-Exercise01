using Module05_Exercise01.ViewModel;
using Module05_Exercise01.Services;

namespace Module05_Exercise01.View;

public partial class ViewEmployee : ContentPage
{
	public ViewEmployee()
	{
		InitializeComponent();

		var employeeViewModel = new EmployeeViewModel();
		BindingContext = employeeViewModel;
	}
}