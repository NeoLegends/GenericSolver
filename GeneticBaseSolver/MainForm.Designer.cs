namespace GeneticBaseSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.MaxLength = 2147483647;
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(627, 119);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.HideSelection = false;
            this.tbOutput.Location = new System.Drawing.Point(12, 137);
            this.tbOutput.MaxLength = 2147483647;
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(627, 115);
            this.tbOutput.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(13, 259);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(316, 21);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(380, 263);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(223, 13);
            this.lbError.TabIndex = 3;
            this.lbError.Text = "Input could not be parsed, is it a multiple of 3?";
            this.lbError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 290);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "DNA to AminoAcid-Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lbError;
    }
}

