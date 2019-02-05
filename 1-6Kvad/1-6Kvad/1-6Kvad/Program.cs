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
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBoxLog;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть крок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть початкову точку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 148);
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
            this.groupBox1.Location = new System.Drawing.Point(372, 12);
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
            this.label6.Location = new System.Drawing.Point(12, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введіть точність обчислень";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(570, 263);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "MyProg";
            this.Text = "Метод квадратичної інтероляції";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            Parser pars = new Parser();
            double step, epsilon, startpoint;
            try
            {
                step = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                textBoxLog.Text += "Крок введено невірно" + Environment.NewLine;
                return;
            }
            if ((step < 0) || (step >= 100))
            {
                textBoxLog.Text += "Крок введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                epsilon = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                textBoxLog.Text += "Точність введено невірно" + Environment.NewLine;
                return;
            }
            if ((epsilon < 0) || (epsilon >= 5))
            {
                textBoxLog.Text += "Точність введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                startpoint = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                textBoxLog.Text += "Стартова точка введена невірно" + Environment.NewLine;
                return;
            }
            string function = textBox1.Text;
            double a, b;
            try
            {
                pars.AddVariable("e", Math.E);
                pars.AddVariable("pi", Math.PI);
                pars.AddVariable("x", 0);
                a = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
                pars.AddVariable("x", startpoint);
                b = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
            }
            catch
            {
                textBoxLog.Text += "Функція введена невірно. Можливо, ви ввели розривну функцію" + Environment.NewLine;
                return;
            }
            if (double.IsNaN(a) || double.IsNaN(b)||double.IsInfinity(a)||double.IsInfinity(b))
            {
                textBoxLog.Text += "Функція введена невірно. Можливо, ви ввели розривну функцію" + Environment.NewLine;
                return;
            }
            textBoxLog.Text += "Success" + Environment.NewLine;
            double x0, x1, x2, x3;
            double f0, f1, f2, f3;
            x0 = startpoint;
            f0 = b;
            x1 = x0 + step;
            pars.AddVariable("x", x1);
            f1 = pars.SimplifyDouble(function);
            pars.RemoveVariable("x");
            if (f0 < f1)
            {
                x2 = x0 - step;
            }
            else
            {
                x1 = x1+step;
                x0 = x0 + step;
                x2 = x0 - step;
            }
            pars.AddVariable("x", x2);
            f2 = pars.SimplifyDouble(function);
            pars.RemoveVariable("x");
            x3 = 0.5*(x0+x1) + (0.5*(f0-f1)*(x1-x2)*(x2-x0))/(((x1-x2)*(f0))+((x2-x0)*(f1))+((x0-x1)*(f2)));
            pars.AddVariable("x", x3);
            f3 = pars.SimplifyDouble(function);
            pars.RemoveVariable("x");
            j = 1;
            double temp;
            while (Math.Abs(f3 - f0) > epsilon)
            {
                j++;
                if (x3 < x2 || x3 > x1)
                {
                    temp = Math.Max(f1, f2);
                    if (temp == f2)
                    {
                        x2 = x0;
                        x0 = x1;
                        x1 = x3;
                    }
                    else
                    {
                        x1 = x0;
                        x0 = x2;
                        x2 = x3;
                    }
                }
                else
                {
                    if ((x3 == x0) || (x3 == x1) || (x3 == x2))
                    {
                        j--;
                        break;
                    }
                    if (x3 < x0)
                    {
                        x1 = x0;
                    }
                    else
                    {
                        x2 = x0;
                    }
                    x0 = x3;
                }
                pars.AddVariable("x", x0);
                f0 = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
                pars.AddVariable("x", x1);
                f1 = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
                pars.AddVariable("x", x2);
                f2 = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
                x3 = 0.5 * (x0 + x1) + (0.5 * (f0 - f1) * (x1 - x2) * (x2 - x0)) / (((x1 - x2) * (f0)) + ((x2 - x0) * (f1)) + ((x0 - x1) * (f2)));
                pars.AddVariable("x", x3);
                f3 = pars.SimplifyDouble(function);
                pars.RemoveVariable("x");
            }
            textBoxLog.Text += " Відповідь - "  + x3+ ", значення функції у цій точці -" + f3 + ", кількість кроків - "+ j +  Environment.NewLine;
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
