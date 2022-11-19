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

namespace WPF_Rassokhin_PR_7_YP
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

        int cvn1;
        int cvn2;
        int summ;
        int summ1;

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tcSample.Items.Count - 1;
            tcSample.SelectedIndex = newIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if (newIndex >= tcSample.Items.Count)
                newIndex = 0;
            tcSample.SelectedIndex = newIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();

            if (summ == 1)
            {
                MessageBox.Show("Правильных вопросов 1/10");
            }
            else if (summ == 2)
            {
                MessageBox.Show("Правильных вопросов 2/10");
            }
            else if (summ == 3)
            {
                MessageBox.Show("Правильных вопросов 3/10");
            }
            else if (summ == 4)
            {
                MessageBox.Show("Правильных вопросов 4/10");
            }
            else if (summ == 5)
            {
                MessageBox.Show("Правильных вопросов 5/10");
            }
            else if (summ == 6)
            {
                MessageBox.Show("Правильных вопросов 6/10");
            }
            else if (summ == 7)
            {
                MessageBox.Show("Правильных вопросов 7/10");
            }
            else if (summ == 8)
            {
                MessageBox.Show("Правильных вопросов 8/10");
            }
            else if (summ == 9)
            {
                MessageBox.Show("Правильных вопросов 9/10");
            }
            else if (summ == 10)
            {
                MessageBox.Show("Правильных вопросов 10/10");
            }
            else if (summ == 0)
            {
                MessageBox.Show("Правильных вопросов 0/10");
            }
            double summ2 = double.Parse(TextBox2.Text);
            double x = summ2 / 10;
            TextBox3.Text += Environment.NewLine + "Ваша оценка " + x.ToString();
            MessageBox.Show(TextBox3.Text);
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
           
        }

        private void Test_V1_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V2_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V3_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V4_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V5_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V6_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V8_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V7_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V9_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Test_V10_Click(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
            int cvn2;
            cvn2 = Convert.ToInt32(TextBox2.Text);
            summ1 = cvn2 + 5;
            TextBox2.Text = summ1.ToString();
        }

        private void Zanovo(object sender, RoutedEventArgs e)
        {
            switch (Test_V1.IsChecked)
            {
                case true:
                    Test_V1.IsChecked = false;
                    break;
            }
            switch (Test_V1_1.IsChecked)
            {
                case true:
                    Test_V1_1.IsChecked = false;
                    break;

            }
            switch (Test_V1_3.IsChecked)
            {
                case true:
                    Test_V1_3.IsChecked = false;
                    break;

            }
            switch (Test_V1_4.IsChecked)
            {
                case true:
                    Test_V1_4.IsChecked = false;
                    break;

            }

            switch (Test_V2.IsChecked)
            {
                case true:
                    Test_V2.IsChecked = false;
                    break;

            }
            switch (Test_V2_1.IsChecked)
            {
                case true:
                    Test_V2_1.IsChecked = false;
                    break;

            }
            switch (Test_V2_3.IsChecked)
            {
                case true:
                    Test_V2_3.IsChecked = false;
                    break;

            }
            switch (Test_V2_4.IsChecked)
            {
                case true:
                    Test_V2_4.IsChecked = false;
                    break;

            }

            switch (Test_V3.IsChecked)
            {
                case true:
                    Test_V3.IsChecked = false;
                    break;

            }
            switch (Test_V3_1.IsChecked)
            {
                case true:
                    Test_V3_1.IsChecked = false;
                    break;

            }
            switch (Test_V3_3.IsChecked)
            {
                case true:
                    Test_V3_3.IsChecked = false;
                    break;

            }
            switch (Test_V3_4.IsChecked)
            {
                case true:
                    Test_V3_4.IsChecked = false;
                    break;

            }

            switch (Test_V4.IsChecked)
            {
                case true:
                    Test_V4.IsChecked = false;
                    break;

            }
            switch (Test_V4_1.IsChecked)
            {
                case true:
                    Test_V4_1.IsChecked = false;
                    break;

            }
            switch (Test_V4_3.IsChecked)
            {
                case true:
                    Test_V4_3.IsChecked = false;
                    break;

            }
            switch (Test_V4_2.IsChecked)
            {
                case true:
                    Test_V4_2.IsChecked = false;
                    break;

            }

            switch (Test_V5.IsChecked)
            {
                case true:
                    Test_V5.IsChecked = false;
                    break;

            }
            switch (Test_V5_1.IsChecked)
            {
                case true:
                    Test_V5_1.IsChecked = false;
                    break;

            }
            switch (Test_V5_2.IsChecked)
            {
                case true:
                    Test_V5_2.IsChecked = false;
                    break;

            }
            switch (Test_V5_4.IsChecked)
            {
                case true:
                    Test_V5_4.IsChecked = false;
                    break;

            }

            switch (Test_V6.IsChecked)
            {
                case true:
                    Test_V6.IsChecked = false;
                    break;

            }
            switch (Test_V6_1.IsChecked)
            {
                case true:
                    Test_V6_1.IsChecked = false;
                    break;

            }
            switch (Test_V6_3.IsChecked)
            {
                case true:
                    Test_V6_3.IsChecked = false;
                    break;

            }
            switch (Test_V6_2.IsChecked)
            {
                case true:
                    Test_V6_2.IsChecked = false;
                    break;

            }

            switch (Test_V7.IsChecked)
            {
                case true:
                    Test_V7.IsChecked = false;
                    break;

            }
            switch (Test_V7_2.IsChecked)
            {
                case true:
                    Test_V7_2.IsChecked = false;
                    break;

            }
            switch (Test_V7_3.IsChecked)
            {
                case true:
                    Test_V7_3.IsChecked = false;
                    break;

            }
            switch (Test_V7_4.IsChecked)
            {
                case true:
                    Test_V7_4.IsChecked = false;
                    break;

            }

            switch (Test_V8.IsChecked)
            {
                case true:
                    Test_V8.IsChecked = false;
                    break;

            }
            switch (Test_V8_1.IsChecked)
            {
                case true:
                    Test_V8_1.IsChecked = false;
                    break;

            }
            switch (Test_V8_3.IsChecked)
            {
                case true:
                    Test_V8_3.IsChecked = false;
                    break;

            }
            switch (Test_V8_2.IsChecked)
            {
                case true:
                    Test_V8_2.IsChecked = false;
                    break;

            }

            switch (Test_V9.IsChecked)
            {
                case true:
                    Test_V9.IsChecked = false;
                    break;

            }
            switch (Test_V9_1.IsChecked)
            {
                case true:
                    Test_V9_1.IsChecked = false;
                    break;

            }
            switch (Test_V9_2.IsChecked)
            {
                case true:
                    Test_V9_2.IsChecked = false;
                    break;

            }
            switch (Test_V9_4.IsChecked)
            {
                case true:
                    Test_V9_4.IsChecked = false;
                    break;

            }

            switch (Test_V10.IsChecked)
            {
                case true:
                    Test_V10.IsChecked = false;
                    break;

            }
            switch (Test_V10_2.IsChecked)
            {
                case true:
                    Test_V10_2.IsChecked = false;
                    break;

            }
            switch (Test_V10_3.IsChecked)
            {
                case true:
                    Test_V10_3.IsChecked = false;
                    break;

            }
            switch (Test_V10_4.IsChecked)
            {
                case true:
                    Test_V10_4.IsChecked = false;
                    break;

            }

            int newIndex = tcSample.SelectedIndex + 1;
            if (newIndex >= tcSample.Items.Count)
                newIndex = 0;
            tcSample.SelectedIndex = newIndex;


            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
        }

    }
}
