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
            dataGridView1.AllowUserToAddRows = false; // запрет на добавление доп. строк

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

        private void button2_Click_1(object sender, EventArgs e)  // работоспособность недоказана
        {
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            int[,] matr = new int[n, m];
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    matr[iRow, iCol] = Convert.ToInt32(dataGridView1.Rows[iRow].Cells[iCol].Value.ToString()); // сохранние матрицы из формы в некую переменную, с которой уже можно будет выполнять операции
                }
        }


        private void button3_Click(object sender, EventArgs e) // работает
        {
            dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold); // делает текст в ячейке жирным
        }

        private void button4_Click(object sender, EventArgs e) // рандомная генерация значений ячеек 
        {                                                      // работает
            Random rnd = new Random();
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    dataGridView1.Rows[iRow].Cells[iCol].Value = rnd.Next(-10, 10); //ячейка = рандом
                }
        }

        private void button5_Click(object sender, EventArgs e) // работает
        {
            dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9); // снимает жирный текст с ячейки
        }

    }
}
