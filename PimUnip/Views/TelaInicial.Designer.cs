namespace PimUnip
{
    partial class TelaInicial
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
            new_func = new Button();
            delete_func = new Button();
            new_depart = new Button();
            edit_cargo = new Button();
            list_func = new Button();
            pagamento = new Button();
            PagFolha = new Button();
            SuspendLayout();
            // 
            // new_func
            // 
            new_func.Location = new Point(280, 52);
            new_func.Name = "new_func";
            new_func.Size = new Size(207, 47);
            new_func.TabIndex = 0;
            new_func.Text = "Novo Funcionario";
            new_func.UseVisualStyleBackColor = true;
            new_func.Click += new_func_Click;
            // 
            // delete_func
            // 
            delete_func.Location = new Point(280, 105);
            delete_func.Name = "delete_func";
            delete_func.Size = new Size(207, 47);
            delete_func.TabIndex = 1;
            delete_func.Text = "Demitir Funcionario";
            delete_func.UseVisualStyleBackColor = true;
            delete_func.Click += delete_func_Click;
            // 
            // new_depart
            // 
            new_depart.Location = new Point(280, 158);
            new_depart.Name = "new_depart";
            new_depart.Size = new Size(207, 47);
            new_depart.TabIndex = 2;
            new_depart.Text = "Adicionar Departamento";
            new_depart.UseVisualStyleBackColor = true;
            new_depart.Click += new_depart_Click;
            // 
            // edit_cargo
            // 
            edit_cargo.Location = new Point(280, 211);
            edit_cargo.Name = "edit_cargo";
            edit_cargo.Size = new Size(207, 47);
            edit_cargo.TabIndex = 4;
            edit_cargo.Text = "Mudar Cargo";
            edit_cargo.UseVisualStyleBackColor = true;
            edit_cargo.Click += edit_cargo_Click;
            // 
            // list_func
            // 
            list_func.Location = new Point(280, 264);
            list_func.Name = "list_func";
            list_func.Size = new Size(207, 47);
            list_func.TabIndex = 5;
            list_func.Text = "Listar Funcionarios";
            list_func.UseVisualStyleBackColor = true;
            list_func.Click += list_func_Click;
            // 
            // pagamento
            // 
            pagamento.Location = new Point(280, 370);
            pagamento.Name = "pagamento";
            pagamento.Size = new Size(207, 47);
            pagamento.TabIndex = 6;
            pagamento.Text = "Listar Folhas de Pagamento";
            pagamento.UseVisualStyleBackColor = true;
            pagamento.Click += pagamento_Click;
            // 
            // PagFolha
            // 
            PagFolha.Location = new Point(280, 317);
            PagFolha.Name = "PagFolha";
            PagFolha.Size = new Size(207, 47);
            PagFolha.TabIndex = 7;
            PagFolha.Text = "Criar Folha De Pagamento";
            PagFolha.UseVisualStyleBackColor = true;
            PagFolha.Click += PagFolha_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(PagFolha);
            Controls.Add(pagamento);
            Controls.Add(list_func);
            Controls.Add(edit_cargo);
            Controls.Add(new_depart);
            Controls.Add(delete_func);
            Controls.Add(new_func);
            Name = "TelaInicial";
            Text = "TelaIncial";
            ResumeLayout(false);
        }

        #endregion

        private Button new_func;
        private Button delete_func;
        private Button new_depart;
        private Button edit_cargo;
        private Button list_func;
        private Button pagamento;
        private Button PagFolha;
    }
}