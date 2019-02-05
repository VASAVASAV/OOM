using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MathParserNet;


namespace _1_6Kvad
{
    class MyProg : Form
    {
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBoxLog;
        private Label label6;
        private TextBox textBox2;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        bool IncomeCreated = false;

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "(x1-1)^2+(x2-1)^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть функцію для пошуку мінімуму ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Знайти мінімум";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(626, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 247);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(181, 222);
            this.textBoxLog.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введіть точність обчислень";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "0,01";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введіть кількість змінних";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Створити матрицю для вводу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(15, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 231);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "=";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "X0";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "+";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "T*";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dn";
            this.Column6.Name = "Column6";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Оціночне значення мінімуму";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(467, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "η = ";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(831, 515);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "MyProg";
            this.Text = "Метод кубічної інтероляції";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IncomeCreated = false)
            {
                textBoxLog.Text += "Start from creating matrix"+Environment.NewLine;
                return;
            }
            int i, j, k;
            string function;
            Parser pars = new Parser();
            function = textBox1.Text;
            double epsilon, QM, ita;
            try
            {
                epsilon = Convert.ToDouble(textBox3.Text);
                if (epsilon <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBoxLog.Text += "Wrong epsilon" + Environment.NewLine;
                return;
            }
            try
            {
                QM = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                textBoxLog.Text += "Wrong QM" + Environment.NewLine;
                return;
            }
            try
            {
                ita = Convert.ToDouble(comboBox1.Text);
                if (ita != 1 && ita != 2)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBoxLog.Text += "Wrong ita" + Environment.NewLine;
                return;
            }
            double[] X0 = new double[dataGridView1.Rows.Count];
            double[] D = new double[dataGridView1.Rows.Count];
            try
            {
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    X0[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    D[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                }
            }
            catch
            {
                textBoxLog.Text += "Wrong input" + Environment.NewLine;
                return;
            }
            ////
            try
            {
                pars.AddVariable("e", Math.E);
                pars.AddVariable("pi", Math.PI);
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    pars.AddVariable("x" + i, 0);
                }
                pars.SimplifyDouble(function);
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
            }
            catch
            {
                textBoxLog.Text += "Функція введена невірно. Можливо, ви ввели розривну функцію" + Environment.NewLine;
                return;
            }
            double Multiplyer = 1; 
            double[] Grad;
            double[] XQ = new double[dataGridView1.Rows.Count], XP = new double[dataGridView1.Rows.Count], XR = new double[dataGridView1.Rows.Count];
            double p, q, Gp, Gq, fp, fq;
            p = 0;
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                XP[i - 1] = X0[i - 1];
                pars.AddVariable("x" + i, XP[i - 1]);
            }
            fp = pars.SimplifyDouble(function);
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                pars.RemoveVariable("x" + i);
            }
            Grad = FindGrad(pars, function, X0);
            Gp = Scalar(Grad,D);
            if (Gp > 0)
            {
                Multiplyer = -1;
            }
            q = p + (Math.Min(ita,(-2*(fp-QM))/Gp));
            // double
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                XQ[i-1] = X0[i - 1]+q*D[i-1];
                pars.AddVariable("x" + i, XQ[i-1]);
            }
            fq = pars.SimplifyDouble(function);
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                pars.RemoveVariable("x" + i);
            }
            Grad = FindGrad(pars, function, XQ);
            Gq = Scalar(Grad, D);
            while ((fq <= fp) && (Multiplyer * Gq < 0.000001))
            {
                q *= 2;
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    XQ[i-1] = X0[i - 1]+q*D[i-1];
                    pars.AddVariable("x" + i, XQ[i-1]);
                }
                fq = pars.SimplifyDouble(function);
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
                Grad = FindGrad(pars, function, XQ);
                Gq = Scalar(Grad, D);
            }
            /////
            double z, w;
            z = ((3*(fp-fq))/q)+Gp+Gq;
            w = Math.Sqrt(z * z - Gp * Gq);
            double r, fr, Gr;
            r = (q * (z + w - Gp)) / (Gq - Gp + 2 * w);
            //r = (q * (((3 * (fp - fq)) / q) + Math.Sqrt(Math.Pow(((3 * (fp - fq)) / q), 2) - Gp * Gq)-Gp)) / (Gq - Gp + 2 * (Math.Sqrt(Math.Pow(((3 * (fp - fq)) / q), 2) - Gp * Gq)));
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                XR[i - 1] = XP[i - 1] + r * D[i - 1];
                pars.AddVariable("x" + i, XR[i - 1]);
            }
            fr = pars.SimplifyDouble(function);
            for (i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                pars.RemoveVariable("x" + i);
            }
            Grad = FindGrad(pars, function, XR);
            Gr = Scalar(Grad, D);
            while (Math.Abs(Gr) > epsilon)
            {
                if (Gr > 0)
                {
                    q = r;
                    // double
                    for (i = 1; i <= dataGridView1.Rows.Count; i++)
                    {
                        XQ[i - 1] = XR[i - 1];
                        pars.AddVariable("x" + i, XQ[i - 1]);
                    }
                    fq = pars.SimplifyDouble(function);
                    for (i = 1; i <= dataGridView1.Rows.Count; i++)
                    {
                        pars.RemoveVariable("x" + i);
                    }
                    Grad = FindGrad(pars, function, XQ);
                    Gq = Scalar(Grad, D);
                }
                else
                {
                    p = r;
                    for (i = 1; i <= dataGridView1.Rows.Count; i++)
                    {
                        XP[i - 1] = XR[i - 1];
                        pars.AddVariable("x" + i, XP[i - 1]);
                    }
                    fp = pars.SimplifyDouble(function);
                    for (i = 1; i <= dataGridView1.Rows.Count; i++)
                    {
                        pars.RemoveVariable("x" + i);
                    }
                    Grad = FindGrad(pars, function, X0);
                    Gp = Scalar(Grad, D);
                }
                z = (3 * (fp - fq)) / q + Gp + Gq;
                w = Math.Sqrt(z * z - Gp * Gq);
                r = (q * (z + w - Gp)) / (Gq - Gp + 2 * w);
                //r = (q * (((3 * (fp - fq)) / q) + Math.Sqrt(Math.Pow(((3 * (fp - fq)) / q), 2) - Gp * Gq) - Gp)) / (Gq - Gp + 2 * (Math.Sqrt(Math.Pow(((3 * (fp - fq)) / q), 2) - Gp * Gq)));
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    XR[i - 1] = XP[i - 1] + r * D[i - 1];
                    pars.AddVariable("x" + i, XR[i - 1]);
                }
                fr = pars.SimplifyDouble(function);
                for (i = 1; i <= dataGridView1.Rows.Count; i++)
                {
                    pars.RemoveVariable("x" + i);
                }
                Grad = FindGrad(pars, function, XR);
                Gr = Scalar(Grad, D);
            }
            textBoxLog.Text += "The answer is T=" + r  + ", value in this point is " + Math.Round(fr,6) + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, k;
            int NumOfVar;
            try
            {
                NumOfVar = Convert.ToInt32(textBox2.Text);
                if(NumOfVar<1||NumOfVar>15)
                    throw new Exception();
            }
            catch
            {
                textBoxLog.Text += "Wrong number of variables" + Environment.NewLine;
                return;
            }
            dataGridView1.Rows.Clear();
            for (i = 0; i < NumOfVar; i++)
            {
                dataGridView1.Rows.Add("X"+(i+1),"=","","+","T*","");
            }
        }

        double Scalar(double[] point1, double[] point2)
        {
            double result = 0;
            for (int i = 0; i < point1.Length; i++)
            {
                result += point1[i] * point2[i];
            }
            return result;
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
                for (j = 1; j <= point.Length; j++)
                {
                    Pars.RemoveVariable("x" + j);
                }
                ans[i] = (temp1 - temp2) / (2 * delta);
            }
            return ans;
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
