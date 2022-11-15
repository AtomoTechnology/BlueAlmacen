using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolver.Helper
{
    public static class DataListHelper
    {
        public static void SetGrid(DataGridView grid, int withheader, int withbordy = 18)
        {
            grid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", withbordy);

            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            grid.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle column_header_cell_style = new DataGridViewCellStyle();
            column_header_cell_style.BackColor = ColorTranslator.FromHtml("#bfdbff");
            column_header_cell_style.ForeColor = Color.Black;
            column_header_cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column_header_cell_style.Font = new Font("#bfdbff", withheader, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle = column_header_cell_style;
        }
    }
}
