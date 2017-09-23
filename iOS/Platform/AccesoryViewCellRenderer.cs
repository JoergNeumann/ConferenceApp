using ConferenceApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(AccesoryViewCellRenderer))]

namespace ConferenceApp.iOS
{
    public class AccesoryViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            return cell;
        }
    }
}