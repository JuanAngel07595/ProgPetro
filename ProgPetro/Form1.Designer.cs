namespace ProgPetro
{
    partial class Backbolivar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgPetro = new System.Windows.Forms.PictureBox();
            this.TMRflash = new System.Windows.Forms.Timer(this.components);
            this.Btncorre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPetro)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPetro
            // 
            this.imgPetro.Image = global::ProgPetro.Properties.Resources.imagenpet;
            this.imgPetro.Location = new System.Drawing.Point(12, 21);
            this.imgPetro.Name = "imgPetro";
            this.imgPetro.Size = new System.Drawing.Size(191, 257);
            this.imgPetro.TabIndex = 0;
            this.imgPetro.TabStop = false;
            this.imgPetro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TMRflash
            // 
            this.TMRflash.Tick += new System.EventHandler(this.TMRflash_Tick);
            // 
            // Btncorre
            // 
            this.Btncorre.Location = new System.Drawing.Point(291, 328);
            this.Btncorre.Name = "Btncorre";
            this.Btncorre.Size = new System.Drawing.Size(156, 77);
            this.Btncorre.TabIndex = 1;
            this.Btncorre.Text = "Corre";
            this.Btncorre.UseVisualStyleBackColor = true;
            this.Btncorre.Click += new System.EventHandler(this.Btncorre_Click);
            // 
            // Backbolivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgPetro.Properties.Resources.Backcasanariño;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btncorre);
            this.Controls.Add(this.imgPetro);
            this.Name = "Backbolivar";
            this.Text = "Casanariño";
            this.Load += new System.EventHandler(this.Backbolivar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPetro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPetro;
        private System.Windows.Forms.Timer TMRflash;
        private System.Windows.Forms.Button Btncorre;
    }
}

