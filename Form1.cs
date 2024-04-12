using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Set<int> ParseInput(string input)
        {
            // Разбиваем введенную строку на элементы
            string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Преобразуем элементы в числа и добавляем в множество
            Set<int> set = new Set<int>();
            foreach (string element in elements)
            {
                if (int.TryParse(element.Trim(), out int value))
                {
                    set.Add(value);
                }
            }

            return set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание объекта вашего класса MyClass
            MyClass myObject = new MyClass();

            // Использование вложенного класса Date для получения даты создания
            MyClass.Date creationDate = new MyClass.Date();
            textBox4.Text += $"Объект создан {creationDate.CreationDate}\r\n";

            // Применение метода расширения для типа string
            string str = textBox1.Text;
            if (String.IsNullOrEmpty(str))
            {
                errorProvider1.SetError(textBox1, "Не указана строка!");
            }
            else
            {
                textBox4.Text += $"Строка с точкой: {str.AddPeriod()}\r\n";
                errorProvider1.Clear();
            }

            // Применение метода расширения для вашего типа из задания
            // Например, если ваш класс называется CustomClass
            MyClass custom = new MyClass();


            // Использование класса Set<T> и его перегруженных операторов
            string input1 = textBox2.Text;
            string input2 = textBox3.Text;

            // Преобразуем введенные строки в множества
            Set<int> set1 = ParseInput(input1);
            Set<int> set2 = ParseInput(input2);

            // Выполняем операцию объединения множеств
            Set<int> intersection = set1 * set2;

            textBox4.Text += $"Пересечение множеств: {string.Join(", ", intersection)}\r\n";

            // Проверка на подмножество
            bool isSubset = set1 > set2;
            textBox4.Text += $"set1 является подмножеством set2: {isSubset}\r\n";
        }
    }



}
