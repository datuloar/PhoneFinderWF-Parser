
namespace Potapov.PhoneFinder.PhoneFinderWf
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.UserInputNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(122, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Репутация:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.HotPink;
            this.richTextBox1.Location = new System.Drawing.Point(22, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(649, 339);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.Color.HotPink;
            this.StartButton.Location = new System.Drawing.Point(27, 97);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(639, 30);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Find";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UserInputNumber
            // 
            // 
            // 
            // 
            this.UserInputNumber.CustomButton.Image = null;
            this.UserInputNumber.CustomButton.Location = new System.Drawing.Point(591, 1);
            this.UserInputNumber.CustomButton.Name = "";
            this.UserInputNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserInputNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserInputNumber.CustomButton.TabIndex = 1;
            this.UserInputNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserInputNumber.CustomButton.UseSelectable = true;
            this.UserInputNumber.CustomButton.Visible = false;
            this.UserInputNumber.Lines = new string[0];
            this.UserInputNumber.Location = new System.Drawing.Point(27, 68);
            this.UserInputNumber.MaxLength = 11;
            this.UserInputNumber.Name = "UserInputNumber";
            this.UserInputNumber.PasswordChar = '\0';
            this.UserInputNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserInputNumber.SelectedText = "";
            this.UserInputNumber.SelectionLength = 0;
            this.UserInputNumber.SelectionStart = 0;
            this.UserInputNumber.ShortcutsEnabled = true;
            this.UserInputNumber.Size = new System.Drawing.Size(639, 23);
            this.UserInputNumber.TabIndex = 12;
            this.UserInputNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UserInputNumber.UseSelectable = true;
            this.UserInputNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserInputNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(22, 498);
            this.metroProgressBar1.Maximum = 3;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(649, 10);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroProgressBar1.TabIndex = 13;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(689, 525);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.UserInputNumber);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "PhoneFinder";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button StartButton;
        private MetroFramework.Controls.MetroTextBox UserInputNumber;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}

