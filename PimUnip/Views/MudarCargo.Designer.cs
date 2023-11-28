namespace PimUnip.Views
{
    partial class MudarCargo
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
            inputIdFunc = new TextBox();
            inputNewCargo = new TextBox();
            inputAumento = new TextBox();
            sendNewAument = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 55);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 0;
            label1.Text = "Adicione o nome cargo do funcionario";
            // 
            // inputIdFunc
            // 
            inputIdFunc.ForeColor = SystemColors.InfoText;
            inputIdFunc.Location = new Point(259, 119);
            inputIdFunc.Name = "inputIdFunc";
            inputIdFunc.Size = new Size(258, 23);
            inputIdFunc.TabIndex = 1;
            inputIdFunc.Text = "Id do Funcionario";
            inputIdFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNewCargo
            // 
            inputNewCargo.ForeColor = SystemColors.InfoText;
            inputNewCargo.Location = new Point(259, 148);
            inputNewCargo.Name = "inputNewCargo";
            inputNewCargo.Size = new Size(258, 23);
            inputNewCargo.TabIndex = 2;
            inputNewCargo.Text = "Novo Cargo";
            inputNewCargo.TextAlign = HorizontalAlignment.Center;
            // 
            // inputAumento
            // 
            inputAumento.ForeColor = SystemColors.InfoText;
            inputAumento.Location = new Point(259, 177);
            inputAumento.Name = "inputAumento";
            inputAumento.Size = new Size(258, 23);
            inputAumento.TabIndex = 3;
            inputAumento.Text = "Novo Salarial";
            inputAumento.TextAlign = HorizontalAlignment.Center;
            // 
            // sendNewAument
            // 
            sendNewAument.Location = new Point(259, 229);
            sendNewAument.Name = "sendNewAument";
            sendNewAument.Size = new Size(258, 41);
            sendNewAument.TabIndex = 4;
            sendNewAument.Text = "Enviar";
            sendNewAument.UseVisualStyleBackColor = true;
            sendNewAument.Click += sendNewAument_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 5;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // MudarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(sendNewAument);
            Controls.Add(inputAumento);
            Controls.Add(inputNewCargo);
            Controls.Add(inputIdFunc);
            Controls.Add(label1);
            Name = "MudarCargo";
            Text = "NovoCargo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputIdFunc;
        private TextBox inputNewCargo;
        private TextBox inputAumento;
        private Button sendNewAument;
        private Button backButton;
    }
}