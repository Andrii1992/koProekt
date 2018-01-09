namespace HotelP
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dodaj = new System.Windows.Forms.Button();
            this.formF = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.dodaj.FlatAppearance.BorderSize = 2;
            this.dodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dodaj.Location = new System.Drawing.Point(34, 95);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.klik);
            // 
            // formF
            // 
            this.formF.Location = new System.Drawing.Point(20, 69);
            this.formF.Name = "formF";
            this.formF.Size = new System.Drawing.Size(100, 20);
            this.formF.TabIndex = 1;
            this.formF.TextChanged += new System.EventHandler(this.formF_TextChanged);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(20, 25);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(108, 13);
            this.Info.TabIndex = 2;
            this.Info.Text = "Format ( dd-mm-yyyy )";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Info);
            this.Controls.Add(this.formF);
            this.Controls.Add(this.dodaj);
            this.Name = "UserControl1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox formF;
        private System.Windows.Forms.Label Info;
    }
}
