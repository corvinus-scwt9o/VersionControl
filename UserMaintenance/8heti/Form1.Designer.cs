
namespace _8heti
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnColor_Click = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPresent = new System.Windows.Forms.Button();
            this.buttonPresentColor1 = new System.Windows.Forms.Button();
            this.buttonPresentColor2 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.buttonPresentColor2);
            this.mainPanel.Controls.Add(this.buttonPresentColor1);
            this.mainPanel.Controls.Add(this.buttonPresent);
            this.mainPanel.Controls.Add(this.btnColor_Click);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnSelectBall);
            this.mainPanel.Controls.Add(this.btnSelectCar);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(783, 369);
            this.mainPanel.TabIndex = 0;
            // 
            // btnColor_Click
            // 
            this.btnColor_Click.BackColor = System.Drawing.Color.Lime;
            this.btnColor_Click.Location = new System.Drawing.Point(23, 166);
            this.btnColor_Click.Name = "btnColor_Click";
            this.btnColor_Click.Size = new System.Drawing.Size(75, 23);
            this.btnColor_Click.TabIndex = 3;
            this.btnColor_Click.UseVisualStyleBackColor = false;
            this.btnColor_Click.Click += new System.EventHandler(this.btnColor_Click_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(20, 140);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(65, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next";
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(104, 114);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBall.TabIndex = 1;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(23, 114);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCar.TabIndex = 0;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(186, 113);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(75, 23);
            this.buttonPresent.TabIndex = 4;
            this.buttonPresent.Text = "present";
            this.buttonPresent.UseVisualStyleBackColor = true;
            this.buttonPresent.Click += new System.EventHandler(this.buttonPresent_Click);
            // 
            // buttonPresentColor1
            // 
            this.buttonPresentColor1.BackColor = System.Drawing.Color.Red;
            this.buttonPresentColor1.Location = new System.Drawing.Point(186, 166);
            this.buttonPresentColor1.Name = "buttonPresentColor1";
            this.buttonPresentColor1.Size = new System.Drawing.Size(75, 23);
            this.buttonPresentColor1.TabIndex = 5;
            this.buttonPresentColor1.UseVisualStyleBackColor = false;
            // 
            // buttonPresentColor2
            // 
            this.buttonPresentColor2.BackColor = System.Drawing.Color.Yellow;
            this.buttonPresentColor2.Location = new System.Drawing.Point(186, 196);
            this.buttonPresentColor2.Name = "buttonPresentColor2";
            this.buttonPresentColor2.Size = new System.Drawing.Size(75, 23);
            this.buttonPresentColor2.TabIndex = 6;
            this.buttonPresentColor2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnColor_Click;
        private System.Windows.Forms.Button buttonPresent;
        private System.Windows.Forms.Button buttonPresentColor2;
        private System.Windows.Forms.Button buttonPresentColor1;
    }
}

