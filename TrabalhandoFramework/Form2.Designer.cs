
namespace TrabalhandoFramework
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir2 = new System.Windows.Forms.Button();
            this.btnEditar2 = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeStatus = new System.Windows.Forms.TextBox();
            this.labelNomeStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir2);
            this.groupBox1.Controls.Add(this.btnEditar2);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtNomeStatus);
            this.groupBox1.Controls.Add(this.labelNomeStatus);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // btnExcluir2
            // 
            this.btnExcluir2.Location = new System.Drawing.Point(603, 132);
            this.btnExcluir2.Name = "btnExcluir2";
            this.btnExcluir2.Size = new System.Drawing.Size(123, 37);
            this.btnExcluir2.TabIndex = 4;
            this.btnExcluir2.Text = "Excluir";
            this.btnExcluir2.UseVisualStyleBackColor = true;
            this.btnExcluir2.Click += new System.EventHandler(this.btnExcluir2_Click);
            // 
            // btnEditar2
            // 
            this.btnEditar2.Location = new System.Drawing.Point(316, 132);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(123, 37);
            this.btnEditar2.TabIndex = 3;
            this.btnEditar2.Text = "Editar";
            this.btnEditar2.UseVisualStyleBackColor = true;
            this.btnEditar2.Click += new System.EventHandler(this.btnEditar2_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(29, 132);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 37);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeStatus
            // 
            this.txtNomeStatus.Location = new System.Drawing.Point(187, 45);
            this.txtNomeStatus.Name = "txtNomeStatus";
            this.txtNomeStatus.Size = new System.Drawing.Size(424, 22);
            this.txtNomeStatus.TabIndex = 1;
            // 
            // labelNomeStatus
            // 
            this.labelNomeStatus.AutoSize = true;
            this.labelNomeStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeStatus.Location = new System.Drawing.Point(25, 45);
            this.labelNomeStatus.Name = "labelNomeStatus";
            this.labelNomeStatus.Size = new System.Drawing.Size(156, 22);
            this.labelNomeStatus.TabIndex = 0;
            this.labelNomeStatus.Text = "Nome do Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 219);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir2;
        private System.Windows.Forms.Button btnEditar2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeStatus;
        private System.Windows.Forms.Label labelNomeStatus;
    }
}