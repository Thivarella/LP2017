using System.Windows.Forms;

namespace ProjetoLp2
{
    partial class CadProduto
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
            if (disposing && (components != null)) {
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
            this.textNomeProd = new System.Windows.Forms.TextBox();
            this.textPrecoProd = new System.Windows.Forms.TextBox();
            this.textQtdeProd = new System.Windows.Forms.TextBox();
            this.textCodProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNomeProd
            // 
            this.textNomeProd.Location = new System.Drawing.Point(82, 26);
            this.textNomeProd.Name = "textNomeProd";
            this.textNomeProd.Size = new System.Drawing.Size(556, 22);
            this.textNomeProd.TabIndex = 0;
            // 
            // textPrecoProd
            // 
            this.textPrecoProd.Location = new System.Drawing.Point(82, 64);
            this.textPrecoProd.Name = "textPrecoProd";
            this.textPrecoProd.Size = new System.Drawing.Size(100, 22);
            this.textPrecoProd.TabIndex = 1;
            // 
            // textQtdeProd
            // 
            this.textQtdeProd.Location = new System.Drawing.Point(313, 64);
            this.textQtdeProd.Name = "textQtdeProd";
            this.textQtdeProd.Size = new System.Drawing.Size(98, 22);
            this.textQtdeProd.TabIndex = 2;
            // 
            // textCodProd
            // 
            this.textCodProd.Enabled = false;
            this.textCodProd.Location = new System.Drawing.Point(522, 63);
            this.textCodProd.Name = "textCodProd";
            this.textCodProd.Size = new System.Drawing.Size(116, 22);
            this.textCodProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(421, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(697, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodProd);
            this.Controls.Add(this.textQtdeProd);
            this.Controls.Add(this.textPrecoProd);
            this.Controls.Add(this.textNomeProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNomeProd;
        private System.Windows.Forms.TextBox textPrecoProd;
        private System.Windows.Forms.TextBox textQtdeProd;
        private System.Windows.Forms.TextBox textCodProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        public TextBox TextNomeProd { get => textNomeProd; set => textNomeProd = value; }
        public TextBox TextPrecoProd { get => textPrecoProd; set => textPrecoProd = value; }
        public TextBox TextQtdeProd { get => textQtdeProd; set => textQtdeProd = value; }
        public TextBox TextCodProd { get => textCodProd; set => textCodProd = value; }
    }
}