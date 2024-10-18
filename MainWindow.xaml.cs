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

namespace ПР6
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

        int[] arr;
        Random a = new Random();
        
        public void b1_Click(object sender, RoutedEventArgs e)
        {
               
            arr = new int[a.Next(10, 25)]; // генерация рандомного массива рандомной длиной от 10 до 25 чисел;
            Random rand = new Random();


            for (int i = 0; i < a.Next(10, 25); i++)
            {
                arr[i] = rand.Next(-100, 100); //заполнение массива числами от -100 до 100
            }
            for (int i = 0; i < a.Next(10, 25); i++)
            {
                tb1.Text = string.Join(Environment.NewLine, arr);

            }


        }


        private void BubbleSort(int[] arr) //сортировка пузырьком
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)        
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }
        public static void InsertionSort(int[] arr) //сортировка вставками
        {
            for (int i = 1; i < arr.Length; i++)
            {
                // Сохраняем текущий элемент (который нужно вставить)
                int k = arr[i];

                // Индекс предыдущего элемента
                int j = i - 1;

                // Пока предыдущий элемент больше текущего (k) и j не меньше 0
                while (j >= 0 && arr[j] > k)
                {
                    // Сдвигаем предыдущий элемент вправо
                    arr[j + 1] = arr[j];
                    // Двигаемся к предыдущему элементу
                    j--;
                }

                // Вставляем k на правильное место 
                arr[j + 1] = k;
            }
        }


        public void SelectionSort(int[] d) //сортировка выбором
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
            }
        }
        public void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public void QuickSort(int[] arr, int low, int high) //быстрая сортировка
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return (i + 1);
        }
        // Обмен элементов массива
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }



     

        private void b2_Click_1(object sender, RoutedEventArgs e)
        {
            int[] b = new int[arr.Length];
            arr.CopyTo(b, 0);
            BubbleSort(b);

            for (int i = 0; i < b.Length; i++)
            {
                tb2.Text = string.Join(Environment.NewLine, b);

            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            int[] c = new int[arr.Length];
            arr.CopyTo(c, 0);
            InsertionSort(c);
            for (int i = 0; i < c.Length; i++)
            {
                tb3.Text = string.Join(Environment.NewLine, c);

            }

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            int[] d = new int[arr.Length];
            arr.CopyTo(d, 0);
            SelectionSort(d);
            for (int i = 0; i < d.Length; i++)
            {
                tb4.Text = string.Join(Environment.NewLine, d);

            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            int[] f = new int[arr.Length];
            arr.CopyTo(f, 0);
            QuickSort(f);
            for (int i = 0; i < f.Length; i++)
            {
                tb5.Text = string.Join(Environment.NewLine, f);

            }
        }
    }
}

