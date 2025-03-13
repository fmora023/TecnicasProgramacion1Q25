namespace ClassExample
{
    partial class FileHandlerForm
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
            btn_CreateRegisters = new Button();
            label2 = new Label();
            txt_FilePath = new TextBox();
            label3 = new Label();
            txt_RequiredPeople = new TextBox();
            btn_AddRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "File Handler Form";
            // 
            // btn_CreateRegisters
            // 
            btn_CreateRegisters.Location = new Point(41, 163);
            btn_CreateRegisters.Name = "btn_CreateRegisters";
            btn_CreateRegisters.Size = new Size(191, 29);
            btn_CreateRegisters.TabIndex = 1;
            btn_CreateRegisters.Text = "Create Registers";
            btn_CreateRegisters.UseVisualStyleBackColor = true;
            btn_CreateRegisters.Click += btn_CreateRegisters_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 71);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Path for file";
            // 
            // txt_FilePath
            // 
            txt_FilePath.Location = new Point(190, 71);
            txt_FilePath.Name = "txt_FilePath";
            txt_FilePath.Size = new Size(454, 27);
            txt_FilePath.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 111);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 4;
            label3.Text = "Required people:";
            // 
            // txt_RequiredPeople
            // 
            txt_RequiredPeople.Location = new Point(190, 111);
            txt_RequiredPeople.Name = "txt_RequiredPeople";
            txt_RequiredPeople.Size = new Size(125, 27);
            txt_RequiredPeople.TabIndex = 5;
            // 
            // btn_AddRegister
            // 
            btn_AddRegister.Location = new Point(262, 163);
            btn_AddRegister.Name = "btn_AddRegister";
            btn_AddRegister.Size = new Size(192, 29);
            btn_AddRegister.TabIndex = 6;
            btn_AddRegister.Text = "Add Register";
            btn_AddRegister.UseVisualStyleBackColor = true;
            btn_AddRegister.Click += btn_AddRegister_Click;
            // 
            // FileHandlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 445);
            Controls.Add(btn_AddRegister);
            Controls.Add(txt_RequiredPeople);
            Controls.Add(label3);
            Controls.Add(txt_FilePath);
            Controls.Add(label2);
            Controls.Add(btn_CreateRegisters);
            Controls.Add(label1);
            Name = "FileHandlerForm";
            Text = "FileHandlerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_CreateRegisters;
        private Label label2;
        private TextBox txt_FilePath;
        private Label label3;
        private TextBox txt_RequiredPeople;
        private Button btn_AddRegister;
    }
}