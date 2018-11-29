namespace _7DLogger
{
    partial class MainForm
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
            this.in_done = new System.Windows.Forms.RichTextBox();
            this.out_done = new System.Windows.Forms.RichTextBox();
            this.out_todo = new System.Windows.Forms.RichTextBox();
            this.in_todo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_todo = new System.Windows.Forms.DateTimePicker();
            this.date_done = new System.Windows.Forms.DateTimePicker();
            this.add_todo = new System.Windows.Forms.Button();
            this.selectPic = new System.Windows.Forms.Button();
            this.addPic = new System.Windows.Forms.Button();
            this.piclabel = new System.Windows.Forms.Label();
            this.add_done = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_done
            // 
            this.in_done.Location = new System.Drawing.Point(87, 126);
            this.in_done.Name = "in_done";
            this.in_done.Size = new System.Drawing.Size(264, 157);
            this.in_done.TabIndex = 0;
            this.in_done.Text = "";
            // 
            // out_done
            // 
            this.out_done.Location = new System.Drawing.Point(525, 97);
            this.out_done.Name = "out_done";
            this.out_done.ReadOnly = true;
            this.out_done.Size = new System.Drawing.Size(309, 186);
            this.out_done.TabIndex = 1;
            this.out_done.Text = "";
            // 
            // out_todo
            // 
            this.out_todo.Location = new System.Drawing.Point(525, 415);
            this.out_todo.Name = "out_todo";
            this.out_todo.ReadOnly = true;
            this.out_todo.Size = new System.Drawing.Size(309, 186);
            this.out_todo.TabIndex = 3;
            this.out_todo.Text = "";
            // 
            // in_todo
            // 
            this.in_todo.Location = new System.Drawing.Point(87, 444);
            this.in_todo.Name = "in_todo";
            this.in_todo.Size = new System.Drawing.Size(264, 157);
            this.in_todo.TabIndex = 2;
            this.in_todo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 662);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Done";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Done";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Do";
            // 
            // date_todo
            // 
            this.date_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_todo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_todo.Location = new System.Drawing.Point(87, 409);
            this.date_todo.Name = "date_todo";
            this.date_todo.Size = new System.Drawing.Size(166, 24);
            this.date_todo.TabIndex = 9;
            // 
            // date_done
            // 
            this.date_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_done.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_done.Location = new System.Drawing.Point(87, 91);
            this.date_done.Name = "date_done";
            this.date_done.Size = new System.Drawing.Size(166, 24);
            this.date_done.TabIndex = 10;
            // 
            // add_todo
            // 
            this.add_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_todo.Location = new System.Drawing.Point(178, 617);
            this.add_todo.Name = "add_todo";
            this.add_todo.Size = new System.Drawing.Size(75, 29);
            this.add_todo.TabIndex = 12;
            this.add_todo.Text = "Add";
            this.add_todo.UseVisualStyleBackColor = true;
            this.add_todo.Click += new System.EventHandler(this.add_todo_Click);
            // 
            // selectPic
            // 
            this.selectPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPic.Location = new System.Drawing.Point(87, 728);
            this.selectPic.Name = "selectPic";
            this.selectPic.Size = new System.Drawing.Size(122, 29);
            this.selectPic.TabIndex = 15;
            this.selectPic.Text = "Select Picture";
            this.selectPic.UseVisualStyleBackColor = true;
            this.selectPic.Click += new System.EventHandler(this.selectPic_Click);
            // 
            // addPic
            // 
            this.addPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.Location = new System.Drawing.Point(87, 813);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(104, 29);
            this.addPic.TabIndex = 16;
            this.addPic.Text = "Add Picture";
            this.addPic.UseVisualStyleBackColor = true;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // piclabel
            // 
            this.piclabel.AutoSize = true;
            this.piclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piclabel.Location = new System.Drawing.Point(83, 774);
            this.piclabel.Name = "piclabel";
            this.piclabel.Size = new System.Drawing.Size(29, 20);
            this.piclabel.TabIndex = 17;
            this.piclabel.Text = "pic";
            // 
            // add_done
            // 
            this.add_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_done.Location = new System.Drawing.Point(178, 309);
            this.add_done.Name = "add_done";
            this.add_done.Size = new System.Drawing.Size(75, 28);
            this.add_done.TabIndex = 11;
            this.add_done.Text = "Add";
            this.add_done.UseVisualStyleBackColor = true;
            this.add_done.Click += new System.EventHandler(this.add_done_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 901);
            this.Controls.Add(this.piclabel);
            this.Controls.Add(this.addPic);
            this.Controls.Add(this.selectPic);
            this.Controls.Add(this.add_todo);
            this.Controls.Add(this.add_done);
            this.Controls.Add(this.date_done);
            this.Controls.Add(this.date_todo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.out_todo);
            this.Controls.Add(this.in_todo);
            this.Controls.Add(this.out_done);
            this.Controls.Add(this.in_done);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox in_done;
        private System.Windows.Forms.RichTextBox out_done;
        private System.Windows.Forms.RichTextBox out_todo;
        private System.Windows.Forms.RichTextBox in_todo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_todo;
        private System.Windows.Forms.DateTimePicker date_done;
        private System.Windows.Forms.Button add_todo;
        private System.Windows.Forms.Button selectPic;
        private System.Windows.Forms.Button addPic;
        private System.Windows.Forms.Label piclabel;
        private System.Windows.Forms.Button add_done;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}