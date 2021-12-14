namespace ComputaçãoGráfica.Classes
{
	class Pixel
	{
		int r, g, b, c, m, y;
		double h, s, i;

		public Pixel() {
		
		}

		public void giveRGB(int r, int g, int b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}

		public void giveCMY(int c, int m, int y)
		{
			this.c = c;
			this.m = m;
			this.y = y;
		}

		public void giveHSI(double h, double s, double i)
		{
			this.h = h;
			this.s = s;
			this.i = i;
		}

		public int R { get => r; set => r = value; }
		public int G { get => g; set => g = value; }
		public int B { get => b; set => b = value; }
		public int C { get => c; set => c = value; }
		public int M { get => m; set => m = value; }
		public int Y { get => y; set => y = value; }
		public double H { get => h; set => h = value; }
		public double S { get => s; set => s = value; }
		public double I { get => i; set => i = value; }
	}
}
