
namespace PersonRegistry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_NewPerson = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txb_Firstname = new System.Windows.Forms.TextBox();
            this.txb_Lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.txb_FirstandLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_People = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_NewPerson.SuspendLayout();
            this.gb_Search.SuspendLayout();
            this.gb_People.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_NewPerson
            // 
            this.gb_NewPerson.Controls.Add(this.label2);
            this.gb_NewPerson.Controls.Add(this.btn_Add);
            this.gb_NewPerson.Controls.Add(this.radioButton2);
            this.gb_NewPerson.Controls.Add(this.radioButton1);
            this.gb_NewPerson.Controls.Add(this.txb_Firstname);
            this.gb_NewPerson.Controls.Add(this.txb_Lastname);
            this.gb_NewPerson.Controls.Add(this.lbl_lastname);
            this.gb_NewPerson.Controls.Add(this.lbl_Firstname);
            this.gb_NewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_NewPerson.Location = new System.Drawing.Point(15, 13);
            this.gb_NewPerson.Name = "gb_NewPerson";
            this.gb_NewPerson.Size = new System.Drawing.Size(705, 286);
            this.gb_NewPerson.TabIndex = 0;
            this.gb_NewPerson.TabStop = false;
            this.gb_NewPerson.Text = "New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(283, 202);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 35);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(449, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(449, 84);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txb_Firstname
            // 
            this.txb_Firstname.Location = new System.Drawing.Point(110, 53);
            this.txb_Firstname.Name = "txb_Firstname";
            this.txb_Firstname.Size = new System.Drawing.Size(207, 22);
            this.txb_Firstname.TabIndex = 3;
            // 
            // txb_Lastname
            // 
            this.txb_Lastname.Location = new System.Drawing.Point(110, 131);
            this.txb_Lastname.Name = "txb_Lastname";
            this.txb_Lastname.Size = new System.Drawing.Size(207, 22);
            this.txb_Lastname.TabIndex = 2;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(34, 131);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(69, 16);
            this.lbl_lastname.TabIndex = 1;
            this.lbl_lastname.Text = "Last name";
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(34, 56);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(69, 16);
            this.lbl_Firstname.TabIndex = 0;
            this.lbl_Firstname.Text = "First name";
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.txb_FirstandLastname);
            this.gb_Search.Controls.Add(this.label1);
            this.gb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search.Location = new System.Drawing.Point(743, 13);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(491, 286);
            this.gb_Search.TabIndex = 0;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Search";
            this.gb_Search.Enter += new System.EventHandler(this.gb_Search_Enter);
            // 
            // txb_FirstandLastname
            // 
            this.txb_FirstandLastname.Location = new System.Drawing.Point(135, 152);
            this.txb_FirstandLastname.Name = "txb_FirstandLastname";
            this.txb_FirstandLastname.Size = new System.Drawing.Size(238, 22);
            this.txb_FirstandLastname.TabIndex = 1;
            this.txb_FirstandLastname.TextChanged += new System.EventHandler(this.txb_FirstandLastname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First or Last name";
            // 
            // gb_People
            // 
            this.gb_People.Controls.Add(this.listBox1);
            this.gb_People.Controls.Add(this.btn_Remove);
            this.gb_People.Controls.Add(this.btn_Merge);
            this.gb_People.Controls.Add(this.btn_Sort);
            this.gb_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_People.Location = new System.Drawing.Point(15, 305);
            this.gb_People.Name = "gb_People";
            this.gb_People.Size = new System.Drawing.Size(706, 331);
            this.gb_People.TabIndex = 1;
            this.gb_People.TabStop = false;
            this.gb_People.Text = "People";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(689, 228);
            this.listBox1.TabIndex = 6;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(465, 277);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(121, 35);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.Location = new System.Drawing.Point(241, 277);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(121, 35);
            this.btn_Merge.TabIndex = 4;
            this.btn_Merge.Text = "Merge";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(37, 277);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(121, 35);
            this.btn_Sort.TabIndex = 3;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(PersonRegistry.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 647);
            this.Controls.Add(this.gb_People);
            this.Controls.Add(this.gb_Search);
            this.Controls.Add(this.gb_NewPerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "People Registry";
            this.gb_NewPerson.ResumeLayout(false);
            this.gb_NewPerson.PerformLayout();
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.gb_People.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_NewPerson;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txb_Firstname;
        private System.Windows.Forms.TextBox txb_Lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_Firstname;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_People;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_FirstandLastname;
        private System.Windows.Forms.BindingSource personBindingSource;
    }
}

