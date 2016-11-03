using System.ComponentModel;

namespace LineIndicator
{
    public class LineIndicatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        double passed;
        public double Passed
        { 
            get { return passed; }
            set
            {
                passed = value;
                NotTested = 100 - (Passed + Failed);
                RaisedPropertyChanged (nameof (Passed));
            }
        }

        double failed;
        public double Failed
        {
            get { return failed; }
            set
            {
                failed = value;
                NotTested = 100 - (Passed + Failed);
                RaisedPropertyChanged (nameof (Failed));
            }
        }

        double notTested;
        public double NotTested
        {
            get { return notTested; }
            set
            {
                notTested = value;
                RaisedPropertyChanged (nameof (NotTested));
            }
        }

        void RaisedPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
        }

    }
}
