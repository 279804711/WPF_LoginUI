using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    internal class LoginVM: INotifyPropertyChanged
    {
        private MainWindow _main;
        public LoginVM(MainWindow main) 
        {
            _main = main;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private LoginModel _LoginM = new LoginModel();
        //public LoginModel LoginM
        //{ 
        //    get { 
        //        if(_LoginM == null)
        //            _LoginM = new LoginModel();
        //        return _LoginM; }
        //    set { 
        //        _LoginM = value;
        //        RaisePropertyChanged("LoginM");
        //    }
        //}

        public string UserName
        {
            get { return _LoginM.UserName; }
            set
            {
                _LoginM.UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string PassWord
        {
            get { return _LoginM.PassWord; }
            set
            {
                _LoginM.PassWord = value;
                RaisePropertyChanged("PassWord");
            }
        }

        public void LoginFunc()
        {
            if (UserName == "wpf" && PassWord == "666")
            {
                Index index = new Index();
                index.Show();
                _main.Hide();
                //MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("输入的用户名或密码不正确！");
                UserName = "";
                PassWord = "";
            }
        }

        bool CanLoginExecute()
        {
            return true;
        }
        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFunc, CanLoginExecute);
            }
        }







    }
}
