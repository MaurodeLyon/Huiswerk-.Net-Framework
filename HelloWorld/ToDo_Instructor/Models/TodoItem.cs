using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Instructor.Models
{
    public class TodoItem : INotifyPropertyChanged
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private bool _completed;

        public bool Completed
        {
            get { return _completed; }
            set
            {
                _completed = value;
                OnpropertyChanged("Completed");

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnpropertyChanged(string propertyName)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

