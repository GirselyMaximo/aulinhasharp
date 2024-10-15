namespace gigi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ButtonAdcionar = new Button();
            buttonCancelar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonAdcionar
            // 
            ButtonAdcionar.Location = new Point(93, 22);
            ButtonAdcionar.Name = "ButtonAdcionar";
            ButtonAdcionar.Size = new Size(112, 44);
            ButtonAdcionar.TabIndex = 0;
            ButtonAdcionar.Text = "Adicionar\r\n";
            ButtonAdcionar.UseVisualStyleBackColor = true;
            ButtonAdcionar.Click += ButtonAdcionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(671, 24);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(112, 43);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Remover";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(690, 316);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(865, 444);
            Controls.Add(dataGridView1);
            Controls.Add(buttonCancelar);
            Controls.Add(ButtonAdcionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAdcionar;
        private Button buttonCancelar;
        private DataGridView dataGridView1;
    }
}
