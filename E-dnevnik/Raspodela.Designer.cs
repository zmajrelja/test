
namespace E_dnevnik
{
    partial class Raspodela
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btt_begin = new System.Windows.Forms.Button();
            this.btt_last = new System.Windows.Forms.Button();
            this.btt_insert = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_next = new System.Windows.Forms.Button();
            this.btt_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nastavnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Predmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Odeljanje";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(440, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(440, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(440, 191);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(440, 242);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(440, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btt_begin
            // 
            this.btt_begin.Location = new System.Drawing.Point(43, 335);
            this.btt_begin.Name = "btt_begin";
            this.btt_begin.Size = new System.Drawing.Size(75, 23);
            this.btt_begin.TabIndex = 11;
            this.btt_begin.Text = "<<";
            this.btt_begin.UseVisualStyleBackColor = true;
            this.btt_begin.Click += new System.EventHandler(this.btt_begin_Click);
            // 
            // btt_last
            // 
            this.btt_last.Location = new System.Drawing.Point(146, 335);
            this.btt_last.Name = "btt_last";
            this.btt_last.Size = new System.Drawing.Size(75, 23);
            this.btt_last.TabIndex = 12;
            this.btt_last.Text = "<";
            this.btt_last.UseVisualStyleBackColor = true;
            this.btt_last.Click += new System.EventHandler(this.btt_last_Click);
            // 
            // btt_insert
            // 
            this.btt_insert.Location = new System.Drawing.Point(255, 335);
            this.btt_insert.Name = "btt_insert";
            this.btt_insert.Size = new System.Drawing.Size(75, 23);
            this.btt_insert.TabIndex = 13;
            this.btt_insert.Text = "insert";
            this.btt_insert.UseVisualStyleBackColor = true;
            this.btt_insert.Click += new System.EventHandler(this.btt_insert_Click);
            // 
            // btt_update
            // 
            this.btt_update.Location = new System.Drawing.Point(353, 335);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 23);
            this.btt_update.TabIndex = 14;
            this.btt_update.Text = "update";
            this.btt_update.UseVisualStyleBackColor = true;
            this.btt_update.Click += new System.EventHandler(this.btt_update_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(456, 335);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 23);
            this.btt_delete.TabIndex = 15;
            this.btt_delete.Text = "delete";
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // btt_next
            // 
            this.btt_next.Location = new System.Drawing.Point(562, 335);
            this.btt_next.Name = "btt_next";
            this.btt_next.Size = new System.Drawing.Size(75, 23);
            this.btt_next.TabIndex = 16;
            this.btt_next.Text = ">";
            this.btt_next.UseVisualStyleBackColor = true;
            this.btt_next.Click += new System.EventHandler(this.btt_nest_Click);
            // 
            // btt_end
            // 
            this.btt_end.Location = new System.Drawing.Point(656, 335);
            this.btt_end.Name = "btt_end";
            this.btt_end.Size = new System.Drawing.Size(75, 23);
            this.btt_end.TabIndex = 17;
            this.btt_end.Text = ">>";
            this.btt_end.UseVisualStyleBackColor = true;
            this.btt_end.Click += new System.EventHandler(this.btt_end_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btt_end);
            this.Controls.Add(this.btt_next);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.btt_insert);
            this.Controls.Add(this.btt_last);
            this.Controls.Add(this.btt_begin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btt_begin;
        private System.Windows.Forms.Button btt_last;
        private System.Windows.Forms.Button btt_insert;
        private System.Windows.Forms.Button btt_update;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_next;
        private System.Windows.Forms.Button btt_end;
    }
}