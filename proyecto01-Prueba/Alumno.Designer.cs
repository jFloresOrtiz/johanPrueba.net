namespace proyecto01_Prueba
{
    partial class Alumno
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Refrescar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(466, 364);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(192, 277);
            button2.Name = "button2";
            button2.Size = new Size(94, 75);
            button2.TabIndex = 2;
            button2.Text = "Guardar Cambios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 317);
            button3.Name = "button3";
            button3.Size = new Size(129, 29);
            button3.TabIndex = 3;
            button3.Text = "Editar Alumno";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(8, 367);
            button4.Name = "button4";
            button4.Size = new Size(129, 29);
            button4.TabIndex = 4;
            button4.Text = "Eliminar Alumno";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(67, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(67, 222);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(192, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(67, 106);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 27);
            txtId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 106);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 149);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 199);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 10;
            label3.Text = "DNI";
            // 
            // button5
            // 
            button5.Location = new Point(2, 277);
            button5.Name = "button5";
            button5.Size = new Size(135, 29);
            button5.TabIndex = 11;
            button5.Text = "Nuevo Alumno";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(192, 358);
            button6.Name = "button6";
            button6.Size = new Size(94, 75);
            button6.TabIndex = 12;
            button6.Text = "Cancelar Cambios";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Alumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Alumno";
            Text = "Form1";
            Load += Alumno_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
        private Button button6;
    }
}