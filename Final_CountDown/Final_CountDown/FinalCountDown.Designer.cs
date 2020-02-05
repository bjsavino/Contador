namespace Final_CountDown
{
    partial class Final_Count_Down
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final_Count_Down));
            this.placas_testadas = new System.Windows.Forms.Label();
            this.labelcount1 = new System.Windows.Forms.Label();
            this.placas_aprovadas = new System.Windows.Forms.Label();
            this.placas_reprovadas = new System.Windows.Forms.Label();
            this.labelcount2 = new System.Windows.Forms.Label();
            this.labelcount3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // placas_testadas
            // 
            this.placas_testadas.AutoSize = true;
            this.placas_testadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placas_testadas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.placas_testadas.Location = new System.Drawing.Point(13, 110);
            this.placas_testadas.Name = "placas_testadas";
            this.placas_testadas.Size = new System.Drawing.Size(111, 13);
            this.placas_testadas.TabIndex = 0;
            this.placas_testadas.Text = "TESTED BOARDS";
            this.placas_testadas.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelcount1
            // 
            this.labelcount1.AutoSize = true;
            this.labelcount1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount1.Location = new System.Drawing.Point(12, 132);
            this.labelcount1.Name = "labelcount1";
            this.labelcount1.Size = new System.Drawing.Size(18, 19);
            this.labelcount1.TabIndex = 3;
            this.labelcount1.Text = "0";
            // 
            // placas_aprovadas
            // 
            this.placas_aprovadas.AutoSize = true;
            this.placas_aprovadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placas_aprovadas.ForeColor = System.Drawing.Color.DarkGreen;
            this.placas_aprovadas.Location = new System.Drawing.Point(9, 174);
            this.placas_aprovadas.Name = "placas_aprovadas";
            this.placas_aprovadas.Size = new System.Drawing.Size(74, 13);
            this.placas_aprovadas.TabIndex = 4;
            this.placas_aprovadas.Text = "APPROVED";
            // 
            // placas_reprovadas
            // 
            this.placas_reprovadas.AutoSize = true;
            this.placas_reprovadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placas_reprovadas.ForeColor = System.Drawing.Color.DarkRed;
            this.placas_reprovadas.Location = new System.Drawing.Point(9, 228);
            this.placas_reprovadas.Name = "placas_reprovadas";
            this.placas_reprovadas.Size = new System.Drawing.Size(95, 13);
            this.placas_reprovadas.TabIndex = 5;
            this.placas_reprovadas.Text = "DISAPPROVED";
            // 
            // labelcount2
            // 
            this.labelcount2.AutoSize = true;
            this.labelcount2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount2.Location = new System.Drawing.Point(12, 193);
            this.labelcount2.Name = "labelcount2";
            this.labelcount2.Size = new System.Drawing.Size(18, 19);
            this.labelcount2.TabIndex = 6;
            this.labelcount2.Text = "0";
            // 
            // labelcount3
            // 
            this.labelcount3.AutoSize = true;
            this.labelcount3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcount3.Location = new System.Drawing.Point(12, 247);
            this.labelcount3.Name = "labelcount3";
            this.labelcount3.Size = new System.Drawing.Size(18, 19);
            this.labelcount3.TabIndex = 7;
            this.labelcount3.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_CountDown.Properties.Resources.calcomp2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 79);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Final_Count_Down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(248, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelcount3);
            this.Controls.Add(this.labelcount2);
            this.Controls.Add(this.placas_reprovadas);
            this.Controls.Add(this.placas_aprovadas);
            this.Controls.Add(this.labelcount1);
            this.Controls.Add(this.placas_testadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Final_Count_Down";
            this.Opacity = 0.95D;
            this.Text = "CALCOMP - The Final Count Down";
            this.Load += new System.EventHandler(this.Final_Count_Down_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placas_testadas;
        private System.Windows.Forms.Label labelcount1;
        private System.Windows.Forms.Label placas_aprovadas;
        private System.Windows.Forms.Label placas_reprovadas;
        private System.Windows.Forms.Label labelcount2;
        private System.Windows.Forms.Label labelcount3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}

