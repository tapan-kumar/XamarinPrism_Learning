using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoToo.ViewModels
{
    public  class TodoItemViewModel : BaseViewModel
    {
        private readonly TodoItem _item;
        public event EventHandler ItemStatusChanged;
        public TodoItem Items
        {
            get;  private set;
        }
        

        public TodoItemViewModel(TodoItem Item)
        {
            _item = Item;
        }
        public string StatusText => Items.Completed ? "Reactivate" : "Completed";
        
    }
}
