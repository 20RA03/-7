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

namespace ПР7
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

        private void FindPerimetr_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rectangle delta = new Rectangle(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
                result.Text = delta.GetPerimetr(delta).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void FindArea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rectangle delta = new Rectangle(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
                result.Text = delta.GetArea(delta).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил Ржевский Александр. Задание: Использовать класс Pair (пара четных чисел). Определить производный класс Rectangle(прямоугольник) с характеристиками стороны прямоугольника.Определить методы вычисления периметра и площади прямоугольника.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            firstP1.Clear();
            secondP1.Clear();
            result.Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
