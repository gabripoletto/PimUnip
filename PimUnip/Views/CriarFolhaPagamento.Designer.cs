namespace PimUnip.Views
{
    partial class CriarFolhaPagamento
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
            criar = new Button();
            hrs_trab = new TextBox();
            sal_bruto = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // criar
            // 
            criar.Location = new Point(289, 219);
            criar.Name = "criar";
            criar.Size = new Size(148, 39);
            criar.TabIndex = 0;
            criar.Text = "Criar";
            criar.UseVisualStyleBackColor = true;
            criar.Click += criar_Click;
            // 
            // hrs_trab
            // 
            hrs_trab.ForeColor = SystemColors.InfoText;
            hrs_trab.Location = new Point(247, 131);
            hrs_trab.Name = "hrs_trab";
            hrs_trab.Size = new Size(241, 23);
            hrs_trab.TabIndex = 1;
            hrs_trab.Text = "Horas Trabalhadas";
            hrs_trab.TextAlign = HorizontalAlignment.Center;
            // 
            // sal_bruto
            // 
            sal_bruto.ForeColor = SystemColors.InfoText;
            sal_bruto.Location = new Point(247, 174);
            sal_bruto.Name = "sal_bruto";
            sal_bruto.Size = new Size(241, 23);
            sal_bruto.TabIndex = 2;
            sal_bruto.Text = "Salario Bruto";
            sal_bruto.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 91);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 3;
            label1.Text = "Gerar Folha de Pagamento";
            // 
            // CriarFolhaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(sal_bruto);
            Controls.Add(hrs_trab);
            Controls.Add(criar);
            Name = "CriarFolhaPagamento";
            Text = "CriarFolhaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criar;
        private TextBox hrs_trab;
        private TextBox sal_bruto;
        private Label label1;
    }
}