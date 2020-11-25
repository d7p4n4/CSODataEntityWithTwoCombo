using Ac4y.Annotation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSODataEntityWithTwoCombo
{
    public class Country
    {
        [Ac4yDescription("Az adatbázis által generált érték")]
        [Ac4yExampleValue("2")]
        public int Id { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("Az ország neve")]
        [Ac4yExampleValue("Svédország")]
        public string Name { get; set; }
    }
}
