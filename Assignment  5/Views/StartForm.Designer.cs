namespace Assignment__5.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.Exitlbutton = new System.Windows.Forms.Button();
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.PictureGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitlbutton
            // 
            this.Exitlbutton.Location = new System.Drawing.Point(268, 484);
            this.Exitlbutton.Name = "Exitlbutton";
            this.Exitlbutton.Size = new System.Drawing.Size(251, 37);
            this.Exitlbutton.TabIndex = 2;
            this.Exitlbutton.Text = "Exit";
            this.Exitlbutton.UseVisualStyleBackColor = true;
            this.Exitlbutton.Click += new System.EventHandler(this.Exitlbutton_Click);
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Location = new System.Drawing.Point(268, 336);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(251, 37);
            this.StartOrderButton.TabIndex = 3;
            this.StartOrderButton.Text = "Start a New Order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(268, 410);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(251, 37);
            this.OpenSavedOrderButton.TabIndex = 4;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // PictureGroupBox
            // 
            this.PictureGroupBox.BackgroundImage = global::Assignment__5.Properties.Resources.PictureGroupBox;
            this.PictureGroupBox.Location = new System.Drawing.Point(243, 95);
            this.PictureGroupBox.Name = "PictureGroupBox";
            this.PictureGroupBox.Size = new System.Drawing.Size(300, 200);
            this.PictureGroupBox.TabIndex = 5;
            this.PictureGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Your Computer Today!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureGroupBox);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.StartOrderButton);
            this.Controls.Add(this.Exitlbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitlbutton;
        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.GroupBox PictureGroupBox;
        private System.Windows.Forms.Label label1;
    }
}

