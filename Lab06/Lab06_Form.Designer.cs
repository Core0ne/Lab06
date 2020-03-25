namespace Lab06
{
    partial class Lab06_Form
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
            this.inputMessageLabel = new System.Windows.Forms.Label();
            this.initialMessageTextBox = new System.Windows.Forms.TextBox();
            this.encodeMessageButton = new System.Windows.Forms.Button();
            this.encodedMessageLabel = new System.Windows.Forms.Label();
            this.encodedMessageTextBox = new System.Windows.Forms.TextBox();
            this.generateErrorButton = new System.Windows.Forms.Button();
            this.messageWithErrorLabel = new System.Windows.Forms.Label();
            this.messageWithErrorTextBox = new System.Windows.Forms.TextBox();
            this.fixErrorButton = new System.Windows.Forms.Button();
            this.fixedMessageLabel = new System.Windows.Forms.Label();
            this.fixedMessageTextBox = new System.Windows.Forms.TextBox();
            this.errorIndexLabel = new System.Windows.Forms.Label();
            this.errorIndexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputMessageLabel
            // 
            this.inputMessageLabel.AutoSize = true;
            this.inputMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputMessageLabel.Location = new System.Drawing.Point(61, 83);
            this.inputMessageLabel.Name = "inputMessageLabel";
            this.inputMessageLabel.Size = new System.Drawing.Size(186, 20);
            this.inputMessageLabel.TabIndex = 0;
            this.inputMessageLabel.Text = "Введите сообщение:";
            // 
            // initialMessageTextBox
            // 
            this.initialMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.initialMessageTextBox.Location = new System.Drawing.Point(337, 77);
            this.initialMessageTextBox.Name = "initialMessageTextBox";
            this.initialMessageTextBox.Size = new System.Drawing.Size(314, 26);
            this.initialMessageTextBox.TabIndex = 1;
            this.initialMessageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialMessageTextBox_KeyPress);
            // 
            // encodeMessageButton
            // 
            this.encodeMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encodeMessageButton.Location = new System.Drawing.Point(250, 143);
            this.encodeMessageButton.Name = "encodeMessageButton";
            this.encodeMessageButton.Size = new System.Drawing.Size(248, 43);
            this.encodeMessageButton.TabIndex = 2;
            this.encodeMessageButton.Text = "Кодировать сообщение";
            this.encodeMessageButton.UseVisualStyleBackColor = true;
            this.encodeMessageButton.Click += new System.EventHandler(this.encodeMessageButton_Click);
            // 
            // encodedMessageLabel
            // 
            this.encodedMessageLabel.AutoSize = true;
            this.encodedMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodedMessageLabel.Location = new System.Drawing.Point(61, 224);
            this.encodedMessageLabel.Name = "encodedMessageLabel";
            this.encodedMessageLabel.Size = new System.Drawing.Size(255, 20);
            this.encodedMessageLabel.TabIndex = 3;
            this.encodedMessageLabel.Text = "Закодированное сообщение:";
            // 
            // encodedMessageTextBox
            // 
            this.encodedMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.encodedMessageTextBox.Location = new System.Drawing.Point(337, 218);
            this.encodedMessageTextBox.Name = "encodedMessageTextBox";
            this.encodedMessageTextBox.ReadOnly = true;
            this.encodedMessageTextBox.Size = new System.Drawing.Size(314, 26);
            this.encodedMessageTextBox.TabIndex = 4;
            this.encodedMessageTextBox.TabStop = false;
            // 
            // generateErrorButton
            // 
            this.generateErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generateErrorButton.Location = new System.Drawing.Point(250, 282);
            this.generateErrorButton.Name = "generateErrorButton";
            this.generateErrorButton.Size = new System.Drawing.Size(248, 43);
            this.generateErrorButton.TabIndex = 5;
            this.generateErrorButton.Text = "Сгенерировать ошибку";
            this.generateErrorButton.UseVisualStyleBackColor = true;
            this.generateErrorButton.Click += new System.EventHandler(this.generateErrorButton_Click);
            // 
            // messageWithErrorLabel
            // 
            this.messageWithErrorLabel.AutoSize = true;
            this.messageWithErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageWithErrorLabel.Location = new System.Drawing.Point(61, 367);
            this.messageWithErrorLabel.Name = "messageWithErrorLabel";
            this.messageWithErrorLabel.Size = new System.Drawing.Size(202, 20);
            this.messageWithErrorLabel.TabIndex = 6;
            this.messageWithErrorLabel.Text = "Сообщение с ошибкой:";
            // 
            // messageWithErrorTextBox
            // 
            this.messageWithErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageWithErrorTextBox.Location = new System.Drawing.Point(337, 361);
            this.messageWithErrorTextBox.Name = "messageWithErrorTextBox";
            this.messageWithErrorTextBox.ReadOnly = true;
            this.messageWithErrorTextBox.Size = new System.Drawing.Size(314, 26);
            this.messageWithErrorTextBox.TabIndex = 7;
            this.messageWithErrorTextBox.TabStop = false;
            // 
            // fixErrorButton
            // 
            this.fixErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fixErrorButton.Location = new System.Drawing.Point(250, 426);
            this.fixErrorButton.Name = "fixErrorButton";
            this.fixErrorButton.Size = new System.Drawing.Size(248, 43);
            this.fixErrorButton.TabIndex = 8;
            this.fixErrorButton.Text = "Исправить ошибку";
            this.fixErrorButton.UseVisualStyleBackColor = true;
            this.fixErrorButton.Click += new System.EventHandler(this.fixErrorButton_Click);
            // 
            // fixedMessageLabel
            // 
            this.fixedMessageLabel.AutoSize = true;
            this.fixedMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fixedMessageLabel.Location = new System.Drawing.Point(61, 515);
            this.fixedMessageLabel.Name = "fixedMessageLabel";
            this.fixedMessageLabel.Size = new System.Drawing.Size(232, 20);
            this.fixedMessageLabel.TabIndex = 9;
            this.fixedMessageLabel.Text = "Исправленное сообщение:";
            // 
            // fixedMessageTextBox
            // 
            this.fixedMessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fixedMessageTextBox.Location = new System.Drawing.Point(337, 509);
            this.fixedMessageTextBox.Name = "fixedMessageTextBox";
            this.fixedMessageTextBox.ReadOnly = true;
            this.fixedMessageTextBox.Size = new System.Drawing.Size(314, 26);
            this.fixedMessageTextBox.TabIndex = 10;
            this.fixedMessageTextBox.TabStop = false;
            // 
            // errorIndexLabel
            // 
            this.errorIndexLabel.AutoSize = true;
            this.errorIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorIndexLabel.Location = new System.Drawing.Point(61, 564);
            this.errorIndexLabel.Name = "errorIndexLabel";
            this.errorIndexLabel.Size = new System.Drawing.Size(292, 20);
            this.errorIndexLabel.TabIndex = 11;
            this.errorIndexLabel.Text = "Ошибка была допущена в бите №";
            // 
            // errorIndexTextBox
            // 
            this.errorIndexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorIndexTextBox.Location = new System.Drawing.Point(370, 558);
            this.errorIndexTextBox.Name = "errorIndexTextBox";
            this.errorIndexTextBox.ReadOnly = true;
            this.errorIndexTextBox.Size = new System.Drawing.Size(68, 26);
            this.errorIndexTextBox.TabIndex = 12;
            this.errorIndexTextBox.TabStop = false;
            // 
            // Lab06_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.errorIndexTextBox);
            this.Controls.Add(this.errorIndexLabel);
            this.Controls.Add(this.fixedMessageTextBox);
            this.Controls.Add(this.fixedMessageLabel);
            this.Controls.Add(this.fixErrorButton);
            this.Controls.Add(this.messageWithErrorTextBox);
            this.Controls.Add(this.messageWithErrorLabel);
            this.Controls.Add(this.generateErrorButton);
            this.Controls.Add(this.encodedMessageTextBox);
            this.Controls.Add(this.encodedMessageLabel);
            this.Controls.Add(this.encodeMessageButton);
            this.Controls.Add(this.initialMessageTextBox);
            this.Controls.Add(this.inputMessageLabel);
            this.Name = "Lab06_Form";
            this.Text = "Lab06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputMessageLabel;
        private System.Windows.Forms.TextBox initialMessageTextBox;
        private System.Windows.Forms.Button encodeMessageButton;
        private System.Windows.Forms.Label encodedMessageLabel;
        private System.Windows.Forms.TextBox encodedMessageTextBox;
        private System.Windows.Forms.Button generateErrorButton;
        private System.Windows.Forms.Label messageWithErrorLabel;
        private System.Windows.Forms.TextBox messageWithErrorTextBox;
        private System.Windows.Forms.Button fixErrorButton;
        private System.Windows.Forms.Label fixedMessageLabel;
        private System.Windows.Forms.TextBox fixedMessageTextBox;
        private System.Windows.Forms.Label errorIndexLabel;
        private System.Windows.Forms.TextBox errorIndexTextBox;
    }
}

