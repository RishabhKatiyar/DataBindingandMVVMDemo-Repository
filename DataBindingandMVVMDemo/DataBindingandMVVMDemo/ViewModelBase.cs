using System.ComponentModel;

namespace DataBindingandMVVMDemo
{
    //Step 3
    //internal class ViewModelBase
    //{
    //}
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}