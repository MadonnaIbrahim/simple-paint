using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Converters;


namespace paint
{
	public partial class Form1 : Form
	{
		string kind;
		bool draw;
		Graphics g;
		Point pt;
		Point pt1;
		Pen L_pen;
		Pen r_pen;
		int pen_size;
		Color clr;
		Color color;
		string col;
		string final_color;


		List<List<string>>shapes_list = new List<List<string>>();
		List<string> sublist = new List<string>();

		int endx, endy;

		public Form1()
		{
			InitializeComponent();
			g = panel_main.CreateGraphics();
			colorDialog1.Color = Color.Black;
			clr = colorDialog1.Color;
			
			pen_size = 1;
            r_pen = L_pen=new Pen(clr,pen_size);
		}



	   public string getString(Point ptn)
		{
			return string.Format("{0},{1}",ptn.X,ptn.Y);
		}

		public string getrecstring(Rectangle rect)
		{
			return string.Format("{0},{1},{2},{3}",rect.X ,rect.Y,rect.Width,rect.Height);
		}


		public Rectangle display_rect(int detectx,int detecty)
		{
			int x = Math.Min(pt.X,detectx);
			int y = Math.Min(pt.Y,detecty);
			int width = Math.Max(pt.X,detectx) - x;
			int height = Math.Max(pt.Y,detecty) - y;
			Rectangle rect = new Rectangle(x, y, width, height);
			return rect;

		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			shapes_list.Clear();
			sublist.Clear();
			g.Clear(Color.White);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(panel_main.Width, panel_main.Height);
			Rectangle rect = new Rectangle(0, 0, panel_main.Width, panel_main.Height);
			panel_main.DrawToBitmap(bmp, rect);      
			bmp.Save(@"G:\ITI\c#\labs\paint", System.Drawing.Imaging.ImageFormat.Png);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			kind = "Pen";
		}

		private void panel_main_MouseDown(object sender, MouseEventArgs e)
		{
			draw = true;
			pt = new Point(e.X, e.Y);
		}


		private void panel_main_MouseMove(object sender, MouseEventArgs e)
		{

			if (draw)
			{
				pt1 = new Point(e.X, e.Y);
					endx = e.X;
					endy = e.Y;
					pt1 = new Point(endx, endy);
					panel_main.Invalidate();
				}
			}
		private void panel_main_MouseUp_1(object sender, MouseEventArgs e)
		{
			draw = false;

						
			switch (kind)
			{
				case "Circle":
					sublist = new List<string>();
					sublist.Add(kind);
					sublist.Add(getrecstring( display_rect(endx, endy)));
					sublist.Add(clr.ToString());
					MessageBox.Show(clr.ToString());
					sublist.Add(pen_size.ToString());
					shapes_list.Add(sublist);
					break;
				case "Rectangle":
					sublist = new List<string>();
					sublist.Add(kind);
					sublist.Add(getrecstring(display_rect(endx, endy)));
					sublist.Add(clr.ToString());
					MessageBox.Show(clr.ToString());
					sublist.Add(pen_size.ToString());
					shapes_list.Add(sublist);
					break;
				case "Line":
					sublist = new List<string>();
					sublist.Add(kind);
					sublist.Add(getString(pt));
					sublist.Add(getString(pt1));
					sublist.Add(clr.ToString());
					//MessageBox.Show(clr.ToString());
					sublist.Add(pen_size.ToString());
					shapes_list.Add(sublist);
					break;
			}
			panel_main.Invalidate();

		}

		private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			kind = "Rectangle";
		}


		public Point convertToPoint(string str)
		{
			PointConverter pcvrt = new PointConverter();
			Point result = new Point();
			result = (Point)pcvrt.ConvertFromString(str);
			return result;
		}

		public Rectangle convertToRect(string str)
		{
			RectangleConverter pcvrt = new RectangleConverter();
			Rectangle rect = new Rectangle();
		    rect = (Rectangle)pcvrt.ConvertFromString(str);
			return rect;
		}
	

		private void panel_main_Paint(object sender, PaintEventArgs e)
		{
			foreach (var item in shapes_list)
			{
				switch (item[0])
				{
					case "Line":
						{
							col = item[3].Remove(0, 7);
							final_color = col.Remove(col.Length - 1);
							color = Color.FromName(final_color);
							g.DrawLine(new Pen(color,int.Parse(item[4])), convertToPoint(item[1]), convertToPoint(item[2]));
							break;
						}

					case "Rectangle":
						 col = item[2].Remove(0, 7);
						 final_color = col.Remove(col.Length - 1);
						color = Color.FromName(final_color);
						g.DrawRectangle(new Pen(color,int.Parse(item[3])), convertToRect(item[1]));
						break;
					case "Circle":
						col = item[2].Remove(0, 7);
						final_color = col.Remove(col.Length - 1);
						color = Color.FromName(final_color);
						
						g.DrawEllipse(new Pen(color, int.Parse(item[3])), convertToRect(item[1]));
						break;
				}
			}
			switch (kind)
			{
				case "Circle":
			        g.DrawEllipse(r_pen, display_rect(endx, endy));
					break;
				case "Rectangle":
					g.DrawRectangle(r_pen,display_rect(endx,endy));
					break;
				case "Line":
					pt1 = new Point(endx, endy);
					g.DrawLine(L_pen, pt,pt1);
					break;
			}

		}

	

		private void circleToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			kind = "Circle";
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)


		{
			DialogResult result = colorDialog1.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				clr = colorDialog1.Color;
				r_pen=L_pen = new Pen(clr,pen_size);
			}
		}

		private void lineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			kind = "Line";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			pen_size = int.Parse(comboBox1.SelectedItem.ToString());
			r_pen = L_pen = new Pen(clr, pen_size);
		}

		private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			kind = "Triangle";
		}

	}

}


	