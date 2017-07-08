using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KGViewer
{
    public partial class EventForm : Form
    {
        //Номер текущего изображения
        private int CurImageNum;
        //Список битмапов-изображений
        private List<Bitmap> Images;

        public EventForm()
        {
            InitializeComponent();
            CurImageNum = 0;
            Images = new List<Bitmap>();
        }

        /// <summary>
        /// Наполение формы данными из карточки события
        /// </summary>
        /// <param name="c">Карточка события</param>
        public void Fill(Card c)
        {
            Text = c.Title;
            TitleLabel.Text = c.Title;
            HintTitle.SetToolTip(TitleLabel, c.Title);
            DescrLabel.Text = c.Description;
            CurrentImg.Load(c.Images[0]);
            //Если картинка только одна - отключаем кнопки вперед/назад
            if (c.Images.Count > 1)
            {
                PrevBtn.Enabled = true;
                NextBtn.Enabled = true;
                foreach (var im in c.Images)
                    Images.Add(Methods.GetBMP(im));
            }
            else
            {
                PrevBtn.Enabled = false;
                NextBtn.Enabled = false;
            }
            Body.Text = c.Body;

            if (String.IsNullOrEmpty(c.Age))
                c.Age = "0+";
            if (!c.Age.EndsWith("+"))
                c.Age += "+";
            if (String.IsNullOrEmpty(c.Price))
                c.Price = "бесплатно";

            InfoLabel.Text = String.Format("Возраст: {0}    Цена: {1}", c.Age, c.Price);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CurImageNum++;
            CurImageNum %= Images.Count;
            CurrentImg.Image = Images[CurImageNum];
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            CurImageNum--;
            if (CurImageNum < 0)
                CurImageNum += Images.Count;
            CurrentImg.Image = Images[CurImageNum];
        }
    }
}
