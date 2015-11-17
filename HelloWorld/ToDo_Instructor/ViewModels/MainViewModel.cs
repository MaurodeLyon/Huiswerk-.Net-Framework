using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo_Instructor.Models;

namespace ToDo_Instructor.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TodoItem> _items;//List<TodoItem> _items;
        public ObservableCollection<TodoItem> Items
        {
            get { return _items; }
        }

        private string _newItemDescription;
        
        public string NewItemDescription
        {
            get { return _newItemDescription; }
            set
            {
                _newItemDescription = value;
                OnpropertyChanged("NewItemDescription");
            }

        }

        private ICommand _addToItemCommand;

        public ICommand AddToDoItemCommand
        {
            get { return _addToItemCommand; }
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

        public MainViewModel()
        {
            _items = new ObservableCollection<TodoItem>();// = new List<TodoItem>();
            _addToItemCommand = new DelagateCommand(AddToDoItem);
            _items.Add(new TodoItem
            {
                Description = "My TODO item"
            });
        }

        private void AddToDoItem()
        {
            var newTodoItem = new TodoItem
            {
                Description = NewItemDescription
            };
            _items.Add(newTodoItem);
        }
    }
}
