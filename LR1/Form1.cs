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

        private void button2_Click_1(object sender, EventArgs e)  // ����������������� ����������
        {
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            double[,] matr = new double[n, m];
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    matr[iRow, iCol] = Convert.ToDouble(dataGridView1.Rows[iRow].Cells[iCol].Value.ToString()); // ��������� ������� �� ����� � ����� ����������, � ������� ��� ����� ����� ��������� ��������
                }
        }


        private void button3_Click(object sender, EventArgs e) // ��������
        {
            dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold); // ������ ����� � ������ ������
        }

        private void button4_Click(object sender, EventArgs e) // ��������� ��������� �������� ����� 
        {                                                      // ��������
            Random rnd = new Random();
            int n = dataGridView1.ColumnCount;
            int m = dataGridView1.RowCount;
            for (int iRow = 0; iRow < n; iRow++)
                for (int iCol = 0; iCol < m; iCol++)
                {
                    dataGridView1.Rows[iRow].Cells[iCol].Value = string.Concat(rnd.Next(-10, 10), ",", rnd.Next(0, 10)); //������ = ������
                }
        }

        private void button5_Click(object sender, EventArgs e) // ��������
        {
            //dataGridView1.Rows[2].Cells[2].Style.Font = new Font("Segoe UI", 9); // ������� ������ ����� � ������
            dataGridView1.Rows[2].Cells[2].Style.SelectionBackColor = Color.Red; // ������� ������ ����� � ������
        }

        private void button1_Click(object sender, EventArgs e)     // �������� ����������� ����������
        {                                                           // ����������� ���������� �������
            dataGridView1.AllowUserToAddRows = false; // ������ �� ���������� ���. �����

            // ��������� �������� "������" ������� (������)
            int amount_rows = Convert.ToInt32(textBox1.Text); //���� ���-�� �����
            for (int i = 0; i < amount_rows; i++)
            {
                cols.Add(new col(1.1, 1.1, 1.1, 1.1, 1.1));
            }

            DataTable matrix = new DataTable("�������");

            int amount_cols = Convert.ToInt32(textBox2.Text); //���� ���-�� ��������
            for (int i = 0; i < amount_cols; i++)
            {
                matrix.Columns.Add(string.Join("*", i + 1), typeof(double));
            }

            for (int i = 0; i < cols.Count; i++)
            {
                matrix.Rows.Add(cols[i].val1, cols[i].val2, cols[i].val3, cols[i].val4, cols[i].val5);
            }                                                      // ��������� �������� "������" ������� (�����)

            dataGridView1.DataSource = matrix;                     // ����� ������� � �����
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/����������_����",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://ru.wikipedia.org/wiki/����������_��������_����",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Test();
            form.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            form.Show();
        }
    }
}
