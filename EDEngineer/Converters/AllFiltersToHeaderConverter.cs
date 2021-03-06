using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using EDEngineer.Filters;

namespace EDEngineer.Converters
{
    public class AllFiltersToHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var builder = new StringBuilder();

            switch ((string) parameter)
            {
                case "Engineer":
                    builder.Append("Engineer Filter");
                    break;
                case "Grade":
                    builder.Append("Grade Filter");
                    break;
                case "Type":
                    builder.Append("Type Filter");
                    break;
                case "Craftable":
                    builder.Append("Craftable Filter");
                    break;
                case "IgnoredAndFavorite":
                    builder.Append("Ignored And Favorite Filter");
                    break;
                default:
                    throw new NotImplementedException();
            }
            var filters = (IEnumerable<BlueprintFilter>) value;

            builder.Append($" ({filters.Count(f => !f.Magic && f.Checked)}/{filters.Count(f => !f.Magic)})");

            return builder.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}