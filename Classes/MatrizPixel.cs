namespace ComputaçãoGráfica.Classes
{
	class MatrizPixel
	{
		private Pixel[,] pixel;
		private int x, y;

		public MatrizPixel(int x, int y)
		{
			this.x = x;
			this.y = y;
			pixel = new Pixel[x+1, y+1];
		}
        public MatrizPixel(MatrizPixel mp)
        {
            pixel = mp.getPixel(); 
        }
		public void insere(int x, int y, Pixel pix)
		{
			pixel[x, y] = pix;
		}

		public Pixel retira(int x, int y)
		{
			return (x < this.x && y < this.y) ? pixel[x, y] : new Pixel();
		}

        public Pixel[,] getPixel()
        {
            return pixel;
        }           
	}
}