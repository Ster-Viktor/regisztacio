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
            this.delButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.del_form = new System.Windows.Forms.TextBox();
            this.update_form = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nev_form
            // 
            this.nev_form.Location = new System.Drawing.Point(27, 38);
            this.nev_form.Name = "nev_form";
            this.nev_form.Size = new System.Drawing.Size(245, 20);
            this.nev_form.TabIndex = 0;
            // 
            // jelszo_form
            // 
            this.jelszo_form.Location = new System.Drawing.Point(27, 64);
            this.jelszo_form.Name = "jelszo_form";
            this.jelszo_form.PasswordChar = '*';
            this.jelszo_form.Size = new System.Drawing.Size(245, 20);
            this.jelszo_form.TabIndex = 1;
            // 
            // szuletesiido
            // 
            this.szuletesiido.Location = new System.Drawing.Point(27, 91);
            this.szuletesiido.Name = "szuletesiido";
            this.szuletesiido.Size = new System.Drawing.Size(245, 20);
            this.szuletesiido.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(197, 130);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Regisztráció";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(197, 181);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Törlés";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(197, 226);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Módosít";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // del_form
            // 
            this.del_form.Location = new System.Drawing.Point(27, 181);
            this.del_form.Name = "del_form";
            this.del_form.Size = new System.Drawing.Size(100, 20);
            this.del_form.TabIndex = 6;
            // 
            // update_form
            // 
            this.update_form.Location = new System.Drawing.Point(27, 229);
            this.update_form.Name = "update_form";
            this.update_form.Size = new System.Drawing.Size(100, 20);
            this.update_form.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Törlés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Módisítás:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_form);
            this.Controls.Add(this.del_form);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesiido);
            this.Controls.Add(this.jelszo_form);
            this.Controls.Add(this.nev_form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_form;
        private System.Windows.Forms.TextBox jelszo_form;
        private System.Windows.Forms.DateTimePicker szuletesiido;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox del_form;
        private System.Windows.Forms.TextBox update_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

