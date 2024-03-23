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
            dataGridView1.AllowUserToAddRows = false; //�������� ���������� ���. �����

            cols.Add(new col(0, 0, 0, 0, 0));                      // ��������� �������� "������" ������� (������)
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));
            cols.Add(new col(0, 0, 0, 0, 0));

            DataTable matrix = new DataTable("�������");
            matrix.Columns.Add("*", typeof(int));
            matrix.Columns.Add("**", typeof(int));
            matrix.Columns.Add("***", typeof(int));
            matrix.Columns.Add("****", typeof(int));
            matrix.Columns.Add("*****", typeof(int));

            for (int i = 0; i < cols.Count; i++)
            {
                matrix.Rows.Add(cols[i].val1, cols[i].val2, cols[i].val3, cols[i].val4, cols[i].val5);
            }                                                      // ��������� �������� "������" ������� (�����)

            dataGridView1.DataSource = matrix;                     // ����� ������� � �����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < dataGridView1.ColumnCount;i++)
                for (int j = 0; i < dataGridView1.RowCount; j++)
                { //�����-�� ��������� ���� ���� �������
                   mass[i, j] = Convert.ToInt32(dataGridView1[i, j].Value.ToString()); // ��������� ������� �� ����� � ����� ����������, � ������� ��� ����� ����� ��������� ��������
                }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            DataTable matrix = new DataTable("�������"); // ��������� ������ "�������"
            int a = Convert.ToInt32(textBox1.Text);      // ���������� ����� �������
            int b = Convert.ToInt32(textBox2.Text);      // ���������� �������� �������

            for (int i = 0; i < b; i++)   // � ����� �������� ������� �������
            {                             // ��������� �� textbox2 
                matrix.Columns.Add("*", typeof(int));
            };
            for (int i = 0; i < a; i++)   // � ����� �������� ������ �������
            {                             // ��������� �� textbox1 
                matrix.Rows.Add("*", typeof(int));
            };
           

            dataGridView1.DataSource = matrix;
             //���� �������� ������ ��� ��������� dataGridView
            // ����� ���������� � matrix 
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
