using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OSIsoft.DataViews;

namespace DataViews
{
    public static class FieldExtension
    {
        public static Field Clone(this Field field)
        {
            if (field == null)
                throw new ArgumentNullException(nameof(field));

            Field newField = new Field();

            newField.Source = field.Source;
            newField.IncludeUom = field.IncludeUom;
            newField.Label = field.Label;
            newField.SummaryDirection = field.SummaryDirection;
            newField.SummaryType = field.SummaryType;
            ((List<string>)newField.Keys).AddRange(field.Keys);
            ((List<string>)newField.StreamReferenceNames).AddRange(field.StreamReferenceNames);

            return newField;
        }
    }
}
