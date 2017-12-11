using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Trimer
{
    public partial class Form1 : Form
    {

        string OriginFilePath;
        string SaveDirPath;


        public Form1()
        {
            InitializeComponent();

            this.OriginFilePath = @"C:\Users\USER\Downloads\Hydrangeas.jpg";
            SetOriginImage(OriginFilePath);

            this.SaveDirPath = @"C:\Users\USER\Desktop\trimed";
            //UpdateSaveDir();

        }

        void SetOriginImage(string origin_file_path)
        {
            this.OriginFilePath = origin_file_path;
            this.label_LoadImage.Text = this.OriginFilePath;
            this.pictureBox_OriginImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox_OriginImage.Image = Image.FromFile(this.OriginFilePath);
        }

        void UpdateSaveDir()
        {


        }


        ////////////////////////////////////////////////////
        // サブルーチン

        // 幅w、高さhのImageオブジェクトを作成
        Image createThumbnail(Image image, int w, int h)
        {
            Bitmap canvas = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, w, h);

            float fw = (float)w / (float)image.Width;
            float fh = (float)h / (float)image.Height;

            float scale = Math.Min(fw, fh);
            fw = image.Width * scale;
            fh = image.Height * scale;

            g.DrawImage(image, (w - fw) / 2, (h - fh) / 2, fw, fh);
            g.Dispose();

            return canvas;
        }


        private void button_LoadImage_Click(object sender, EventArgs e)
        {

            // 1. Load Image
            // 2. Show Image Info



            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.html";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            //ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            //ofd.Filter = "Imageファイル(*.html;*.htm)|*.jpg;*.jpeg|すべてのファイル(*.*)|*.*";
            ofd.Filter = "画像ファイル(*.png,*.jpg,*.bmp,*.gif)|*.png;*.jpg;*.bmp;*.gif|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);
                // Origin画像をセット
                this.SetOriginImage(ofd.FileName);
            }


        }

        // crop using Graphics object
        Bitmap Crop1(Bitmap image)
        {
            Bitmap dest = new Bitmap(200, 150, image.PixelFormat);
            Graphics g = Graphics.FromImage(dest);
            Rectangle srcRect = new Rectangle(50, 80, 200, 150);
            Rectangle desRect = new Rectangle(0, 0, 200, 150);
            g.DrawImage(image, desRect, srcRect, GraphicsUnit.Pixel);
            g.Dispose();
            return dest;
        }

        // crop using Bitmap.Clone method
        Bitmap Crop2(Bitmap image, int w, int h, int x, int y)
        {
            Rectangle rect = new Rectangle(x, y, w, h);
            return image.Clone(rect, image.PixelFormat);
        }

        private async void button_Triming_Click(object sender, EventArgs e)
        {

            int stride = (int)numericUpDown1.Value;
            int Wt = 224;
            int Ht = 224;

            Bitmap imgSrc = new Bitmap(this.OriginFilePath);

            int Wo = imgSrc.Width;
            int Ho = imgSrc.Height;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int cnt = 0;

            await Task.Run(() =>
            {
                // 
                // ここで重たい処理をする
                // 
                // 

                for (int x = 0; x < (Wo - Wt); x += stride)
                {
                    for (int y = 0; y < (Ho - Ht); y += stride)
                    {
                        //this.textBox_Debug.Text = $"x{x},y{y} start";

                        string savefilename = $"_{Wt}x{Ht}s{stride}_x{x}y{y}.jpg";
                        string SaveFilePath = Path.Combine(SaveDirPath, Path.GetFileName(OriginFilePath) + savefilename);

                        imgSrc = new Bitmap(this.OriginFilePath);

                        Bitmap imgDst = Crop2(imgSrc, Wt, Ht, x, y);

                        //Bitmap imgDst = image2(imgSrc);
                        imgDst.Save(SaveFilePath, ImageFormat.Jpeg);
                        imgDst.Dispose();
                        imgSrc.Dispose();


                        this.BeginInvoke(new Action(() =>
                        {
                            this.textBox_Debug.Text = $"{cnt} :: x{x},y{y} {sw.ElapsedMilliseconds}ms";
                        }), null);

                        cnt++;

                    }
                }

            });

            sw.Stop();
            this.textBox_Debug.Text = $"{cnt}: Elapsed time = {sw.ElapsedMilliseconds} ms";


        }

        private void button_SaveDir_Click(object sender, EventArgs e)
        {

            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                Console.WriteLine(fbd.SelectedPath);
                this.label_Savedir.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("正しいディレクトリを選択してください");
                return;
            }

            this.SaveDirPath = fbd.SelectedPath;
            imageList1.Images.Clear();
            listView_TrimedImages.Clear();


        }

        private void button_ListUpdate_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////
            string imageDir = this.SaveDirPath;
            string[] jpgFiles = System.IO.Directory.GetFiles(imageDir, "*.jpg");

            int width = 50;
            int height = 50;

            // 初期化
            imageList1.ImageSize = new Size(width, height);
            listView_TrimedImages.LargeImageList = imageList1;


            for (int i = 0; i < jpgFiles.Length; i++)
            {

                if (imageList1.Images.ContainsKey(Path.GetFileName(jpgFiles[i])))
                {
                    continue;
                }

                Image original = Bitmap.FromFile(jpgFiles[i]);
                Image thumbnail = createThumbnail(original, width, height);

                //imageList1.Images.Add(thumbnail);
                imageList1.Images.Add(Path.GetFileName(jpgFiles[i]), thumbnail);
                listView_TrimedImages.Items.Add(Path.GetFileName(jpgFiles[i]), i);

                original.Dispose();
                thumbnail.Dispose();
            }
        }
    }
}
