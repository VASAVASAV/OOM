using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MathParserNet;
namespace _1_8Huk
{
    class MyProg : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCoor;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn ColumnValues;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        int NumberOfDim;

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(218, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть тут розмірність простору";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть функцію для пошуку мінімуму ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCoor,
            this.ColumnValues});
            this.dataGridView1.Location = new System.Drawing.Point(218, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(223, 166);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnCoor
            // 
            this.ColumnCoor.HeaderText = "Координата";
            this.ColumnCoor.Name = "ColumnCoor";
            this.ColumnCoor.ReadOnly = true;
            this.ColumnCoor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCoor.Width = 80;
            // 
            // ColumnValues
            // 
            this.ColumnValues.HeaderText = "Значення";
            this.ColumnValues.Name = "ColumnValues";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть початкову точку пошуку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Знайти мінімум";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(218, 332);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(223, 164);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Координата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Значення";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Точка мінімуму:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(447, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 481);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 456);
            this.textBox4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введіть точність обчислень";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введіть початкове шаг λ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "1";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(711, 564);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MyProg";
            this.Text = "Метод найшвидшого спуску";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private double[,] MySort(double[,] aim, int dim)
        {
            double temp;
            int i, j, k;
            for (i = 0; i < dim; i++)
            {
                for (j = 0; j < dim - i - 1; j++)
                {
                    if (aim[j, 0] < aim[j + 1, 0])
                    {
                        for (k = 0; k < dim; k++)
                        {
                            temp = aim[j, k];
                            aim[j, k] = aim[j + 1, k];
                            aim[j + 1, k] = temp;
                        }
                    }
                }
            }
            return aim;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            try
            {
                NumberOfDim = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox4.Text += "Розмірність простору введена невірно" + Environment.NewLine;
                textBox2.Enabled = false;
                return;
            }
            if (NumberOfDim < 2)
            {
                textBox4.Text += "Розмірність простору введена невірно" + Environment.NewLine;
                textBox2.Enabled = false;
                return;
            }
            if (NumberOfDim > 100)
            {
                textBox4.Text += "Розмірність простору занадто велика" + Environment.NewLine;
                textBox2.Enabled = false;
                return;
            }
            textBox2.Enabled = true;
            int i;
            for (i = 0; i < NumberOfDim; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "x" + (i + 1);
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = "x" + (i + 1);
            }
            dataGridView2.Rows.Add();
            dataGridView2.Rows[NumberOfDim].Cells[0].Value = "Значення - ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            Parser pars = new Parser();
            if (textBox2.Enabled == false)
            {
                textBox4.Text += "Неможливо почати роботу - для початку введіть усі дані" + Environment.NewLine;
                return;
            }
            double Lambda, LastLambda;
            try
            {
                Lambda = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                textBox4.Text += "Початкове значення λ введено невірно" + Environment.NewLine;
                return;
            }
            if ((Lambda <= 0) || (Lambda >= 1000000))
            {
                textBox4.Text += "Початкове значення λ введено невірно. Памятайте, що вонο має бути додатнім" + Environment.NewLine;
                return;
            }
            string function = textBox2.Text;
            try
            {
                pars.AddVariable("e", Math.E);
                pars.AddVariable("pi", Math.PI);
                for (i = 1; i <= NumberOfDim; i++)
                {
                    pars.AddVariable("x" + i, 0);
                }
                pars.SimplifyDouble(function);
                for (i = 1; i <= NumberOfDim; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
            }
            catch
            {
                textBox4.Text += "Функція введена невірно. Можливо, ви ввели розривну функцію" + Environment.NewLine;
                return;
            }
            double epsilon;
            try
            {
                epsilon = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                textBox4.Text += "Точність введена невірно" + Environment.NewLine;
                return;
            }
            double CurFunc;
            double NextFunc;
            double[] Grad;
            double TempVal;
            bool Changed = false;
            double[] CurPoint = new double[NumberOfDim];
            double[] TempPoint = new double[NumberOfDim];
            try
            {
                for (i = 0; i < NumberOfDim; i++)
                {
                    CurPoint[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    pars.AddVariable("x" + (i + 1), CurPoint[i]);
                }
                CurFunc = pars.SimplifyDouble(function);
                for (i = 1; i <= NumberOfDim; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
            }
            catch
            {
                textBox4.Text += "Початкова точка введена невірно" + Environment.NewLine;
                return;
            }
            int Num = 0;
            Grad = FindGrad(pars, function, CurPoint);
            ////
            Random a = new Random();
            double TempMaxLam = (LastLambda = Lambda);
            double TempLambda;
            while (FindLeng(Grad) > epsilon)
            {
               // Lambda *= 0.99;
                LastLambda = Lambda;
                Num++;
                if (Num > 10000)
                {
                    textBox4.Text += "Трапилося зациклення. Спробуйте підкоректувати початкове лямбда" + Environment.NewLine;
                    return;
                }
                /////
                for (i = 0; i < NumberOfDim; i++)
                {
                    TempPoint[i] = CurPoint[i] - LastLambda * Math.Sign(Grad[i]);
                }
                /////
                for (i = 0; i < NumberOfDim; i++)
                {
                    pars.AddVariable("x" + (i + 1), TempPoint[i]);
                }
                NextFunc = pars.SimplifyDouble(function);
                for (i = 1; i <= NumberOfDim; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
                while (NextFunc >= CurFunc)
                {
                    LastLambda /=2;
                    for (i = 0; i < NumberOfDim; i++)
                    {
                        TempPoint[i] = CurPoint[i] - LastLambda * Math.Sign(Grad[i]);
                    }
                    /////
                    for (i = 0; i < NumberOfDim; i++)
                    {
                        pars.AddVariable("x" + (i + 1), TempPoint[i]);
                    }
                    NextFunc = pars.SimplifyDouble(function);
                    for (i = 1; i <= NumberOfDim; i++)
                    {
                        pars.RemoveVariable("x" + i);
                    }
                }
                for (i = 0; i < NumberOfDim; i++)
                {
                    CurPoint[i] -= LastLambda * Math.Sign(Grad[i]);
                }
                /////
                for (i = 0; i < NumberOfDim; i++)
                {
                    pars.AddVariable("x" + (i + 1), CurPoint[i]);
                }
                CurFunc = pars.SimplifyDouble(function);
                for (i = 1; i <= NumberOfDim; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
                /////
                //Lambda = 3*TempMaxLam;
                Grad = FindGrad(pars, function, CurPoint);
                Lambda -= (Lambda-LastLambda)/10;
               //////

            }
            ////
            for (i = 0; i < NumberOfDim; i++)
            {
                pars.AddVariable("x" + (i + 1), CurPoint[i]);
            }
            CurFunc = pars.SimplifyDouble(function);
            for (i = 1; i <= NumberOfDim; i++)
            {
                pars.RemoveVariable("x" + i);
            }
            for (i = 0; i < NumberOfDim; i++)
            {
                dataGridView2.Rows[i].Cells[1].Value = "" + Math.Round(CurPoint[i], 6);
            }
            dataGridView2.Rows[NumberOfDim].Cells[1].Value = "" + Math.Round(CurFunc, 6);
            ////
            textBox4.Text += "Кілкість кроків - " + Num + Environment.NewLine;
        }


        double[] FindGrad(Parser Pars, string func, double[] point)
        {
            double delta = 0.00001;
            double temp1, temp2;
            int i, j;
            double[] ans = new double[point.Length];
            for (i = 0; i < point.Length; i++)
            {
                for (j = 0; j < point.Length; j++)
                {
                    Pars.AddVariable("x" + (j + 1), point[j]);
                }
                Pars.RemoveVariable("x" + (i + 1));
                Pars.AddVariable("x" + (i + 1), point[i] + delta);
                temp1 = Pars.SimplifyDouble(func);
                Pars.RemoveVariable("x" + (i + 1));
                Pars.AddVariable("x" + (i + 1), point[i] - delta);
                temp2 = Pars.SimplifyDouble(func);
                for (j = 1; j <= NumberOfDim; j++)
                {
                    Pars.RemoveVariable("x" + j);
                }
                ans[i] = (temp1 - temp2) / (2 * delta);
            }
            return ans;
        }

        double FindLeng(double[] aim)
        {
            double temp = 0;
            for (int i = 0; i < aim.Length; i++)
            {
                temp += aim[i] * aim[i];
            }
            temp = Math.Sqrt(temp);
            return temp;
        }
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyProg Prog = new MyProg();
            Application.Run(Prog);
        }
    }
}
