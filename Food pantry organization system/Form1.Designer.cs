namespace Food_pantry_organization_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.numericUpDown1.Location = new System.Drawing.Point(605, 234);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter what you donated and then the amount donated.";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Canned Soup",
            "Canned Vegtables",
            "Canned Meat",
            "Canned Fish",
            "Canned Chicken",
            "Canned Fruits",
            "Nut Butters",
            "Boxes of Beans, Rice, Peas, or Pasta",
            "Stocks/ Broths"});
            this.comboBox1.Location = new System.Drawing.Point(326, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.ItemHeight = 20;
            this.listBoxInventory.Location = new System.Drawing.Point(12, 86);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(247, 444);
            this.listBoxInventory.TabIndex = 5;
            this.listBoxInventory.SelectedIndexChanged += new System.EventHandler(this.listBoxInventory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Inventroy";
            // 
            // textBoxItem
            // 
            this.textBoxItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxItem.Location = new System.Drawing.Point(326, 234);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(125, 27);
            this.textBoxItem.TabIndex = 7;
            this.textBoxItem.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select the category in the drop down and then enter what type of food it is in th" +
    "e text box ";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSubmit.ForeColor = System.Drawing.Color.Black;
            this.buttonSubmit.Location = new System.Drawing.Point(326, 327);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 29);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit Item";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(897, 546);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxInventory);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown numericUpDown1;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBoxInventory;
        private Label label2;
        private TextBox textBoxItem;
        private Label label3;
        private Button buttonSubmit;
    }
}