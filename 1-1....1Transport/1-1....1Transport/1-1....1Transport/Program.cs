using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace _1_1._._._._1Transport
{
    class MyForm : Form
    {
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private DataGridView dataGridView2;
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість постачальників";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "та замовників";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Побудувати матрицю задачі";
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
            this.textBox3.Size = new System.Drawing.Size(191, 476);
            this.textBox3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Вирішити задачу!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 418);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(706, 343);
            this.dataGridView2.TabIndex = 9;
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(1118, 774);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int providers, purchasers;
            try
            {
                providers = Convert.ToInt32(textBox1.Text);
                purchasers = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                textBox3.Text += "Wrong number of perchasers or providers" + Environment.NewLine;
                return;
            }
            if (providers < 1 || providers > 50 || purchasers < 1 || purchasers > 50)
            {
                textBox3.Text += "Wrong number of perchasers or providers" + Environment.NewLine;
                return;
            }
            int i, j;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[0].HeaderText = ("        Магазини\n      \\ \nСклади");
            dataGridView1.Columns[0].Name = "Column0";
            for (i = 1; i <= purchasers; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[i].HeaderText = ("Магазин#"+i);
                dataGridView1.Columns[i].ReadOnly = false;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[0].Name = "Column"+i;
            }
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns[purchasers+1].HeaderText = "Запаси";
            dataGridView1.Columns[purchasers + 1].ReadOnly = false;
            dataGridView1.Columns[purchasers + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[0].Name = "Column"+i;
            for (i = 0; i < providers; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[0].Value = "Склад#" + (i + 1);
            }
            dataGridView1.Rows.Add(new DataGridViewColumn());
            dataGridView1.Rows[providers].Cells[0].Value = "Потреби";// +(i + 1);
            dataGridView1.Rows[providers].Cells[purchasers + 1].Value = "////////";
            dataGridView1.Rows[providers].Cells[purchasers + 1].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int providers, purchasers;
            int i, j, k;
            providers = dataGridView1.Rows.Count - 1;
            purchasers = dataGridView1.Columns.Count - 2;
            if (dataGridView1.Columns.Count < 1 || dataGridView1.Rows[providers].Cells[purchasers + 1].Value != "////////")
            {
                textBox3.Text += "Task is not complete....yet";
                return;
            }
            element[] matrix = new element[providers* purchasers];
            double[] Holdings=new double[providers],  Needs  = new double[purchasers];
            double HoldingsSum = 0, NeedsSum = 0;
            try
            {
                for (i = 0; i < providers; i++)
                {
                    for (j = 1; j <= purchasers;j++)
                    {
                        matrix[i*purchasers+ j - 1].Cost = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        if (matrix[i * purchasers + j - 1].Cost <= 0)
                        {
                            throw new Exception();
                        }
                        matrix[i * purchasers + j - 1].x = j - 1;
                        matrix[i * purchasers + j - 1].y = i;
                    }
                    Holdings[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[purchasers+1].Value);
                    if (Holdings[i] < 0)
                    {
                        throw new Exception();
                    }
                    HoldingsSum += Holdings[i];
                }
                for (j = 1; j <= purchasers; j++)
                {
                    Needs[j - 1] = Convert.ToDouble(dataGridView1.Rows[providers].Cells[j].Value);
                    if (Needs[j - 1] < 0)
                    {
                        throw new Exception();
                    }
                    NeedsSum+=Needs[j-1];
                }
            }
            catch
            {
                textBox3.Text += "Wrong input, mortal"+Environment.NewLine;
                return;
            }
            if(Math.Round(HoldingsSum,10)!=Math.Round(NeedsSum,10))
            {
                textBox3.Text += "Problem shall be closed" + Environment.NewLine;
                return; 
            }
            matrix = matrix.OrderBy(Temp => Temp.Cost).ToArray();
            element[,] RelienceMatrix = new element[providers, purchasers];
            double[] ResultNeeds = new double[purchasers];
            double[] ResultHoldings = new double[providers];
            for (i = 0; i < providers; i++)
            {
                ResultHoldings[i] = Holdings[i];
                for (j = 0; j < providers; j++)
                {
                    RelienceMatrix[i, j]=new element(i,j);
                }
            }
            for (i = 0; i < purchasers; i++)
            {
                ResultNeeds[i] = Needs[i];
            }
            int BasicCells = 0;
            for (i = 0; i < matrix.Length; i++)
            {
                RelienceMatrix[matrix[i].y, matrix[i].x].Cost = matrix[i].Cost;
                if (ResultNeeds[matrix[i].x] < ResultHoldings[matrix[i].y])
                {
                    RelienceMatrix[matrix[i].y, matrix[i].x].Value = ResultNeeds[matrix[i].x];
                    ResultHoldings[matrix[i].y] -= ResultNeeds[matrix[i].x];
                    ResultNeeds[matrix[i].x] = 0;
                    if (RelienceMatrix[matrix[i].y, matrix[i].x].Value != 0)
                    {
                        BasicCells++;
                    }
                }
                else
                {
                    RelienceMatrix[matrix[i].y, matrix[i].x].Value = ResultHoldings[matrix[i].y];
                    ResultNeeds[matrix[i].x] -= ResultHoldings[matrix[i].y];
                    ResultHoldings[matrix[i].y] = 0;
                    if (RelienceMatrix[matrix[i].y, matrix[i].x].Value != 0)
                    {
                        BasicCells++;
                    }
                }
            }
            if (BasicCells < providers + purchasers - 1)
            {
                textBox3.Text += "Degeneracy relience matrix" + Environment.NewLine;
                return; 
            }
            double[] ProvPotent = new double[providers], PurchPotent = new double[purchasers];
            bool[] ProvPotentNum = new bool[providers], PurchPotentNum = new bool[purchasers];
            int AllPotentUnupdatedNum = providers + purchasers - 1;
            for (j = 0; j < providers; j++)
            {
                ProvPotentNum[j] = false;
            }
            for (i = 0; i < purchasers; i++)
            {
                PurchPotentNum[i] = false;
            }
            ProvPotentNum[0] = true;
            ProvPotent[0] = 0;
            AllPotentUnupdatedNum--;
            while (AllPotentUnupdatedNum > 0)
            {
                for (j = 0; j < providers; j++)
                {
                    if (ProvPotentNum[j] == true)
                    {
                        for (i = 0; i < purchasers; i++)
                        {
                            if ((RelienceMatrix[j,i].Value != 0)&&(PurchPotentNum[i] ==false))
                            {
                                PurchPotent[i] = RelienceMatrix[j, i].Cost - ProvPotent[j];
                                PurchPotentNum[i] = true;
                                AllPotentUnupdatedNum--;
                            }
                        }
                    }
                }
                for (j = 0; j < purchasers; j++)
                {
                    if (PurchPotentNum[j] == true)
                    {
                        for (i = 0; i < providers; i++)
                        {
                            if ((RelienceMatrix[i, j].Value != 0)&&(ProvPotentNum[i] ==false))
                            {
                                ProvPotent[i] = RelienceMatrix[i, j].Cost - PurchPotent[j];
                                ProvPotentNum[i] = true;
                                AllPotentUnupdatedNum--;
                            }
                        }
                    }
                }
            }
            for (i = 0; i < providers; i++)
            {
                for (j = 0; j < purchasers; j++)
                {
                    RelienceMatrix[i, j].delta = RelienceMatrix[i, j].Cost - ProvPotent[i] - PurchPotent[j];
                }
            }
            bool TimeToEnd = true;
            int wrongx = -1, wrongy = -1;
            for (i = 0; i < providers; i++)
            {
                for (j = 0; j < purchasers; j++)
                {
                    if (RelienceMatrix[i, j].delta < 0)
                    {
                        TimeToEnd = false;
                        wrongx = j;
                        wrongy = i;
                    }
                }
            }
            int Tempx = -1, Tempy = -1;
            double temp;
            int NumberOfIter = 1;
            while (!TimeToEnd)
            {
                for (i = 0; i < providers; i++)
                {
                    if (RelienceMatrix[i, wrongx].Value > 0)
                    {
                        for (j = 0; j < purchasers; j++)
                        {
                            if (RelienceMatrix[wrongy, j].Value > 0)
                            {
                                if (RelienceMatrix[i, j].Value > 0)
                                {
                                    Tempx = j;
                                    Tempy = i;
                                    break;
                                }
                            }
                        }
                        if (Tempx!=-1)
                            break;
                    }
                }
                temp = Math.Min(RelienceMatrix[Tempy, wrongx].Value, RelienceMatrix[wrongy, Tempx].Value);
                RelienceMatrix[Tempy, wrongx].Value -= temp;
                RelienceMatrix[wrongy, Tempx].Value-= temp;
                RelienceMatrix[Tempy, Tempx].Value+= temp;
                RelienceMatrix[wrongy, wrongx].Value += temp;
                AllPotentUnupdatedNum = providers + purchasers - 1;
                for (j = 0; j < providers; j++)
                {
                    ProvPotentNum[j] = false;
                }
                for (i = 0; i < purchasers; i++)
                {
                    PurchPotentNum[i] = false;
                }
                ProvPotentNum[0] = true;
                ProvPotent[0] = 0;
                AllPotentUnupdatedNum--;
                while (AllPotentUnupdatedNum > 0)
                {
                    for (j = 0; j < providers; j++)
                    {
                        if (ProvPotentNum[j] == true)
                        {
                            for (i = 0; i < purchasers; i++)
                            {
                                if ((RelienceMatrix[j, i].Value != 0) && (PurchPotentNum[i] == false))
                                {
                                    PurchPotent[i] = RelienceMatrix[j, i].Cost - ProvPotent[j];
                                    PurchPotentNum[i] = true;
                                    AllPotentUnupdatedNum--;
                                }
                            }
                        }
                    }
                    for (j = 0; j < purchasers; j++)
                    {
                        if (PurchPotentNum[j] == true)
                        {
                            for (i = 0; i < providers; i++)
                            {
                                if ((RelienceMatrix[i, j].Value != 0) && (ProvPotentNum[i] == false))
                                {
                                    ProvPotent[i] = RelienceMatrix[i, j].Cost - PurchPotent[j];
                                    ProvPotentNum[i] = true;
                                    AllPotentUnupdatedNum--;
                                }
                            }
                        }
                    }
                }
                for (i = 0; i < providers; i++)
                {
                    for (j = 0; j < purchasers; j++)
                    {
                        RelienceMatrix[i, j].delta = RelienceMatrix[i, j].Cost - ProvPotent[i] - PurchPotent[j];
                    }
                }
                TimeToEnd = true;
                wrongx = -1; wrongy = -1;
                for (i = 0; i < providers; i++)
                {
                    for (j = 0; j < purchasers; j++)
                    {
                        if (RelienceMatrix[i, j].delta < 0)
                        {
                            TimeToEnd = false;
                            wrongx = j;
                            wrongy = i;
                        }
                    }
                }
                Tempx = -1; Tempy = -1;
                NumberOfIter++;
            }
            Console.WriteLine(NumberOfIter);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView2.Columns[0].ReadOnly = false;
            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[0].HeaderText = ("        Магазини\n      \\ \nСклади");
            dataGridView2.Columns[0].Name = "Column0";
            for (i = 1; i <= purchasers; i++)
            {
                dataGridView2.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView2.Columns[i].HeaderText = ("Магазин#" + i);
                dataGridView2.Columns[i].ReadOnly = false;
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView2.Columns[0].Name = "Column" + i;
            }
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView2.Columns[purchasers + 1].HeaderText = "U";
            dataGridView2.Columns[purchasers + 1].ReadOnly = false;
            dataGridView2.Columns[purchasers + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[0].Name = "Column" + i;
            for (i = 0; i < providers; i++)
            {
                dataGridView2.Rows.Add(new DataGridViewRow());
                dataGridView2.Rows[i].Cells[0].Value = "Склад#" + (i + 1);
            }
            dataGridView2.Rows.Add(new DataGridViewColumn());
            dataGridView2.Rows[providers].Cells[0].Value = "V";// +(i + 1);
            dataGridView2.Rows[providers].Cells[purchasers + 1].Value = "////////";
            dataGridView2.Rows[providers].Cells[purchasers + 1].ReadOnly = false;
            for (i = 0; i < providers; i++)
            {
                for (j = 0; j < purchasers; j++)
                {
                    dataGridView2.Rows[i].Cells[j + 1].Value = "" + RelienceMatrix[i, j].Value + "\\" + RelienceMatrix[i, j].delta + "\\" + RelienceMatrix[i,j].Cost;
                }
                dataGridView2.Rows[i].Cells[purchasers + 1].Value = ProvPotent[i];
            }
            for (j = 0; j < purchasers; j++)
            {
                dataGridView2.Rows[providers].Cells[j+1].Value = PurchPotent[j];
            }
        }
    }
    struct element
    {
        public int x, y;
        public double Cost;
        public double Value;
        public double delta;

        /*public element()
        {
            x = 0;
            y = 0;
            Cost = 0;
            Value = 0;
            delta = 0;
        */
        public element(int NX, int NY)
        {
            x = NX;
            y = NY;
            Cost = 0;
            Value = 0;
            delta = 0;
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
}
