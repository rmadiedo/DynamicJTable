using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DynamicJTable
{
    public class DynJTable
    {
        public bool AnimationsEnabled { get; set; }
        public bool ColumnResizable { get; set; }
        public bool ColumnSelectable { get; set; }
        public string DefaultDateFormat { get; set; }
        public string DefaultSorting { get; set; }
        public string DeleteConfirmation { get; set; }
        public bool Multiselect { get; set; }
        public bool MultiSorting { get; set; }
        public bool Paging { get; set; }
        public string PageList { get; set; }
        public int PageSize { get; set; }
        public bool Sorting { get; set; }
        public string Title { get; set; }
        public djtActions Actions { get; set; }
        public List<djtField> Fields { get; set; }

        public DynJTable()
        {
            Actions = new djtActions();
            Fields = new List<djtField>();
        }
    }
}
