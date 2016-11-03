using Xamarin.Forms;

namespace LineIndicator
{

    public partial class LineIndicatorPage : ContentPage
    {
        public LineIndicatorViewModel ViewModel {get; set;}

        public LineIndicatorPage ()
        {
            ViewModel = new LineIndicatorViewModel ();

            InitializeComponent ();

            BindingContext = ViewModel;
        }
    }
}
