namespace DexNumConverter
{
    partial class Converter
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
            this.spriteFolderPath = new System.Windows.Forms.TextBox();
            this.outputFolderPath = new System.Windows.Forms.TextBox();
            this.activateButton = new System.Windows.Forms.Button();
            this.setSprite = new System.Windows.Forms.Button();
            this.setOutput = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // spriteFolderPath
            // 
            this.spriteFolderPath.AccessibleName = "";
            this.spriteFolderPath.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.spriteFolderPath.Location = new System.Drawing.Point(64, 7);
            this.spriteFolderPath.Name = "spriteFolderPath";
            this.spriteFolderPath.ReadOnly = true;
            this.spriteFolderPath.Size = new System.Drawing.Size(100, 23);
            this.spriteFolderPath.TabIndex = 0;
            this.spriteFolderPath.Text = "Input";
            // 
            // outputFolderPath
            // 
            this.outputFolderPath.AccessibleName = "";
            this.outputFolderPath.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.outputFolderPath.Location = new System.Drawing.Point(64, 36);
            this.outputFolderPath.Name = "outputFolderPath";
            this.outputFolderPath.ReadOnly = true;
            this.outputFolderPath.Size = new System.Drawing.Size(100, 23);
            this.outputFolderPath.TabIndex = 0;
            this.outputFolderPath.Text = "Output";
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(64, 65);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(100, 23);
            this.activateButton.TabIndex = 1;
            this.activateButton.Text = "Convert";
            this.activateButton.UseVisualStyleBackColor = true;
            // 
            // setSprite
            // 
            this.setSprite.Location = new System.Drawing.Point(20, 6);
            this.setSprite.Name = "setSprite";
            this.setSprite.Size = new System.Drawing.Size(38, 23);
            this.setSprite.TabIndex = 2;
            this.setSprite.Text = "Set";
            this.setSprite.UseVisualStyleBackColor = true;
            // 
            // setOutput
            // 
            this.setOutput.Location = new System.Drawing.Point(20, 36);
            this.setOutput.Name = "setOutput";
            this.setOutput.Size = new System.Drawing.Size(38, 23);
            this.setOutput.TabIndex = 2;
            this.setOutput.Text = "Set";
            this.setOutput.UseVisualStyleBackColor = true;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 94);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(200, 23);
            this.pBar.TabIndex = 3;
            this.pBar.Visible = false;
            // 
            // Converter
            // 
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 145);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.setOutput);
            this.Controls.Add(this.setSprite);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.outputFolderPath);
            this.Controls.Add(this.spriteFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Converter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox spriteFolderPath;
        private System.Windows.Forms.TextBox outputFolderPath;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button setSprite;
        private System.Windows.Forms.Button setOutput;
        private System.Windows.Forms.ProgressBar pBar;
    }
}

