namespace ClassExample
{
    partial class Form1
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
            btn_sumar = new Button();
            btn_restar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbx_input1 = new TextBox();
            tbx_Input2 = new TextBox();
            tbx_Result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btn_sumar
            // 
            btn_sumar.Location = new Point(676, 422);
            btn_sumar.Margin = new Padding(3, 4, 3, 4);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(184, 88);
            btn_sumar.TabIndex = 0;
            btn_sumar.Text = "sumar";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += Btn_sumar_Click;
            // 
            // btn_restar
            // 
            btn_restar.Location = new Point(414, 422);
            btn_restar.Margin = new Padding(3, 4, 3, 4);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(217, 88);
            btn_restar.TabIndex = 1;
            btn_restar.Text = "restar";
            btn_restar.UseVisualStyleBackColor = true;
            btn_restar.Click += btn_restar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 126);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 202);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 290);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // tbx_input1
            // 
            tbx_input1.Location = new Point(543, 126);
            tbx_input1.Margin = new Padding(3, 4, 3, 4);
            tbx_input1.Name = "tbx_input1";
            tbx_input1.Size = new Size(211, 27);
            tbx_input1.TabIndex = 5;
            tbx_input1.TextAlign = HorizontalAlignment.Right;
            // 
            // tbx_Input2
            // 
            tbx_Input2.Location = new Point(543, 202);
            tbx_Input2.Margin = new Padding(3, 4, 3, 4);
            tbx_Input2.Name = "tbx_Input2";
            tbx_Input2.Size = new Size(211, 27);
            tbx_Input2.TabIndex = 6;
            tbx_Input2.TextAlign = HorizontalAlignment.Right;
            // 
            // tbx_Result
            // 
            tbx_Result.Enabled = false;
            tbx_Result.Location = new Point(543, 285);
            tbx_Result.Margin = new Padding(3, 4, 3, 4);
            tbx_Result.Name = "tbx_Result";
            tbx_Result.Size = new Size(211, 27);
            tbx_Result.TabIndex = 7;
            tbx_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(197, 422);
            button1.Name = "button1";
            button1.Size = new Size(169, 88);
            button1.TabIndex = 8;
            button1.Text = "Div";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(911, 425);
            button2.Name = "button2";
            button2.Size = new Size(157, 85);
            button2.TabIndex = 9;
            button2.Text = "Mult";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 676);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbx_Result);
            Controls.Add(tbx_Input2);
            Controls.Add(tbx_input1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_restar);
            Controls.Add(btn_sumar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_input1;
        private System.Windows.Forms.TextBox tbx_Input2;
        private System.Windows.Forms.TextBox tbx_Result;
        private Button button1;
        private Button button2;
    }
}

