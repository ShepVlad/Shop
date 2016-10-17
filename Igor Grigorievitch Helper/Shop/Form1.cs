using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.DbLayer;
using System.Data.Entity;
using Shop.BusinessLayer;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Shop
{
    public partial class Form1 : Form
    {
        ShopContext context = new ShopContext();
        BindingSource bsCategory = new BindingSource();
        BindingSource bsGood = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Categories.Load();
            context.Goods.Load();
            context.Manufacturers.Load();
            context.Photos.Load();

            bsCategory.DataSource = context.Categories.Local;
            listBoxCategory.DisplayMember = "CategoryName";
            listBoxCategory.ValueMember = "CategoryId";
            listBoxCategory.DataSource = bsCategory;
            int CategoryId = Convert.ToInt32(listBoxCategory.SelectedValue);
            GetGoodsByCategory(CategoryId);

        }

        private void GetGoodsByCategory(int CategoryId)
        {
            bsGood.DataSource = context.Goods.Local.Where(g => g.CategoryId == CategoryId);
            listBoxGood.DisplayMember = "GoodName";
            listBoxGood.ValueMember = "GoodId";
            listBoxGood.DataSource = bsGood;
         
            int count = context.Goods.Local.Where(g => g.CategoryId == CategoryId).Count();
            listBoxGood.Visible = (count > 0);
            groupBoxGoods.Visible = (count > 0);
            btnAddtoCart.Visible = (count > 0);
                
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CategoryId = Convert.ToInt32(listBoxCategory.SelectedValue);
            GetGoodsByCategory(CategoryId);
            //if(context.Goods.Local.Where(g=>g.CategoryId==CategoryId).Count()>0)
            //{
            //    int GoodId = Convert.ToInt32(listBoxGood.SelectedValue);
            //        GetGoodShow(GoodId);
            //}
        }
        private GoodInfo GetGoodInfo(int GoodId)
        {
            SqlParameter parametr = new SqlParameter("@GoodId", GoodId);
            var query = context.Database.SqlQuery<GoodInfo>(@"select top 1 g.GoodId, g.GoodName,
                         CASE
                         when  m.ManufacturerName IS Null Then 'Не задан производитель'
                         ELSE m.ManufacturerName
                         end ManufacturerName
                         ,
                         g.Price,g.GoodCount,
                         Case
                         When p.PhotoPath IS Null Then 'Images\photo.png'
                         Else p.PhotoPath
                         End PhotoPath
                         from dbo.Good g Left Join dbo.Manufacturer m On g.ManufacturerId=m.ManufacturerId
                         Left Join dbo.Photo p ON (g.GoodId=p.GoodId)
                         Where g.GoodId= @GoodId ", parametr);
            GoodInfo tmp = query.FirstOrDefault();
            return tmp;
        }

        private void listBoxGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int GoodId = Convert.ToInt32(listBoxGood.SelectedValue);
            GetGoodShow(GoodId);

        }

        private void GetGoodShow(int GoodId)
        {
            GoodInfo good = GetGoodInfo(GoodId);
            name.Text = good.GoodName;
            Manufacturer.Text = good.ManufacturerName;
            Price.Text = Convert.ToString(good.Price);
            Count.Text = Convert.ToString(good.GoodCount);
            Image img = Image.FromFile(good.PhotoPath);
            pictureBox1.Image = img;
        }


        //#region #Resize image
        private static Image FixedSize(Image image, int Width, int Height, bool needToFill)
        {
            #region много арифметики
            int sourceWidth = image.Width;
            int sourceHeight = image.Height;
            int sourceX = 0;
            int sourceY = 0;
            double destX = 0;
            double destY = 0;

            double nScale = 0;
            double nScaleW = 0;
            double nScaleH = 0;

            nScaleW = ((double)Width / (double)sourceWidth);
            nScaleH = ((double)Height / (double)sourceHeight);
            if (!needToFill)
            {
                nScale = Math.Min(nScaleH, nScaleW);
            }
            else
            {
                nScale = Math.Max(nScaleH, nScaleW);
                destY = (Height - sourceHeight * nScale) / 2;
                destX = (Width - sourceWidth * nScale) / 2;
            }

            if (nScale > 1)
                nScale = 1;

            int destWidth = (int)Math.Round(sourceWidth * nScale);
            int destHeight = (int)Math.Round(sourceHeight * nScale);
            #endregion

            System.Drawing.Bitmap bmPhoto = null;
            try
            {
                bmPhoto = new System.Drawing.Bitmap(destWidth + (int)Math.Round(2 * destX), destHeight + (int)Math.Round(2 * destY));
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("destWidth:{0}, destX:{1}, destHeight:{2}, desxtY:{3}, Width:{4}, Height:{5}",
                    destWidth, destX, destHeight, destY, Width, Height), ex);
            }
            using (System.Drawing.Graphics grPhoto = System.Drawing.Graphics.FromImage(bmPhoto))
            {
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.CompositingQuality = CompositingQuality.HighQuality;
                grPhoto.SmoothingMode = SmoothingMode.HighQuality;

                Rectangle to = new System.Drawing.Rectangle((int)Math.Round(destX), (int)Math.Round(destY), destWidth, destHeight);
                Rectangle from = new System.Drawing.Rectangle(sourceX, sourceY, sourceWidth, sourceHeight);
                //Console.WriteLine("From: " + from.ToString());
                //Console.WriteLine("To: " + to.ToString());
                grPhoto.DrawImage(image, to, from, System.Drawing.GraphicsUnit.Pixel);

                return bmPhoto;
            }
        }
    }
}