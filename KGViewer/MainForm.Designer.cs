namespace KGViewer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CardsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PaginationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.LinkLabel();
            this.MainLayout.SuspendLayout();
            this.PaginationLayout.SuspendLayout();
            this.CategoryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardsLayout
            // 
            this.CardsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardsLayout.ColumnCount = 3;
            this.CardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.CardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.CardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.CardsLayout.Location = new System.Drawing.Point(3, 43);
            this.CardsLayout.Name = "CardsLayout";
            this.CardsLayout.RowCount = 3;
            this.CardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.CardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.CardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.CardsLayout.Size = new System.Drawing.Size(609, 516);
            this.CardsLayout.TabIndex = 0;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.CardsLayout, 0, 1);
            this.MainLayout.Controls.Add(this.PaginationLayout, 0, 2);
            this.MainLayout.Controls.Add(this.CategoryLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.Size = new System.Drawing.Size(615, 602);
            this.MainLayout.TabIndex = 1;
            // 
            // PaginationLayout
            // 
            this.PaginationLayout.ColumnCount = 5;
            this.PaginationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PaginationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PaginationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PaginationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PaginationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PaginationLayout.Controls.Add(this.PrevButton, 1, 0);
            this.PaginationLayout.Controls.Add(this.NextButton, 3, 0);
            this.PaginationLayout.Controls.Add(this.PageLabel, 2, 0);
            this.PaginationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaginationLayout.Location = new System.Drawing.Point(3, 565);
            this.PaginationLayout.Name = "PaginationLayout";
            this.PaginationLayout.RowCount = 1;
            this.PaginationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PaginationLayout.Size = new System.Drawing.Size(609, 34);
            this.PaginationLayout.TabIndex = 1;
            // 
            // PrevButton
            // 
            this.PrevButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrevButton.Enabled = false;
            this.PrevButton.Location = new System.Drawing.Point(252, 3);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(24, 28);
            this.PrevButton.TabIndex = 0;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextButton.Location = new System.Drawing.Point(332, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 28);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageLabel.Location = new System.Drawing.Point(282, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(44, 34);
            this.PageLabel.TabIndex = 2;
            this.PageLabel.Text = "1";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // CategoryLayout
            // 
            this.CategoryLayout.ColumnCount = 4;
            this.CategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.CategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.CategoryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CategoryLayout.Controls.Add(this.UpdateButton, 2, 0);
            this.CategoryLayout.Controls.Add(this.CategoryLabel, 1, 0);
            this.CategoryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLayout.Location = new System.Drawing.Point(3, 3);
            this.CategoryLayout.Name = "CategoryLayout";
            this.CategoryLayout.RowCount = 1;
            this.CategoryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryLayout.Size = new System.Drawing.Size(609, 34);
            this.CategoryLayout.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateButton.Location = new System.Drawing.Point(367, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(74, 28);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.LinkColor = System.Drawing.Color.Black;
            this.CategoryLabel.Location = new System.Drawing.Point(167, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(194, 34);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.TabStop = true;
            this.CategoryLabel.Text = "Выбрать категории";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CategoryLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CategoryLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "KudaGo - страница 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainLayout.ResumeLayout(false);
            this.PaginationLayout.ResumeLayout(false);
            this.PaginationLayout.PerformLayout();
            this.CategoryLayout.ResumeLayout(false);
            this.CategoryLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CardsLayout;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.TableLayoutPanel PaginationLayout;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel CategoryLayout;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.LinkLabel CategoryLabel;
    }
}

