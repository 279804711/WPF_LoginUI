using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WPF_LoginUI
{
    internal class CustomButton:Button
    {
        //依赖属性


        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(CustomButton));









        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(CustomButton));





        public Brush BackgroudPressed
        {
            get { return (Brush)GetValue(BackgroudPressedProperty); }
            set { SetValue(BackgroudPressedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroudPressed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroudPressedProperty =
            DependencyProperty.Register("BackgroudPressed", typeof(Brush), typeof(CustomButton));







    }
}
