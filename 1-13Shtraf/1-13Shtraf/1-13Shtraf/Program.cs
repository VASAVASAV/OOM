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
        private DataGridView dataGridView3;
        private Label label7;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label8;
        private TextBox textBox7;
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть крок пошуку";
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
            this.dataGridView1.Location = new System.Drawing.Point(218, 117);
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
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть початкову точку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 310);
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
            this.dataGridView2.Location = new System.Drawing.Point(218, 384);
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
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Точка мінімуму:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(727, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 617);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 592);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView3.Location = new System.Drawing.Point(447, 117);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(274, 166);
            this.dataGridView3.TabIndex = 14;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Х№";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "=";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значення для обмеження";
            this.Column2.Name = "Column2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Введіть тут кількість обмежень";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(530, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Стартове значення r";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(482, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(932, 644);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView3);
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
            this.Text = "Метод Хука-Дживса";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            int NumOfLim;
            try
            {
                NumOfLim = Convert.ToInt32(textBox6.Text);
            }
            catch
            {
                textBox4.Text += "Кілкість обмежень введена невірно" + Environment.NewLine;
                textBox2.Enabled = false;
                return;
            }
            for (int i = 0; i < NumOfLim; i++)
            {
                dataGridView3.Rows.Add("","=","");
            }
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
            if (NumberOfDim < 1)
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
            int R, beta = 2;
            int NumOfLim = dataGridView3.Rows.Count;
            Parser pars = new Parser();
            List<double[]> Limits = new List<double[]>();
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
                textBox4.Text += "Крок введено невірно" + Environment.NewLine;
                return;
            }
            if ((step <= 0) || (step >= 100))
            {
                textBox4.Text += "Крок введено невірно. Памятайте, що крок має бути додатнім" + Environment.NewLine;
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
            ////
            try
            {
                for (i = 0; i < NumOfLim; i++)
                {
                    Limits.Add(new double[] { Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value), Convert.ToDouble(dataGridView3.Rows[i].Cells[0].Value) });
                    if (Limits[i][0] <= 0 || Limits[i][0] > NumberOfDim)
                        throw new Exception();
                }
            }
            catch
            {
                textBox4.Text += "Limits are wrong" + Environment.NewLine;
                return;
            }
            try
            {
                R = Convert.ToInt32(textBox7.Text);
                if(R<=0)
                    throw new Exception();

            }
            catch
            {
                textBox4.Text += "Wrong R" + Environment.NewLine;
                return;
            }
            string NewFunction = "0";
            double addVal;
            double LastVal;
            for(i=0; i < NumOfLim;i++)
            {
                NewFunction += "+(1/" + R + ")*(1+(1/(x" + Limits[i][0] + "-" + Limits[i][1] + ")))";
                //NewFunction+="+"+R+"*(1/(x"+Limits[i][0]+"-"+Limits[i][1]+"))";
               // NewFunction += "-" + R + "*log(x" + Limits[i][0] + "-" + Limits[i][1] + ")";
            }
            ////
            double CurFunc;
            double NextFunc;
            double TempVal;
            bool Changed = false;
            double[] CurPoint = new double[NumberOfDim];
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
            try
            {
                while((1.0/R)>epsilon)
                {
                    step = Convert.ToDouble(textBox3.Text);
                    while (step >= epsilon)
                    {
                        Changed = false;
                        for (i = 0; i < NumberOfDim; i++)
                        {
                            pars.AddVariable("x" + (i + 1), CurPoint[i]);
                        }
                        LastVal = pars.SimplifyDouble(function);
                        addVal = pars.SimplifyDouble(NewFunction);
                        CurFunc = addVal + LastVal;
                        for (i = 1; i <= NumberOfDim; i++)
                        {
                            pars.RemoveVariable("x" + i);
                        }
                        for (i = 0; i < NumberOfDim; i++)
                        {
                            //TempVal = CurPoint[i] + step;
                            for (j = 0; j < NumberOfDim; j++)
                            {
                                pars.AddVariable("x" + (j + 1), CurPoint[j]);
                            }
                            pars.RemoveVariable("x" + (i + 1));
                            pars.AddVariable("x" + (i + 1), CurPoint[i] + step);
                            LastVal = pars.SimplifyDouble(function);
                            addVal = pars.SimplifyDouble(NewFunction);
                            NextFunc = addVal + LastVal;
                            if (NextFunc < CurFunc)
                            {
                                Changed = true;
                                CurPoint[i] = CurPoint[i] + step;
                                CurFunc = NextFunc;
                            }
                            pars.RemoveVariable("x" + (i + 1));
                            pars.AddVariable("x" + (i + 1), CurPoint[i] - step);
                            LastVal = pars.SimplifyDouble(function);
                            addVal = pars.SimplifyDouble(NewFunction);
                            NextFunc = addVal + LastVal;
                            if (NextFunc < CurFunc)
                            {
                                Changed = true;
                                CurPoint[i] = CurPoint[i] - step;
                                CurFunc = NextFunc;
                            }
                            for (j = 1; j <= NumberOfDim; j++)
                            {
                                pars.RemoveVariable("x" + j);
                            }
                        }
                        if (Changed == false)
                        {
                            step *= 0.1;
                        }
                    }
                    R *= beta;
                    NewFunction = "0";
                    for (i = 0; i < NumOfLim; i++)
                    {
                        NewFunction += "+(1/" + R + ")*(1+(1/(x" + Limits[i][0] + "-" + Limits[i][1] + ")))";
                        //NewFunction += "+" + R + "*(1/(x" + Limits[i][0] + "-" + Limits[i][1] + "))";
                    }
                }
            }
            catch (Exception exp)
            {
                textBox4.Text += "Під час виконання програми виникла помилка. Детальніше:" + exp.Message + Environment.NewLine;
                return;
            }
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
            //textBox4.Text += "Success" + Environment.NewLine;
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
