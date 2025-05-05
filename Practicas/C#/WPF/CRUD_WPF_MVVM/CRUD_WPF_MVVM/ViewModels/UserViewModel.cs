using CRUD_WPF_MVVM.Commands;
using CRUD_WPF_MVVM.Models;
using CRUD_WPF_MVVM.Models.BD;
using CRUD_WPF_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CRUD_WPF_MVVM.ViewModels
{
    internal class UserViewModel : ViewModelBase
    {
        private readonly BD _bd;
        private ObservableCollection<UserModel> _users;
        private UserModel _user;


        public UserViewModel()
        {
            _bd = new BD();
            _user = new UserModel();
            _users = _bd.Get();
        }

        public UserModel User 
        { 
            get => _user;
            set
            {
                if (_user != value)
                {
                    _user = value;
                    OnPropertyChanged(nameof(User));
                }
            }
        }

        public ObservableCollection<UserModel> Users 
        { 
            get => _users; 
            set
            {
                if (_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        public ICommand AddCommand
        {
            get
            {
                return new RelayCommand(AddExecute, AddCanExecute);
            }
            set
            {

            }
        }

        public ICommand EditCommand
        {
            get
            {
                return new RelayCommand(EditExecute, EditCanExecute);
            }
            set
            {

            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand(DeleteExecute, DeleteCanExecute);
            }
            set
            {

            }
        }

        private void AddExecute(Object user)
        {
            _bd.Add(User);
            Users = _bd.Get();
            User = new UserModel();
        }

        private bool AddCanExecute(Object user)
        {
            return true;
        }

        private void EditExecute(Object user)
        {
            _bd.Edit(User);
            Users = _bd.Get();
            User = new UserModel();
        }

        private bool EditCanExecute(Object user)
        {
            return true;
        }

        private void DeleteExecute(Object user)
        {
            _bd.Delete(User);
            Users = _bd.Get();
            User = new UserModel();
        }

        private bool DeleteCanExecute(Object user)
        {
            return true;
        }



    }
}
