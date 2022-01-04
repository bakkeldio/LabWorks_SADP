
namespace Lab10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firstFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstFormToolStripMenuItem,
            this.secondFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firstFormToolStripMenuItem
            // 
            this.firstFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayStylesToolStripMenuItem});
            this.firstFormToolStripMenuItem.Name = "firstFormToolStripMenuItem";
            this.firstFormToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.firstFormToolStripMenuItem.Text = "First Form";
            // 
            // secondFormToolStripMenuItem
            // 
            this.secondFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationToolStripMenuItem});
            this.secondFormToolStripMenuItem.Name = "secondFormToolStripMenuItem";
            this.secondFormToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.secondFormToolStripMenuItem.Text = "Second Form";
            // 
            // displayStylesToolStripMenuItem
            // 
            this.displayStylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.titleHorizontalToolStripMenuItem,
            this.titleVerticalToolStripMenuItem});
            this.displayStylesToolStripMenuItem.Name = "displayStylesToolStripMenuItem";
            this.displayStylesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.displayStylesToolStripMenuItem.Text = "Display Styles";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // titleHorizontalToolStripMenuItem
            // 
            this.titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
            this.titleHorizontalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.titleHorizontalToolStripMenuItem.Text = "TitleHorizontal";
            this.titleHorizontalToolStripMenuItem.Click += new System.EventHandler(this.titleHorizontalToolStripMenuItem_Click);
            // 
            // titleVerticalToolStripMenuItem
            // 
            this.titleVerticalToolStripMenuItem.Name = "titleVerticalToolStripMenuItem";
            this.titleVerticalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.titleVerticalToolStripMenuItem.Text = "TitleVertical";
            this.titleVerticalToolStripMenuItem.Click += new System.EventHandler(this.titleVerticalToolStripMenuItem_Click);
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculationToolStripMenuItem.Text = "Calculation";
            this.calculationToolStripMenuItem.Click += new System.EventHandler(this.calculationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firstFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationToolStripMenuItem;
    }
}

