
namespace TakeYourHeight
{
    partial class TakeYourHeight
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.text_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_height
            // 
            this.text_height.Location = new System.Drawing.Point(155, 25);
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(100, 21);
            this.text_height.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入你的身高（cm）：";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(155, 67);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "计算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // TakeYourHeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 269);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_height);
            this.Name = "TakeYourHeight";
            this.Text = "TakeYourHeight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calc;
    }
}

