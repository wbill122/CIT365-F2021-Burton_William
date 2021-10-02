
namespace MegaDesk_Burton1
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveQuote = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDesktopMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRushOrder = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(46, 66);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(309, 22);
            this.CustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width of Desk:";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(46, 145);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 22);
            this.Width.TabIndex = 3;
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(46, 203);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(100, 22);
            this.Depth.TabIndex = 5;
            this.Depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_Keypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth of Desk:";
            // 
            // buttonSaveQuote
            // 
            this.buttonSaveQuote.Location = new System.Drawing.Point(515, 233);
            this.buttonSaveQuote.Name = "buttonSaveQuote";
            this.buttonSaveQuote.Size = new System.Drawing.Size(184, 54);
            this.buttonSaveQuote.TabIndex = 7;
            this.buttonSaveQuote.Text = "Save Quote";
            this.buttonSaveQuote.UseVisualStyleBackColor = true;
            this.buttonSaveQuote.Click += new System.EventHandler(this.buttonSaveQuote_Click);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(515, 351);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(184, 40);
            this.buttonMainMenu.TabIndex = 8;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Drawers:";
            // 
            // comboBoxDesktopMaterial
            // 
            this.comboBoxDesktopMaterial.FormattingEnabled = true;
            this.comboBoxDesktopMaterial.Location = new System.Drawing.Point(46, 257);
            this.comboBoxDesktopMaterial.Name = "comboBoxDesktopMaterial";
            this.comboBoxDesktopMaterial.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDesktopMaterial.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rush Order:";
            // 
            // comboBoxRushOrder
            // 
            this.comboBoxRushOrder.FormattingEnabled = true;
            this.comboBoxRushOrder.Location = new System.Drawing.Point(46, 315);
            this.comboBoxRushOrder.Name = "comboBoxRushOrder";
            this.comboBoxRushOrder.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRushOrder.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date of Order:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxRushOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDesktopMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.buttonSaveQuote);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveQuote;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDesktopMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRushOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}