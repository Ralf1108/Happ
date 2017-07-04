using Xamarin.Forms;

namespace HApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            MyImage.GestureRecognizers.Add(new TapGestureRecognizer(OnImageClick));            
        }

        private void OnImageClick(View arg1, object arg2)
        {
            DependencyService.Get<INativeHelper>().CloseApp();
        }
    }
}
