namespace Receive
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonliste = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonouvrir = new System.Windows.Forms.Button();
            this.buttonfermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonliste
            // 
            this.buttonliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonliste.Location = new System.Drawing.Point(60, 65);
            this.buttonliste.Name = "buttonliste";
            this.buttonliste.Size = new System.Drawing.Size(115, 49);
            this.buttonliste.TabIndex = 1;
            this.buttonliste.Text = "Liste";
            this.buttonliste.UseVisualStyleBackColor = true;
            this.buttonliste.Click += new System.EventHandler(this.buttonliste_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonouvrir
            // 
            this.buttonouvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonouvrir.Location = new System.Drawing.Point(60, 167);
            this.buttonouvrir.Name = "buttonouvrir";
            this.buttonouvrir.Size = new System.Drawing.Size(115, 39);
            this.buttonouvrir.TabIndex = 8;
            this.buttonouvrir.Text = "ouvrir";
            this.buttonouvrir.UseVisualStyleBackColor = true;
            this.buttonouvrir.Click += new System.EventHandler(this.buttonouvrir_Click);
            // 
            // buttonfermer
            // 
            this.buttonfermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfermer.Location = new System.Drawing.Point(332, 167);
            this.buttonfermer.Name = "buttonfermer";
            this.buttonfermer.Size = new System.Drawing.Size(115, 39);
            this.buttonfermer.TabIndex = 9;
            this.buttonfermer.Text = "fermer";
            this.buttonfermer.UseVisualStyleBackColor = true;
            this.buttonfermer.Click += new System.EventHandler(this.buttonfermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 31);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "POC-AnasMili-2025";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "D2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "D1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonfermer);
            this.Controls.Add(this.buttonouvrir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonliste);
            this.Name = "Form1";
            this.Text = "recevoir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonliste;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonouvrir;
        private System.Windows.Forms.Button buttonfermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

