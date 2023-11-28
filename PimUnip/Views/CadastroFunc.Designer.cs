namespace PimUnip
{
    partial class CadastroFunc
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
            inputNomeFunc = new TextBox();
            inputCpfFunc = new TextBox();
            inputIdadeFunc = new TextBox();
            inputEndFunc = new TextBox();
            inputTelFunc = new TextBox();
            inputCargoFunc = new TextBox();
            sendNewFunc = new Button();
            backButton = new Button();
            inputSalario = new TextBox();
            IdDep = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 53);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionarios";
            // 
            // inputNomeFunc
            // 
            inputNomeFunc.ForeColor = SystemColors.ScrollBar;
            inputNomeFunc.Location = new Point(275, 87);
            inputNomeFunc.Name = "inputNomeFunc";
            inputNomeFunc.Size = new Size(243, 23);
            inputNomeFunc.TabIndex = 1;
            inputNomeFunc.Text = "Nome do Funcionario";
            inputNomeFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputCpfFunc
            // 
            inputCpfFunc.ForeColor = SystemColors.ScrollBar;
            inputCpfFunc.Location = new Point(275, 116);
            inputCpfFunc.Name = "inputCpfFunc";
            inputCpfFunc.Size = new Size(243, 23);
            inputCpfFunc.TabIndex = 2;
            inputCpfFunc.Text = "CPF do Funcionario";
            inputCpfFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputIdadeFunc
            // 
            inputIdadeFunc.ForeColor = SystemColors.ScrollBar;
            inputIdadeFunc.Location = new Point(275, 145);
            inputIdadeFunc.Name = "inputIdadeFunc";
            inputIdadeFunc.Size = new Size(243, 23);
            inputIdadeFunc.TabIndex = 3;
            inputIdadeFunc.Text = "Idade do Funcionario";
            inputIdadeFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputEndFunc
            // 
            inputEndFunc.ForeColor = SystemColors.ScrollBar;
            inputEndFunc.Location = new Point(275, 174);
            inputEndFunc.Multiline = true;
            inputEndFunc.Name = "inputEndFunc";
            inputEndFunc.Size = new Size(243, 54);
            inputEndFunc.TabIndex = 4;
            inputEndFunc.Text = "Endereço do Funcionario";
            inputEndFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputTelFunc
            // 
            inputTelFunc.ForeColor = SystemColors.ScrollBar;
            inputTelFunc.Location = new Point(275, 234);
            inputTelFunc.Name = "inputTelFunc";
            inputTelFunc.Size = new Size(243, 23);
            inputTelFunc.TabIndex = 5;
            inputTelFunc.Text = "Telefone do Funcionario";
            inputTelFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // inputCargoFunc
            // 
            inputCargoFunc.ForeColor = SystemColors.ScrollBar;
            inputCargoFunc.Location = new Point(275, 263);
            inputCargoFunc.Name = "inputCargoFunc";
            inputCargoFunc.Size = new Size(243, 23);
            inputCargoFunc.TabIndex = 6;
            inputCargoFunc.Text = "Cargo do Funcionario";
            inputCargoFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // sendNewFunc
            // 
            sendNewFunc.Location = new Point(275, 354);
            sendNewFunc.Name = "sendNewFunc";
            sendNewFunc.Size = new Size(243, 46);
            sendNewFunc.TabIndex = 7;
            sendNewFunc.Text = "Enviar";
            sendNewFunc.UseVisualStyleBackColor = true;
            sendNewFunc.Click += sendNewFunc_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 8;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // inputSalario
            // 
            inputSalario.ForeColor = SystemColors.ScrollBar;
            inputSalario.Location = new Point(275, 292);
            inputSalario.Name = "inputSalario";
            inputSalario.Size = new Size(243, 23);
            inputSalario.TabIndex = 9;
            inputSalario.Text = "Salario do Funcionario";
            inputSalario.TextAlign = HorizontalAlignment.Center;
            // 
            // IdDep
            // 
            IdDep.ForeColor = SystemColors.ScrollBar;
            IdDep.Location = new Point(275, 321);
            IdDep.Name = "IdDep";
            IdDep.Size = new Size(243, 23);
            IdDep.TabIndex = 10;
            IdDep.Text = "Id do Departamento";
            IdDep.TextAlign = HorizontalAlignment.Center;
            // 
            // CadastroFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IdDep);
            Controls.Add(inputSalario);
            Controls.Add(backButton);
            Controls.Add(sendNewFunc);
            Controls.Add(inputCargoFunc);
            Controls.Add(inputTelFunc);
            Controls.Add(inputEndFunc);
            Controls.Add(inputIdadeFunc);
            Controls.Add(inputCpfFunc);
            Controls.Add(inputNomeFunc);
            Controls.Add(label1);
            Name = "CadastroFunc";
            Text = "CadastroFunc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputNomeFunc;
        private TextBox inputCpfFunc;
        private TextBox inputIdadeFunc;
        private TextBox inputEndFunc;
        private TextBox inputTelFunc;
        private TextBox inputCargoFunc;
        private Button sendNewFunc;
        private Button backButton;
        private TextBox inputSalario;
        private TextBox IdDep;
    }
}