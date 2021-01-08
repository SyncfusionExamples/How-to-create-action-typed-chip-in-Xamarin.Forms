using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChipType_Sample
{
   public class ViewModel:INotifyPropertyChanged
    {
        private bool isOpen = false;

        private Model modelProperty;

        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                isOpen = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsOpen"));
            }
        }
        public Model ModelProperty
        {
            get { return modelProperty; }
            set
            {
                modelProperty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ModelProperty"));
            }
        }

        public ObservableCollection<Model> InputItems
        {
            get; set;
        }

        public Command ActionCommand { get; set; }

        private void ShowPopup(Object obj)
        {

            ModelProperty = obj as Model;
            IsOpen = true;
        }

        public ViewModel()
        {
            InputItems = new ObservableCollection<Model>();
            InputItems.Add(new Model() { PersonName = "John", PersonImage = ImageSource.FromResource("ChipType_Sample.Image1.png"), PersonMailId = "john@emil.com" });
            InputItems.Add(new Model() { PersonName = "Rose", PersonImage = ImageSource.FromResource("ChipType_Sample.Image2.png"), PersonMailId = "rose@emil.com" });
            ActionCommand = new Command(ShowPopup);
        }
    }
}
