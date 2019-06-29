namespace ProjetCavalier
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xDepart = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.yDepart = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.retour = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.labCommnetaire = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 480);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "position de  depart";
            // 
            // xDepart
            // 
            this.xDepart.Location = new System.Drawing.Point(538, 27);
            this.xDepart.Name = "xDepart";
            this.xDepart.Size = new System.Drawing.Size(66, 20);
            this.xDepart.TabIndex = 63;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(520, 30);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(12, 13);
            this.x.TabIndex = 64;
            this.x.Text = "x";
            // 
            // yDepart
            // 
            this.yDepart.Location = new System.Drawing.Point(538, 52);
            this.yDepart.Name = "yDepart";
            this.yDepart.Size = new System.Drawing.Size(66, 20);
            this.yDepart.TabIndex = 65;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(520, 55);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(12, 13);
            this.y.TabIndex = 66;
            this.y.Text = "y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Demarrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Annulez";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(523, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 69;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "automatique";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(523, 131);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 70;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "manuelle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(749, 0);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(90, 47);
            this.retour.TabIndex = 71;
            this.retour.Text = "RETOUR";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(689, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "SCORE";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(739, 112);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 74;
            // 
            // labCommnetaire
            // 
            this.labCommnetaire.AutoSize = true;
            this.labCommnetaire.Location = new System.Drawing.Point(520, 210);
            this.labCommnetaire.Name = "labCommnetaire";
            this.labCommnetaire.Size = new System.Drawing.Size(0, 13);
            this.labCommnetaire.TabIndex = 75;
            // 
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 490);
            this.Controls.Add(this.labCommnetaire);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.y);
            this.Controls.Add(this.yDepart);
            this.Controls.Add(this.x);
            this.Controls.Add(this.xDepart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox xDepart;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox yDepart;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
       
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label labCommnetaire;
        private System.Windows.Forms.ToolTip toolTip1;

  

    }
}

