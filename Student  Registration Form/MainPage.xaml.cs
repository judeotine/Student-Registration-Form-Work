using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Student__Registration_Form
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void GreetStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!NameBox.Text.StartsWith("Hello "))
            {
                NameBox.Text = "Hello " + NameBox.Text;
            }
            ContentDialog dialog = new ContentDialog
            {
                Title = "ISBAT FORM",
                Content = "You have greeted the student",
                CloseButtonText = "OKAY"
            };
            await dialog.ShowAsync();
        }


        private async void ShowCourse_Click(object sender, RoutedEventArgs e)
        {
            CourseBox.Text = "Course: " + CourseBox.Text;
            ContentDialog dialog = new ContentDialog
            {
                Title = "ISBAT FORM",
                Content = "Course information displayed successfully",
                CloseButtonText = "OKAY"
            };
            await dialog.ShowAsync();
        }

        private async void ShowContacts_Click(object sender, RoutedEventArgs e)
        {
            EmailBox.Text = "Email: " + EmailBox.Text;
            PhoneBox.Text = "Phone: " + PhoneBox.Text;

            ContentDialog dialog = new ContentDialog
            {
                Title = "ISBAT FORM",
                Content = "Contact information displayed successfully",
                CloseButtonText = "OKAY"
            };
            await dialog.ShowAsync();
        }

        private async void ConfirmRegistration_Click(object sender, RoutedEventArgs e)
        {
            string message = "Registration Confirmed for " + NameBox.Text +
                             "\nID: " + IdBox.Text +
                             "\nCourse: " + CourseBox.Text +
                             "\nEmail: " + EmailBox.Text +
                             "\nPhone: " + PhoneBox.Text;

            ContentDialog dialog = new ContentDialog
            {
                Title = "ISBAT FORM",
                Content = message,
                CloseButtonText = "OKAY"
            };
            await dialog.ShowAsync();
        }
    }
}
