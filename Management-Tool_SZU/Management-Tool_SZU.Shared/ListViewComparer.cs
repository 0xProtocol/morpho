using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Tool_SZU.Shared
{
    public class ListViewComparer : IComparer
    {

        private int col;
        private SortOrder order;
        public ListViewComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            try
            {
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);

            if (order == SortOrder.Descending)
                returnVal *= -1;
        }
            catch (Exception)
            {
            }

            return returnVal;
        }
    }

    class ListViewItemDateTimeComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemDateTimeComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemDateTimeComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            try
            {
                System.DateTime first =
                        DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                System.DateTime second =
                        DateTime.Parse(((ListViewItem)y).SubItems[col].Text);

                returnVal = DateTime.Compare(first, second);
            }
            catch
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                           ((ListViewItem)y).SubItems[col].Text);
            }

            if (order == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}
