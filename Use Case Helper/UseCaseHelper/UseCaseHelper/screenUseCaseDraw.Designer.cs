namespace UseCaseHelper
{
    partial class ScreenUseCaseDraw
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
            this.gbSelectDrawingGroup = new System.Windows.Forms.GroupBox();
            this.rbtnText = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnEclipse = new System.Windows.Forms.RadioButton();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlUseCase = new System.Windows.Forms.Panel();
            this.gbSelectDrawingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectDrawingGroup
            // 
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnText);
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnLine);
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnEclipse);
            this.gbSelectDrawingGroup.Location = new System.Drawing.Point(12, 6);
            this.gbSelectDrawingGroup.Name = "gbSelectDrawingGroup";
            this.gbSelectDrawingGroup.Size = new System.Drawing.Size(166, 55);
            this.gbSelectDrawingGroup.TabIndex = 0;
            this.gbSelectDrawingGroup.TabStop = false;
            this.gbSelectDrawingGroup.Text = "Select drawing group";
            // 
            // rbtnText
            // 
            this.rbtnText.AutoSize = true;
            this.rbtnText.Location = new System.Drawing.Point(112, 19);
            this.rbtnText.Name = "rbtnText";
            this.rbtnText.Size = new System.Drawing.Size(46, 17);
            this.rbtnText.TabIndex = 2;
            this.rbtnText.TabStop = true;
            this.rbtnText.Text = "Text";
            this.rbtnText.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(65, 19);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(45, 17);
            this.rbtnLine.TabIndex = 1;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Line";
            this.rbtnLine.UseVisualStyleBackColor = true;
            // 
            // rbtnEclipse
            // 
            this.rbtnEclipse.AutoSize = true;
            this.rbtnEclipse.Location = new System.Drawing.Point(0, 19);
            this.rbtnEclipse.Name = "rbtnEclipse";
            this.rbtnEclipse.Size = new System.Drawing.Size(59, 17);
            this.rbtnEclipse.TabIndex = 0;
            this.rbtnEclipse.TabStop = true;
            this.rbtnEclipse.Text = "Eclipse";
            this.rbtnEclipse.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(182, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.UseWaitCursor = true;
            // 
            // pnlUseCase
            // 
            this.pnlUseCase.Location = new System.Drawing.Point(12, 67);
            this.pnlUseCase.Name = "pnlUseCase";
            this.pnlUseCase.Size = new System.Drawing.Size(860, 582);
            this.pnlUseCase.TabIndex = 3;
            this.pnlUseCase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUseCase_MouseClick);
            // 
            // ScreenUseCaseDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.pnlUseCase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.gbSelectDrawingGroup);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "ScreenUseCaseDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Use Case Helper";
            this.gbSelectDrawingGroup.ResumeLayout(false);
            this.gbSelectDrawingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectDrawingGroup;
        private System.Windows.Forms.RadioButton rbtnText;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnEclipse;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlUseCase;
    }
}

