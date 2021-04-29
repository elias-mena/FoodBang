
namespace FoodBang.Forms.User
{
    partial class FrmPreparando
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tiempoEspera = new System.Windows.Forms.Label();
            this.proEntregando = new System.Windows.Forms.ProgressBar();
            this.proConCamino = new System.Windows.Forms.ProgressBar();
            this.proPreOrden = new System.Windows.Forms.ProgressBar();
            this.progresoOrRecibido = new System.Windows.Forms.ProgressBar();
            this.temp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 53);
            this.button3.TabIndex = 41;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 53);
            this.button2.TabIndex = 40;
            this.button2.Text = "Ver Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 39;
            this.button1.Text = "Imprimir Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiempoEspera
            // 
            this.tiempoEspera.AutoSize = true;
            this.tiempoEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoEspera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tiempoEspera.Location = new System.Drawing.Point(119, 118);
            this.tiempoEspera.Name = "tiempoEspera";
            this.tiempoEspera.Size = new System.Drawing.Size(459, 55);
            this.tiempoEspera.TabIndex = 37;
            this.tiempoEspera.Text = "Preparando Entrega";
            // 
            // proEntregando
            // 
            this.proEntregando.Location = new System.Drawing.Point(483, 72);
            this.proEntregando.Name = "proEntregando";
            this.proEntregando.Size = new System.Drawing.Size(139, 23);
            this.proEntregando.TabIndex = 36;
            // 
            // proConCamino
            // 
            this.proConCamino.Location = new System.Drawing.Point(338, 72);
            this.proConCamino.Name = "proConCamino";
            this.proConCamino.Size = new System.Drawing.Size(139, 23);
            this.proConCamino.TabIndex = 35;
            // 
            // proPreOrden
            // 
            this.proPreOrden.Location = new System.Drawing.Point(189, 72);
            this.proPreOrden.Name = "proPreOrden";
            this.proPreOrden.Size = new System.Drawing.Size(139, 23);
            this.proPreOrden.TabIndex = 34;
            // 
            // progresoOrRecibido
            // 
            this.progresoOrRecibido.Location = new System.Drawing.Point(44, 72);
            this.progresoOrRecibido.Name = "progresoOrRecibido";
            this.progresoOrRecibido.Size = new System.Drawing.Size(139, 23);
            this.progresoOrRecibido.TabIndex = 33;
            // 
            // temp
            // 
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(251, 193);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(199, 50);
            this.temp.TabIndex = 42;
            this.temp.Text = "00:00:00";
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Orden Recibida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Preparando Orden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "En Camino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Entregado";
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPreparando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tiempoEspera);
            this.Controls.Add(this.proEntregando);
            this.Controls.Add(this.proConCamino);
            this.Controls.Add(this.proPreOrden);
            this.Controls.Add(this.progresoOrRecibido);
            this.Name = "FrmPreparando";
            this.Text = "FrmPreparando";
            this.Load += new System.EventHandler(this.FrmPreparando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tiempoEspera;
        private System.Windows.Forms.ProgressBar proEntregando;
        private System.Windows.Forms.ProgressBar proConCamino;
        private System.Windows.Forms.ProgressBar proPreOrden;
        private System.Windows.Forms.ProgressBar progresoOrRecibido;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tempo;
    }
}