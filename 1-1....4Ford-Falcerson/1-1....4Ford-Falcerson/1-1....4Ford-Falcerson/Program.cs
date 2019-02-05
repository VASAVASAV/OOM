using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace _1_1._._._._4Ford_Falcerson
{
    class MyForm : Form
    {
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Button button2;
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть кількість вершин графу";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 9);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(перша вважається за вхід, остання за вихід)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Створити матрицю суміжності";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(1118, 774);
            this.Controls.Add(this.button2);
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
            int NumOfVert;
            try
            {
                NumOfVert = Convert.ToInt32(textBox1.Text);
                if (NumOfVert <= 1 || NumOfVert >= 20)
                    throw new Exception();
            }
            catch
            {
                textBox3.Text += "Wrong number of vertices. Matrix cant be created" + Environment.NewLine;
                return;
            }
            int i, j;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (i = 0; i < NumOfVert; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            }
            for (i = 0; i < NumOfVert; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[i].ReadOnly = true;
                dataGridView1.Rows[i].Cells[i].Value = "0";//"No cycles";
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                dataGridView1.Rows[i].Cells[0].Value = "0";//"No input in start vertex ";
            }
            for (i = 0; i < NumOfVert; i++)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = "0";//"No output from end vertex";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Columns.Count<=1)
            {
                textBox3.Text += "You shall create graph" + Environment.NewLine;
                return;
            }
            int i,j;
            int NumOfVec = dataGridView1.Columns.Count;
            int Check;
            try
            {
                for (i = 0; i < NumOfVec; i++)
                {
                    for (j = 0; j < NumOfVec; j++)
                    {
                        if(dataGridView1.Rows[i].Cells[j].ReadOnly==false)
                        {
                            Check = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                            if (Check < 0)
                                throw new Exception();
                        }
                    }
                }
            }
            catch
            {
                textBox3.Text += "Wrong input" + Environment.NewLine;
                return;
            }
            List<Way> CurWays;
            List<Way> LastWays;
            int AllStream = 0;
            bool StepMade;
            bool MoveMade = true;
            bool DeleteNeeded = false;
            int Temp;
            while(MoveMade)
            {
                StepMade = true;
                MoveMade = false;
                CurWays = new List<Way>();
                LastWays = new List<Way>();
                LastWays.Add(new Way(0));
                while(StepMade)
                {
                    CurWays = new List<Way>();
                    //CurWays = LastWays;
                    StepMade = false;
                    for (i = 0; i < LastWays.Count; i++)
                    {
                        DeleteNeeded = true;
                        if(LastWays[i].CurWay[LastWays[i].CurWay.Count-1]==(dataGridView1.Rows.Count-1))
                        {
                            CurWays.Add(LastWays[i]);
                            //StepMade = false;
                            continue;
                           // DeleteNeeded = false;
                        }
                        for (j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[LastWays[i].CurWay[LastWays[i].CurWay.Count - 1]].Cells[j].Value) != 0)
                            {
                                CurWays.Add(new Way(LastWays[i]));
                                CurWays[CurWays.Count - 1].AddPoint(j,Convert.ToInt32(dataGridView1.Rows[LastWays[i].CurWay[LastWays[i].CurWay.Count - 1]].Cells[j].Value));
                                DeleteNeeded = false;
                                StepMade = true;
                                if (CurWays[CurWays.Count - 1].CheckCycle())
                                {
                                    CurWays.RemoveAt(CurWays.Count - 1);
                                }
                            }
                        }
                        /*if (DeleteNeeded)
                        {
                            LastWays.RemoveAt(i);
                            i--;
                        }*/
                    }
                    LastWays = CurWays;
                }
                LastWays.Sort();
                if (LastWays.Count!=0 && (LastWays[LastWays.Count - 1].MinVal != 0  || LastWays[LastWays.Count - 1].MinVal != int.MaxValue ))
                {
                    AllStream+=LastWays[LastWays.Count - 1].MinVal;
                    for (i = 1; i < LastWays[LastWays.Count - 1].CurWay.Count;i++ )
                    {
                        dataGridView1.Rows[LastWays[LastWays.Count - 1].CurWay[i - 1]].Cells[LastWays[LastWays.Count - 1].CurWay[i]].Value = Convert.ToInt32(dataGridView1.Rows[LastWays[LastWays.Count - 1].CurWay[i - 1]].Cells[LastWays[LastWays.Count - 1].CurWay[i]].Value) - LastWays[LastWays.Count - 1].MinVal;
                        dataGridView1.Rows[LastWays[LastWays.Count - 1].CurWay[i]].Cells[LastWays[LastWays.Count - 1].CurWay[i - 1]].Value = Convert.ToInt32(dataGridView1.Rows[LastWays[LastWays.Count - 1].CurWay[i]].Cells[LastWays[LastWays.Count - 1].CurWay[i-1]].Value) + LastWays[LastWays.Count - 1].MinVal;
                    }
                    MoveMade = true;
                }
            }
            textBox3.Text += "The answer is " + AllStream + Environment.NewLine;


            
        }
    }
    class Way : IEquatable<Way>, IComparable<Way>
    {
        public List<int> CurWay;
        public int MinVal;
        public Way(int Start)
        {
            CurWay = new List<int>();
            CurWay.Add(Start);
            MinVal = int.MaxValue;
        }
        public Way(Way otherWay)
        {
            CurWay = new List<int>();
            int i = 0;
            for (i = 0; CurWay.Count != otherWay.CurWay.Count;i++)
            {
                CurWay.Add(otherWay.CurWay[i]);
            }
            MinVal = otherWay.MinVal;
        }
        public void AddPoint(int NewPoint, int Value)
        {
            CurWay.Add(NewPoint);
            if (Value < MinVal)
            {
                MinVal = Value;
            }
        }
        public bool CheckCycle()
        {
            int i;
            for (i = 0; i < CurWay.Count - 1; i++)
            {
                if(CurWay[i] == CurWay[CurWay.Count-1])
                {
                    return true;    
                }
            }
            return false;
        }

        public int CompareTo(Way compareWay)
        {
            // A null value means that this object is greater.
            if (compareWay == null)
                return 1;

            else
                return this.MinVal.CompareTo(compareWay.MinVal);//this.PartId.CompareTo(comparePart.PartId);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Way objAsPart = obj as Way;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public bool Equals(Way other)
        {
            if (other == null) return false;
            return (this.MinVal.Equals(other.MinVal));
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
