using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PolygonAreaCalculator
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnClearArea = new System.Windows.Forms.Button();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.lblHeaderResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPointsHeader = new System.Windows.Forms.Label();
            this.listViewPoints = new System.Windows.Forms.ListBox();
            this.lblAreaHeader = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.Location = new System.Drawing.Point(10, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(563, 360);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnClearArea
            // 
            this.btnClearArea.Location = new System.Drawing.Point(13, 387);
            this.btnClearArea.Name = "btnClearArea";
            this.btnClearArea.Size = new System.Drawing.Size(105, 23);
            this.btnClearArea.TabIndex = 1;
            this.btnClearArea.Text = "Очистить";
            this.btnClearArea.UseVisualStyleBackColor = true;
            this.btnClearArea.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(125, 387);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(95, 23);
            this.btnCalculateArea.TabIndex = 2;
            this.btnCalculateArea.Text = "Расчитать";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.btnCalculateArea_Click);
            // 
            // lblHeaderResult
            // 
            this.lblHeaderResult.AutoSize = true;
            this.lblHeaderResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeaderResult.Location = new System.Drawing.Point(12, 426);
            this.lblHeaderResult.Name = "lblHeaderResult";
            this.lblHeaderResult.Size = new System.Drawing.Size(200, 15);
            this.lblHeaderResult.TabIndex = 3;
            this.lblHeaderResult.Text = "Площадь многоугольника равна: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(208, 426);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 4;
            // 
            // lblPointsHeader
            // 
            this.lblPointsHeader.Location = new System.Drawing.Point(705, 20);
            this.lblPointsHeader.Name = "lblPointsHeader";
            this.lblPointsHeader.Size = new System.Drawing.Size(95, 30);
            this.lblPointsHeader.TabIndex = 6;
            this.lblPointsHeader.Text = "Список координат";
            this.lblPointsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewPoints
            // 
            this.listViewPoints.FormattingEnabled = true;
            this.listViewPoints.Location = new System.Drawing.Point(708, 54);
            this.listViewPoints.Name = "listViewPoints";
            this.listViewPoints.Size = new System.Drawing.Size(80, 329);
            this.listViewPoints.TabIndex = 7;
            // 
            // lblAreaHeader
            // 
            this.lblAreaHeader.AutoSize = true;
            this.lblAreaHeader.Location = new System.Drawing.Point(7, 6);
            this.lblAreaHeader.Name = "lblAreaHeader";
            this.lblAreaHeader.Size = new System.Drawing.Size(550, 13);
            this.lblAreaHeader.TabIndex = 8;
            this.lblAreaHeader.Text = "Нарисуйте многоугольник на рабочей поверхности или добавьте координаты вручную (н" +
    "е менее 3-х точек)";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(579, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(123, 13);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "Введите координату X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(579, 99);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(123, 13);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "Введите координату Y:";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(582, 71);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(120, 20);
            this.txbX.TabIndex = 11;
            this.txbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(582, 116);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(120, 20);
            this.txbY.TabIndex = 12;
            this.txbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(582, 143);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(120, 23);
            this.btnAddPoint.TabIndex = 13;
            this.btnAddPoint.Text = "Добавить";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblAreaHeader);
            this.Controls.Add(this.listViewPoints);
            this.Controls.Add(this.lblPointsHeader);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblHeaderResult);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.btnClearArea);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Расчет площади многоугольника";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private Button btnClearArea;
        private Button btnCalculateArea;
        private Label lblHeaderResult;
        private Label lblResult;
        private Label lblPointsHeader;
        private ListBox listViewPoints;
        private Label lblAreaHeader;
        private Label lblX;
        private Label lblY;
        private TextBox txbX;
        private TextBox txbY;
        private Button btnAddPoint;
    }   
}

