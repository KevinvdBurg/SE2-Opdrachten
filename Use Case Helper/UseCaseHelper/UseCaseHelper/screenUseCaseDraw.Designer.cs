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
            this.rbtnPointer = new System.Windows.Forms.RadioButton();
            this.rbtnText = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnEclipse = new System.Windows.Forms.RadioButton();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.dyX = new System.Windows.Forms.Label();
            this.dyY = new System.Windows.Forms.Label();
            this.btnNewUseCase = new System.Windows.Forms.Button();
            this.gbSelectDrawingGroup.SuspendLayout();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectDrawingGroup
            // 
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnPointer);
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnText);
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnLine);
            this.gbSelectDrawingGroup.Controls.Add(this.rbtnEclipse);
            this.gbSelectDrawingGroup.Location = new System.Drawing.Point(12, 6);
            this.gbSelectDrawingGroup.Name = "gbSelectDrawingGroup";
            this.gbSelectDrawingGroup.Size = new System.Drawing.Size(279, 55);
            this.gbSelectDrawingGroup.TabIndex = 0;
            this.gbSelectDrawingGroup.TabStop = false;
            this.gbSelectDrawingGroup.Text = "Select drawing group";
            // 
            // rbtnPointer
            // 
            this.rbtnPointer.AutoSize = true;
            this.rbtnPointer.Location = new System.Drawing.Point(6, 19);
            this.rbtnPointer.Name = "rbtnPointer";
            this.rbtnPointer.Size = new System.Drawing.Size(58, 17);
            this.rbtnPointer.TabIndex = 3;
            this.rbtnPointer.TabStop = true;
            this.rbtnPointer.Text = "Pointer";
            this.rbtnPointer.UseVisualStyleBackColor = true;
            this.rbtnPointer.CheckedChanged += new System.EventHandler(this.btnPointer_CheckedChanged);
            // 
            // rbtnText
            // 
            this.rbtnText.AutoSize = true;
            this.rbtnText.Location = new System.Drawing.Point(210, 19);
            this.rbtnText.Name = "rbtnText";
            this.rbtnText.Size = new System.Drawing.Size(46, 17);
            this.rbtnText.TabIndex = 2;
            this.rbtnText.TabStop = true;
            this.rbtnText.Text = "Text";
            this.rbtnText.UseVisualStyleBackColor = true;
            this.rbtnText.CheckedChanged += new System.EventHandler(this.rbtnText_CheckedChanged);
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(145, 19);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(45, 17);
            this.rbtnLine.TabIndex = 1;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Line";
            this.rbtnLine.UseVisualStyleBackColor = true;
            this.rbtnLine.CheckedChanged += new System.EventHandler(this.rbtnLine_CheckedChanged);
            // 
            // rbtnEclipse
            // 
            this.rbtnEclipse.AutoSize = true;
            this.rbtnEclipse.Location = new System.Drawing.Point(80, 19);
            this.rbtnEclipse.Name = "rbtnEclipse";
            this.rbtnEclipse.Size = new System.Drawing.Size(59, 17);
            this.rbtnEclipse.TabIndex = 0;
            this.rbtnEclipse.TabStop = true;
            this.rbtnEclipse.Text = "Eclipse";
            this.rbtnEclipse.UseVisualStyleBackColor = true;
            this.rbtnEclipse.CheckedChanged += new System.EventHandler(this.rbtnEclipse_CheckedChanged);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(297, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(297, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.UseWaitCursor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlDraw
            //
            this.pnlDraw.Location = new System.Drawing.Point(12, 67);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(860, 582);
            this.pnlDraw.TabIndex = 3;
            this.pnlDraw.Click += new System.EventHandler(this.pnlUseCase_Click);
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUseCase_Paint);
            this.pnlDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUseCase_MouseClick);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUseCase_MouseMove);
            // 
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(826, 21);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(14, 13);
            this.lbX.TabIndex = 4;
            this.lbX.Text = "X";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(826, 38);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(14, 13);
            this.lbY.TabIndex = 5;
            this.lbY.Text = "Y";
            // 
            // dyX
            // 
            this.dyX.AutoSize = true;
            this.dyX.Location = new System.Drawing.Point(847, 21);
            this.dyX.Name = "dyX";
            this.dyX.Size = new System.Drawing.Size(25, 13);
            this.dyX.TabIndex = 6;
            this.dyX.Text = "dyX";
            // 
            // dyY
            // 
            this.dyY.AutoSize = true;
            this.dyY.Location = new System.Drawing.Point(847, 38);
            this.dyY.Name = "dyY";
            this.dyY.Size = new System.Drawing.Size(25, 13);
            this.dyY.TabIndex = 7;
            this.dyY.Text = "dyY";
            // 
            // btnNewUseCase
            // 
            this.btnNewUseCase.Location = new System.Drawing.Point(689, 25);
            this.btnNewUseCase.Name = "btnNewUseCase";
            this.btnNewUseCase.Size = new System.Drawing.Size(114, 23);
            this.btnNewUseCase.TabIndex = 8;
            this.btnNewUseCase.Text = "New UseCase";
            this.btnNewUseCase.UseVisualStyleBackColor = true;
            this.btnNewUseCase.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScreenUseCaseDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnNewUseCase);
            this.Controls.Add(this.dyY);
            this.Controls.Add(this.dyX);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.gbSelectDrawingGroup);
            this.Controls.Add(this.pnlDraw);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "ScreenUseCaseDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Use Case Helper";
            this.gbSelectDrawingGroup.ResumeLayout(false);
            this.gbSelectDrawingGroup.PerformLayout();
            this.pnlDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectDrawingGroup;
        private System.Windows.Forms.RadioButton rbtnText;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnEclipse;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label dyX;
        private System.Windows.Forms.Label dyY;
        private System.Windows.Forms.RadioButton rbtnPointer;
        private System.Windows.Forms.Button btnNewUseCase;
    }
}

