using System.ComponentModel;

namespace TestApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string name;
        private string description;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                if (this.description != value)
                {
                    this.description = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                    }
                }
            }
        }
    }
}