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
        private TextBox textBox3;
        private Label label3;
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
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть довжину граней симлексу";
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
            this.dataGridView1.Location = new System.Drawing.Point(218, 195);
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
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть початкову точку симплекса";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 367);
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
            this.dataGridView2.Location = new System.Drawing.Point(218, 411);
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
            this.label5.Location = new System.Drawing.Point(12, 411);
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
            this.groupBox1.Size = new System.Drawing.Size(213, 560);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 535);
            this.textBox4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введіть точність обчислень";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введіть α";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(218, 169);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "2";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(218, 143);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "0,5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Введіть γ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Введіть β";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(666, 583);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "MyProg";
            this.Text = "Метод Нелдера-Міда";
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
            int i, j,k;
            for (i = 0; i < dim; i++)
            {
                for (j = 0; j < dim - i - 1;j++ )
                {
                    if (aim[j, 0] < aim[j + 1, 0])
                    {
                        for (k = 0; k < dim; k++)
                        {
                            temp = aim[j, k];
                            aim[j, k] = aim[j + 1, k];
                            aim[j+1, k] = temp;
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
            double step;
            try
            {
                step = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                textBox4.Text += "Довжина грані введено невірно" + Environment.NewLine;
                return;
            }
            if ((step <= 0) || (step >= 100))
            {
                textBox4.Text += "Довжина гранівведено невірно. Памятайте, що вона має бути додатнім" + Environment.NewLine;
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
            double alfa, beta, gamma;
            try
            {
                alfa = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                textBox4.Text += "Параметр альфа введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                beta = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                textBox4.Text += "параметр бета введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                gamma = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                textBox4.Text += "Параметр гамма введено невірно" + Environment.NewLine;
                return;
            }
            double[,] Cors = new double[NumberOfDim + 1, NumberOfDim + 1];
            for (i = 0; i <= NumberOfDim; i++)
            {   
                for (j = 1; j <= NumberOfDim; j++)
                {
                    Cors[i,j] = Convert.ToDouble(dataGridView1.Rows[j-1].Cells[1].Value);
                }
            }
            for (j = 1; j <= NumberOfDim; j++)
            {
                Cors[j,j] += step;
            }
            try
            {
                for (i = 0; i <= NumberOfDim; i++)
                {
                    for (j = 1; j <= NumberOfDim; j++)
                    {
                        pars.AddVariable("x" + j, Cors[i,j]);
                    }
                    Cors[i,0] = pars.SimplifyDouble(function);
                    for (j = 1; j <= NumberOfDim; j++)
                    {
                        pars.RemoveVariable("x" + j);
                    }
                }
            }    
            catch
            {
                textBox4.Text += "Початкова точка введена невірно" + Environment.NewLine;
                return;
            }
            Cors = MySort(Cors, NumberOfDim+1);
            textBox4.Text += "Success" + Environment.NewLine;
            //////
            double[] SoG, Xr = new double[NumberOfDim + 1], Xe = new double[NumberOfDim + 1], Xc = new double[NumberOfDim + 1];
            while (!CheckAnswer(Cors, NumberOfDim+1, epsilon))
            {
                SoG = FindSog(Cors,NumberOfDim+1);
                for (j = 1; j <= NumberOfDim; j++)
                {
                    pars.AddVariable("x" + j, SoG[j]);
                }
                SoG[0] = pars.SimplifyDouble(function);
                for (j = 1; j <= NumberOfDim; j++)
                {
                    pars.RemoveVariable("x" + j);
                }
                //////
                for (i = 1; i < NumberOfDim + 1; i++)
                {
                    Xr[i] = (1 + alfa) * SoG[i] - alfa * Cors[0, i];
                }
                for (j = 1; j <= NumberOfDim; j++)
                {
                    pars.AddVariable("x" + j, Xr[j]);
                }
                Xr[0] = pars.SimplifyDouble(function);
                for (j = 1; j <= NumberOfDim; j++)
                {
                    pars.RemoveVariable("x" + j);
                }
                /////
                if(Xr[0]<Cors[NumberOfDim,0])
                {
                    //////
                    for (i = 1; i < NumberOfDim + 1; i++)
                    {
                        Xe[i] = gamma * Xr[i] + (1 - gamma) * SoG[i];
                    }
                    for (j = 1; j <= NumberOfDim; j++)
                    {
                        pars.AddVariable("x" + j, Xe[j]);
                    }
                    Xe[0] = pars.SimplifyDouble(function);
                    for (j = 1; j <= NumberOfDim; j++)
                    {
                        pars.RemoveVariable("x" + j);
                    }
                    //////
                    if (Xe[0] < Cors[NumberOfDim, 0])
                    {
                        for (i = 0; i < NumberOfDim + 1; i++)
                        {
                            Cors[0, i] = Xe[i];
                        }
                        Cors = MySort(Cors, NumberOfDim + 1);
                    }
                    else 
                    {
                        for (i = 0; i < NumberOfDim + 1; i++)
                        {
                            Cors[0, i] = Xr[i];
                        }
                        Cors = MySort(Cors, NumberOfDim + 1);
                    }
                }
                else
                {
                    if (Xr[0] > Cors[1, 0])
                    {
                        if (!(Xr[0] > Cors[0, 0]))
                        {
                            for (i = 0; i < NumberOfDim + 1; i++)
                            {
                                Cors[0, i] = Xr[i];
                            }
                            Cors = MySort(Cors, NumberOfDim + 1);
                        }
                        //////
                        for (i = 1; i < NumberOfDim + 1; i++)
                        {
                            Xc[i] = beta * Cors[0, i] + (1 - beta) * SoG[i];
                        }
                        for (j = 1; j <= NumberOfDim; j++)
                        {
                            pars.AddVariable("x" + j, Xc[j]);
                        }
                        Xc[0] = pars.SimplifyDouble(function);
                        for (j = 1; j <= NumberOfDim; j++)
                        {
                            pars.RemoveVariable("x" + j);
                        }
                        //////
                        if (Xc[0] > Cors[0, 0])
                        {
                            for (i = 0; i < NumberOfDim; i++)
                            {
                                for (j = 1; j < NumberOfDim + 1; j++)
                                {
                                    Cors[i, j] += 0.5 * (Cors[i, j] - Cors[NumberOfDim + 1, j]);
                                }
                            }
                            for (i = 0; i <= NumberOfDim; i++)
                            {
                                for (j = 1; j <= NumberOfDim; j++)
                                {
                                    pars.AddVariable("x" + j, Cors[i, j]);
                                }
                                Cors[i, 0] = pars.SimplifyDouble(function);
                                for (j = 1; j <= NumberOfDim; j++)
                                {
                                    pars.RemoveVariable("x" + j);
                                }
                            }
                            Cors = MySort(Cors, NumberOfDim+1);
                        }
                        else
                        {
                            for (i = 0; i < NumberOfDim + 1; i++)
                            {
                                Cors[0, i] = Xc[i];
                            }
                            Cors = MySort(Cors, NumberOfDim + 1);
                        }
                    }
                    else
                    {
                        for (i = 0; i < NumberOfDim + 1; i++)
                        {
                            Cors[0, i] = Xr[i];
                        }
                        Cors = MySort(Cors, NumberOfDim + 1);
                    }
                }
            }
            textBox4.Text += "Success" + Environment.NewLine;
        }

        private bool CheckAnswer(double [,] aim, int dim, double eps )
        {
            double fs=0;
            int i, j;
            for (i = 0; i < dim; i++)
            {
                fs += aim[i, 0];
            }
            fs/=dim;
            fs += 1;
            double sigm = 0;
            for (i = 0; i < dim; i++)
            {
                sigm += Math.Pow(aim[i,0] - fs,2);
            }
            sigm /=dim;
            if (Math.Sqrt(sigm) < eps)
                return true;
            else 
                return false;
        }

        private double[] FindSog(double[,] aim, int dim)
        {
            double temp;
            double[] answer = new double[dim];
            int i, j;
            for (i = 1; i < dim; i++)
            {
                temp = 0;
                for (j = 1; j < dim; j++)
                {
                    temp += aim[j, i];
                }
                answer[i] = (1.0 / (dim - 1)) * temp;
            }
            return answer;
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
