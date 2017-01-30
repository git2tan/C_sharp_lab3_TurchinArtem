namespace C_sharp_lab3_TurchinArtem
{
    partial class EditFormDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxOfRepairs = new System.Windows.Forms.ListBox();
            this.labelOfNumber = new System.Windows.Forms.Label();
            this.comboBoxOfMarks = new System.Windows.Forms.ComboBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textPower = new System.Windows.Forms.TextBox();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Марка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мощность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Грузоподъемность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ремонты";
            // 
            // listBoxOfRepairs
            // 
            this.listBoxOfRepairs.FormattingEnabled = true;
            this.listBoxOfRepairs.Location = new System.Drawing.Point(19, 206);
            this.listBoxOfRepairs.Name = "listBoxOfRepairs";
            this.listBoxOfRepairs.Size = new System.Drawing.Size(501, 95);
            this.listBoxOfRepairs.TabIndex = 6;
            this.listBoxOfRepairs.SelectedIndexChanged += new System.EventHandler(this.listBoxOfRepairs_SelectedIndexChanged);
            // 
            // labelOfNumber
            // 
            this.labelOfNumber.AutoSize = true;
            this.labelOfNumber.Location = new System.Drawing.Point(41, 19);
            this.labelOfNumber.Name = "labelOfNumber";
            this.labelOfNumber.Size = new System.Drawing.Size(35, 13);
            this.labelOfNumber.TabIndex = 7;
            this.labelOfNumber.Text = "label7";
            // 
            // comboBoxOfMarks
            // 
            this.comboBoxOfMarks.FormattingEnabled = true;
            this.comboBoxOfMarks.Items.AddRange(new object[] {
            "Тойота",
            "Мазда",
            "Бентли",
            "BMW",
            "Ауди",
            "Митсубиши"});
            this.comboBoxOfMarks.Location = new System.Drawing.Point(138, 47);
            this.comboBoxOfMarks.Name = "comboBoxOfMarks";
            this.comboBoxOfMarks.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOfMarks.TabIndex = 8;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(138, 81);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(121, 20);
            this.textPrice.TabIndex = 9;
            // 
            // textPower
            // 
            this.textPower.Location = new System.Drawing.Point(138, 115);
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(121, 20);
            this.textPower.TabIndex = 10;
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(138, 153);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(121, 20);
            this.textCargo.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(19, 381);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(445, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Location = new System.Drawing.Point(19, 316);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(75, 23);
            this.btnAddRepair.TabIndex = 14;
            this.btnAddRepair.Text = "add (repair)";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            this.btnAddRepair.Click += new System.EventHandler(this.btnAddRepair_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(445, 316);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "del (repair)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // EditFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(532, 418);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textCargo);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.comboBoxOfMarks);
            this.Controls.Add(this.labelOfNumber);
            this.Controls.Add(this.listBoxOfRepairs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditFormDialog";
            this.Text = "EditFormDialog";
            this.Load += new System.EventHandler(this.EditFormDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxOfRepairs;
        private System.Windows.Forms.Label labelOfNumber;
        private System.Windows.Forms.ComboBox comboBoxOfMarks;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnDel;
    }
}