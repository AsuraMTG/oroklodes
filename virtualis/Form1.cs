using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtualis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Animal
        {
            public int kg;
            public string color;

            public int Kg
            {
                get { return kg; }
                set { kg = value; }
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public Animal(int kg, string color)
            {
                Kg = kg;
                Color = color;
            }
            public virtual string halad()
            {
                return "fein";
            }
        }

        abstract public class Etel
        {
            public string leves;
            public string sultek;
        }

        public class Fishes : Animal 
        {
            
            public int a;
            public string b;

            public int A
            {
                get { return kg; }
                set { a = value; }
            }
            public string B
            {
                get { return color; }
                set { b = value; }
            }
            public Fishes(int a, string b) : base(a,b)
            {
                Kg = kg;
                Color = color;
            }

            public override string halad()
            {
                return "uszik";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal Macska = new Animal(8,"kék");
            label1.Text += $"{Macska.halad()}\n";
            Fishes Harcsa = new Fishes(7, "Barna");
            label1.Text += $"{Harcsa.halad()}\n";
        }
    }
}
