using DoToo.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoToo.ViewModels
{
    public  class ItemViewModel : BaseViewModel
    {
        private TodoItemRepository _repository;
        public ItemViewModel(TodoItemRepository Repository)
        {
            _repository = Repository;
        }
    }
}
