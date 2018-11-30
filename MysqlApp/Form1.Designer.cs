namespace MysqlApp
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
            this.nev_form = new System.Windows.Forms.TextBox();
            this.jelszo_form = new System.Windows.Forms.TextBox();
            this.szuletesiido = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.regUserekLabel = new System.Windows.Forms.Label();
            this.felhasznaloListBox = new System.Windows.Forms.ListBox();
            this.statListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nev_form
            // 
            this.nev_form.Location = new System.Drawing.Point(13, 47);
            this.nev_form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nev_form.Name = "nev_form";
            this.nev_form.Size = new System.Drawing.Size(802, 22);
            this.nev_form.TabIndex = 0;
            // 
            // jelszo_form
            // 
            this.jelszo_form.Location = new System.Drawing.Point(13, 79);
            this.jelszo_form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jelszo_form.Name = "jelszo_form";
            this.jelszo_form.PasswordChar = '*';
            this.jelszo_form.Size = new System.Drawing.Size(802, 22);
            this.jelszo_form.TabIndex = 1;
            // 
            // szuletesiido
            // 
            this.szuletesiido.Location = new System.Drawing.Point(13, 112);
            this.szuletesiido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.szuletesiido.Name = "szuletesiido";
            this.szuletesiido.Size = new System.Drawing.Size(802, 22);
            this.szuletesiido.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(715, 315);
            this.regButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(100, 28);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Regisztráció";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // regUserekLabel
            // 
            this.regUserekLabel.AutoSize = true;
            this.regUserekLabel.Location = new System.Drawing.Point(12, 315);
            this.regUserekLabel.Name = "regUserekLabel";
            this.regUserekLabel.Size = new System.Drawing.Size(46, 17);
            this.regUserekLabel.TabIndex = 5;
            this.regUserekLabel.Text = "label2";
            // 
            // felhasznaloListBox
            // 
            this.felhasznaloListBox.FormattingEnabled = true;
            this.felhasznaloListBox.ItemHeight = 16;
            this.felhasznaloListBox.Location = new System.Drawing.Point(13, 160);
            this.felhasznaloListBox.Name = "felhasznaloListBox";
            this.felhasznaloListBox.Size = new System.Drawing.Size(407, 148);
            this.felhasznaloListBox.TabIndex = 6;
            // 
            // statListBox
            // 
            this.statListBox.FormattingEnabled = true;
            this.statListBox.ItemHeight = 16;
            this.statListBox.Location = new System.Drawing.Point(426, 160);
            this.statListBox.Name = "statListBox";
            this.statListBox.Size = new System.Drawing.Size(389, 148);
            this.statListBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statListBox);
            this.Controls.Add(this.felhasznaloListBox);
            this.Controls.Add(this.regUserekLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesiido);
            this.Controls.Add(this.jelszo_form);
            this.Controls.Add(this.nev_form);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_form;
        private System.Windows.Forms.TextBox jelszo_form;
        private System.Windows.Forms.DateTimePicker szuletesiido;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label regUserekLabel;
        private System.Windows.Forms.ListBox felhasznaloListBox;
        private System.Windows.Forms.ListBox statListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

