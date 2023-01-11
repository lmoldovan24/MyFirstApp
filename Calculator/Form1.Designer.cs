namespace Calculator
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
            this.txtBox_a = new System.Windows.Forms.TextBox();
            this.txtBox_b = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_rezultat_static = new System.Windows.Forms.Label();
            this.lbl_rezultat = new System.Windows.Forms.Label();
            this.btn_adunare = new System.Windows.Forms.Button();
            this.btn_scadere = new System.Windows.Forms.Button();
            this.btn_inmultire = new System.Windows.Forms.Button();
            this.btn_impartire = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_a
            // 
            this.txtBox_a.Location = new System.Drawing.Point(34, 70);
            this.txtBox_a.Name = "txtBox_a";
            this.txtBox_a.Size = new System.Drawing.Size(125, 27);
            this.txtBox_a.TabIndex = 0;
            // 
            // txtBox_b
            // 
            this.txtBox_b.Location = new System.Drawing.Point(250, 70);
            this.txtBox_b.Name = "txtBox_b";
            this.txtBox_b.Size = new System.Drawing.Size(125, 27);
            this.txtBox_b.TabIndex = 1;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(57, 32);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(17, 20);
            this.lbl_a.TabIndex = 2;
            this.lbl_a.Text = "a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(277, 37);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(18, 20);
            this.lbl_b.TabIndex = 3;
            this.lbl_b.Text = "b";
            // 
            // lbl_rezultat_static
            // 
            this.lbl_rezultat_static.AutoSize = true;
            this.lbl_rezultat_static.Location = new System.Drawing.Point(57, 381);
            this.lbl_rezultat_static.Name = "lbl_rezultat_static";
            this.lbl_rezultat_static.Size = new System.Drawing.Size(66, 20);
            this.lbl_rezultat_static.TabIndex = 4;
            this.lbl_rezultat_static.Text = "Rezultat:";
            // 
            // lbl_rezultat
            // 
            this.lbl_rezultat.AutoSize = true;
            this.lbl_rezultat.Location = new System.Drawing.Point(188, 383);
            this.lbl_rezultat.Name = "lbl_rezultat";
            this.lbl_rezultat.Size = new System.Drawing.Size(0, 20);
            this.lbl_rezultat.TabIndex = 5;
            // 
            // btn_adunare
            // 
            this.btn_adunare.Location = new System.Drawing.Point(614, 124);
            this.btn_adunare.Name = "btn_adunare";
            this.btn_adunare.Size = new System.Drawing.Size(94, 29);
            this.btn_adunare.TabIndex = 6;
            this.btn_adunare.Text = "adunare";
            this.btn_adunare.UseVisualStyleBackColor = true;
            this.btn_adunare.Click += new System.EventHandler(this.btn_adunare_Click);
            // 
            // btn_scadere
            // 
            this.btn_scadere.Location = new System.Drawing.Point(614, 180);
            this.btn_scadere.Name = "btn_scadere";
            this.btn_scadere.Size = new System.Drawing.Size(94, 29);
            this.btn_scadere.TabIndex = 7;
            this.btn_scadere.Text = "scadere";
            this.btn_scadere.UseVisualStyleBackColor = true;
            this.btn_scadere.Click += new System.EventHandler(this.btn_scadere_Click);
            // 
            // btn_inmultire
            // 
            this.btn_inmultire.Location = new System.Drawing.Point(614, 242);
            this.btn_inmultire.Name = "btn_inmultire";
            this.btn_inmultire.Size = new System.Drawing.Size(94, 29);
            this.btn_inmultire.TabIndex = 8;
            this.btn_inmultire.Text = "inmultire";
            this.btn_inmultire.UseVisualStyleBackColor = true;
            this.btn_inmultire.Click += new System.EventHandler(this.btn_inmultire_Click);
            // 
            // btn_impartire
            // 
            this.btn_impartire.Location = new System.Drawing.Point(614, 306);
            this.btn_impartire.Name = "btn_impartire";
            this.btn_impartire.Size = new System.Drawing.Size(94, 29);
            this.btn_impartire.TabIndex = 9;
            this.btn_impartire.Text = "impartire";
            this.btn_impartire.UseVisualStyleBackColor = true;
            this.btn_impartire.Click += new System.EventHandler(this.btn_impartire_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(614, 379);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_impartire);
            this.Controls.Add(this.btn_inmultire);
            this.Controls.Add(this.btn_scadere);
            this.Controls.Add(this.btn_adunare);
            this.Controls.Add(this.lbl_rezultat);
            this.Controls.Add(this.lbl_rezultat_static);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.txtBox_b);
            this.Controls.Add(this.txtBox_a);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_a;
        private TextBox txtBox_b;
        private Label lbl_a;
        private Label lbl_b;
        private Label lbl_rezultat_static;
        private Label lbl_rezultat;
        private Button btn_adunare;
        private Button btn_scadere;
        private Button btn_inmultire;
        private Button btn_impartire;
        private Button btn_clear;
    }
}