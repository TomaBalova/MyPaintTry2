namespace MyPaintTry2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLineType = new System.Windows.Forms.GroupBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.comboBoxFontType = new System.Windows.Forms.ComboBox();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonImage = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkBoxNoFill = new System.Windows.Forms.CheckBox();
            this.panelBGColor = new System.Windows.Forms.Panel();
            this.panelFGColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHatchBrushes = new System.Windows.Forms.ComboBox();
            this.labelLineThickness = new System.Windows.Forms.Label();
            this.numericUpDownLineThickness = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonPaintBrush = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLineType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThickness)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 527);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBoxLineType
            // 
            this.groupBoxLineType.Controls.Add(this.radioButtonPaintBrush);
            this.groupBoxLineType.Controls.Add(this.textBoxText);
            this.groupBoxLineType.Controls.Add(this.comboBoxFontType);
            this.groupBoxLineType.Controls.Add(this.numericUpDownFontSize);
            this.groupBoxLineType.Controls.Add(this.radioButtonText);
            this.groupBoxLineType.Controls.Add(this.radioButtonImage);
            this.groupBoxLineType.Controls.Add(this.radioButtonEllipse);
            this.groupBoxLineType.Controls.Add(this.radioButtonRectangle);
            this.groupBoxLineType.Controls.Add(this.radioButtonLine);
            this.groupBoxLineType.Location = new System.Drawing.Point(5, 3);
            this.groupBoxLineType.Name = "groupBoxLineType";
            this.groupBoxLineType.Size = new System.Drawing.Size(263, 210);
            this.groupBoxLineType.TabIndex = 1;
            this.groupBoxLineType.TabStop = false;
            this.groupBoxLineType.Text = "Вид линии";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(5, 154);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(245, 48);
            this.textBoxText.TabIndex = 8;
            // 
            // comboBoxFontType
            // 
            this.comboBoxFontType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontType.FormattingEnabled = true;
            this.comboBoxFontType.Location = new System.Drawing.Point(117, 130);
            this.comboBoxFontType.Name = "comboBoxFontType";
            this.comboBoxFontType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFontType.TabIndex = 7;
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(67, 130);
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownFontSize.TabIndex = 6;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(5, 130);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(55, 17);
            this.radioButtonText.TabIndex = 4;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Текст";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // radioButtonImage
            // 
            this.radioButtonImage.AutoSize = true;
            this.radioButtonImage.Location = new System.Drawing.Point(7, 86);
            this.radioButtonImage.Name = "radioButtonImage";
            this.radioButtonImage.Size = new System.Drawing.Size(95, 17);
            this.radioButtonImage.TabIndex = 3;
            this.radioButtonImage.TabStop = true;
            this.radioButtonImage.Text = "Изображение";
            this.radioButtonImage.UseVisualStyleBackColor = true;
            this.radioButtonImage.CheckedChanged += new System.EventHandler(this.radioButtonImage_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(117, 20);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Эллипс";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(7, 44);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(7, 20);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(57, 17);
            this.radioButtonLine.TabIndex = 0;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Линия";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.checkBoxNoFill);
            this.panel1.Controls.Add(this.panelBGColor);
            this.panel1.Controls.Add(this.panelFGColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxHatchBrushes);
            this.panel1.Controls.Add(this.labelLineThickness);
            this.panel1.Controls.Add(this.numericUpDownLineThickness);
            this.panel1.Controls.Add(this.groupBoxLineType);
            this.panel1.Location = new System.Drawing.Point(717, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 528);
            this.panel1.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(138, 502);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(5, 502);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 23);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoFill
            // 
            this.checkBoxNoFill.AutoSize = true;
            this.checkBoxNoFill.Location = new System.Drawing.Point(14, 333);
            this.checkBoxNoFill.Name = "checkBoxNoFill";
            this.checkBoxNoFill.Size = new System.Drawing.Size(90, 17);
            this.checkBoxNoFill.TabIndex = 8;
            this.checkBoxNoFill.Text = "Не заливать";
            this.checkBoxNoFill.UseVisualStyleBackColor = true;
            // 
            // panelBGColor
            // 
            this.panelBGColor.BackColor = System.Drawing.Color.White;
            this.panelBGColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBGColor.Location = new System.Drawing.Point(73, 272);
            this.panelBGColor.Name = "panelBGColor";
            this.panelBGColor.Size = new System.Drawing.Size(34, 35);
            this.panelBGColor.TabIndex = 7;
            // 
            // panelFGColor
            // 
            this.panelFGColor.BackColor = System.Drawing.Color.Black;
            this.panelFGColor.Location = new System.Drawing.Point(14, 272);
            this.panelFGColor.Name = "panelFGColor";
            this.panelFGColor.Size = new System.Drawing.Size(34, 35);
            this.panelFGColor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стиль заливки";
            // 
            // comboBoxHatchBrushes
            // 
            this.comboBoxHatchBrushes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHatchBrushes.FormattingEnabled = true;
            this.comboBoxHatchBrushes.Location = new System.Drawing.Point(138, 235);
            this.comboBoxHatchBrushes.Name = "comboBoxHatchBrushes";
            this.comboBoxHatchBrushes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHatchBrushes.TabIndex = 4;
            // 
            // labelLineThickness
            // 
            this.labelLineThickness.AutoSize = true;
            this.labelLineThickness.Location = new System.Drawing.Point(11, 216);
            this.labelLineThickness.Name = "labelLineThickness";
            this.labelLineThickness.Size = new System.Drawing.Size(86, 13);
            this.labelLineThickness.TabIndex = 3;
            this.labelLineThickness.Text = "Толщина линии";
            // 
            // numericUpDownLineThickness
            // 
            this.numericUpDownLineThickness.Location = new System.Drawing.Point(11, 235);
            this.numericUpDownLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLineThickness.Name = "numericUpDownLineThickness";
            this.numericUpDownLineThickness.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLineThickness.TabIndex = 2;
            this.numericUpDownLineThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButtonPaintBrush
            // 
            this.radioButtonPaintBrush.AutoSize = true;
            this.radioButtonPaintBrush.Location = new System.Drawing.Point(117, 44);
            this.radioButtonPaintBrush.Name = "radioButtonPaintBrush";
            this.radioButtonPaintBrush.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPaintBrush.TabIndex = 9;
            this.radioButtonPaintBrush.TabStop = true;
            this.radioButtonPaintBrush.Text = "Кисть";
            this.radioButtonPaintBrush.UseVisualStyleBackColor = true;
            this.radioButtonPaintBrush.CheckedChanged += new System.EventHandler(this.radioButtonPaintBrush_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLineType.ResumeLayout(false);
            this.groupBoxLineType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThickness)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxLineType;
        private System.Windows.Forms.RadioButton radioButtonImage;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.ComboBox comboBoxFontType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLineThickness;
        private System.Windows.Forms.NumericUpDown numericUpDownLineThickness;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHatchBrushes;
        private System.Windows.Forms.CheckBox checkBoxNoFill;
        private System.Windows.Forms.Panel panelBGColor;
        private System.Windows.Forms.Panel panelFGColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton radioButtonPaintBrush;
    }
}

