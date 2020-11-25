using Ac4y.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSODataEntityWithTwoCombo
{
    public class Color
    {
        [Ac4yDescription("Az adatbázis által generált érték")]
        [Ac4yExampleValue("2")]
        public int Id { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A szín neve")]
        [Ac4yExampleValue("zöld")]
        public string Name { get; set; }
    }
}
