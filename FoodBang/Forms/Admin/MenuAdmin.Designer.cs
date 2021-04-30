
namespace FoodBang.Forms.Admin
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarRestaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarComidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarComidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarUsuariosToolStripMenuItem,
            this.GestionarRestaurantesToolStripMenuItem,
            this.GestionarComidasToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GestionarUsuariosToolStripMenuItem
            // 
            this.GestionarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarUsuarioToolStripMenuItem,
            this.ConsultarUsuarioToolStripMenuItem,
            this.EliminarUsuarioToolStripMenuItem});
            this.GestionarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GestionarUsuariosToolStripMenuItem.Image")));
            this.GestionarUsuariosToolStripMenuItem.Name = "GestionarUsuariosToolStripMenuItem";
            this.GestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.GestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            // 
            // AgregarUsuarioToolStripMenuItem
            // 
            this.AgregarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AgregarUsuarioToolStripMenuItem.Image")));
            this.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem";
            this.AgregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.AgregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // ConsultarUsuarioToolStripMenuItem
            // 
            this.ConsultarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarUsuarioToolStripMenuItem.Image")));
            this.ConsultarUsuarioToolStripMenuItem.Name = "ConsultarUsuarioToolStripMenuItem";
            this.ConsultarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ConsultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            this.ConsultarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuarioToolStripMenuItem_Click);
            // 
            // EliminarUsuarioToolStripMenuItem
            // 
            this.EliminarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EliminarUsuarioToolStripMenuItem.Image")));
            this.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem";
            this.EliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.EliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // GestionarRestaurantesToolStripMenuItem
            // 
            this.GestionarRestaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarMenusToolStripMenuItem,
            this.modificarMenusToolStripMenuItem});
            this.GestionarRestaurantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GestionarRestaurantesToolStripMenuItem.Image")));
            this.GestionarRestaurantesToolStripMenuItem.Name = "GestionarRestaurantesToolStripMenuItem";
            this.GestionarRestaurantesToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.GestionarRestaurantesToolStripMenuItem.Text = "Gestionar Menus";
            // 
            // GestionarMenusToolStripMenuItem
            // 
            this.GestionarMenusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GestionarMenusToolStripMenuItem.Image")));
            this.GestionarMenusToolStripMenuItem.Name = "GestionarMenusToolStripMenuItem";
            this.GestionarMenusToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.GestionarMenusToolStripMenuItem.Text = "Consultar Menus";
            this.GestionarMenusToolStripMenuItem.Click += new System.EventHandler(this.GestionarMenusToolStripMenuItem_Click);
            // 
            // modificarMenusToolStripMenuItem
            // 
            this.modificarMenusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarMenusToolStripMenuItem.Image")));
            this.modificarMenusToolStripMenuItem.Name = "modificarMenusToolStripMenuItem";
            this.modificarMenusToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modificarMenusToolStripMenuItem.Text = "Modificar Menus";
            this.modificarMenusToolStripMenuItem.Click += new System.EventHandler(this.modificarMenusToolStripMenuItem_Click);
            // 
            // GestionarComidasToolStripMenuItem
            // 
            this.GestionarComidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarComidaToolStripMenuItem,
            this.ConsultarComidaToolStripMenuItem,
            this.EliminarComidaToolStripMenuItem});
            this.GestionarComidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GestionarComidasToolStripMenuItem.Image")));
            this.GestionarComidasToolStripMenuItem.Name = "GestionarComidasToolStripMenuItem";
            this.GestionarComidasToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.GestionarComidasToolStripMenuItem.Text = "Gestionar Comidas";
            // 
            // AgregarComidaToolStripMenuItem
            // 
            this.AgregarComidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AgregarComidaToolStripMenuItem.Image")));
            this.AgregarComidaToolStripMenuItem.Name = "AgregarComidaToolStripMenuItem";
            this.AgregarComidaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.AgregarComidaToolStripMenuItem.Text = "Agregar Comida";
            this.AgregarComidaToolStripMenuItem.Click += new System.EventHandler(this.agregarComidaToolStripMenuItem_Click);
            // 
            // ConsultarComidaToolStripMenuItem
            // 
            this.ConsultarComidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarComidaToolStripMenuItem.Image")));
            this.ConsultarComidaToolStripMenuItem.Name = "ConsultarComidaToolStripMenuItem";
            this.ConsultarComidaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ConsultarComidaToolStripMenuItem.Text = "Consultar Comida";
            this.ConsultarComidaToolStripMenuItem.Click += new System.EventHandler(this.consultarComidaToolStripMenuItem_Click);
            // 
            // EliminarComidaToolStripMenuItem
            // 
            this.EliminarComidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EliminarComidaToolStripMenuItem.Image")));
            this.EliminarComidaToolStripMenuItem.Name = "EliminarComidaToolStripMenuItem";
            this.EliminarComidaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.EliminarComidaToolStripMenuItem.Text = "Eliminar Comida";
            this.EliminarComidaToolStripMenuItem.Click += new System.EventHandler(this.eliminarComidaToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 316);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuAdmin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarComidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EliminarComidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarRestaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}