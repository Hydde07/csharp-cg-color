using ComputaçãoGráfica.Classes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ComputaçãoGráfica
{
	public partial class fPrincipal : Form
	{
		private Image imagemOriginal;
		private Image image;
		private Image imageSecond;
		private Bitmap imageBitmap;
		private Bitmap imageBitmap2;
		private MatrizPixel matrizImg;
		private MatrizPixel matrizDst;
        private MatrizPixel matrizOriginal;
		private int padrao;

		public fPrincipal()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
		}

		Bitmap ResizeImage(Image image, int width, int height)
		{
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}
			return destImage;
		}

		private void pbImg_MouseEnter(object sender, EventArgs e)
		{
			pInfo.Visible = true;
		}

		private void pbImg_MouseLeave(object sender, EventArgs e)
		{
			pInfo.Visible = false;
		}

		private void pbImg_MouseMove(object sender, MouseEventArgs e)
		{
            Pixel pix;
			Point p = this.PointToClient(Cursor.Position);
			int x = p.X - pbImg.Location.X, y = p.Y - pbImg.Location.Y;
            p.Y-= pInfo.Height*(p.Y + pInfo.Height + 10 >= gbCanais.Location.Y? 1:0);
			pInfo.Location = p;

			try
			{
                pix = matrizImg.retira(x,y);
		        lbPixel.Text = "Pixel(" + x + "," + y + ")";
				lbRGB.Text = "RGB: (" + pix.R + "; " + pix.G + "; " + pix.B + ")";
				lbCMY.Text = "CMY: (" + pix.C + "; " + pix.M + "; " + pix.Y + ")";
				lbHSI.Text = "HSI: (" + Math.Round(pix.H, 2) + "; " + Math.Round(pix.S, 2) + "; " + Math.Round(pix.I, 2) + ")";
			}
			catch(Exception ex){ Console.WriteLine(ex.Message); }
		}

		private void pbDst_MouseEnter(object sender, EventArgs e)
		{
			pInfo.Visible = true;
		}

		private void pbDst_MouseLeave(object sender, EventArgs e)
		{
			pInfo.Visible = false;
		}

		private void pbDst_MouseMove(object sender, MouseEventArgs e)
		{
			Point p = this.PointToClient(Cursor.Position);
			int x = p.X - pbDst.Location.X, y = p.Y - pbDst.Location.Y;
			p.X -= pInfo.Width * ((p.X + pInfo.Width + 10 >= gbOption.Location.X)?1:0);
			pInfo.Location = p;

			try
			{
				lbPixel.Text = "Pixel(" + x + "," + y + ")";
				lbRGB.Text = "RGB: (" + matrizDst.retira(x, y).R + "; " + matrizDst.retira(x, y).G + "; " + matrizDst.retira(x, y).B + ")";
				lbCMY.Text = "CMY: (" + matrizDst.retira(x, y).C + "; " + matrizDst.retira(x, y).M + "; " + matrizDst.retira(x, y).Y + ")";
				lbHSI.Text = "HSI: (" + Math.Round(matrizDst.retira(x, y).H,2) + "; " + Math.Round(matrizDst.retira(x, y).S, 2) + "; " + Math.Round(matrizDst.retira(x, y).I, 2) + ")";
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void fPrincipal_Load(object sender, EventArgs e)
		{
			matrizImg = new MatrizPixel(pbImg.Width,pbImg.Height);
			matrizDst = new MatrizPixel(pbImg.Width, pbImg.Height);
            matrizOriginal = new MatrizPixel(pbImg.Width, pbImg.Height);
			disableSystem();
		}

		private void disableSystem()
		{
			pbDst.Enabled = false;
			pbImg.Enabled = false;

			btnLimpar.Enabled = false;

			gbOption.Enabled = false;
			gbCanais.Enabled = false;

			padrao = 180;
			tbMatiz.Value = 180;

			pbImg.Image = null;
			pbDst.Image = null;

            lbBrilho.Text = "Brilho: 100%";
            tbBrilho.Value = 100;
        }

		private void enableSystem()
		{
			pbDst.Enabled = true;
			pbImg.Enabled = true;

			btnLimpar.Enabled = true;

			gbCanais.Enabled = true;
			gbOption.Enabled = true;
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limpador();
		}

		private void limpador()
		{
			fazImagem();
            Smooth();

		}

        private void Smooth()
        {
            Bitmap imgDest = new Bitmap(imageSecond);
            Bitmap imageBitmap2 = (Bitmap)imageSecond;
            Metodos.passaLimpo(imageBitmap2, imgDest);
           
            pbDst.Image = imgDest;
            imageSecond = imgDest;
        }

		private void btnAbrirImagem_Click(object sender, EventArgs e)
		{
			opfAbrir.FileName = "";
			opfAbrir.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
			if (opfAbrir.ShowDialog() == DialogResult.OK)
			{
				imagemOriginal = Image.FromFile(opfAbrir.FileName);
				fazImagem();
				enableSystem();
                Smooth();
			}
		}

		private void fazImagem()
		{
			imageSecond = ResizeImage(imagemOriginal, pbDst.Width, pbDst.Height);
			image = ResizeImage(imagemOriginal, pbImg.Width, pbImg.Height);
			pbImg.Image = image;
			pbDst.Image = image;
			imageBitmap = (Bitmap)image;
			imageBitmap2 = (Bitmap)imageSecond;
			padrao = 180;
			tbMatiz.Value = 180;
            tbBrilho.Value = 100;
			matrizImg = Metodos.preenchePixel(imageBitmap);
			matrizDst = Metodos.preenchePixel(imageBitmap2);
            matrizOriginal = Metodos.preenchePixel(imageBitmap2);
            geraIsolados();
		}

		private void btnLuminancia_Click(object sender, EventArgs e)
		{
			Bitmap imgDest = new Bitmap(imageSecond);
			Bitmap imageBitmap2 = (Bitmap)imageSecond;
			Metodos.luminancia(imageBitmap2, imgDest);
			alteraImgDest(imgDest);
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			int val = tbMatiz.Value - 180;
			if (val>0)
				lbMatiz.Text = "Matiz: +" + val + "º";
			else
				lbMatiz.Text = "Matiz: " + val + "º";
		}

		private void tbMatiz_MouseUp(object sender, MouseEventArgs e)
		{
			newMatizBrilho();
		}

		private void geraIsolados()
		{
			Bitmap imgR = new Bitmap(imageSecond);
			imageBitmap = (Bitmap)imageSecond;
			Metodos.isolaR(imgR,matrizDst);
			pbR.Image = imgR;

			Bitmap imgG = new Bitmap(imageSecond);
			Metodos.isolaG(imgG, matrizDst);
			pbG.Image = imgG;

			Bitmap imgB = new Bitmap(imageSecond);
			Metodos.isolaB(imgB, matrizDst);
			pbB.Image = imgB;

			Bitmap imgC = new Bitmap(imageSecond);
			Metodos.isolaC(imgC, matrizDst);
			pbC.Image = imgC;

			Bitmap imgM = new Bitmap(imageSecond);
			Metodos.isolaM(imgM, matrizDst);
			pbM.Image = imgM;

			Bitmap imgY = new Bitmap(imageSecond);
			Metodos.isolaY(imgY, matrizDst);
			pbY.Image = imgY;

            Bitmap imgH = new Bitmap(imageSecond);
            Metodos.isolaH(imgH, matrizDst);
            pbH.Image = imgH;

            Bitmap imgS = new Bitmap(imageSecond);
            Metodos.isolaS(imgS, matrizDst);
            pbS.Image = imgS;

            Bitmap imgI = new Bitmap(imageSecond);
            Metodos.isolaI(imgI, matrizDst);
            pbI.Image = imgI;
        }

        private void newMatizBrilho()
		{
			int val =  tbMatiz.Value - 180;
			int val2 = tbBrilho.Value;
			Console.WriteLine("Val = " + val + "   ValorReal=" + tbMatiz.Value + "     Padrao=" + padrao);
			Bitmap imgDest = new Bitmap(imageSecond);
			Metodos.mudaMatiz(imgDest, val, matrizOriginal);
			matrizDst = Metodos.preenchePixel(imgDest);
			Metodos.mudaBrilho(imgDest, val2, matrizDst);
			alteraImgDest(imgDest);
		}

		private void alteraImgDest(Bitmap imgDest)
		{
			matrizDst = Metodos.preenchePixel(imgDest);
			pbDst.Image = imgDest;
			imageSecond = imgDest;
			padrao = tbMatiz.Value;
			geraIsolados();
		}

		private void btnMaisMatiz_Click(object sender, EventArgs e)
		{
			tbMatiz.Value = tbMatiz.Value + 10;
			newMatizBrilho();
		}

		private void btnMenosMatiz_Click(object sender, EventArgs e)
		{
			tbMatiz.Value = tbMatiz.Value - 10;
			newMatizBrilho();
		}

        private void TbBrilho_ValueChanged(object sender, EventArgs e)
        {
            lbBrilho.Text = "Brilho: "+ (tbBrilho.Value) + "%";
        }

        private void TbBrilho_MouseUp(object sender, MouseEventArgs e)
        {
			newMatizBrilho();
        }

		private void btnMaisBrilho_Click(object sender, EventArgs e)
		{
			tbBrilho.Value = tbBrilho.Value + 10;
			newMatizBrilho();
		}

		private void btnMenosBrilho_Click(object sender, EventArgs e)
		{
			tbBrilho.Value = tbBrilho.Value - 10;
			newMatizBrilho();
		}
	}
}
