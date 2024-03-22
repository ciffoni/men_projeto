namespace projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConectar = new Button();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            dataGridUsuario = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(78, 480);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(86, 31);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conexão";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(78, 376);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 31);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 80);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 121);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "e-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 153);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(149, 76);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 111);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(147, 149);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 8;
            // 
            // dataGridUsuario
            // 
            dataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuario.Location = new Point(333, 95);
            dataGridUsuario.Margin = new Padding(3, 4, 3, 4);
            dataGridUsuario.Name = "dataGridUsuario";
            dataGridUsuario.RowHeadersWidth = 51;
            dataGridUsuario.Size = new Size(274, 200);
            dataGridUsuario.TabIndex = 9;
            dataGridUsuario.CellContentClick += dataGridUsuario_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(199, 376);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Alterar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(317, 380);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(149, 209);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 211);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 13;
            label5.Text = "Perfil:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 600);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(dataGridUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnConectar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Cadastro do usuário";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private DataGridView dataGridUsuario;
        private Button btnEditar;
        private Button btnExcluir;
        private ComboBox comboBox1;
        private Label label5;
    }
}
