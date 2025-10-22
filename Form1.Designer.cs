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
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portsList
            // 
            this.portsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Port,
            this.Since});
            this.portsList.FullRowSelect = true;
            this.portsList.HideSelection = false;
            this.portsList.Location = new System.Drawing.Point(22, 42);
            this.portsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portsList.MultiSelect = false;
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(276, 223);
            this.portsList.TabIndex = 0;
            this.portsList.TileSize = new System.Drawing.Size(240, 40);
            this.portsList.UseCompatibleStateImageBehavior = false;
            this.portsList.View = System.Windows.Forms.View.Details;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            // 
            // Since
            // 
            this.Since.Text = "Since";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port";
            // 
            // portSpeed
            // 
            this.portSpeed.Location = new System.Drawing.Point(310, 44);
            this.portSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portSpeed.Name = "portSpeed";
            this.portSpeed.Size = new System.Drawing.Size(284, 31);
            this.portSpeed.TabIndex = 2;
            this.portSpeed.TextChanged += new System.EventHandler(this.portSpeed_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(574, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Launch Putty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetPuttyClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set Putty Location";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LaunchPuttyClick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.info.Location = new System.Drawing.Point(206, 339);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(222, 24);
            this.info.TabIndex = 6;
            this.info.Text = "Made by RK - Version 0.2";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 372);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label info;
    }
}

