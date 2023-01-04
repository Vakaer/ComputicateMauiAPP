using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputicateMobileAPP.Controls
{
    public class DatePickerControl : DatePicker
    {
        public static readonly BindableProperty EnterTextProperty = BindableProperty
                                                                    .Create(
                                                                    propertyName: "Placeholder", 
                                                                    returnType: typeof(string), 
                                                                    declaringType: typeof(DatePickerControl), 
                                                                    defaultValue: default(string));
        public static readonly BindableProperty PlaceHolderProperty = BindableProperty
                                                                    .Create(
                                                                    propertyName: "PlaceholderColor",
                                                                    returnType: typeof(Color),
                                                                    declaringType: typeof(DatePickerControl),
                                                                    defaultValue: default(string));
        public string Placeholder { get; set; }
        public Color PlaceHolderColor { get; set; }
    }
}
