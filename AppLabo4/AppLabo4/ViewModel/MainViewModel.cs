using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using AppLabo4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppLabo4.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        private Student _selectedStudent;
        private INavigationService _navigationService;
        private ICommand _editStudentCommand;
        // 
        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }


        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());

        }

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                if (_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudent");
                }
            }
        }

        public ICommand EditStudentCommand
        {
            get
            {
                if (this._editStudentCommand == null)
                {
                    this._editStudentCommand = new RelayCommand(() => EditStudent());
                }
                return this._editStudentCommand;
            }
        }

        private void EditStudent()
        {
            if (CanExecute() == true)
            {
                _navigationService.NavigateTo("SecondPage", SelectedStudent);
            }
        }

        public bool CanExecute()
        {
            return (SelectedStudent == null) ? false : true;
        }
    }
}