using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginModel loginModel;
        public MainWindow()
        {
            
            InitializeComponent();
            loginModel = new LoginModel();

            this.DataContext = loginModel;//指定上下文
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String userName = txtUserName.Text;
            //String passWord = txtPassWord.Text;
            if(loginModel.userName == "wpf" && loginModel.passWord == "666")
            {
                Index index = new Index();
                index.Show();
                this.Hide();
                //MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("输入的用户名或密码不正确！");
                loginModel.userName = "";
                loginModel.passWord = "";

            }
        }
    }

    public class LoginModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private String _userName;
        public String userName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged("userName");
            }
        }

        private String _passWord;
        public String passWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
                RaisePropertyChanged("passWord");
            }
        }
    }


}
