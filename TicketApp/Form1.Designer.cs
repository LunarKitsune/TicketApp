namespace TicketApp
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtSpeedLimit = new System.Windows.Forms.TextBox();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnLambdaCalc = new System.Windows.Forms.Button();
            this.btnLambdaBool = new System.Windows.Forms.Button();
            this.btnIDValidate = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(49, 163);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(165, 191);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(120, 147);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Fine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed Limit:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(114, 27);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 4;
            // 
            // txtSpeedLimit
            // 
            this.txtSpeedLimit.Location = new System.Drawing.Point(114, 67);
            this.txtSpeedLimit.Name = "txtSpeedLimit";
            this.txtSpeedLimit.Size = new System.Drawing.Size(100, 20);
            this.txtSpeedLimit.TabIndex = 5;
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(272, 27);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(95, 53);
            this.btnInterface.TabIndex = 6;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(272, 93);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(95, 53);
            this.btnDelegate.TabIndex = 7;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnLambdaCalc
            // 
            this.btnLambdaCalc.Location = new System.Drawing.Point(272, 161);
            this.btnLambdaCalc.Name = "btnLambdaCalc";
            this.btnLambdaCalc.Size = new System.Drawing.Size(95, 53);
            this.btnLambdaCalc.TabIndex = 8;
            this.btnLambdaCalc.Text = "Lambda";
            this.btnLambdaCalc.UseVisualStyleBackColor = true;
            this.btnLambdaCalc.Click += new System.EventHandler(this.btnLambdaCalc_Click);
            // 
            // btnLambdaBool
            // 
            this.btnLambdaBool.Location = new System.Drawing.Point(272, 231);
            this.btnLambdaBool.Name = "btnLambdaBool";
            this.btnLambdaBool.Size = new System.Drawing.Size(95, 53);
            this.btnLambdaBool.TabIndex = 9;
            this.btnLambdaBool.Text = "Lambda Bool";
            this.btnLambdaBool.UseVisualStyleBackColor = true;
            this.btnLambdaBool.Click += new System.EventHandler(this.btnLambdaBool_Click);
            // 
            // btnIDValidate
            // 
            this.btnIDValidate.Location = new System.Drawing.Point(272, 301);
            this.btnIDValidate.Name = "btnIDValidate";
            this.btnIDValidate.Size = new System.Drawing.Size(95, 53);
            this.btnIDValidate.TabIndex = 10;
            this.btnIDValidate.Text = "Validate";
            this.btnIDValidate.UseVisualStyleBackColor = true;
            this.btnIDValidate.Click += new System.EventHandler(this.btnIDValidate_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkRate = 0;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 105);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIDValidate);
            this.Controls.Add(this.btnLambdaBool);
            this.Controls.Add(this.btnLambdaCalc);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.txtSpeedLimit);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.rtbOutput);
            this.Name = "Form1";
            this.Text = "TicketApp";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtSpeedLimit;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnLambdaCalc;
        private System.Windows.Forms.Button btnLambdaBool;
        private System.Windows.Forms.Button btnIDValidate;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}

