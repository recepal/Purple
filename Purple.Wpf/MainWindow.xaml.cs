using Purple.Service.Grpc;
using Purple.Wpf.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Purple.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonnelClient _service;
        public MainWindow()
        {
            InitializeComponent();

            _service = new PersonnelClient();
        }

        private async void Grpc_Click(object sender, RoutedEventArgs e)
        {
            PersonnelGto personnel = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Remre",
                Surname = "Dalışkan"
            };
            PersonnelRequest request = new();
            request.Personnel = personnel;
            PersonnelResponse result = await _service.SavePersonnel(request);
            bool isOk = result.Result;
        }
    }
}
