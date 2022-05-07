
namespace E_dnevnik
{
    partial class Osoba
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.tb_jmbg = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_uloga = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btt_begin = new System.Windows.Forms.Button();
            this.btt_last = new System.Windows.Forms.Button();
            this.btt_next = new System.Windows.Forms.Button();
            this.btt_end = new System.Windows.Forms.Button();
            this.btt_insert = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezie:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "uloga:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(278, 55);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_ime.TabIndex = 8;
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(278, 89);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(100, 20);
            this.tb_prezime.TabIndex = 9;
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(278, 126);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(100, 20);
            this.tb_adresa.TabIndex = 10;
            // 
            // tb_jmbg
            // 
            this.tb_jmbg.Location = new System.Drawing.Point(278, 162);
            this.tb_jmbg.Name = "tb_jmbg";
            this.tb_jmbg.Size = new System.Drawing.Size(100, 20);
            this.tb_jmbg.TabIndex = 11;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(278, 197);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 12;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(278, 233);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 13;
            // 
            // tb_uloga
            // 
            this.tb_uloga.Location = new System.Drawing.Point(278, 270);
            this.tb_uloga.Name = "tb_uloga";
            this.tb_uloga.Size = new System.Drawing.Size(100, 20);
            this.tb_uloga.TabIndex = 14;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(278, 23);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 20);
            this.tb_ID.TabIndex = 15;
            // 
            // btt_begin
            // 
            this.btt_begin.Location = new System.Drawing.Point(99, 318);
            this.btt_begin.Name = "btt_begin";
            this.btt_begin.Size = new System.Drawing.Size(75, 23);
            this.btt_begin.TabIndex = 16;
            this.btt_begin.Text = "<<";
            this.btt_begin.UseVisualStyleBackColor = true;
            this.btt_begin.Click += new System.EventHandler(this.btt_begin_Click);
            // 
            // btt_last
            // 
            this.btt_last.Location = new System.Drawing.Point(212, 318);
            this.btt_last.Name = "btt_last";
            this.btt_last.Size = new System.Drawing.Size(75, 23);
            this.btt_last.TabIndex = 17;
            this.btt_last.Text = "<";
            this.btt_last.UseVisualStyleBackColor = true;
            this.btt_last.Click += new System.EventHandler(this.btt_last_Click);
            // 
            // btt_next
            // 
            this.btt_next.Location = new System.Drawing.Point(410, 318);
            this.btt_next.Name = "btt_next";
            this.btt_next.Size = new System.Drawing.Size(75, 23);
            this.btt_next.TabIndex = 18;
            this.btt_next.Text = ">";
            this.btt_next.UseVisualStyleBackColor = true;
            this.btt_next.Click += new System.EventHandler(this.btt_next_Click);
            // 
            // btt_end
            // 
            this.btt_end.Location = new System.Drawing.Point(527, 318);
            this.btt_end.Name = "btt_end";
            this.btt_end.Size = new System.Drawing.Size(75, 23);
            this.btt_end.TabIndex = 19;
            this.btt_end.Text = ">>";
            this.btt_end.UseVisualStyleBackColor = true;
            this.btt_end.Click += new System.EventHandler(this.btt_end_Click);
            // 
            // btt_insert
            // 
            this.btt_insert.Location = new System.Drawing.Point(212, 365);
            this.btt_insert.Name = "btt_insert";
            this.btt_insert.Size = new System.Drawing.Size(75, 23);
            this.btt_insert.TabIndex = 20;
            this.btt_insert.Text = "Insert";
            this.btt_insert.UseVisualStyleBackColor = true;
            this.btt_insert.Click += new System.EventHandler(this.btt_insert_Click);
            // 
            // btt_update
            // 
            this.btt_update.Location = new System.Drawing.Point(315, 365);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 23);
            this.btt_update.TabIndex = 21;
            this.btt_update.Text = "Update";
            this.btt_update.UseVisualStyleBackColor = true;
            this.btt_update.Click += new System.EventHandler(this.btt_update_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(410, 365);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 23);
            this.btt_delete.TabIndex = 22;
            this.btt_delete.Text = "Delete";
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.btt_insert);
            this.Controls.Add(this.btt_end);
            this.Controls.Add(this.btt_next);
            this.Controls.Add(this.btt_last);
            this.Controls.Add(this.btt_begin);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_uloga);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_jmbg);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.tb_prezime);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.TextBox tb_jmbg;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_uloga;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btt_begin;
        private System.Windows.Forms.Button btt_last;
        private System.Windows.Forms.Button btt_next;
        private System.Windows.Forms.Button btt_end;
        private System.Windows.Forms.Button btt_insert;
        private System.Windows.Forms.Button btt_update;
        private System.Windows.Forms.Button btt_delete;
    }
}