using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace DruggieLibrary
{

    public static class EnumerableExtensionsEx
    {
        public static AutoCompleteStringCollection ToAutoCompleteStringCollection(this IEnumerable<string> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException("enumerable");
            var autocomplete = new AutoCompleteStringCollection();
            foreach (var item in enumerable) autocomplete.Add(item);
            return autocomplete;
        }
    }

    public static class Func
    {
        public static List<string> loadDataSource(Control box, List<IModel> model)
        {
            List<string> dataSource = new List<string>();
            foreach (var m in model)
                dataSource.Add(m.Name);

            if (box is ComboBox)
            {

                ComboBox cb = (ComboBox)box;
                cb.DataSource = dataSource;
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb.Text = String.Empty;
            }

            if (box is TextBox)
            {
                TextBox tb = (TextBox)box;
                tb.AutoCompleteCustomSource = dataSource.ToAutoCompleteStringCollection();
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tb.Text = String.Empty;
            }
            return dataSource;
        }
    }
}
