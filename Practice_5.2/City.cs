using System.ComponentModel;
using System.Drawing;

namespace Practice_5._2
{
    public class City
    {

        [Browsable(true)]
        [Description("Название страны")]
        [DisplayName("Название")]
        public string Name { get; set; } = "";

        [Browsable(true)]
        [Description("Количество человек, проживаюших в городе")]
        [DisplayName("Популяция")]
        public int Population { get; set; }

        [Browsable(true)]
        [Description("Название страны, в которой находится город")]
        [DisplayName("Страна")]
        public string Country { get; set; }

        [Browsable(true)]
        [Description("Указывает, сколкьо лет прошло с первого упоминания города")]
        [DisplayName("Возраст")]
        public int CityAge { get; set; }

        [Browsable(true)]
        [Description("Количество улиц в выбранном городе")]
        [DisplayName("Количество улиц")]
        public int CountStreet { get; set; }

        [DisplayName("Фотография")]
        public Image Image { get; set; }

    }
}
