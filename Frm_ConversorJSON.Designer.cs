namespace ConversorXML_JSON
{
    partial class Frm_Conversor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Conteudo = new System.Windows.Forms.TextBox();
            this.Btn_ConvertJson = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Resultado = new System.Windows.Forms.TextBox();
            this.Btn_Copiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Conteudo
            // 
            this.Txt_Conteudo.Location = new System.Drawing.Point(12, 48);
            this.Txt_Conteudo.Multiline = true;
            this.Txt_Conteudo.Name = "Txt_Conteudo";
            this.Txt_Conteudo.Size = new System.Drawing.Size(453, 139);
            this.Txt_Conteudo.TabIndex = 0;
            // 
            // Btn_ConvertJson
            // 
            this.Btn_ConvertJson.Location = new System.Drawing.Point(12, 415);
            this.Btn_ConvertJson.Name = "Btn_ConvertJson";
            this.Btn_ConvertJson.Size = new System.Drawing.Size(130, 23);
            this.Btn_ConvertJson.TabIndex = 1;
            this.Btn_ConvertJson.Text = "JSON to XML";
            this.Btn_ConvertJson.UseVisualStyleBackColor = true;
            this.Btn_ConvertJson.Click += new System.EventHandler(this.Btn_ConvertJson_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(335, 415);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(130, 23);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Resultado
            // 
            this.Txt_Resultado.Location = new System.Drawing.Point(12, 220);
            this.Txt_Resultado.Multiline = true;
            this.Txt_Resultado.Name = "Txt_Resultado";
            this.Txt_Resultado.Size = new System.Drawing.Size(453, 139);
            this.Txt_Resultado.TabIndex = 3;
            // 
            // Btn_Copiar
            // 
            this.Btn_Copiar.Location = new System.Drawing.Point(175, 415);
            this.Btn_Copiar.Name = "Btn_Copiar";
            this.Btn_Copiar.Size = new System.Drawing.Size(130, 23);
            this.Btn_Copiar.TabIndex = 4;
            this.Btn_Copiar.Text = "Copiar";
            this.Btn_Copiar.UseVisualStyleBackColor = true;
            this.Btn_Copiar.Click += new System.EventHandler(this.Btn_Copiar_Click);
            // 
            // Frm_Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.Btn_Copiar);
            this.Controls.Add(this.Txt_Resultado);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_ConvertJson);
            this.Controls.Add(this.Txt_Conteudo);
            this.Name = "Frm_Conversor";
            this.Text = "Conversor JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Conteudo;
        private System.Windows.Forms.Button Btn_ConvertJson;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Resultado;
        private System.Windows.Forms.Button Btn_Copiar;
    }
}

