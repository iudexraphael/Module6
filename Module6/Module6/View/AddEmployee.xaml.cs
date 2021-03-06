using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module6.Model;
using Module6.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployee : ContentPage
    {
        EmployeeViewModel _viewModel;
        bool _isUpdate;
        int employeeID;
        public AddEmployee()
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            _isUpdate = false;
        }
        public AddEmployee(EmployeeModel obj)
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            if (obj != null)
            {
                employeeID = obj.Id;
                txtName.Text = obj.Employeename;
                txtEmail.Text = obj.Email;
                txtAddress.Text = obj.Address;
                _isUpdate = true;
            }

        }
        private async void btnSaveUpdate_Clicked(object sender, EventArgs e)
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Employeename = txtName.Text;
            obj.Email = txtEmail.Text;
            obj.Address = txtAddress.Text;
            if (_isUpdate)
            {
                obj.Id = employeeID;
                await _viewModel.UpdateEmployee(obj);
            }
            else
            {
                _viewModel.InsertEmployee(obj);
            }
            await this.Navigation.PopAsync();
        }
    }
}