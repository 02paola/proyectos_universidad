namespace UNACH.Windows
{
    partial class Modelo3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.btn_empezar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 154);
            this.label1.TabIndex = 11;
            this.label1.Text = ".";
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_borrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ForeColor = System.Drawing.Color.White;
            this.btn_borrar.Location = new System.Drawing.Point(29, 140);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(155, 49);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_pausar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pausar.ForeColor = System.Drawing.Color.White;
            this.btn_pausar.Location = new System.Drawing.Point(29, 252);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(155, 48);
            this.btn_pausar.TabIndex = 9;
            this.btn_pausar.Text = "Pausar";
            this.btn_pausar.UseVisualStyleBackColor = false;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // btn_empezar
            // 
            this.btn_empezar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_empezar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empezar.ForeColor = System.Drawing.Color.White;
            this.btn_empezar.Location = new System.Drawing.Point(29, 40);
            this.btn_empezar.Name = "btn_empezar";
            this.btn_empezar.Size = new System.Drawing.Size(155, 47);
            this.btn_empezar.TabIndex = 8;
            this.btn_empezar.Text = "Empezar";
            this.btn_empezar.UseVisualStyleBackColor = false;
            this.btn_empezar.Click += new System.EventHandler(this.btn_empezar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cambiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar.Location = new System.Drawing.Point(315, 291);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(127, 33);
            this.btn_cambiar.TabIndex = 12;
            this.btn_cambiar.Text = "Cambiar Diseño";
            this.btn_cambiar.UseVisualStyleBackColor = false;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // Modelo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(454, 336);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_empezar);
            this.Name = "Modelo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Button btn_empezar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_cambiar;
    }
}