// Contributors:  Justin Hutchison (yibbidy@gmail.com)

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Cryption
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		[STAThread]
		public static void Main() {
			Application.Run(new Form2()); 		
		}
		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 24);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(75, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel4.Size = new System.Drawing.Size(218, 24);
            this.panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "<Type message to encrypt here>";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(293, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Decrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 350);
            this.panel2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Text in Image Encryption";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form2_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form2_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private Bitmap GenerateRandomImage() {
			Bitmap bitmap = new Bitmap(512, 512, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			Graphics g = Graphics.FromImage(bitmap);

			Random random = new Random(Environment.TickCount);

			for( int i=0; i<100; ++i ) {
				byte[] b = new byte[8];
				random.NextBytes(b);

				Brush brush = new SolidBrush(Color.FromArgb(b[0], b[1], b[2], b[3]));
				Pen pen = new Pen(Color.FromArgb(b[4], b[5], b[6], b[7]));
				float x = (float)random.NextDouble()*bitmap.Width;
				float y = (float)random.NextDouble()*bitmap.Height;
				float width = (float)random.NextDouble()*100;
				float height = (float)random.NextDouble()*100;
				int shape = (int)(random.NextDouble()*5);
				float angle1 = (float)random.NextDouble()*360;
				float angle2 = (float)random.NextDouble()*360;

				switch( shape ) {
					case 0:
						g.FillPie(brush, x, y, width, height, angle1, angle2);
						break;
					case 1:
						g.DrawRectangle(pen, x, y, width, height);
						break;
					case 2:
						g.DrawEllipse(pen, x, y, width, height);
						break;
					case 3:
						g.FillRectangle(brush, x, y, width, height);
						break;
					case 4:
						g.FillEllipse(brush, x, y, width, height);
						break;
					case 5:
						g.DrawPie(pen, x, y, width,  height, angle1, angle2);
						break;
				}
			}

			return bitmap;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			byte[] message = new byte[textBox1.Text.Length];
			int i=0;
			foreach( char c in textBox1.Text ) message[i++] = (byte)c;
			
			pictureBox1.Image = JCrypt.Encode((Bitmap)pictureBox1.Image, message);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Portable Network Graphic File|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                Text = saveFileDialog1.FileName;
            }
		}

		private void button2_Click(object sender, System.EventArgs e) {
			byte[] decodedMessage = JCrypt.Decode((Bitmap)pictureBox1.Image);
			string message = "";
			foreach( byte b in decodedMessage ) message += (char)b;
			textBox1.Text = message;

		}

		private void Form2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
			if( e.Data.GetDataPresent(DataFormats.FileDrop, false) == true ) e.Effect = DragDropEffects.All;
		}

		private void Form2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if( files.Length > 0 ) {
				Text = files[0];
				pictureBox1.Image = new Bitmap(files[0]);
			}
		}

		private void pictureBox1_Click(object sender, System.EventArgs e) {
			pictureBox1.Image = GenerateRandomImage();
		}
	}
}
