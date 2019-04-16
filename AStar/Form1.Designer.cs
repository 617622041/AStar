namespace AStar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.starMap1 = new AStar.Component.StarMap();
            this.wall25 = new AStar.Component.Wall();
            this.wall24 = new AStar.Component.Wall();
            this.wall23 = new AStar.Component.Wall();
            this.wall22 = new AStar.Component.Wall();
            this.wall21 = new AStar.Component.Wall();
            this.wall20 = new AStar.Component.Wall();
            this.wall19 = new AStar.Component.Wall();
            this.wall18 = new AStar.Component.Wall();
            this.wall17 = new AStar.Component.Wall();
            this.wall16 = new AStar.Component.Wall();
            this.wall15 = new AStar.Component.Wall();
            this.wall14 = new AStar.Component.Wall();
            this.wall13 = new AStar.Component.Wall();
            this.wall12 = new AStar.Component.Wall();
            this.wall11 = new AStar.Component.Wall();
            this.wall10 = new AStar.Component.Wall();
            this.wall9 = new AStar.Component.Wall();
            this.wall8 = new AStar.Component.Wall();
            this.wall7 = new AStar.Component.Wall();
            this.wall6 = new AStar.Component.Wall();
            this.wall5 = new AStar.Component.Wall();
            this.runner1 = new AStar.Component.Runner();
            this.wall4 = new AStar.Component.Wall();
            this.wall3 = new AStar.Component.Wall();
            this.endPoint1 = new AStar.Component.EndPoint();
            this.startPoint1 = new AStar.Component.StartPoint();
            this.wall2 = new AStar.Component.Wall();
            this.wall1 = new AStar.Component.Wall();
            this.startPoint2 = new AStar.Component.StartPoint();
            this.label1 = new System.Windows.Forms.Label();
            this.endPoint2 = new AStar.Component.EndPoint();
            this.label2 = new System.Windows.Forms.Label();
            this.starMap1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // starMap1
            // 
            this.starMap1.CellWidth = 30;
            this.starMap1.Controls.Add(this.wall25);
            this.starMap1.Controls.Add(this.wall24);
            this.starMap1.Controls.Add(this.wall23);
            this.starMap1.Controls.Add(this.wall22);
            this.starMap1.Controls.Add(this.wall21);
            this.starMap1.Controls.Add(this.wall20);
            this.starMap1.Controls.Add(this.wall19);
            this.starMap1.Controls.Add(this.wall18);
            this.starMap1.Controls.Add(this.wall17);
            this.starMap1.Controls.Add(this.wall16);
            this.starMap1.Controls.Add(this.wall15);
            this.starMap1.Controls.Add(this.wall14);
            this.starMap1.Controls.Add(this.wall13);
            this.starMap1.Controls.Add(this.wall12);
            this.starMap1.Controls.Add(this.wall11);
            this.starMap1.Controls.Add(this.wall10);
            this.starMap1.Controls.Add(this.wall9);
            this.starMap1.Controls.Add(this.wall8);
            this.starMap1.Controls.Add(this.wall7);
            this.starMap1.Controls.Add(this.wall6);
            this.starMap1.Controls.Add(this.wall5);
            this.starMap1.Controls.Add(this.runner1);
            this.starMap1.Controls.Add(this.wall4);
            this.starMap1.Controls.Add(this.wall3);
            this.starMap1.Controls.Add(this.endPoint1);
            this.starMap1.Controls.Add(this.startPoint1);
            this.starMap1.Controls.Add(this.wall2);
            this.starMap1.Controls.Add(this.wall1);
            this.starMap1.Location = new System.Drawing.Point(12, 12);
            this.starMap1.Name = "starMap1";
            this.starMap1.Size = new System.Drawing.Size(780, 510);
            this.starMap1.TabIndex = 0;
            // 
            // wall25
            // 
            this.wall25.Location = new System.Drawing.Point(361, 211);
            this.wall25.Name = "wall25";
            this.wall25.Size = new System.Drawing.Size(28, 28);
            this.wall25.TabIndex = 29;
            // 
            // wall24
            // 
            this.wall24.Location = new System.Drawing.Point(422, 361);
            this.wall24.Name = "wall24";
            this.wall24.Size = new System.Drawing.Size(86, 28);
            this.wall24.TabIndex = 28;
            // 
            // wall23
            // 
            this.wall23.Location = new System.Drawing.Point(391, 362);
            this.wall23.Name = "wall23";
            this.wall23.Size = new System.Drawing.Size(29, 146);
            this.wall23.TabIndex = 27;
            // 
            // wall22
            // 
            this.wall22.Location = new System.Drawing.Point(391, 242);
            this.wall22.Name = "wall22";
            this.wall22.Size = new System.Drawing.Size(58, 58);
            this.wall22.TabIndex = 26;
            // 
            // wall21
            // 
            this.wall21.Location = new System.Drawing.Point(391, 181);
            this.wall21.Name = "wall21";
            this.wall21.Size = new System.Drawing.Size(58, 58);
            this.wall21.TabIndex = 25;
            // 
            // wall20
            // 
            this.wall20.Location = new System.Drawing.Point(331, 301);
            this.wall20.Name = "wall20";
            this.wall20.Size = new System.Drawing.Size(118, 28);
            this.wall20.TabIndex = 24;
            // 
            // wall19
            // 
            this.wall19.Location = new System.Drawing.Point(301, 302);
            this.wall19.Name = "wall19";
            this.wall19.Size = new System.Drawing.Size(29, 146);
            this.wall19.TabIndex = 23;
            // 
            // wall18
            // 
            this.wall18.Location = new System.Drawing.Point(211, 481);
            this.wall18.Name = "wall18";
            this.wall18.Size = new System.Drawing.Size(151, 27);
            this.wall18.TabIndex = 22;
            // 
            // wall17
            // 
            this.wall17.Location = new System.Drawing.Point(421, 121);
            this.wall17.Name = "wall17";
            this.wall17.Size = new System.Drawing.Size(58, 58);
            this.wall17.TabIndex = 21;
            // 
            // wall16
            // 
            this.wall16.Location = new System.Drawing.Point(334, 122);
            this.wall16.Name = "wall16";
            this.wall16.Size = new System.Drawing.Size(86, 31);
            this.wall16.TabIndex = 20;
            // 
            // wall15
            // 
            this.wall15.Location = new System.Drawing.Point(390, 3);
            this.wall15.Name = "wall15";
            this.wall15.Size = new System.Drawing.Size(30, 118);
            this.wall15.TabIndex = 19;
            // 
            // wall14
            // 
            this.wall14.Location = new System.Drawing.Point(211, 3);
            this.wall14.Name = "wall14";
            this.wall14.Size = new System.Drawing.Size(181, 27);
            this.wall14.TabIndex = 18;
            // 
            // wall13
            // 
            this.wall13.Location = new System.Drawing.Point(301, 181);
            this.wall13.Name = "wall13";
            this.wall13.Size = new System.Drawing.Size(58, 58);
            this.wall13.TabIndex = 17;
            // 
            // wall12
            // 
            this.wall12.Location = new System.Drawing.Point(270, 62);
            this.wall12.Name = "wall12";
            this.wall12.Size = new System.Drawing.Size(92, 27);
            this.wall12.TabIndex = 16;
            // 
            // wall11
            // 
            this.wall11.Location = new System.Drawing.Point(270, 79);
            this.wall11.Name = "wall11";
            this.wall11.Size = new System.Drawing.Size(29, 130);
            this.wall11.TabIndex = 15;
            // 
            // wall10
            // 
            this.wall10.Location = new System.Drawing.Point(241, 271);
            this.wall10.Name = "wall10";
            this.wall10.Size = new System.Drawing.Size(29, 177);
            this.wall10.TabIndex = 14;
            // 
            // wall9
            // 
            this.wall9.Location = new System.Drawing.Point(181, 302);
            this.wall9.Name = "wall9";
            this.wall9.Size = new System.Drawing.Size(29, 205);
            this.wall9.TabIndex = 13;
            // 
            // wall8
            // 
            this.wall8.Location = new System.Drawing.Point(90, 330);
            this.wall8.Name = "wall8";
            this.wall8.Size = new System.Drawing.Size(58, 30);
            this.wall8.TabIndex = 12;
            // 
            // wall7
            // 
            this.wall7.Location = new System.Drawing.Point(119, 361);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(29, 121);
            this.wall7.TabIndex = 11;
            // 
            // wall6
            // 
            this.wall6.Location = new System.Drawing.Point(181, 62);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(59, 59);
            this.wall6.TabIndex = 10;
            // 
            // wall5
            // 
            this.wall5.Location = new System.Drawing.Point(61, 274);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(29, 86);
            this.wall5.TabIndex = 9;
            // 
            // runner1
            // 
            this.runner1.Location = new System.Drawing.Point(32, 62);
            this.runner1.Name = "runner1";
            this.runner1.Size = new System.Drawing.Size(28, 28);
            this.runner1.TabIndex = 8;
            // 
            // wall4
            // 
            this.wall4.Location = new System.Drawing.Point(211, 153);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(29, 86);
            this.wall4.TabIndex = 7;
            // 
            // wall3
            // 
            this.wall3.Location = new System.Drawing.Point(62, 241);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(268, 29);
            this.wall3.TabIndex = 6;
            // 
            // endPoint1
            // 
            this.endPoint1.Location = new System.Drawing.Point(602, 242);
            this.endPoint1.Name = "endPoint1";
            this.endPoint1.Size = new System.Drawing.Size(28, 28);
            this.endPoint1.TabIndex = 5;
            // 
            // startPoint1
            // 
            this.startPoint1.Location = new System.Drawing.Point(2, 2);
            this.startPoint1.Name = "startPoint1";
            this.startPoint1.Size = new System.Drawing.Size(28, 28);
            this.startPoint1.TabIndex = 4;
            // 
            // wall2
            // 
            this.wall2.Location = new System.Drawing.Point(0, 181);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(118, 28);
            this.wall2.TabIndex = 3;
            // 
            // wall1
            // 
            this.wall1.Location = new System.Drawing.Point(151, 2);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(28, 207);
            this.wall1.TabIndex = 2;
            // 
            // startPoint2
            // 
            this.startPoint2.Location = new System.Drawing.Point(812, 116);
            this.startPoint2.Name = "startPoint2";
            this.startPoint2.Size = new System.Drawing.Size(28, 28);
            this.startPoint2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "起点";
            // 
            // endPoint2
            // 
            this.endPoint2.Location = new System.Drawing.Point(812, 163);
            this.endPoint2.Name = "endPoint2";
            this.endPoint2.Size = new System.Drawing.Size(28, 28);
            this.endPoint2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "路径终点";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endPoint2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startPoint2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.starMap1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.starMap1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.StarMap starMap1;
        private System.Windows.Forms.Button button1;
        private Component.Wall wall1;
        private Component.Wall wall2;
        private Component.StartPoint startPoint1;
        private Component.EndPoint endPoint1;
        private Component.Wall wall4;
        private Component.Wall wall3;
        private Component.Runner runner1;
        private Component.Wall wall5;
        private Component.Wall wall10;
        private Component.Wall wall9;
        private Component.Wall wall8;
        private Component.Wall wall7;
        private Component.Wall wall6;
        private Component.Wall wall13;
        private Component.Wall wall12;
        private Component.Wall wall11;
        private Component.Wall wall20;
        private Component.Wall wall19;
        private Component.Wall wall18;
        private Component.Wall wall17;
        private Component.Wall wall16;
        private Component.Wall wall15;
        private Component.Wall wall14;
        private Component.Wall wall23;
        private Component.Wall wall22;
        private Component.Wall wall21;
        private Component.Wall wall24;
        private Component.Wall wall25;
        private Component.StartPoint startPoint2;
        private System.Windows.Forms.Label label1;
        private Component.EndPoint endPoint2;
        private System.Windows.Forms.Label label2;


    }
}

