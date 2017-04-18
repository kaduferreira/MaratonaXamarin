using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace MaratonaXamarin.iOSApp.Sources
{
    public class TableViewSource : UITableViewSource
    {
        private List<string> _repositories;

        public TableViewSource(List<string> repositories)
        {
            _repositories = repositories;
        }

        public override nint RowsInSection(UITableView tableview, nint section) => _repositories.Count;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cellName = "TableViewCell";
            var cell = tableView.DequeueReusableCell(cellName);

            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellName);

            cell.TextLabel.Text = _repositories[indexPath.Row];

            return cell;
        }
    }
}