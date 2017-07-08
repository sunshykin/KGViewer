using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KGViewer
{
    public class Card
    {
        //Дата начала события
        public DateTime StartDate;
        //Текстовые значения для детального описания
        public string Title, Description, Body, Age, Price;
        //Список ссылок на изображения
        public List<string> Images;

        //Контролы для котрочки на форме
        public TableLayoutPanel Table;
        public Label NameLabel, DateLabel;
        public PictureBox Image;

        public Card()
        {
            ColumnStyle st = new ColumnStyle() { SizeType = SizeType.Absolute, Width = 30};
            Table = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset, RowCount = 3,
                RowStyles =
                {
                    new RowStyle() { SizeType = SizeType.Absolute, Height = 30 },
                    new RowStyle() { SizeType = SizeType.Percent, Height = 100},
                    new RowStyle() { SizeType = SizeType.Absolute, Height = 15}
                },
                Dock = DockStyle.Fill
            };
            NameLabel = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill};
            Table.Controls.Add(NameLabel, 0, 0);
            Image = new PictureBox() {Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.StretchImage};
            Table.Controls.Add(Image, 0, 1);
            DateLabel = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill};
            Table.Controls.Add(DateLabel, 0, 2);

            //Делегат для события нажатия на карточку
            Action ShowEv = delegate()
            {
                EventForm ef = new EventForm();
                ef.Fill(this);
                ef.Show();
            };

            NameLabel.Click += (s, e) =>{ ShowEv();};
            Image.Click += (s, e) =>{ ShowEv();};
            DateLabel.Click += (s, e) =>{ ShowEv();};
        }
    }
}
