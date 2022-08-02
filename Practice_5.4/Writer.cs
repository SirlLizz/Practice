using System;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace Practice_5._4
{
    [Serializable]
    public class Writer
    {

        [Browsable(true)]
        [Description("Имя автора")]
        [DisplayName("ФИО")]
        public string Name { get; set; } = string.Empty;

        [Browsable(true)]
        [Description("Год, в который родился писатель")]
        [DisplayName("Год рождения")]
        public int Year { get; set; }

        [Browsable(true)]
        [Description("Название страны, в которой родился писатель")]
        [DisplayName("Страна")]
        public string Country { get; set; } = string.Empty;

        [Browsable(true)]
        [Description("Количество произведений, написанных писателем")]
        [DisplayName("Кол-во произведений")]
        public int CountBook { get; set; }

        [Browsable(true)]
        [Description("Самое известное произведение")]
        [DisplayName("Самое известное произведение")]
        public string MostFamousBook { get; set; } = string.Empty;

        [XmlIgnore]
        [DisplayName("Фотография")]
        public Image Image { get; set; }

    }
}
