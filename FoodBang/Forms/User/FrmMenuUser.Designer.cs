
namespace FoodBang.Forms.User
{
    partial class FrmMenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuUser));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnMac = new System.Windows.Forms.Button();
            this.BtnPH = new System.Windows.Forms.Button();
            this.BtnOB = new System.Windows.Forms.Button();
            this.BtnTB = new System.Windows.Forms.Button();
            this.btnOG = new System.Windows.Forms.Button();
            this.BtnNA = new System.Windows.Forms.Button();
            this.BtnCarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 83;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(337, 349);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 80;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(337, 44);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(362, 289);
            this.dgvInfo.TabIndex = 78;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPagar.Location = new System.Drawing.Point(626, 346);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(73, 57);
            this.BtnPagar.TabIndex = 77;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // BtnMac
            // 
            this.BtnMac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMac.BackgroundImage")));
            this.BtnMac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMac.Location = new System.Drawing.Point(12, 44);
            this.BtnMac.Name = "BtnMac";
            this.BtnMac.Size = new System.Drawing.Size(143, 83);
            this.BtnMac.TabIndex = 86;
            this.BtnMac.UseVisualStyleBackColor = true;
            this.BtnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // BtnPH
            // 
            this.BtnPH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPH.BackgroundImage")));
            this.BtnPH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPH.Location = new System.Drawing.Point(161, 44);
            this.BtnPH.Name = "BtnPH";
            this.BtnPH.Size = new System.Drawing.Size(143, 83);
            this.BtnPH.TabIndex = 87;
            this.BtnPH.UseVisualStyleBackColor = true;
            this.BtnPH.Click += new System.EventHandler(this.btnPH_Click);
            // 
            // BtnOB
            // 
            this.BtnOB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOB.BackgroundImage")));
            this.BtnOB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOB.Location = new System.Drawing.Point(161, 250);
            this.BtnOB.Name = "BtnOB";
            this.BtnOB.Size = new System.Drawing.Size(143, 83);
            this.BtnOB.TabIndex = 88;
            this.BtnOB.UseVisualStyleBackColor = true;
            this.BtnOB.Click += new System.EventHandler(this.btnOB_Click);
            // 
            // BtnTB
            // 
            this.BtnTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTB.BackgroundImage")));
            this.BtnTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTB.Location = new System.Drawing.Point(12, 145);
            this.BtnTB.Name = "BtnTB";
            this.BtnTB.Size = new System.Drawing.Size(143, 83);
            this.BtnTB.TabIndex = 89;
            this.BtnTB.UseVisualStyleBackColor = true;
            this.BtnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // btnOG
            // 
            this.btnOG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOG.BackgroundImage")));
            this.btnOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOG.Location = new System.Drawing.Point(161, 145);
            this.btnOG.Name = "btnOG";
            this.btnOG.Size = new System.Drawing.Size(143, 83);
            this.btnOG.TabIndex = 90;
            this.btnOG.UseVisualStyleBackColor = true;
            this.btnOG.Click += new System.EventHandler(this.btnOG_Click);
            // 
            // BtnNA
            // 
            this.BtnNA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNA.BackgroundImage")));
            this.BtnNA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNA.Location = new System.Drawing.Point(12, 250);
            this.BtnNA.Name = "BtnNA";
            this.BtnNA.Size = new System.Drawing.Size(143, 83);
            this.BtnNA.TabIndex = 91;
            this.BtnNA.UseVisualStyleBackColor = true;
            this.BtnNA.Click += new System.EventHandler(this.btnNA_Click);
            // 
            // BtnCarrito
            // 
            this.BtnCarrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCarrito.BackgroundImage")));
            this.BtnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCarrito.Location = new System.Drawing.Point(545, 346);
            this.BtnCarrito.Name = "BtnCarrito";
            this.BtnCarrito.Size = new System.Drawing.Size(75, 57);
            this.BtnCarrito.TabIndex = 92;
            this.BtnCarrito.UseVisualStyleBackColor = true;
            this.BtnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // FrmMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.BtnCarrito);
            this.Controls.Add(this.BtnNA);
            this.Controls.Add(this.btnOG);
            this.Controls.Add(this.BtnTB);
            this.Controls.Add(this.BtnOB);
            this.Controls.Add(this.BtnPH);
            this.Controls.Add(this.BtnMac);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.BtnPagar);
            this.Name = "FrmMenuUser";
            this.Text = "FrmMenuUser";
            this.Load += new System.EventHandler(this.FrmMenuUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnMac;
        private System.Windows.Forms.Button BtnPH;
        private System.Windows.Forms.Button BtnOB;
        private System.Windows.Forms.Button BtnTB;
        private System.Windows.Forms.Button btnOG;
        private System.Windows.Forms.Button BtnNA;
        private System.Windows.Forms.Button BtnCarrito;
    }
}