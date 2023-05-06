namespace CalculocomTeste
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
            nro1 = new TextBox();
            nro2 = new TextBox();
            lblResultado = new Label();
            btn_soma = new Button();
            btn_sub = new Button();
            btn_multi = new Button();
            btn_div = new Button();
            SuspendLayout();
            // 
            // nro1
            // 
            nro1.Location = new Point(40, 27);
            nro1.Name = "nro1";
            nro1.Size = new Size(100, 23);
            nro1.TabIndex = 0;
            // 
            // nro2
            // 
            nro2.Location = new Point(40, 78);
            nro2.Name = "nro2";
            nro2.Size = new Size(100, 23);
            nro2.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(40, 128);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "RESULTADO";
            // 
            // btn_soma
            // 
            btn_soma.Location = new Point(214, 31);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(75, 23);
            btn_soma.TabIndex = 3;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = true;
            btn_soma.Click += btn_soma_Click;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(214, 77);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(75, 23);
            btn_sub.TabIndex = 4;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btnSub_Click;
            // 
            // btn_multi
            // 
            btn_multi.Location = new Point(326, 31);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(75, 23);
            btn_multi.TabIndex = 5;
            btn_multi.Text = "*";
            btn_multi.UseVisualStyleBackColor = true;
            btn_multi.Click += btn_multi_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(326, 78);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(75, 23);
            btn_div.TabIndex = 6;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_div);
            Controls.Add(btn_multi);
            Controls.Add(btn_sub);
            Controls.Add(btn_soma);
            Controls.Add(lblResultado);
            Controls.Add(nro2);
            Controls.Add(nro1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nro1;
        private TextBox nro2;
        private Label lblResultado;
        private Button btn_soma;
        private Button btn_sub;
        private Button btn_multi;
        private Button btn_div;
    }
}