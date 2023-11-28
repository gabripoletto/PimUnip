namespace PimUnip
{
    partial class DemitirFunc
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
            input_id_func_delete = new TextBox();
            delete_func = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 53);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o id do funcionario demitido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_id_func_delete
            // 
            input_id_func_delete.ForeColor = SystemColors.InfoText;
            input_id_func_delete.Location = new Point(304, 95);
            input_id_func_delete.Name = "input_id_func_delete";
            input_id_func_delete.Size = new Size(193, 23);
            input_id_func_delete.TabIndex = 1;
            input_id_func_delete.Text = "Id do funcionario";
            input_id_func_delete.TextAlign = HorizontalAlignment.Center;
            // 
            // delete_func
            // 
            delete_func.Location = new Point(328, 141);
            delete_func.Name = "delete_func";
            delete_func.Size = new Size(139, 37);
            delete_func.TabIndex = 2;
            delete_func.Text = "Excluir funcionario";
            delete_func.UseVisualStyleBackColor = true;
            delete_func.Click += delete_func_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 3;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // DemitirFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(delete_func);
            Controls.Add(input_id_func_delete);
            Controls.Add(label1);
            Name = "DemitirFunc";
            Text = "DemitirFunc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_id_func_delete;
        private Button delete_func;
        private Button backButton;
    }
}