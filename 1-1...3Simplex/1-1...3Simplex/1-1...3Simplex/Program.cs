using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace _1_1._._._3Simplex
{
    class MyForm : Form
    {
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Label label4;
        private Button button1;

        public MyForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 506);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість змінних";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вирішити задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Журнал";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(882, 40);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 506);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "та нерівностей";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Створити поле для вводу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Запишіть цільову функцію в останній стовпчик";
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(1118, 774);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NumOfVar, NumOfIn;
            int i, j;
            try
            {
                NumOfVar = Convert.ToInt32(textBox1.Text);
                NumOfIn = Convert.ToInt32(textBox2.Text);
                if (NumOfVar <= 1 || NumOfVar >= 20 || NumOfIn <= 1 || NumOfIn>=20)
                    throw new Exception();
            }
            catch
            {
                textBox3.Text += "Wrong number of variables or inequalities" + Environment.NewLine;
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (i = 0; i < NumOfVar; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[i].HeaderText = "X" + (i + 1);
            }
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns[NumOfVar].HeaderText = "B";
            for (i = 0; i <= NumOfIn; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
            }
            dataGridView1.Rows[NumOfIn].Cells[NumOfVar].ReadOnly = true;
            dataGridView1.Rows[NumOfIn].Cells[NumOfVar].Value = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumOfVar, NumOfIn;
            int i, j;
            NumOfIn = dataGridView1.Rows.Count;
            NumOfVar = dataGridView1.Columns.Count;
            double[,] SymplexTable = new double[NumOfIn, NumOfVar];
            try
            {
                for (i = 0; i < NumOfIn; i++)
                {
                    SymplexTable[i, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[NumOfVar-1].Value);
                }
                for (i = 0; i < NumOfIn-1; i++)
                {
                    for (j = 1; j < NumOfVar; j++)
                    {
                        SymplexTable[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j - 1].Value);
                    }
                }
                for (i = 0; i < NumOfVar-1; i++)
                    SymplexTable[NumOfIn-1, i + 1] = -1 * Convert.ToDouble(Convert.ToDouble(dataGridView1.Rows[NumOfIn-1].Cells[i].Value));
            }
            catch 
            {
                textBox3.Text += "Wrong input" + Environment.NewLine;
                return;
            }
            Simplex Obj = new Simplex(SymplexTable);
            double[] Answer = new double[NumOfVar];
            SymplexTable = Obj.Solve(Answer);
            textBox3.Text += "The answer is:" + Environment.NewLine;
            for (i = 0; i < NumOfVar-1; i++)
            {
                textBox3.Text += "X" + (i + 1) + "=" + Answer[i] + Environment.NewLine;
            }
            double Val = 0;
            for (i = 0; i < NumOfVar - 1; i++)
            {
                Val += Answer[i] * Convert.ToDouble(Convert.ToDouble(dataGridView1.Rows[NumOfIn - 1].Cells[i].Value));
            }
            textBox3.Text += "The value in this point is" + Val + Environment.NewLine;
        }
    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm Prog = new MyForm();
            Application.Run(Prog);
        }
    }
    public class Simplex
    {
        double[,] SymplexTable;

        int M, N;
        int i, j;
        List<int> Basis;
        public Simplex(double[,] InputTable)
        {
            M = InputTable.GetLength(0);
            N = InputTable.GetLength(1);
            SymplexTable = new double[M, N + M - 1];
            Basis = new List<int>();

            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N + M - 1; j++)
                {
                    if (j < N)
                        SymplexTable[i, j] = InputTable[i, j];
                    else
                        SymplexTable[i, j] = 0;
                }
                if ((N + i) < N + M - 1)
                {
                    SymplexTable[i, N + i] = 1;
                    Basis.Add(N + i);
                }
            }
            N = SymplexTable.GetLength(1);
        }

        public double[,] Solve(double[] result)
        {
            int TempColumnIndex, TempRowindex;
            double[,] TempTable;

            while (!ExitCondition())
            {
                TempColumnIndex = ColumnIndex();
                TempRowindex = RowIndex(TempColumnIndex);
                Basis[TempRowindex] = TempColumnIndex;

                TempTable = new double[M, N];

                for (j = 0; j < N; j++)
                    TempTable[TempRowindex, j] = SymplexTable[TempRowindex, j] / SymplexTable[TempRowindex, TempColumnIndex];
                for (i = 0; i < M; i++)
                {
                    if (i == TempRowindex)
                        continue;

                    for (j = 0; j < N; j++)
                        TempTable[i, j] = SymplexTable[i, j] - SymplexTable[i, TempColumnIndex] * TempTable[TempRowindex, j];
                }
                SymplexTable = TempTable;
            }

            for (int i = 0; i < result.Length; i++)
            {
                int k = Basis.IndexOf(i + 1);
                if (k != -1)
                    result[i] = SymplexTable[k, 0];
                else
                    result[i] = 0;
            }
            return SymplexTable;
        }

        private bool ExitCondition()
        {
            for (j = 1; j < N; j++)
            {
                if (SymplexTable[M - 1, j] < 0)
                    return false;
            }
            return true;
        }

        private int ColumnIndex()
        {
            int Index = 1;

            for (j = 2; j < N; j++)
                if (SymplexTable[M - 1, j] < SymplexTable[M - 1, Index])
                    Index = j;

            return Index;
        }

        private int RowIndex(int mainCol)
        {
            int Index = 0;

            for (int i = 0; i < M - 1; i++)
            {
                if (SymplexTable[i, mainCol] > 0)
                {
                    Index = i;
                    break;
                }
            }
            for (int i = Index + 1; i < M - 1; i++)
                if ((SymplexTable[i, mainCol] > 0)
                    && ((SymplexTable[i, 0] / SymplexTable[i, mainCol]) < (SymplexTable[Index, 0] / SymplexTable[Index, mainCol])))
                    Index = i;
            return Index;
        }


    }
}
