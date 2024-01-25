using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PersonRegistry
{
    public partial class Form1 : Form
    {
        readonly List<Person> people = new List<Person>();

        public Form1()
        {

            InitializeComponent();
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (this.txb_Firstname.Text != "" && this.txb_Lastname.Text != "" && this.radioButton1.Checked)
            {

                Male male = new Male
                {
                    FirstName = this.txb_Firstname.Text,
                    LastName = this.txb_Lastname.Text
                };
                listBox1.Items.Add(male.GetName());
                people.Add(male);

                this.txb_Firstname.Focus();
                this.txb_Lastname.Focus();
                this.txb_Firstname.Clear();
                this.txb_Lastname.Clear();
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
            }
            else if (this.txb_Firstname.Text != "" && this.txb_Lastname.Text != "" && this.radioButton2.Checked)
            {
                Female female = new Female
                {
                    FirstName = this.txb_Firstname.Text,
                    LastName = this.txb_Lastname.Text
                };
                listBox1.Items.Add(female.GetName());
                people.Add(female);
                this.txb_Firstname.Focus();
                this.txb_Lastname.Focus();
                this.txb_Firstname.Clear();
                this.txb_Lastname.Clear();
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show("Please enter the persons fulls details to Add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_Firstname.Focus();
                this.txb_Lastname.Focus();
                this.radioButton1.Focus();
                this.radioButton2.Focus();
            }
        }
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            
            people.Sort();
            listBox1.Sorted = true;
            listBox1.Items.Clear();
            people.ForEach(p => listBox1.Items.Add(p.GetName()));
            
           
        }
        private void btn_Merge_Click(object sender, EventArgs e)
        {
            string str = "";

            Child a = new Child();

            foreach (object item in listBox1.SelectedItems)
            {
                str = item.ToString();
            }
            do
            {
                if (str.StartsWith("Miss."))
                {
                    a.FirstName = str.Split(' ')[1];
                }
                Child b = new Child();

                string v = this.listBox1.SelectedItem.ToString();
                str = v;

                if (str.StartsWith("Mr."))
                {
                    b.LastName = str.Split(' ')[2];
                }

                //Operator overload

                Child c = a + b;

                listBox1.Items.Add(c.GetName());

                people.Add(c);

            } while (str.StartsWith("Mr. ") && str.StartsWith("Miss. "));
        }

        private void txb_FirstandLastname_TextChanged(object sender, EventArgs e)
        {

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection
            {
                listBox1.Items.ToString()
            };
            txb_FirstandLastname.AutoCompleteMode = AutoCompleteMode.Suggest;
            txb_FirstandLastname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txb_FirstandLastname.AutoCompleteCustomSource = autotext;

        }

        private void gb_Search_Enter(object sender, EventArgs e)
        {

            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection
            {
                listBox1.Items.ToString()
                
        };
            txb_FirstandLastname.AutoCompleteMode = AutoCompleteMode.Suggest;
            txb_FirstandLastname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txb_FirstandLastname.AutoCompleteCustomSource = autotext;


        }
    }
}
