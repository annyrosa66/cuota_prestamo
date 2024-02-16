namespace Cuota_Prestamo_9_2_24
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
            lbl_Monto = new Label();
            lbl_Tasa_Interes = new Label();
            lbl_Anos = new Label();
            lbl_Cuotas = new Label();
            btn_Calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            txt_Monto = new TextBox();
            txt_Tasa_Interes = new TextBox();
            txt_Cuotas = new TextBox();
            txt_Años = new TextBox();
            lbl_Total = new Label();
            txt_Total = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize = true;
            lbl_Monto.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Monto.Location = new Point(271, 155);
            lbl_Monto.Name = "lbl_Monto";
            lbl_Monto.Size = new Size(63, 22);
            lbl_Monto.TabIndex = 0;
            lbl_Monto.Text = "Monto";
            // 
            // lbl_Tasa_Interes
            // 
            lbl_Tasa_Interes.AutoSize = true;
            lbl_Tasa_Interes.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Tasa_Interes.Location = new Point(271, 211);
            lbl_Tasa_Interes.Name = "lbl_Tasa_Interes";
            lbl_Tasa_Interes.Size = new Size(113, 22);
            lbl_Tasa_Interes.TabIndex = 1;
            lbl_Tasa_Interes.Text = "Tasa_Interes";
            // 
            // lbl_Anos
            // 
            lbl_Anos.AutoSize = true;
            lbl_Anos.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Anos.Location = new Point(273, 293);
            lbl_Anos.Name = "lbl_Anos";
            lbl_Anos.Size = new Size(49, 22);
            lbl_Anos.TabIndex = 2;
            lbl_Anos.Text = "Años";
            // 
            // lbl_Cuotas
            // 
            lbl_Cuotas.AutoSize = true;
            lbl_Cuotas.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Cuotas.Location = new Point(271, 415);
            lbl_Cuotas.Name = "lbl_Cuotas";
            lbl_Cuotas.Size = new Size(67, 22);
            lbl_Cuotas.TabIndex = 3;
            lbl_Cuotas.Text = "Cuotas";
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = SystemColors.GradientActiveCaption;
            btn_Calcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(677, 188);
            btn_Calcular.Margin = new Padding(3, 4, 3, 4);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(94, 45);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.GradientActiveCaption;
            btn_Limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location = new Point(677, 272);
            btn_Limpiar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(94, 45);
            btn_Limpiar.TabIndex = 5;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.GradientActiveCaption;
            btn_Salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location = new Point(677, 355);
            btn_Salir.Margin = new Padding(3, 4, 3, 4);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(94, 45);
            btn_Salir.TabIndex = 6;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Monto
            // 
            txt_Monto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Monto.Location = new Point(440, 151);
            txt_Monto.Margin = new Padding(3, 4, 3, 4);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(114, 30);
            txt_Monto.TabIndex = 7;
            // 
            // txt_Tasa_Interes
            // 
            txt_Tasa_Interes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Tasa_Interes.Location = new Point(440, 223);
            txt_Tasa_Interes.Margin = new Padding(3, 4, 3, 4);
            txt_Tasa_Interes.Name = "txt_Tasa_Interes";
            txt_Tasa_Interes.Size = new Size(114, 30);
            txt_Tasa_Interes.TabIndex = 8;
            // 
            // txt_Cuotas
            // 
            txt_Cuotas.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Cuotas.Location = new Point(440, 415);
            txt_Cuotas.Margin = new Padding(3, 4, 3, 4);
            txt_Cuotas.Name = "txt_Cuotas";
            txt_Cuotas.Size = new Size(114, 30);
            txt_Cuotas.TabIndex = 9;
            // 
            // txt_Años
            // 
            txt_Años.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Años.Location = new Point(440, 283);
            txt_Años.Margin = new Padding(3, 4, 3, 4);
            txt_Años.Name = "txt_Años";
            txt_Años.Size = new Size(114, 30);
            txt_Años.TabIndex = 10;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_Total.Location = new Point(275, 353);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(51, 22);
            lbl_Total.TabIndex = 11;
            lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            txt_Total.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Total.Location = new Point(440, 353);
            txt_Total.Margin = new Padding(3, 4, 3, 4);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(114, 30);
            txt_Total.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 12);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 13;
            label1.Text = "Cuota_Prestamo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txt_Total);
            Controls.Add(lbl_Total);
            Controls.Add(txt_Años);
            Controls.Add(txt_Cuotas);
            Controls.Add(txt_Tasa_Interes);
            Controls.Add(txt_Monto);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Cuotas);
            Controls.Add(lbl_Anos);
            Controls.Add(lbl_Tasa_Interes);
            Controls.Add(lbl_Monto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Monto;
        private Label lbl_Tasa_Interes;
        private Label lbl_Anos;
        private Label lbl_Cuotas;
        private Button btn_Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private TextBox txt_Monto;
        private TextBox txt_Tasa_Interes;
        private TextBox txt_Cuotas;
        private TextBox txt_Años;
        private Label lbl_Total;
        private TextBox txt_Total;
        private Label label1;
    }
}