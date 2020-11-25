using Ac4y.Annotation;
using System;

namespace CSODataEntityWithTwoCombo
{
    public class Person
    {
        [Ac4yDescription("Az adatbázis által generált érték")]
        [Ac4yExampleValue("2")]
        public int Id { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó név")]
        [Ac4yExampleValue("Nagy Károly")]
        public string Name { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.COMBOBOX)]
        [Ac4yComboboxEntityName("Country")]
        [Ac4yDescription("Az ország neve, ahol a személy lakik")]
        [Ac4yExampleValue("Portugália")]
        public string HomeCountry { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.COMBOBOX)]
        [Ac4yComboboxEntityName("Color")]
        [Ac4yDescription("A személy szemének színe")]
        [Ac4yExampleValue("kék")]
        public string EyeColor { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.DATETIME)]
        [Ac4yDescription("A személy születésidátuma")]
        [Ac4yExampleValue("1990. 02. 02.")]
        public DateTime? BirthDate { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        [Ac4yDescription("A személy tanuló-e vagy sem")]
        [Ac4yExampleValue("true")]
        public bool? Student { get; set; }
    }
}
