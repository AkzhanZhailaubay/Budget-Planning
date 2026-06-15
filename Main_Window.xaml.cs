using System;
using System.Windows;
using System.Windows.Input;

namespace Budget_Planner_Alnur_Madiyev_w68646
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) //all window to be moved even with window styling set to none 
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }



        public void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); //when close button clicked exit program
        }

        public void Rd_Budget_Checked(object sender, RoutedEventArgs e)
        {
        }

        public void Rd_Home_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void Cb_Dark_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
