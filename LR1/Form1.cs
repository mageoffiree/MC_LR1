using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Numerics;

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
            public double val1;
            public double val2;
            public double val3;
            public double val4;
            public double val5;

            public col(double _val1, double _val2, double _val3, double _val4, double _val5)
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

        }

        private void button2_Click_1(object sender, EventArgs e)  // работоспособность недоказана
        {
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            double[,] matr = new double[n, m];
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    matr[iRow, iCol] = Convert.ToDouble(dataGridView1.Rows[iRow].Cells[iCol].Value.ToString()); // сохранние матрицы из формы в некую переменную, с которой уже можно будет выполн€ть операции
                }
        }


        private void button3_Click(object sender, EventArgs e) // работает
        {
            dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold); // делает текст в €чейке жирным
        }

        private void button4_Click(object sender, EventArgs e) // рандомна€ генераци€ значений €чеек 
        {                                                      // работает
            Random rnd = new Random();
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    dataGridView1.Rows[iRow].Cells[iCol].Value = string.Concat(rnd.Next(-10, 10), ",", rnd.Next(0, 10)); //€чейка = рандом
                }
        }

        private void button5_Click(object sender, EventArgs e) // работает
        {
            //dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9); // снимает жирный текст с €чейки
            dataGridView1.Rows[2].Cells[2].Style.SelectionBackColor = Color.Red; // снимает жирный текст с €чейки
        }

        private void button1_Click(object sender, EventArgs e)     // работает изначальное заполнение
        {                                                           // изначальное заполнение матрицы
            dataGridView1.AllowUserToAddRows = false; // запрет на добавление доп. строк

            // стартовое создание "пустой" матрицы (начало)
            int amount_rows = Convert.ToInt32(textBox1.Text); //беру кол-во строк
            for (int i = 0; i < amount_rows; i++)
            {
                cols.Add(new col(1.1, 1.1, 1.1, 1.1, 1.1));
            }

            DataTable matrix = new DataTable("ћатрица");

            int amount_cols = Convert.ToInt32(textBox2.Text); //беру кол-во столбцов
            for (int i = 0; i < amount_cols; i++)
            {
                matrix.Columns.Add(string.Join("*", i + 1), typeof(double));
            }

            for (int i = 0; i < cols.Count; i++)
            {
                matrix.Rows.Add(cols[i].val1, cols[i].val2, cols[i].val3, cols[i].val4, cols[i].val5);
            }                                                      // стартовое создание "пустой" матрицы (конец)

            dataGridView1.DataSource = matrix;                     // вывод матрицы в форму
        }

        private void равновесиеѕоЌэшуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/–авновесие_Ќэша",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void равновесиедрожащей–укиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/–авновесие_дрожащей_руки",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void пройтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Test();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            form.Show();
        }
    }
}
