using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using MathParserNet;

namespace _1_1._._._._2Gen
{
    class MyProg : Form
    {
        private Panel panel1;
        List<int[]> Points;
        private TextBox textBox2;
        Pen MyPen;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private Button button2;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        Point[] ToBuild;
        Boolean WayNeeded = false;
        private CheckBox checkBox1;
        private Button button3;
        List<int> PerfectWay;

        public MyProg()
        {
            ToBuild = null;
            MyPen = new Pen(Color.FromName("Red"), 3f);
            InitializeComponent();
            Points = new List<int[]>();
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 538);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintingLines);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(870, 308);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(319, 242);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистити  поле";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кількість популяцій";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1056, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "10";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1056, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0,05";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(882, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ймовірність мутації";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1056, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Розмір першої популяції";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1056, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "приріст популяції (%)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Почати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1056, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "обмеження популяції (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(882, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(не більше минулого значення)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(885, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Деталі";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Очистити журнал";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1201, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MyProg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void PaintingLines(object sender, PaintEventArgs e)
        {
            Graphics MyGraphics = e.Graphics;
            MyGraphics.Clear((sender as Panel).BackColor);
            for (int i = 0; i < Points.Count; i++)
            {
                MyGraphics.DrawRectangle(MyPen, Points[i][0]-3, Points[i][1]-3, 6, 6);
                //MyGraphics.DrawLine(MyPen, Points[i][0], Points[i][1], Points[i][0]+1, Points[i][1]+2);
                // MyGraphics.DrawLine(MyPen, Points[i][0]+1, Points[i][1], Points[i][0], Points[i][1]+2);
            }
            if (ToBuild != null)
            {
                //MyGraphics.DrawRectangle(MyPen, Points[i][0], Points[i][1],1,1);
                MyGraphics.DrawLines(MyPen, ToBuild);
            }
            if (WayNeeded)
            {
                for (int i = 1; i < Points.Count; i++)
                {
                    MyGraphics.DrawLine(MyPen,Points[PerfectWay[i-1]][0],Points[PerfectWay[i-1]][1],Points[PerfectWay[i]][0],Points[PerfectWay[i]][1]);
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            WayNeeded = false;
            int x, y;
            x = e.X;
            y = e.Y;
            Points.Add(new int[] { x, y });
            panel1.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WayNeeded = false;
            Points = new List<int[]>();
            ToBuild = null;
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WayNeeded = false;
            panel1.Invalidate();
            Random a = new Random();
            int i,j,k;
            int NumberOfPop, NumberOfEnt, NewNumberOfEnt;
            double PosOfMut, LimOfPop, NewPop;
            // checking income
            if(Points.Count<2)
            {
                textBox2.Text += "Senseless work" + Environment.NewLine;
                return;
            }
            try
            {
                NumberOfPop = Convert.ToInt32(textBox1.Text);
                if (NumberOfPop <= 1 || NumberOfPop > 400)
                    throw new Exception();
            }
            catch
            {
                textBox2.Text += "Wrong number of generations! It shall be >1 and <=400" + Environment.NewLine;
                return;
            }
            try
            {
                NumberOfEnt = Convert.ToInt32(textBox4.Text);
                if (NumberOfEnt <= 0 || NumberOfEnt > 10000)
                    throw new Exception();
            }
            catch
            {
                textBox2.Text += "Wrong number of start entities. It shall be >0 and <=10000" + Environment.NewLine;
                return;
            }
            try
            {
                PosOfMut = Convert.ToDouble(textBox3.Text);
                if (PosOfMut < 0 || PosOfMut >= 1)
                    throw new Exception();
            }
            catch
            {
                textBox2.Text += "Wrong value of mutation possibility. Its shall be in limits from 0 to 1 and shall not be equal 1!" + Environment.NewLine;
                return;
            }
            try
            {
                    LimOfPop = 1+0.01*Convert.ToDouble(textBox6.Text);
                    if (LimOfPop < 1 || LimOfPop > 20)
                        throw new Exception();
            }
            catch
            {
                textBox2.Text += "Wrong number of population limit. It shall be in limits from 0 to 1900%" + Environment.NewLine;
                return;
            }
            try
            {
                NewPop = 1 + 0.01 * Convert.ToDouble(textBox5.Text);
                if (NewPop < 1 || NewPop > 20 || NewPop<LimOfPop)
                    throw new Exception();
            }
            catch
            {
                textBox2.Text += "Wrong number of population growth. It shall be in limits from 0 to 1900% and shouldnt be lesser then population limit" + Environment.NewLine;
                return;
            }
            // creating  first generation
            int Temp;
            List<Entity> CurPopulation = new List<Entity>();
            List<int> ResToTakeFrom = new List<int>();//this thing is used to create a new entity by taking random 
            for (i = 0; i < Points.Count; i++)
            {
                ResToTakeFrom.Add(i);
            }
            Entity NewEntity = new Entity(new List<int>());
            List<int> ToTakeFrom = new List<int>();
            for (i = 0; i < NumberOfEnt; i++)
            {
                //ToTakeFrom = ResToTakeFrom;
                for (j = 0; j < Points.Count; j++)
                {
                    ToTakeFrom.Add(ResToTakeFrom[j]);
                }
                CurPopulation.Add(new Entity(new List<int>()));
                for (j = 0; j < Points.Count; j++)
                {
                    Temp = a.Next(ToTakeFrom.Count);
                    CurPopulation[i].Genes.Add(ToTakeFrom[Temp]);
                    ToTakeFrom.RemoveAt(Temp);
                }
                CurPopulation[i].Length=0;
                for (j = 1; j < Points.Count; j++)
                {
                    CurPopulation[i].Length += Math.Sqrt(Math.Pow(Points[CurPopulation[i].Genes[j]][0] - Points[CurPopulation[i].Genes[j-1]][0], 2) + Math.Pow(Points[CurPopulation[i].Genes[j]][1] - Points[CurPopulation[i].Genes[j-1]][1], 2));
                }

            }
            int NumberOfLastGen;
            int TA1, TA2;
            int TP1, TP2;
            double DT;
            for (int CurGeneration = 2; CurGeneration <= NumberOfPop; CurGeneration++)
            {
                NumberOfLastGen = CurPopulation.Count;
                //crossover
                for (NumberOfEnt = (int)Math.Floor(CurPopulation.Count * NewPop); CurPopulation.Count < NumberOfEnt; )
                {
                    TA1 = a.Next(NumberOfLastGen);
                    TA2 = a.Next(NumberOfLastGen);
                    TP1 = 0;
                    TP2 = 0;
                    CurPopulation.Add(new Entity(new List<int>()));
                    for (j = 0; j < Points.Count; j++)
                    {
                        DT = a.NextDouble();
                        if (DT <= 0.5)
                        {
                            if (!CurPopulation[CurPopulation.Count - 1].Genes.Contains(CurPopulation[TA1].Genes[TP1]))
                            {
                                CurPopulation[CurPopulation.Count - 1].Genes.Add(CurPopulation[TA1].Genes[TP1]);
                                TP1++;
                            }
                            else
                            {
                                TP1++;
                                j--;
                                continue;
                            }
                        }
                        else
                        {
                            if (!CurPopulation[CurPopulation.Count - 1].Genes.Contains(CurPopulation[TA2].Genes[TP2]))
                            {
                                CurPopulation[CurPopulation.Count - 1].Genes.Add(CurPopulation[TA2].Genes[TP2]);
                                TP2++;
                            }
                            else
                            {
                                j--;
                                TP2++;
                                continue;
                            }
                        }
                       // CurPopulation[CurPopulation.Count-1].Genes.Add
                    }
                    CurPopulation[CurPopulation.Count - 1].Length = 0;
                    for (j = 1; j < Points.Count; j++)
                    {
                        CurPopulation[CurPopulation.Count - 1].Length += Math.Sqrt(Math.Pow(Points[CurPopulation[CurPopulation.Count - 1].Genes[j]][0] - Points[CurPopulation[CurPopulation.Count - 1].Genes[j - 1]][0], 2) + Math.Pow(Points[CurPopulation[CurPopulation.Count - 1].Genes[j]][1] - Points[CurPopulation[CurPopulation.Count - 1].Genes[j - 1]][1], 2));
                    }
                }
                ////Mutations
                for (j = 0; j < CurPopulation.Count; j++)
                {
                    DT = a.NextDouble();
                    if (DT < PosOfMut)
                    {
                        TA1 = a.Next(Points.Count);
                        TA2 = a.Next(Points.Count);
                        k = CurPopulation[j].Genes[TA1];
                        CurPopulation[j].Genes[TA1] = CurPopulation[j].Genes[TA2];
                        CurPopulation[j].Genes[TA2] = k;
                        CurPopulation[j].Length = 0;
                        for (k = 1; k < Points.Count; k++)
                        {
                            CurPopulation[j].Length += Math.Sqrt(Math.Pow(Points[CurPopulation[j].Genes[k]][0] - Points[CurPopulation[j].Genes[k - 1]][0], 2) + Math.Pow(Points[CurPopulation[j].Genes[k]][1] - Points[CurPopulation[j].Genes[k-1]][1], 2));
                        }
                        j--;
                        continue;
                    }
                }
                    ////
                CurPopulation.Sort();
                for (NumberOfEnt = (int)Math.Floor(NumberOfLastGen * LimOfPop); CurPopulation.Count > NumberOfEnt; )
                {
                    CurPopulation.RemoveAt(CurPopulation.Count-1);
                }
                if(checkBox1.Checked)
                {
                    textBox2.Text += "The best answer of step #" + CurGeneration + " has length of " + CurPopulation[0].Length + ", its way is" + Environment.NewLine;
                    for (k = 0; k < Points.Count-1; k++)
                    {
                        textBox2.Text += CurPopulation[0].Genes[k] + "->";
                    }
                    textBox2.Text += CurPopulation[0].Genes[Points.Count - 1] + Environment.NewLine;
                }
            }
            textBox2.Text += "The result has length of " + CurPopulation[0].Length + ", its way is" + Environment.NewLine;
            for (k = 0; k < Points.Count - 1; k++)
            {
                textBox2.Text += CurPopulation[0].Genes[k] + "->";
            }
            textBox2.Text += CurPopulation[0].Genes[Points.Count - 1] + Environment.NewLine;
            WayNeeded = true;
            PerfectWay = CurPopulation[0].Genes;
            panel1.Invalidate();
        }


        class Entity : IEquatable<Entity>, IComparable<Entity>
        {
            public List<int> Genes;
            public double Length;
            public Entity(List<int> IncomeGenes)
            {
                Genes = IncomeGenes;
                Length = -1;
            }
            public Entity(List<int> IncomeGenes, double NewLength)
            {
                Genes = IncomeGenes;
                Length = NewLength;
            }
            public int CompareTo(Entity compareEntity)
            {
                // A null value means that this object is greater.
                if (compareEntity == null)
                    return 1;

                else
                    return this.Length.CompareTo(compareEntity.Length);//this.PartId.CompareTo(comparePart.PartId);
            }

            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Entity objAsPart = obj as Entity;
                if (objAsPart == null) return false;
                else return Equals(objAsPart);
            }
            public bool Equals(Entity other)
            {
                if (other == null) return false;
                return (this.Length.Equals(other.Length));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }


    }
    struct Being
    {
        public double[] genom;
        public double f;
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
