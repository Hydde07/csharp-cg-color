namespace ComputaçãoGráfica
{
	partial class fPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnAbrirImagem = new System.Windows.Forms.Button();
			this.pbDst = new System.Windows.Forms.PictureBox();
			this.pbImg = new System.Windows.Forms.PictureBox();
			this.gbOption = new System.Windows.Forms.GroupBox();
			this.btnMenosMatiz = new System.Windows.Forms.Button();
			this.btnMaisMatiz = new System.Windows.Forms.Button();
			this.btnMenosBrilho = new System.Windows.Forms.Button();
			this.btnMaisBrilho = new System.Windows.Forms.Button();
			this.lbBrilho = new System.Windows.Forms.Label();
			this.tbBrilho = new System.Windows.Forms.TrackBar();
			this.lbMatiz = new System.Windows.Forms.Label();
			this.tbMatiz = new System.Windows.Forms.TrackBar();
			this.btnLuminancia = new System.Windows.Forms.Button();
			this.pInfo = new System.Windows.Forms.Panel();
			this.lbPixel = new System.Windows.Forms.Label();
			this.lbHSI = new System.Windows.Forms.Label();
			this.lbCMY = new System.Windows.Forms.Label();
			this.lbRGB = new System.Windows.Forms.Label();
			this.gbCanais = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pbB = new System.Windows.Forms.PictureBox();
			this.pbG = new System.Windows.Forms.PictureBox();
			this.pbR = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pbY = new System.Windows.Forms.PictureBox();
			this.pbM = new System.Windows.Forms.PictureBox();
			this.pbC = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbI = new System.Windows.Forms.PictureBox();
			this.pbS = new System.Windows.Forms.PictureBox();
			this.pbH = new System.Windows.Forms.PictureBox();
			this.opfAbrir = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbDst)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
			this.gbOption.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbMatiz)).BeginInit();
			this.pInfo.SuspendLayout();
			this.gbCanais.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(813, 678);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(101, 41);
			this.btnLimpar.TabIndex = 106;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnAbrirImagem
			// 
			this.btnAbrirImagem.Location = new System.Drawing.Point(706, 678);
			this.btnAbrirImagem.Name = "btnAbrirImagem";
			this.btnAbrirImagem.Size = new System.Drawing.Size(101, 41);
			this.btnAbrirImagem.TabIndex = 107;
			this.btnAbrirImagem.Text = "Abrir Imagem";
			this.btnAbrirImagem.UseVisualStyleBackColor = true;
			this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
			// 
			// pbDst
			// 
			this.pbDst.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbDst.Location = new System.Drawing.Point(481, 12);
			this.pbDst.Name = "pbDst";
			this.pbDst.Size = new System.Drawing.Size(660, 660);
			this.pbDst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDst.TabIndex = 109;
			this.pbDst.TabStop = false;
			this.pbDst.MouseEnter += new System.EventHandler(this.pbDst_MouseEnter);
			this.pbDst.MouseLeave += new System.EventHandler(this.pbDst_MouseLeave);
			this.pbDst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDst_MouseMove);
			// 
			// pbImg
			// 
			this.pbImg.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbImg.Location = new System.Drawing.Point(149, 12);
			this.pbImg.Name = "pbImg";
			this.pbImg.Size = new System.Drawing.Size(190, 190);
			this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImg.TabIndex = 108;
			this.pbImg.TabStop = false;
			this.pbImg.MouseEnter += new System.EventHandler(this.pbImg_MouseEnter);
			this.pbImg.MouseLeave += new System.EventHandler(this.pbImg_MouseLeave);
			this.pbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseMove);
			// 
			// gbOption
			// 
			this.gbOption.BackColor = System.Drawing.SystemColors.Control;
			this.gbOption.Controls.Add(this.btnMenosMatiz);
			this.gbOption.Controls.Add(this.btnMaisMatiz);
			this.gbOption.Controls.Add(this.btnMenosBrilho);
			this.gbOption.Controls.Add(this.btnMaisBrilho);
			this.gbOption.Controls.Add(this.lbBrilho);
			this.gbOption.Controls.Add(this.tbBrilho);
			this.gbOption.Controls.Add(this.lbMatiz);
			this.gbOption.Controls.Add(this.tbMatiz);
			this.gbOption.Controls.Add(this.btnLuminancia);
			this.gbOption.Location = new System.Drawing.Point(1147, 12);
			this.gbOption.Name = "gbOption";
			this.gbOption.Size = new System.Drawing.Size(234, 707);
			this.gbOption.TabIndex = 110;
			this.gbOption.TabStop = false;
			this.gbOption.Text = "Opções";
			// 
			// btnMenosMatiz
			// 
			this.btnMenosMatiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenosMatiz.Location = new System.Drawing.Point(141, 404);
			this.btnMenosMatiz.Name = "btnMenosMatiz";
			this.btnMenosMatiz.Size = new System.Drawing.Size(28, 46);
			this.btnMenosMatiz.TabIndex = 10;
			this.btnMenosMatiz.Text = "-";
			this.btnMenosMatiz.UseVisualStyleBackColor = true;
			this.btnMenosMatiz.Click += new System.EventHandler(this.btnMenosMatiz_Click);
			// 
			// btnMaisMatiz
			// 
			this.btnMaisMatiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaisMatiz.Location = new System.Drawing.Point(141, 317);
			this.btnMaisMatiz.Name = "btnMaisMatiz";
			this.btnMaisMatiz.Size = new System.Drawing.Size(28, 46);
			this.btnMaisMatiz.TabIndex = 9;
			this.btnMaisMatiz.Text = "+";
			this.btnMaisMatiz.UseVisualStyleBackColor = true;
			this.btnMaisMatiz.Click += new System.EventHandler(this.btnMaisMatiz_Click);
			// 
			// btnMenosBrilho
			// 
			this.btnMenosBrilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenosBrilho.Location = new System.Drawing.Point(34, 404);
			this.btnMenosBrilho.Name = "btnMenosBrilho";
			this.btnMenosBrilho.Size = new System.Drawing.Size(28, 46);
			this.btnMenosBrilho.TabIndex = 8;
			this.btnMenosBrilho.Text = "-";
			this.btnMenosBrilho.UseVisualStyleBackColor = true;
			this.btnMenosBrilho.Click += new System.EventHandler(this.btnMenosBrilho_Click);
			// 
			// btnMaisBrilho
			// 
			this.btnMaisBrilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaisBrilho.Location = new System.Drawing.Point(34, 317);
			this.btnMaisBrilho.Name = "btnMaisBrilho";
			this.btnMaisBrilho.Size = new System.Drawing.Size(28, 46);
			this.btnMaisBrilho.TabIndex = 7;
			this.btnMaisBrilho.Text = "+";
			this.btnMaisBrilho.UseVisualStyleBackColor = true;
			this.btnMaisBrilho.Click += new System.EventHandler(this.btnMaisBrilho_Click);
			// 
			// lbBrilho
			// 
			this.lbBrilho.AutoSize = true;
			this.lbBrilho.Location = new System.Drawing.Point(6, 377);
			this.lbBrilho.Name = "lbBrilho";
			this.lbBrilho.Size = new System.Drawing.Size(45, 13);
			this.lbBrilho.TabIndex = 6;
			this.lbBrilho.Text = "Brilho: 0";
			// 
			// tbBrilho
			// 
			this.tbBrilho.Location = new System.Drawing.Point(73, 78);
			this.tbBrilho.Maximum = 500;
			this.tbBrilho.Name = "tbBrilho";
			this.tbBrilho.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tbBrilho.Size = new System.Drawing.Size(45, 611);
			this.tbBrilho.TabIndex = 5;
			this.tbBrilho.Value = 100;
			this.tbBrilho.ValueChanged += new System.EventHandler(this.TbBrilho_ValueChanged);
			this.tbBrilho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbBrilho_MouseUp);
			// 
			// lbMatiz
			// 
			this.lbMatiz.AutoSize = true;
			this.lbMatiz.Location = new System.Drawing.Point(121, 377);
			this.lbMatiz.Name = "lbMatiz";
			this.lbMatiz.Size = new System.Drawing.Size(48, 13);
			this.lbMatiz.TabIndex = 4;
			this.lbMatiz.Text = "Matiz: 0º";
			// 
			// tbMatiz
			// 
			this.tbMatiz.Location = new System.Drawing.Point(183, 78);
			this.tbMatiz.Maximum = 360;
			this.tbMatiz.Name = "tbMatiz";
			this.tbMatiz.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tbMatiz.Size = new System.Drawing.Size(45, 611);
			this.tbMatiz.TabIndex = 3;
			this.tbMatiz.Value = 180;
			this.tbMatiz.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			this.tbMatiz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbMatiz_MouseUp);
			// 
			// btnLuminancia
			// 
			this.btnLuminancia.Location = new System.Drawing.Point(51, 19);
			this.btnLuminancia.Name = "btnLuminancia";
			this.btnLuminancia.Size = new System.Drawing.Size(133, 36);
			this.btnLuminancia.TabIndex = 0;
			this.btnLuminancia.Text = "Luminância";
			this.btnLuminancia.UseVisualStyleBackColor = true;
			this.btnLuminancia.Click += new System.EventHandler(this.btnLuminancia_Click);
			// 
			// pInfo
			// 
			this.pInfo.BackColor = System.Drawing.SystemColors.Info;
			this.pInfo.Controls.Add(this.lbPixel);
			this.pInfo.Controls.Add(this.lbHSI);
			this.pInfo.Controls.Add(this.lbCMY);
			this.pInfo.Controls.Add(this.lbRGB);
			this.pInfo.Location = new System.Drawing.Point(111, 93);
			this.pInfo.Name = "pInfo";
			this.pInfo.Size = new System.Drawing.Size(213, 66);
			this.pInfo.TabIndex = 111;
			this.pInfo.Visible = false;
			// 
			// lbPixel
			// 
			this.lbPixel.AutoSize = true;
			this.lbPixel.Location = new System.Drawing.Point(35, 7);
			this.lbPixel.Name = "lbPixel";
			this.lbPixel.Size = new System.Drawing.Size(54, 13);
			this.lbPixel.TabIndex = 3;
			this.lbPixel.Text = "Pixel: (x,y)";
			// 
			// lbHSI
			// 
			this.lbHSI.AutoSize = true;
			this.lbHSI.Location = new System.Drawing.Point(3, 46);
			this.lbHSI.Name = "lbHSI";
			this.lbHSI.Size = new System.Drawing.Size(28, 13);
			this.lbHSI.TabIndex = 2;
			this.lbHSI.Text = "HSI:";
			// 
			// lbCMY
			// 
			this.lbCMY.AutoSize = true;
			this.lbCMY.Location = new System.Drawing.Point(3, 33);
			this.lbCMY.Name = "lbCMY";
			this.lbCMY.Size = new System.Drawing.Size(30, 13);
			this.lbCMY.TabIndex = 1;
			this.lbCMY.Text = "CMY";
			// 
			// lbRGB
			// 
			this.lbRGB.AutoSize = true;
			this.lbRGB.Location = new System.Drawing.Point(3, 20);
			this.lbRGB.Name = "lbRGB";
			this.lbRGB.Size = new System.Drawing.Size(33, 13);
			this.lbRGB.TabIndex = 0;
			this.lbRGB.Text = "RGB:";
			// 
			// gbCanais
			// 
			this.gbCanais.BackColor = System.Drawing.SystemColors.Control;
			this.gbCanais.Controls.Add(this.label7);
			this.gbCanais.Controls.Add(this.label8);
			this.gbCanais.Controls.Add(this.label9);
			this.gbCanais.Controls.Add(this.pbB);
			this.gbCanais.Controls.Add(this.pbG);
			this.gbCanais.Controls.Add(this.pbR);
			this.gbCanais.Controls.Add(this.label4);
			this.gbCanais.Controls.Add(this.label5);
			this.gbCanais.Controls.Add(this.label6);
			this.gbCanais.Controls.Add(this.pbY);
			this.gbCanais.Controls.Add(this.pbM);
			this.gbCanais.Controls.Add(this.pbC);
			this.gbCanais.Controls.Add(this.label3);
			this.gbCanais.Controls.Add(this.label2);
			this.gbCanais.Controls.Add(this.label1);
			this.gbCanais.Controls.Add(this.pbI);
			this.gbCanais.Controls.Add(this.pbS);
			this.gbCanais.Controls.Add(this.pbH);
			this.gbCanais.Location = new System.Drawing.Point(8, 223);
			this.gbCanais.Name = "gbCanais";
			this.gbCanais.Size = new System.Drawing.Size(467, 478);
			this.gbCanais.TabIndex = 112;
			this.gbCanais.TabStop = false;
			this.gbCanais.Text = "Canais";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(391, 453);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "B";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(228, 453);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "G";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(62, 453);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(15, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "R";
			// 
			// pbB
			// 
			this.pbB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbB.Location = new System.Drawing.Point(330, 320);
			this.pbB.Name = "pbB";
			this.pbB.Size = new System.Drawing.Size(130, 130);
			this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbB.TabIndex = 14;
			this.pbB.TabStop = false;
			// 
			// pbG
			// 
			this.pbG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbG.Location = new System.Drawing.Point(168, 320);
			this.pbG.Name = "pbG";
			this.pbG.Size = new System.Drawing.Size(130, 130);
			this.pbG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbG.TabIndex = 13;
			this.pbG.TabStop = false;
			// 
			// pbR
			// 
			this.pbR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbR.Location = new System.Drawing.Point(8, 320);
			this.pbR.Name = "pbR";
			this.pbR.Size = new System.Drawing.Size(130, 130);
			this.pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbR.TabIndex = 12;
			this.pbR.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(391, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Y";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(228, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "M";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "C";
			// 
			// pbY
			// 
			this.pbY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbY.Location = new System.Drawing.Point(330, 171);
			this.pbY.Name = "pbY";
			this.pbY.Size = new System.Drawing.Size(130, 130);
			this.pbY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbY.TabIndex = 8;
			this.pbY.TabStop = false;
			// 
			// pbM
			// 
			this.pbM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbM.Location = new System.Drawing.Point(168, 171);
			this.pbM.Name = "pbM";
			this.pbM.Size = new System.Drawing.Size(130, 130);
			this.pbM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbM.TabIndex = 7;
			this.pbM.TabStop = false;
			// 
			// pbC
			// 
			this.pbC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbC.Location = new System.Drawing.Point(6, 171);
			this.pbC.Name = "pbC";
			this.pbC.Size = new System.Drawing.Size(130, 130);
			this.pbC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbC.TabIndex = 6;
			this.pbC.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(391, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(10, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "I";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(228, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "S";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "H";
			// 
			// pbI
			// 
			this.pbI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbI.Location = new System.Drawing.Point(330, 22);
			this.pbI.Name = "pbI";
			this.pbI.Size = new System.Drawing.Size(130, 130);
			this.pbI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbI.TabIndex = 2;
			this.pbI.TabStop = false;
			// 
			// pbS
			// 
			this.pbS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbS.Location = new System.Drawing.Point(168, 22);
			this.pbS.Name = "pbS";
			this.pbS.Size = new System.Drawing.Size(130, 130);
			this.pbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbS.TabIndex = 1;
			this.pbS.TabStop = false;
			// 
			// pbH
			// 
			this.pbH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbH.Location = new System.Drawing.Point(6, 22);
			this.pbH.Name = "pbH";
			this.pbH.Size = new System.Drawing.Size(130, 130);
			this.pbH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbH.TabIndex = 0;
			this.pbH.TabStop = false;
			// 
			// opfAbrir
			// 
			this.opfAbrir.FileName = "openFileDialog1";
			// 
			// fPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1393, 724);
			this.Controls.Add(this.gbCanais);
			this.Controls.Add(this.pInfo);
			this.Controls.Add(this.gbOption);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnAbrirImagem);
			this.Controls.Add(this.pbDst);
			this.Controls.Add(this.pbImg);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "fPrincipal";
			this.Text = "Computação Gráfica";
			this.Load += new System.EventHandler(this.fPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbDst)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
			this.gbOption.ResumeLayout(false);
			this.gbOption.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbBrilho)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbMatiz)).EndInit();
			this.pInfo.ResumeLayout(false);
			this.pInfo.PerformLayout();
			this.gbCanais.ResumeLayout(false);
			this.gbCanais.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnAbrirImagem;
		private System.Windows.Forms.PictureBox pbDst;
		private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.GroupBox gbOption;
		private System.Windows.Forms.Button btnLuminancia;
		private System.Windows.Forms.Panel pInfo;
		private System.Windows.Forms.Label lbHSI;
		private System.Windows.Forms.Label lbCMY;
		private System.Windows.Forms.Label lbRGB;
		private System.Windows.Forms.Label lbMatiz;
		private System.Windows.Forms.TrackBar tbMatiz;
		private System.Windows.Forms.Label lbPixel;
		private System.Windows.Forms.GroupBox gbCanais;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbI;
		private System.Windows.Forms.PictureBox pbS;
		private System.Windows.Forms.PictureBox pbH;
		private System.Windows.Forms.OpenFileDialog opfAbrir;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbB;
		private System.Windows.Forms.PictureBox pbG;
		private System.Windows.Forms.PictureBox pbR;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pbY;
		private System.Windows.Forms.PictureBox pbM;
		private System.Windows.Forms.PictureBox pbC;
		private System.Windows.Forms.Button btnMenosMatiz;
		private System.Windows.Forms.Button btnMaisMatiz;
		private System.Windows.Forms.Button btnMenosBrilho;
		private System.Windows.Forms.Button btnMaisBrilho;
		private System.Windows.Forms.Label lbBrilho;
		private System.Windows.Forms.TrackBar tbBrilho;
	}
}

