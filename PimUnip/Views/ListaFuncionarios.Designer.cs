namespace PimUnip.Views
{
    partial class ListaFuncionarios
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
            components = new System.ComponentModel.Container();
            backButton = new Button();
            dataGridView1 = new DataGridView();
            folhaPagamentoBindingSource = new BindingSource(components);
            idFolhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horasTrabalhadasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioBrutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salarioLiquidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)folhaPagamentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idFolhaDataGridViewTextBoxColumn, horasTrabalhadasDataGridViewTextBoxColumn, salarioBrutoDataGridViewTextBoxColumn, salarioLiquidoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = folhaPagamentoBindingSource;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 388);
            dataGridView1.TabIndex = 2;
            // 
            // folhaPagamentoBindingSource
            // 
            folhaPagamentoBindingSource.DataSource = typeof(Models.FolhaPagamentoModal);
            // 
            // idFolhaDataGridViewTextBoxColumn
            // 
            idFolhaDataGridViewTextBoxColumn.DataPropertyName = "IdFolha";
            idFolhaDataGridViewTextBoxColumn.HeaderText = "IdFolha";
            idFolhaDataGridViewTextBoxColumn.Name = "idFolhaDataGridViewTextBoxColumn";
            // 
            // horasTrabalhadasDataGridViewTextBoxColumn
            // 
            horasTrabalhadasDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabalhadas";
            horasTrabalhadasDataGridViewTextBoxColumn.HeaderText = "HorasTrabalhadas";
            horasTrabalhadasDataGridViewTextBoxColumn.Name = "horasTrabalhadasDataGridViewTextBoxColumn";
            // 
            // salarioBrutoDataGridViewTextBoxColumn
            // 
            salarioBrutoDataGridViewTextBoxColumn.DataPropertyName = "SalarioBruto";
            salarioBrutoDataGridViewTextBoxColumn.HeaderText = "SalarioBruto";
            salarioBrutoDataGridViewTextBoxColumn.Name = "salarioBrutoDataGridViewTextBoxColumn";
            // 
            // salarioLiquidoDataGridViewTextBoxColumn
            // 
            salarioLiquidoDataGridViewTextBoxColumn.DataPropertyName = "SalarioLiquido";
            salarioLiquidoDataGridViewTextBoxColumn.HeaderText = "SalarioLiquido";
            salarioLiquidoDataGridViewTextBoxColumn.Name = "salarioLiquidoDataGridViewTextBoxColumn";
            // 
            // ListaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(backButton);
            Name = "ListaFuncionarios";
            Text = "ListaFuncionarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)folhaPagamentoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button backButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idFolhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horasTrabalhadasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioBrutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salarioLiquidoDataGridViewTextBoxColumn;
        private BindingSource folhaPagamentoBindingSource;
    }
}