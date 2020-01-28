using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dynamic.Elements.Load.Models
{
    public class ElementsModel
    {
        public int IncrementValue { get; set; }

        public string TestName { get; set; }

        public TemplateModel lstTemplateModels { get; set; }

        public TemplateModel _TemplateModel { get; set; }
    }

    public class TemplateModel
    {
        public string Name { get; set; }

        public bool IsChecked { get; set; }

        public string DropDownValue { get; set; }
    }
}