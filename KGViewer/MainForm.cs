using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace KGViewer
{
    public partial class MainForm : Form
    {
        //Карточки событий на форме
        private Card[] Cards;
        //Текущая страница на форма, максимальная на форме и страница для запроса
        private int Page, MaxPage, PageAPI;
        //Ответ на запрос в десериализованном виде
        private ResponseString resp;
        //Форма для выбора категорий событий
        private CategoriesForm cf;
        //Подстрока категорий для запроса
        public string categories;

        public MainForm()
        {
            InitializeComponent();
            InitializeCards();
            InitializeStandarts();
        }
        
        public void InitializeStandarts()
        {
            Page = 1;
            PageAPI = 0;
            MaxPage = 0;
            categories = "&categories=";
            CheckPageSet();
        }

        /// <summary>
        /// Инициализация карточек событий
        /// </summary>
        private void InitializeCards()
        {
            Cards = new Card[9];
            for (int i = 0; i < 9; i++)
                Cards[i] = new Card();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    CardsLayout.Controls.Add(Cards[count].Table, j, i);
                    count++;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        /// <summary>
        /// Подтягивание и загрузка событий на форму
        /// </summary>
        private void LoadCards()
        {
            int count = 9 * (Page - 1), pos = 0;
            
            if (MaxPage == 0)
                MaxPage = Methods.GetEventsPage(1, categories).Count / 9 + 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (count / 20 + 1 != PageAPI)
                    {
                        PageAPI = count / 20 + 1;
                        resp = Methods.GetEventsPage(PageAPI, categories);
                    }

                    if (count % 20 < resp.Results.Count)
                        LoadEvent(resp.Results[count % 20], pos);
                    else
                        LoadEvent(null, pos);
                    pos++;
                    count++;
                }
            }
        }

        /// <summary>
        /// Подтягивание полных данных о событии и запись его в i-ую карточку на форме
        /// </summary>
        /// <param name="ev">Информация о событии</param>
        /// <param name="i">Номер карточки на форме</param>
        private void LoadEvent(EventShort ev, int i)
        {
            //Если нет события - не показываем карточку
            if (ev == null)
            {
                Cards[i].NameLabel.Text = "";
                Cards[i].Image.Image = null;
                Cards[i].DateLabel.Text = "";
                Cards[i].Table.Visible = false;
                return;
            }
            else if (!Cards[i].Table.Visible)
                Cards[i].Table.Visible = true;

            //Подтягиваем полную информацию о событии (ибо дата только в полной информации)
            WebRequest request = WebRequest.Create("https://kudago.com/public-api/v1.3/events/" + ev.Id + "/");
            WebResponse response = request.GetResponse();

            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line = stream.ReadLine();
                if (line != null)
                {
                    JObject search = JObject.Parse(line);
                    Card c = Cards[i];

                    c.Title = Methods.FirstToUpper(search["title"].ToString());
                    c.StartDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        .AddSeconds(search["dates"].Children()["start"].ToList()[0].ToObject<int>()).ToLocalTime();
                    c.Description = Methods.CutTags(search["description"].ToString());
                    c.Body = Methods.CutTags(search["body_text"].ToString());
                    c.Images = search["images"].Children()["image"].Select(x => x.ToString()).ToList();
                    c.Age = search["age_restriction"].ToString();
                    c.Price = search["price"].ToString();

                    c.NameLabel.Text = c.Title;
                    c.Image.Load(c.Images[0]);
                    c.DateLabel.Text = c.StartDate.ToString();

                    Hint.SetToolTip(c.NameLabel, c.NameLabel.Text);
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Page++;
            LoadCards();
            CheckPageSet();
            Cursor = Cursors.Arrow;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Page--;
            LoadCards();
            CheckPageSet();
            Cursor = Cursors.Arrow;
        }

        private void CategoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Если форма еще не была создана - создаем
            if (cf == null)
            {
                cf = new CategoriesForm();
                cf.Owner = this;
            }
            cf.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        /// <summary>
        /// Функция для обновления результатов на форме
        /// </summary>
        public void Update()
        {
            Cursor = Cursors.WaitCursor;
            LoadCards();
            Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Проверка всего, что связано с номером страницы
        /// </summary>
        private void CheckPageSet()
        {
            PageLabel.Text = Page.ToString();
            if (Page == 1)
                PrevButton.Enabled = false;
            else
                PrevButton.Enabled = true;
            if (Page == MaxPage)
                NextButton.Enabled = false;
            else
                NextButton.Enabled = true;
            Text = "KudaGo - страница " + Page;
        }


    }
}
