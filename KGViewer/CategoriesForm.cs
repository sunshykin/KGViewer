using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KGViewer
{
    public partial class CategoriesForm : Form
    {
        //Список категорий
        private List<Category> Categories;
        //Контрол-лэйаут для добавления чек-боксов
        private TableLayoutPanel Table;

        public CategoriesForm()
        {
            InitializeComponent();
            LoadList();
            InitializeTable();
            AddCheckBoxes();
        }

        /// <summary>
        /// Загрузка списка категорий
        /// </summary>
        private void LoadList()
        {
            Categories = Methods.GetCategoriesPage();
        }

        /// <summary>
        /// Инициализация лэйаута
        /// </summary>
        private void InitializeTable()
        {
            int c = Categories.Count;
            Table = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset,
                RowCount = c % 2 == 0 ? c / 2 : c / 2 + 1,
                ColumnCount = 2,
                ColumnStyles =
                {
                    new ColumnStyle() {SizeType = SizeType.Percent, Width = 50},
                    new ColumnStyle() {SizeType = SizeType.Percent, Width = 50}
                },
                Dock = DockStyle.Fill,
                AutoScroll = true,
                MaximumSize = new Size(500, 0)
            };
            //Добавляем строки
            for (int i = 0; i < Table.RowCount; i++)
                Table.RowStyles.Add(new RowStyle() {SizeType = SizeType.Absolute, Height = 40});
            //Добавляем в лэйаут на форме
            MainLayout.Controls.Add(Table, 1, 1);
        }

        /// <summary>
        /// Добавление чек-боксов
        /// </summary>
        private void AddCheckBoxes()
        {
            for (int i = 0; i < Categories.Count; i++)
            {
                CheckBox check = new CheckBox()
                {
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Checked = true,
                    Text = Categories[i].Name
                };
                Table.Controls.Add(check, i % 2, i / 2);
            }
        }

        /// <summary>
        /// Получение строки категория для запроса
        /// </summary>
        /// <returns>Строка категорий</returns>
        private string GetString()
        {
            List<string> result = new List<string>();
            foreach (CheckBox ch in Table.Controls)
            {
                //Если чекнута - подтягиваем слаг этой категории
                if (ch.Checked)
                    result.Add(Categories.Find(x => x.Name == ch.Text).Slug);
            }
            return String.Join(",", result);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string res = GetString();
            MainForm main = Owner as MainForm;
            if (main != null)
            {
                main.InitializeStandarts();
                main.categories += res;
                main.Update();
            }
            Hide();
        }

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если окно закрывается пользователем - прячем его
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
