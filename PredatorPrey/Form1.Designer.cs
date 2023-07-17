namespace PredatorPrey
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textCountPrey = new System.Windows.Forms.TextBox();
            this.textKoefPrey = new System.Windows.Forms.TextBox();
            this.textKoefFind = new System.Windows.Forms.TextBox();
            this.textCountPredator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSpeedDownPop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textReprodPredator = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число жертв";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Коэффициент прироста жертв";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCountPrey
            // 
            this.textCountPrey.Location = new System.Drawing.Point(51, 47);
            this.textCountPrey.Name = "textCountPrey";
            this.textCountPrey.Size = new System.Drawing.Size(100, 23);
            this.textCountPrey.TabIndex = 3;
            this.textCountPrey.Text = "200";
            this.textCountPrey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // textKoefPrey
            // 
            this.textKoefPrey.Location = new System.Drawing.Point(51, 110);
            this.textKoefPrey.Name = "textKoefPrey";
            this.textKoefPrey.Size = new System.Drawing.Size(100, 23);
            this.textKoefPrey.TabIndex = 4;
            this.textKoefPrey.Text = "5";
            this.textKoefPrey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // textKoefFind
            // 
            this.textKoefFind.Location = new System.Drawing.Point(254, 110);
            this.textKoefFind.Name = "textKoefFind";
            this.textKoefFind.Size = new System.Drawing.Size(100, 23);
            this.textKoefFind.TabIndex = 5;
            this.textKoefFind.Text = "0,1";
            this.textKoefFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // textCountPredator
            // 
            this.textCountPredator.Location = new System.Drawing.Point(254, 47);
            this.textCountPredator.Name = "textCountPredator";
            this.textCountPredator.Size = new System.Drawing.Size(100, 23);
            this.textCountPredator.TabIndex = 6;
            this.textCountPredator.Text = "25";
            this.textCountPredator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Число хищников";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Параметр эффективности поиска жертв";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Параметр скорости снижения популяции хищников в отсутствии пищи";
            // 
            // textSpeedDownPop
            // 
            this.textSpeedDownPop.Location = new System.Drawing.Point(254, 165);
            this.textSpeedDownPop.Name = "textSpeedDownPop";
            this.textSpeedDownPop.Size = new System.Drawing.Size(100, 23);
            this.textSpeedDownPop.TabIndex = 10;
            this.textSpeedDownPop.Text = "5";
            this.textSpeedDownPop.TextChanged += new System.EventHandler(this.textSpeedDownPop_TextChanged);
            this.textSpeedDownPop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Эффективность рождения потомства у хищников в результате поедания жертв";
            // 
            // textReprodPredator
            // 
            this.textReprodPredator.Location = new System.Drawing.Point(254, 222);
            this.textReprodPredator.Name = "textReprodPredator";
            this.textReprodPredator.Size = new System.Drawing.Size(100, 23);
            this.textReprodPredator.TabIndex = 12;
            this.textReprodPredator.Text = "0,5";
            this.textReprodPredator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnteringNumbersKeyPress);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(36, 195);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 13;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(717, 8);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(282, 335);
            this.plotView1.TabIndex = 14;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 352);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textReprodPredator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSpeedDownPop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCountPredator);
            this.Controls.Add(this.textKoefFind);
            this.Controls.Add(this.textKoefPrey);
            this.Controls.Add(this.textCountPrey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textCountPrey;
        private TextBox textKoefPrey;
        private TextBox textKoefFind;
        private TextBox textCountPredator;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textSpeedDownPop;
        private Label label6;
        private TextBox textReprodPredator;
        private Label labelError;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}