namespace Hostel
{
    partial class AdminDahboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.addBedToolStripMenuItem,
            this.workersToolStripMenuItem,
            this.earningToolStripMenuItem,
            this.expenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRoomToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(106, 40);
            this.addRoomToolStripMenuItem.Text = "Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.AddRoomToolStripMenuItem_Click);
            // 
            // addBedToolStripMenuItem
            // 
            this.addBedToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBedToolStripMenuItem.Name = "addBedToolStripMenuItem";
            this.addBedToolStripMenuItem.Size = new System.Drawing.Size(80, 40);
            this.addBedToolStripMenuItem.Text = "Bed";
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(139, 40);
            this.workersToolStripMenuItem.Text = "Workers";
            // 
            // earningToolStripMenuItem
            // 
            this.earningToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.earningToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.earningToolStripMenuItem.Name = "earningToolStripMenuItem";
            this.earningToolStripMenuItem.Size = new System.Drawing.Size(131, 40);
            this.earningToolStripMenuItem.Text = "Earning";
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expenseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(143, 40);
            this.expenseToolStripMenuItem.Text = "Expense";
            // 
            // dtgView
            // 
            this.dtgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgView.Location = new System.Drawing.Point(0, 257);
            this.dtgView.Name = "dtgView";
            this.dtgView.RowTemplate.Height = 24;
            this.dtgView.Size = new System.Drawing.Size(1140, 468);
            this.dtgView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(976, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Hostel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hostel.Properties.Resources.the_hostel1;
            this.pictureBox1.Location = new System.Drawing.Point(886, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDahboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDahboard";
            this.Text = "AdminDahboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDahboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}