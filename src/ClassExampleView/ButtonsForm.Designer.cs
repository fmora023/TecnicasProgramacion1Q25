namespace ClassExample
{
    partial class ButtonsForm
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
            btn_Next = new Button();
            btn_Generate = new Button();
            SuspendLayout();
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(888, 571);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(206, 82);
            btn_Next.TabIndex = 0;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Generate
            // 
            btn_Generate.Location = new Point(662, 571);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(167, 82);
            btn_Generate.TabIndex = 1;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // ButtonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 687);
            Controls.Add(btn_Generate);
            Controls.Add(btn_Next);
            Name = "ButtonsForm";
            Text = "ButtonsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Next;
        private Button btn_Generate;
    }
}