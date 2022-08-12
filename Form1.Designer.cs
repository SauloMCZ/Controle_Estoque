namespace Controle_Estoque
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnMovimento = new System.Windows.Forms.Button();
            this.btnMarcaProduto = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(36, 96);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(95, 23);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnMovimento
            // 
            this.btnMovimento.Location = new System.Drawing.Point(199, 96);
            this.btnMovimento.Name = "btnMovimento";
            this.btnMovimento.Size = new System.Drawing.Size(97, 23);
            this.btnMovimento.TabIndex = 1;
            this.btnMovimento.Text = "Movimento";
            this.btnMovimento.UseVisualStyleBackColor = true;
            this.btnMovimento.Click += new System.EventHandler(this.btnMovimento_Click);
            // 
            // btnMarcaProduto
            // 
            this.btnMarcaProduto.Location = new System.Drawing.Point(199, 39);
            this.btnMarcaProduto.Name = "btnMarcaProduto";
            this.btnMarcaProduto.Size = new System.Drawing.Size(97, 23);
            this.btnMarcaProduto.TabIndex = 2;
            this.btnMarcaProduto.Text = "Marca";
            this.btnMarcaProduto.UseVisualStyleBackColor = true;
            this.btnMarcaProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(36, 39);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(95, 23);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(130, 138);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.Text = "Exibir Lista";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Página de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verificar de Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Controle E/S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Página Marca Produto";
            // 
            // dgvListaProdutos
            // 
            this.dgvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProdutos.Location = new System.Drawing.Point(39, 167);
            this.dgvListaProdutos.Name = "dgvListaProdutos";
            this.dgvListaProdutos.Size = new System.Drawing.Size(273, 146);
            this.dgvListaProdutos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(341, 325);
            this.Controls.Add(this.dgvListaProdutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnMarcaProduto);
            this.Controls.Add(this.btnMovimento);
            this.Controls.Add(this.btnEstoque);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Tela Loja Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnMovimento;
        private System.Windows.Forms.Button btnMarcaProduto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaProdutos;
    }
}

