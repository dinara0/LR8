
namespace LR8
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Coord_label = new System.Windows.Forms.Label();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonCGroup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ShowColor_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSticky = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Coord_label);
            this.panel1.Location = new System.Drawing.Point(76, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 367);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // Coord_label
            // 
            this.Coord_label.AutoSize = true;
            this.Coord_label.Location = new System.Drawing.Point(2, 6);
            this.Coord_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Coord_label.Name = "Coord_label";
            this.Coord_label.Size = new System.Drawing.Size(63, 13);
            this.Coord_label.TabIndex = 1;
            this.Coord_label.Text = "Coord_label";
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(9, 255);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(63, 35);
            this.buttonLine.TabIndex = 12;
            this.buttonLine.Text = "линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(9, 132);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(63, 35);
            this.buttonCircle.TabIndex = 9;
            this.buttonCircle.Text = "круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(9, 214);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(63, 35);
            this.buttonTriangle.TabIndex = 11;
            this.buttonTriangle.Text = "треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(9, 174);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(63, 35);
            this.buttonSquare.TabIndex = 10;
            this.buttonSquare.Text = "квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonCGroup
            // 
            this.buttonCGroup.Location = new System.Drawing.Point(187, 372);
            this.buttonCGroup.Name = "buttonCGroup";
            this.buttonCGroup.Size = new System.Drawing.Size(84, 35);
            this.buttonCGroup.TabIndex = 15;
            this.buttonCGroup.Text = "группировать";
            this.buttonCGroup.UseVisualStyleBackColor = true;
            this.buttonCGroup.Click += new System.EventHandler(this.buttonCGroup_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "выделить\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowColor_button
            // 
            this.ShowColor_button.Location = new System.Drawing.Point(9, 372);
            this.ShowColor_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowColor_button.Name = "ShowColor_button";
            this.ShowColor_button.Size = new System.Drawing.Size(84, 35);
            this.ShowColor_button.TabIndex = 13;
            this.ShowColor_button.Text = "выбрать цвет";
            this.ShowColor_button.UseVisualStyleBackColor = true;
            this.ShowColor_button.Click += new System.EventHandler(this.ShowColor_button_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(276, 372);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 35);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(365, 372);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(84, 35);
            this.buttonRead.TabIndex = 17;
            this.buttonRead.Text = "Выгрузить из файла";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(802, 1);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(149, 369);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // buttonSticky
            // 
            this.buttonSticky.Location = new System.Drawing.Point(470, 372);
            this.buttonSticky.Name = "buttonSticky";
            this.buttonSticky.Size = new System.Drawing.Size(80, 34);
            this.buttonSticky.TabIndex = 19;
            this.buttonSticky.Text = "липкий объект";
            this.buttonSticky.UseVisualStyleBackColor = true;
            this.buttonSticky.Click += new System.EventHandler(this.buttonSticky_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 413);
            this.Controls.Add(this.buttonSticky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCGroup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowColor_button);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonSquare);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Coord_label;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonCGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ShowColor_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSticky;
    }
}

