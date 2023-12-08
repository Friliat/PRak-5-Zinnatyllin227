using System;
using System.Collections.Generic;
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

namespace PRak_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = -1;
                int n = Convert.ToInt32(ListBoxData.Items[0]);
                int max = 0;
                for (int i = 1; i <= n; i++)
                {
                    int m = Convert.ToInt32(ListBoxData.Items[i]);
                    if (m % 10 == 6 || m % 6 == 0)
                    {
                        if (k == -1)
                        {
                            max = m;
                            k = 0;
                        }
                        else
                        {
                            max = max + m;
                        }
                    }
                }
                if (k != -1)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{max}";
                    ListBoxData.Items.Add("0");
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\n Чисел оканчивающихся на 3 нет";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }
    }
}