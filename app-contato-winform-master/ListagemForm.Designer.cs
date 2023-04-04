namespace AppContatoForm
{
    partial class dgvLista
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
            this.dvgLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btNovo = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgLista
            // 
            this.dvgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLista.Location = new System.Drawing.Point(12, 75);
            this.dvgLista.Name = "dvgLista";
            this.dvgLista.Size = new System.Drawing.Size(566, 325);
            this.dvgLista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contatos";
            // 
            // btNovo
            // 
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btNovo.Location = new System.Drawing.Point(449, 414);
            this.btNovo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(109, 39);
            this.btNovo.TabIndex = 13;
            this.btNovo.Text = "Novo";
            this.btNovo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dgvLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 474);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgLista);
            this.Name = "dgvLista";
            this.Text = "ListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgLista;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btNovo;
    }
}