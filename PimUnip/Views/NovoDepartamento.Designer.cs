namespace PimUnip.Views
{
    partial class NovoDepartamento
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
            label1 = new Label();
            sendNewDep = new Button();
            inputNovoDepartamento = new TextBox();
            inputSalarioDep = new TextBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Departamento";
            // 
            // sendNewDep
            // 
            sendNewDep.Location = new Point(287, 211);
            sendNewDep.Name = "sendNewDep";
            sendNewDep.Size = new Size(201, 31);
            sendNewDep.TabIndex = 1;
            sendNewDep.Text = "Enviar";
            sendNewDep.UseVisualStyleBackColor = true;
            sendNewDep.Click += sendNewDep_Click;
            // 
            // inputNovoDepartamento
            // 
            inputNovoDepartamento.ForeColor = SystemColors.InfoText;
            inputNovoDepartamento.Location = new Point(287, 119);
            inputNovoDepartamento.Name = "inputNovoDepartamento";
            inputNovoDepartamento.Size = new Size(201, 23);
            inputNovoDepartamento.TabIndex = 2;
            inputNovoDepartamento.Text = "Nome do Departamento";
            inputNovoDepartamento.TextAlign = HorizontalAlignment.Center;
            // 
            // inputSalarioDep
            // 
            inputSalarioDep.ForeColor = SystemColors.InfoText;
            inputSalarioDep.Location = new Point(287, 160);
            inputSalarioDep.Name = "inputSalarioDep";
            inputSalarioDep.Size = new Size(201, 23);
            inputSalarioDep.TabIndex = 3;
            inputSalarioDep.Text = "Salario Base do Departamento";
            inputSalarioDep.TextAlign = HorizontalAlignment.Center;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 4;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // NovoDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(inputSalarioDep);
            Controls.Add(inputNovoDepartamento);
            Controls.Add(sendNewDep);
            Controls.Add(label1);
            Name = "NovoDepartamento";
            Text = "NovoDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button sendNewDep;
        private TextBox inputNovoDepartamento;
        private TextBox inputSalarioDep;
        private Button backButton;
    }
}