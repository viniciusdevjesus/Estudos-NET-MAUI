using TesteMVVM.View;

namespace TesteMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductView();
        }
    }
}
