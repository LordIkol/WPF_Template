using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Template.Models;

namespace WPF_Template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RentalObject rental = new RentalObject(
                new Address("TestStreet", "2", 12345, "somewherecity"), new ContractInformation(1000, DateTime.Now, true),new RenterMain("Herr","Marc","Rieken",100,101, DateTime.Parse("05.03.1985"),1));
        }
    }
}
