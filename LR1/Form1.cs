using System.Data;
using System.Drawing.Drawing2D;

namespace LR1
{
        public partial class Form1 : Form
        {

        public Form1()
        {
            InitializeComponent();
        }

        public struct col        
        {
            public int val1;
            public int val2;
            public int val3;
            public int val4;
            public int val5;

            public col(int _val1, int _val2, int _val3, int _val4, int _val5)
            {
                val1 = _val1;
                val2 = _val2;   
                val3 = _val3;
                val4 = _val4;
                val5 = _val5;
            }
           
        }
        List<col> cols = new List<col>();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false; //запретна добавление доп. строк

            cols.Add(new col(0, 0, 0, 0, 0));                      // стартовое создание "пустой" матрицы (начало)
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));

            DataTable matrix = new DataTable("Матрица");
            matrix.Columns.Add("*", typeof(int));
            matrix.Columns.Add("**", typeof(int));
            matrix.Columns.Add("***", typeof(int));
            matrix.Columns.Add("****", typeof(int));
            matrix.Columns.Add("*****", typeof(int));

            for (int i = 0; i < cols.Count; i++)
            {
                matrix.Rows.Add(cols[i].val1, cols[i].val2, cols[i].val3, cols[i].val4, cols[i].val5);
            }                                                      // стартовое создание "пустой" матрицы (конец)

            dataGridView1.DataSource = matrix;                     // вывод матрицы в форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < dataGridView1.ColumnCount;i++)
                for (int j = 0; i < dataGridView1.RowCount; j++)
                { //какую-то структуру сюда надо сделать
                   mass[i, j] = Convert.ToInt32(dataGridView1[i, j].Value.ToString()); // сохранние матрицы из формы в некую переменную, с которой уже можно будет выполнять операции
                }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            DataTable matrix = new DataTable("Матрица"); // создается объект "Матрица"
            int a = Convert.ToInt32(textBox1.Text);      // количество строк матрицы
            int b = Convert.ToInt32(textBox2.Text);      // количество столбцов матрицы

            for (int i = 0; i < b; i++)   // в цикле задаются столбцы матрицы
            {                             // считанные из textbox2 
                matrix.Columns.Add("*", typeof(int));
            };
            for (int i = 0; i < a; i++)   // в цикле задаются строки матрицы
            {                             // считанные из textbox1 
                matrix.Rows.Add("*", typeof(int));
            };
           

            dataGridView1.DataSource = matrix;
             //этой строчкой теперь все изменения dataGridView
            // будут отражаться в matrix 
        }*/

        /*
        private void razmerBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            for (int i = 0; i < m; i++)
            {
                dataGridView1.Columns.Add("", "");
            }
            for (int j = 0; j < n; j++)
            {

                dataGridView1.Rows.Add();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount - 1;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
        }
        */
    }
}
