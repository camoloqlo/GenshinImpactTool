
namespace GenshinImpactTool
{
    partial class ScheduleCharacter
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.imgLibro = new System.Windows.Forms.PictureBox();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbName.Location = new System.Drawing.Point(42, 148);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // imgLibro
            // 
            this.imgLibro.Location = new System.Drawing.Point(3, 139);
            this.imgLibro.Name = "imgLibro";
            this.imgLibro.Size = new System.Drawing.Size(40, 40);
            this.imgLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLibro.TabIndex = 2;
            this.imgLibro.TabStop = false;
            // 
            // imgIcon
            // 
            this.imgIcon.Location = new System.Drawing.Point(3, 3);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(130, 130);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcon.TabIndex = 0;
            this.imgIcon.TabStop = false;
            // 
            // ScheduleCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgLibro);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.imgIcon);
            this.Name = "ScheduleCharacter";
            this.Size = new System.Drawing.Size(136, 184);
            ((System.ComponentModel.ISupportInitialize)(this.imgLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgIcon;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.PictureBox imgLibro;
    }
}
