using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> cars = new List<string>
            //{
            //    "Chevrolet",
            //    "Audi",
            //    "Mercedes",
            //    "Ferrari",
            //};
            //listBox1.DataSource = cars;
            //listBox1.SelectedIndex = 2;


            //List<Car> cars = new List<Car>
            //{
            //    new Car
            //    {
            //        Name="Mercedes"
            //    },
            //    new Car
            //    {
            //        Name="Audi"
            //    },
            //    new Car
            //    {
            //        Name="Ferrari"
            //    },
            //    new Car
            //    {
            //        Name="Cruze 2LT"
            //    },
            //};

            //listBox1.DataSource = cars;

            listBox1.Items.Add(new Car
            {
                Name = "Mercedes"
            });
            listBox1.Items.Add(new Car
            {
                Name="Ferrari"
            });

            listBox1.DisplayMember = "Name";

            //listBox1.SelectionMode = SelectionMode.MultiSimple;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var item = listBox1.SelectedItem as string;
            //label1.Text = item;
            //var item = listBox1.SelectedItem as Car;
            //label1.Text = item?.Name;

            var obj = listBox1.SelectedItem;
            try
            {

            listBox1.Items.Remove(obj);
            listBox2.Items.Add(obj);
            listBox1.SelectedItem = null;
            }
            catch (Exception)
            {

            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //listBox1.DisplayMember = "Id";
            listBox1.Items.Add(new Car
            {
                Name = carTxtb.Text
            });
        }

        private void sendAllBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in listBox1.SelectedItems)
            {
                var car = item as Car;
                sb.Append($"{car?.Name}\n");
            }
            label1.Text = sb.ToString();
        }
    }
}
