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
        public MainWindow()
        {
            
            InitializeComponent();
            LoginVM loginVm = new LoginVM(this);
            this.DataContext = loginVm;//指定上下文
        }


        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //String userName = txtUserName.Text;
        //    //String passWord = txtPassWord.Text;
        //    if (loginVm.UserName == "wpf" && loginVm.PassWord == "666")
        //    {
        //        Index index = new Index();
        //        index.Show();
        //        this.Hide();
        //        //MessageBox.Show("OK");
        //    }
        //    else
        //    {
        //        MessageBox.Show("输入的用户名或密码不正确！");
        //        loginVm.UserName = "";
        //        loginVm.PassWord = "";
        //    }
        //}
    }

    //public class LoginModel:INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    private void RaisePropertyChanged(string propertyName)
    //    {
    //        PropertyChangedEventHandler handler = this.PropertyChanged;
    //        if (handler != null)
    //        {
    //            handler(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }


    //}


}
