using DoToo.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoToo.ViewModels
{
   public  class MainViewModel : BaseViewModel
    {
        private readonly TodoItemRepository _repository;

        public MainViewModel(TodoItemRepository Repository)

        {
            _repository = Repository;
            Task.Run(async () => await LoadData());
        }

        private async Task LoadData()
        {

        }
    }
}
