// Contributors:  Justin Hutchison (yibbidy@gmail.com)

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Cryption
{
	/// <summary>
	/// Summary description for Cryption.
	/// </summary>
	public class JCrypt4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
		private System.Windows.Forms.PictureBox pictureBox5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public JCrypt4()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(JCrypt4));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(200, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(192, 152);
			this.panel1.TabIndex = 1;
			this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
			this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(192, 152);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 650);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(466, 22);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "JCrypt 4";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(128, 96);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
			this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
			// 
			// panel2
			// 
			this.panel2.AllowDrop = true;
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Location = new System.Drawing.Point(104, 240);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(248, 152);
			this.panel2.TabIndex = 4;
			this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
			this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(248, 152);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
			this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
			this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
			// 
			// panel3
			// 
			this.panel3.AllowDrop = true;
			this.panel3.AutoScroll = true;
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(32, 32);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(128, 96);
			this.panel3.TabIndex = 5;
			this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
			this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel3_DragDrop);
			// 
			// panel4
			// 
			this.panel4.AllowDrop = true;
			this.panel4.AutoScroll = true;
			this.panel4.Controls.Add(this.pictureBox4);
			this.panel4.Location = new System.Drawing.Point(176, 464);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(240, 168);
			this.panel4.TabIndex = 6;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(240, 168);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
			this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "encrypted.png";
			this.saveFileDialog1.Filter = "PNG Files|*.png";
			// 
			// saveFileDialog2
			// 
			this.saveFileDialog2.FileName = "decrypted";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(0, 8);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(240, 144);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// JCrypt4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(466, 672);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "JCrypt4";
			this.Text = "Cryption";
			this.Resize += new System.EventHandler(this.Cryption_Resize);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cryption_MouseDown);
			this.Load += new System.EventHandler(this.Cryption_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Cryption_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cryption_MouseMove);
			this.MouseLeave += new System.EventHandler(this.Cryption_MouseLeave);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void panel_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
			if( e.Data.GetDataPresent(DataFormats.FileDrop, false) == true ) e.Effect = DragDropEffects.All;
		
		}

		string filePath = "";
		private void panel3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if( files.Length > 0 ) {
				filePath = files[0];
				try {
					FileStream fs = new FileStream(filePath, FileMode.Open);
					pictureBox2.Image = new Bitmap(fs);
					fs.Close();
				} catch( Exception ) {
					pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
					pictureBox2.Image = null;
					pictureBox2.Size = new Size(panel3.Width-1, panel3.Height-1);
					pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
					pictureBox2.BackColor = Color.Red;
				}
			}
			Invalidate();
		}

		private void panel1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if( files.Length > 0 ) {
				pictureBox1.Image = new Bitmap(files[0]);
			}
			Invalidate();
		}

		private void panel2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if( files.Length > 0 ) {
				pictureBox1.Image = null;
				filePath = "";
				pictureBox2.Image = null;
				pictureBox3.Image = new Bitmap(files[0]);
			}
			Invalidate();
		}

		private void pictureBox3_DragLeave(object sender, System.EventArgs e) {
			//DoDragDrop("file.txt", DragDropEffects.Copy);
		
		}

		private PointF[] DrawVerticalArrow(PointF begin, int length, bool closed) {
			PointF pt1 = new PointF(begin.X - 10, begin.Y); 
			PointF pt2 = new PointF(pt1.X, pt1.Y+length-20);
			PointF pt3 = new PointF(pt2.X-5, pt2.Y);
			PointF pt4 = new PointF(pt3.X+15, pt3.Y+20);
			PointF pt5 = new PointF(pt4.X+15, pt4.Y-20);
			PointF pt6 = new PointF(pt5.X-5, pt5.Y);
			PointF pt7 = new PointF(pt6.X, pt6.Y-(length-20));

			if( closed ) return new PointF[] { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt1 };
			else return new PointF[] { pt1, pt2, pt3, pt4, pt5, pt6, pt7 };
		}
		private void Cryption_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			PointF pt1 = new PointF(panel2.Left+panel2.Width/4.0f, panel2.Top-60); 
			PointF ptLeft = new PointF(pt1.X-10, pt1.Y);
			PointF ptRight = new PointF(pt1.X+10, pt1.Y);
			PointF[] points = DrawVerticalArrow(pt1, 60, false);
			if( encrypt ) e.Graphics.FillPolygon(Brushes.Yellow, points);
			e.Graphics.DrawLines(Pens.Olive, points);

			PointF beginPoint = new PointF(panel3.Right-panel3.Width/4.0f, panel3.Bottom);
			e.Graphics.DrawLine(Pens.DarkGreen, beginPoint, ptLeft);
		
			beginPoint = new PointF(panel1.Left+panel1.Width/4.0f, panel1.Bottom);
			e.Graphics.DrawLine(Pens.DarkGreen, beginPoint, ptRight);

			pt1 = new PointF((panel4.Left+panel4.Right)/2.0f, panel4.Top-60); 
			ptLeft = new PointF(pt1.X-10, pt1.Y);
			ptRight = new PointF(pt1.X+10, pt1.Y);
			points = DrawVerticalArrow(pt1, 60, true);
			if( decrypt ) e.Graphics.FillPolygon(Brushes.Green, points);
			e.Graphics.DrawLines(Pens.DarkGreen, points);

			beginPoint = new PointF((panel2.Left+panel2.Right)/2.0f, panel2.Bottom);
			e.Graphics.DrawLine(Pens.DarkGreen, beginPoint, pt1);
		
		}

		private void Cryption_Resize(object sender, System.EventArgs e) {
			Invalidate();
		}

		private void Cryption_Load(object sender, System.EventArgs e) {
			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
			UpdateStyles();
		}

		byte[] output;
		private void Cryption_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if( encrypt ) {
				int length = (int)new FileInfo(filePath).Length;
				byte[] data = new byte[length];
				FileStream fs = new FileStream(filePath, FileMode.Open);
				fs.Read(data, 0, length);
				pictureBox3.Image = Encode((Bitmap)pictureBox1.Image, data);
			} else if( decrypt ) {
				output = Decode((Bitmap)pictureBox3.Image);
				MemoryStream ms = new MemoryStream(output);
				try {
					pictureBox4.Image = new Bitmap(ms);
				} catch( Exception ) {
					pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
					pictureBox4.Image = null;
					pictureBox4.Size = new Size(panel4.Width-1, panel4.Height-1);
					pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
					pictureBox4.BackColor = Color.Red;
				}
			}
		}

		bool encrypt = false;
		bool decrypt = false;

		private void Cryption_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			encrypt = decrypt = false;
			if( e.Y>panel1.Bottom && e.Y<panel2.Top ) {
				encrypt = filePath!="" && pictureBox1.Image!=null;
				if( encrypt ) statusBar1.Text = "Click here to perform the encryption";
			} else if( e.Y>panel2.Bottom && e.Y<panel4.Top ) {
				decrypt = pictureBox3.Image != null;
				if( decrypt ) statusBar1.Text = "Click here to perform the decryption";
			} else {
				statusBar1.Text = "";
			}
			Invalidate();
		}

		private void Cryption_MouseLeave(object sender, System.EventArgs e) {
			encrypt = decrypt = false;
			statusBar1.Text = "";
			Invalidate();
		}

		private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			if( null == pictureBox2.Image ) {
				LinearGradientBrush brush = new LinearGradientBrush(pictureBox2.Bounds, Color.FromArgb(200, 0, 0, 200), Color.FromArgb(0, 0, 0, 200), LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(brush, pictureBox2.Bounds);
				if( filePath == "" ) {
					e.Graphics.DrawString("Drop a file here", Font, Brushes.WhiteSmoke, pictureBox2.Bounds);
				} else {
					e.Graphics.DrawString(filePath, Font, Brushes.WhiteSmoke, pictureBox2.Bounds);
				}
			}
		}

		private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			if( null == pictureBox1.Image ) {
				LinearGradientBrush brush = new LinearGradientBrush(pictureBox1.Bounds, Color.FromArgb(200, 0, 0, 200), Color.FromArgb(0, 0, 0, 200), LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(brush, pictureBox1.Bounds);
				e.Graphics.DrawString("Drop an image here", Font, Brushes.WhiteSmoke, pictureBox1.Bounds);
			}
		}

		private void pictureBox3_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			if( null == pictureBox3.Image ) {
				LinearGradientBrush brush = new LinearGradientBrush(pictureBox3.Bounds, Color.FromArgb(200, 0, 0, 200), Color.FromArgb(0, 0, 0, 200), LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(brush, pictureBox3.Bounds);
				e.Graphics.DrawString("Drag an image here.  Click here to save the image.", Font, Brushes.WhiteSmoke, pictureBox3.Bounds);
			}
		}

		private void pictureBox4_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			if( null == pictureBox4.Image ) {
				LinearGradientBrush brush = new LinearGradientBrush(pictureBox4.Bounds, Color.FromArgb(200, 0, 0, 200), Color.FromArgb(0, 0, 0, 200), LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(brush, pictureBox4.Bounds);
				if( null == output ) e.Graphics.DrawString("Click here to save the decrypted output.", Font, Brushes.WhiteSmoke, pictureBox4.Bounds);
				else e.Graphics.DrawString("Decrypted Output", Font, Brushes.WhiteSmoke, pictureBox4.Bounds);
			}
		}

		private void EncodeData(Bitmap decoded, ref Bitmap encoded, ref Random random, ref bool[,] dirty, byte data) {
			int x = 0;
			int y = 0;
			do {
				x = (int)(random.NextDouble()*(decoded.Width-1)/3 - 1);
				y = (int)(random.NextDouble()*(decoded.Height-1)/3 - 1);
			} while( dirty[y, x] );
			dirty[y, x] = true;

			x = x*3 + 1;
			y = y*3 + 1;

			Color average = SpecialAverage(decoded, x, y);
			int sign = 0;
			if( average.R > 128 ) sign = 1;
			else sign = -1;

			int d1 = data/3;
			int d2 = d1 + data%3;

			Color encodedPixel = Color.FromArgb(
				average.R + sign*d1,
				average.G + sign*d1,
				average.B + sign*d2 );

			encoded.SetPixel(x, y, encodedPixel);
		}

		public Bitmap Encode(Bitmap decoded, byte[] data) {
			Bitmap encoded = (Bitmap)decoded.Clone();

			Color c = decoded.GetPixel(decoded.Width-1, decoded.Height-1);
			int seed = decoded.GetPixel(decoded.Width-1, decoded.Height-1).ToArgb();
			Random random = new Random(seed);
			
			bool[,] dirty = new bool[(int)decoded.Height/3, (int)decoded.Width/3];
			for( int y=0; y<dirty.GetLength(0); ++y ) {
				for( int x=0; x<dirty.GetLength(1); ++x ) dirty[y, x] = false;
			}
			// encode length of data
			EncodeData(decoded, ref encoded, ref random, ref dirty, (byte)(data.Length>>24));
			EncodeData(decoded, ref encoded, ref random, ref dirty, (byte)(data.Length>>16));
			EncodeData(decoded, ref encoded, ref random, ref dirty, (byte)(data.Length>>8));
			EncodeData(decoded, ref encoded, ref random, ref dirty, (byte)(data.Length));
			
			// encode data
			foreach( byte b in data ) EncodeData(decoded, ref encoded, ref random, ref dirty, b);
			
			return encoded;
		}

		private byte DecodeData(Bitmap encoded, ref Random random, ref bool[,] dirty) {
			int x = 0;
			int y = 0;
			do {
				x = (int)(random.NextDouble()*(encoded.Width-1)/3 - 1);
				y = (int)(random.NextDouble()*(encoded.Height-1)/3 - 1);
			} while( dirty[y, x] );
			dirty[y, x] = true;

			x = x*3 + 1;
			y = y*3 + 1;

			Color encodedPixel = encoded.GetPixel(x, y);
			Color average = SpecialAverage(encoded, x, y);

			byte decoded = 0;

			int sign = 0;
			if( average.R>128 ) sign = 1;
			else sign = -1;

			decoded += (byte)(sign*encodedPixel.R - sign*average.R);
			decoded += (byte)(sign*encodedPixel.G - sign*average.G);
			decoded += (byte)(sign*encodedPixel.B - sign*average.B);

			return decoded;
		}

		public byte[] Decode(Bitmap encoded) {
			int seed = encoded.GetPixel(encoded.Width-1, encoded.Height-1).ToArgb();
			Random random = new Random(seed);
			
			bool[,] dirty = new bool[(int)encoded.Height/3, (int)encoded.Width/3];
			for( int y=0; y<dirty.GetLength(0); ++y ) {
				for( int x=0; x<dirty.GetLength(1); ++x ) dirty[y, x] = false;
			}

			int length = DecodeData(encoded, ref random, ref dirty);
			length = (length<<8) + DecodeData(encoded, ref random, ref dirty);
			length = (length<<8) + DecodeData(encoded, ref random, ref dirty);
			length = (length<<8) + DecodeData(encoded, ref random, ref dirty);
			byte[] decoded = new byte[length];

			for( int i=0; i<length; ++i ) decoded[i] = DecodeData(encoded, ref random, ref dirty);

			return decoded;
		}

		private Color SpecialAverage(Bitmap bitmap, int x, int y) {
			Color p1 = bitmap.GetPixel(x-1, y-1);
			Color p2 = bitmap.GetPixel(x, y-1);
			Color p3 = bitmap.GetPixel(x+1, y-1);
			Color p4 = bitmap.GetPixel(x-1, y);
			Color p5 = bitmap.GetPixel(x+1, y);
			Color p6 = bitmap.GetPixel(x-1, y+1);
			Color p7 = bitmap.GetPixel(x, y+1);
			Color p8 = bitmap.GetPixel(x+1, y+1);

			int r = Math.Min(Math.Max((128 + p1.R + p2.R + p3.R + p4.R + p5.R + p6.R + p7.R + p8.R) / 9, 87), 168);
			int g = Math.Min(Math.Max((128 + p1.G + p2.G + p3.G + p4.G + p5.G + p6.G + p7.G + p8.G) / 9, 87), 168);
			int b = Math.Min(Math.Max((128 + p1.B + p2.B + p3.B + p4.B + p5.B + p6.B + p7.B + p8.B) / 9, 87), 168);

			return Color.FromArgb(r, g, b);
		}

		private void pictureBox2_MouseEnter(object sender, System.EventArgs e) {
			statusBar1.Text = "Drop the file you want to encryt here";
		}

		private void pictureBox1_MouseEnter(object sender, System.EventArgs e) {
			statusBar1.Text = "Drop the image you want the file encrypted into here";
		}

		private void pictureBox3_MouseEnter(object sender, System.EventArgs e) {
			statusBar1.Text = "Drop an image here to load an encrypted image.  Click to save.  ";
			
		}

		private void pictureBox3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			
		}

		private void pictureBox4_Click(object sender, System.EventArgs e) {
			if( output != null ) {
				if( saveFileDialog2.ShowDialog(this) != DialogResult.OK ) return;
				FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.Create);
				BinaryWriter bw = new BinaryWriter(fs);
				bw.Write(output);
				bw.Close();

			}
		}

		private void pictureBox3_Click(object sender, System.EventArgs e) {
			if( pictureBox3.Image != null ) {
				if( saveFileDialog1.ShowDialog(this) != DialogResult.OK ) return;
				pictureBox3.Image.Save(saveFileDialog1.FileName);
			}
		}

		private void pictureBox4_MouseEnter(object sender, System.EventArgs e) {
			if( output != null ) statusBar1.Text = "Click this image to save the decoded data.";
		
		}

	}
}
