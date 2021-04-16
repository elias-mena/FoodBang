
namespace FoodBang.Forms.Admin
{
    partial class FrmConsultarC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarC));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComida = new System.Windows.Forms.DataGridView();
            this.btnConsCatego = new System.Windows.Forms.Button();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Comida por Categoría";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(175, 57);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mostrar Todas las Comidas";
            // 
            // dgvComida
            // 
            this.dgvComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComida.Location = new System.Drawing.Point(15, 91);
            this.dgvComida.Name = "dgvComida";
            this.dgvComida.Size = new System.Drawing.Size(263, 208);
            this.dgvComida.TabIndex = 4;
            // 
            // btnConsCatego
            // 
            this.btnConsCatego.Location = new System.Drawing.Point(175, 18);
            this.btnConsCatego.Name = "btnConsCatego";
            this.btnConsCatego.Size = new System.Drawing.Size(75, 23);
            this.btnConsCatego.TabIndex = 5;
            this.btnConsCatego.Text = "Consultar";
            this.btnConsCatego.UseVisualStyleBackColor = true;
            this.btnConsCatego.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(284, 91);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(104, 21);
            this.cbxCategorias.TabIndex = 6;
            // 
            // FrmConsultarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 317);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.btnConsCatego);
            this.Controls.Add(this.dgvComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmConsultarC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Comida";
            this.Load += new System.EventHandler(this.FrmConsultarC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvComida;
        private System.Windows.Forms.Button btnConsCatego;
        private System.Windows.Forms.ComboBox cbxCategorias;
    }
}