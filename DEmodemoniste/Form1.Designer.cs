namespace DEmodemoniste
{
    partial class Walou
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Zarma = new System.Windows.Forms.Label();
            this.Rabes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(113, 344);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Zarma
            // 
            this.Zarma.AutoSize = true;
            this.Zarma.Location = new System.Drawing.Point(113, 325);
            this.Zarma.Name = "Zarma";
            this.Zarma.Size = new System.Drawing.Size(37, 13);
            this.Zarma.TabIndex = 1;
            this.Zarma.Text = "Zarma";
            // 
            // Rabes
            // 
            this.Rabes.AutoSize = true;
            this.Rabes.Location = new System.Drawing.Point(561, 123);
            this.Rabes.Name = "Rabes";
            this.Rabes.Size = new System.Drawing.Size(38, 13);
            this.Rabes.TabIndex = 2;
            this.Rabes.Text = "Rabes";
            // 
            // Walou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rabes);
            this.Controls.Add(this.Zarma);
            this.Controls.Add(this.radioButton1);
            this.Name = "Walou";
            this.Text = "Walou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Zarma;
        private System.Windows.Forms.Label Rabes;
    }
}

