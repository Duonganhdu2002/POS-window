﻿namespace FinalProject.Forms
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Panel panelContent;
        private FinalProject.Components.Common.close_minmize closeMinimize; // Thêm dòng này

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            labelEmployeeName = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            button9 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            button7 = new Button();
            panel8 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelContent = new Panel();
            panel9 = new Panel();
            closeMinimize = new Components.Common.close_minmize(components);
            label1 = new Label();
            product_btn = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(10, 8);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(0, 15);
            labelEmployeeName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 583);
            panel1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(button9);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 513);
            panel7.Name = "panel7";
            panel7.Size = new Size(70, 70);
            panel7.TabIndex = 7;
            panel7.Paint += panel7_Paint;
            // 
            // button9
            // 
            button9.Font = new Font("#9Slide03 Cabin", 8.999999F);
            button9.ForeColor = Color.DimGray;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(-16, -14);
            button9.Name = "button9";
            button9.Size = new Size(104, 83);
            button9.TabIndex = 6;
            button9.Text = "Log out";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(70, 70);
            panel3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("#9Slide03 Cabin", 8.999999F);
            button2.ForeColor = Color.DimGray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-16, -12);
            button2.Name = "button2";
            button2.Size = new Size(104, 83);
            button2.TabIndex = 4;
            button2.Text = "Report";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 140);
            panel6.Name = "panel6";
            panel6.Size = new Size(70, 70);
            panel6.TabIndex = 8;
            // 
            // button7
            // 
            button7.Font = new Font("#9Slide03 Cabin", 8.999999F);
            button7.ForeColor = Color.DimGray;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(-16, -11);
            button7.Name = "button7";
            button7.Size = new Size(104, 83);
            button7.TabIndex = 4;
            button7.Text = "Orders";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 70);
            panel8.Name = "panel8";
            panel8.Size = new Size(70, 70);
            panel8.TabIndex = 6;
            // 
            // button6
            // 
            button6.Font = new Font("#9Slide03 Cabin", 8.999999F);
            button6.ForeColor = Color.DimGray;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(-16, -11);
            button6.Name = "button6";
            button6.Size = new Size(104, 83);
            button6.TabIndex = 4;
            button6.Text = "Casher";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 70);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("#9Slide03 Cabin", 8.999999F);
            button1.ForeColor = Color.DimGray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-16, -11);
            button1.Name = "button1";
            button1.Size = new Size(104, 83);
            button1.TabIndex = 4;
            button1.Text = "Home ";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("#9Slide03 Cabin", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DimGray;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(104, 83);
            button5.TabIndex = 4;
            button5.Text = "Home ";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Location = new Point(700, 301);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.Location = new Point(75, 56);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1030, 581);
            panelContent.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(closeMinimize);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1105, 50);
            panel9.TabIndex = 7;
            panel9.Paint += panel9_Paint;
            // 
            // closeMinimize
            // 
            closeMinimize.Dock = DockStyle.Right;
            closeMinimize.Location = new Point(935, 0);
            closeMinimize.Name = "closeMinimize";
            closeMinimize.Size = new Size(170, 50);
            closeMinimize.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("#9Slide03 Cabin Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 12);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "RESTRO POS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // product_btn
            // 
            product_btn.Font = new Font("#9Slide03 Cabin", 8.999999F);
            product_btn.ForeColor = Color.DimGray;
            product_btn.Image = (Image)resources.GetObject("product_btn.Image");
            product_btn.Location = new Point(-17, -8);
            product_btn.Name = "product_btn";
            product_btn.Size = new Size(104, 83);
            product_btn.TabIndex = 5;
            product_btn.Text = "Product";
            product_btn.TextAlign = ContentAlignment.BottomCenter;
            product_btn.UseVisualStyleBackColor = true;
            product_btn.Click += product_btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(product_btn);
            panel4.Location = new Point(1, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(70, 70);
            panel4.TabIndex = 8;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 636);
            Controls.Add(panel9);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(labelEmployeeName);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel6;
        private Button button7;
        private Panel panel8;
        private Button button6;
        private Panel panel3;
        private Button button2;
        private Button button9;
        private Panel panel9;
        private Label label1;
        private Panel panel7;
        private Panel panel4;
        private Button product_btn;
    }
}
