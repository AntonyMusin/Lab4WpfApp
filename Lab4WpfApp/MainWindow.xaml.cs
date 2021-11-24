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

namespace Lab4WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDouble = rateEuro * sumEuro;
            resSumE.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rateG.Text);
            double sumGrivna = Convert.ToDouble(sumG.Text);
            double resDouble = rateGrivna * sumGrivna;
            resSumG.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateD.Text);
            double sumDram = Convert.ToDouble(sumD.Text);
            double resDouble = rateDram * sumDram;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rateI.Text);
            double inch=(2.54*rateInch)/100;
            resI.Text = inch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rateF.Text);
            double foot = (30.48 * rateFoot) / 100;
            resF.Text = foot.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rateM.Text);
            double mile = 1609.34 * rateMile;
            resM.Text = mile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVersta = Convert.ToDouble(rateV.Text);
            double versta = 1066.8 * rateVersta;
            resV.Text = versta.ToString();
        }
    }
}
