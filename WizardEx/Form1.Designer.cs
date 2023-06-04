
namespace WizardEx
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.header_label = new System.Windows.Forms.Label();
            this.page2_label = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.Panel();
            this.page1_label = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.page_container = new System.Windows.Forms.Panel();
            this.page2 = new System.Windows.Forms.Panel();
            this.page2_label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.page1.SuspendLayout();
            this.footer.SuspendLayout();
            this.page_container.SuspendLayout();
            this.page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.header_label);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(576, 56);
            this.header.TabIndex = 0;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.header_label.Location = new System.Drawing.Point(13, 8);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(152, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "환영합니다";
            // 
            // page2_label
            // 
            this.page2_label.Location = new System.Drawing.Point(0, 0);
            this.page2_label.Name = "page2_label";
            this.page2_label.Size = new System.Drawing.Size(100, 23);
            this.page2_label.TabIndex = 0;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.button5);
            this.page1.Controls.Add(this.label1);
            this.page1.Controls.Add(this.textBox2);
            this.page1.Controls.Add(this.page1_label);
            this.page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page1.Location = new System.Drawing.Point(0, 0);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(573, 293);
            this.page1.TabIndex = 1;
            // 
            // page1_label
            // 
            this.page1_label.AutoSize = true;
            this.page1_label.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.page1_label.Location = new System.Drawing.Point(13, 8);
            this.page1_label.Name = "page1_label";
            this.page1_label.Size = new System.Drawing.Size(95, 30);
            this.page1_label.TabIndex = 3;
            this.page1_label.Text = "1 페이지";
            // 
            // footer
            // 
            this.footer.Controls.Add(this.button4);
            this.footer.Controls.Add(this.button3);
            this.footer.Controls.Add(this.button5);
            this.footer.Controls.Add(this.button2);
            this.footer.Controls.Add(this.button1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 355);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(576, 49);
            this.footer.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "취소";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "마침";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //button5

            this.button5.Location = new System.Drawing.Point(408, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "설치";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "다음";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "뒤로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // page_container
            // 
            this.page_container.Controls.Add(this.page2);
            this.page_container.Controls.Add(this.page1);
            this.page_container.Location = new System.Drawing.Point(3, 62);
            this.page_container.Name = "page_container";
            this.page_container.Size = new System.Drawing.Size(573, 293);
            this.page_container.TabIndex = 3;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.page2_label1);
            this.page2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page2.Location = new System.Drawing.Point(0, 0);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(573, 293);
            this.page2.TabIndex = 2;
            // 
            // page2_label1
            // 
            this.page2_label1.AutoSize = true;
            this.page2_label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.page2_label1.Location = new System.Drawing.Point(13, 8);
            this.page2_label1.Name = "page2_label1";
            this.page2_label1.Size = new System.Drawing.Size(95, 30);
            this.page2_label1.TabIndex = 3;
            this.page2_label1.Text = "2 페이지";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 2);
            this.label2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "설치 위치";
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.page_container);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "꽃집 FZip 설치";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.footer.ResumeLayout(false);
            this.page_container.ResumeLayout(false);
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Label page2_label;
        private System.Windows.Forms.Label page1_label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel page_container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Label page2_label1;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

