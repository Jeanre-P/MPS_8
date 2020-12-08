using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MPS_Assignment_8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void On1ButtonClicked(object sender, EventArgs args)
        {
            string status = statusMessage.Text = "";
            DisplayAlert("You have placed a new a Order", status, "Confirmed");
            App.PeopleRepo.AddNewPerson(newFullname.Text, newGender.Text, newTshirtsize.Text, newDateoforder.Text, newTshirtcolour.Text, newShippingaddress.Text);
            statusMessage.Text = App.PeopleRepo.StatusMessage;
        }

        public void On2ButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<Customer> people = App.PeopleRepo.GetAllPeople();
            customerList.ItemsSource = people;
        }
    }   
}
