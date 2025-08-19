namespace PuttyComSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portsList = new System.Windows.Forms.ListView();
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Since = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.portSpeed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portsList
            // 
            this.portsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Port,
            this.Since});
            this.portsList.FullRowSelect = true;
            this.portsList.HideSelection = false;
            this.portsList.Location = new System.Drawing.Point(15, 27);
            this.portsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portsList.MultiSelect = false;
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(185, 144);
            this.portsList.TabIndex = 0;
            this.portsList.TileSize = new System.Drawing.Size(240, 40);
            this.portsList.UseCompatibleStateImageBehavior = false;
            this.portsList.View = System.Windows.Forms.View.Details;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 70;
            // 
            // Since
            // 
            this.Since.Text = "Since";
            this.Since.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port";
            // 
            // portSpeed
            // 
            this.portSpeed.Location = new System.Drawing.Point(207, 28);
            this.portSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portSpeed.Name = "portSpeed";
            this.portSpeed.Size = new System.Drawing.Size(191, 22);
            this.portSpeed.TabIndex = 2;
            this.portSpeed.TextChanged += new System.EventHandler(this.portSpeed_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Launch Putty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetPuttyClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set Putty Location";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LaunchPuttyClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 221);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PuttyComSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView portsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader Since;
    }
}

