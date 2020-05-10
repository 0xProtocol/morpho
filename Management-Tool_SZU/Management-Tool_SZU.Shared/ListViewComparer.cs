using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Tool_SZU.Shared
{
    /// <summary>
    /// Class ListViewComparer to sort items form a listview
    /// </summary>
    public class ListViewComparer : IComparer
    {

        private int col;
        private SortOrder order;

        /// <summary>
        /// Constructor of the class ListViewComparer
        /// </summary>
        public ListViewComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        /// <summary>
        /// Constructor of the class ListViewComparer
        /// </summary>
        /// <param name="column"></param>
        /// <param name="order"></param>
        public ListViewComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        /// <summary>
        /// Compares two listview items
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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

    /// <summary>
    /// Class ListViewItemDateTimeComparer to sort items form a listview by DateTime
    /// </summary>
    class ListViewItemDateTimeComparer : IComparer
    {
        private int col;
        private SortOrder order;

        /// <summary>
        /// Constructor of the class ListViewItemDateTimeComparer
        /// </summary>
        public ListViewItemDateTimeComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        /// <summary>
        /// Constructor of the class ListViewItemDateTimeComparer
        /// </summary>
        public ListViewItemDateTimeComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        /// <summary>
        /// Compares two listview items
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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
