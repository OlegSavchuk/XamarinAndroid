using Android.Widget;
using System.Collections.ObjectModel;
using Android.App;
using Android.Views;

namespace App1
{
	public class SimpleAdapter : BaseAdapter<string>
	{
		protected string[] m_aStrings;
		protected Activity m_oActivity;

		public SimpleAdapter(Activity oActivity, string[] aStrings) : base()
		{
			this.m_oActivity = oActivity;

			this.m_aStrings = aStrings;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override string this[int position]
		{
			get { return (m_aStrings[position]); }
		}
		public override int Count
		{
			get { return (m_aStrings.Length); }
		}
		public override View GetView(int nPosition, View oConvertView, ViewGroup oParent)
		{
			// re-use an existing view, if one is available
			View oView = oConvertView;

			// otherwise create a new one
			if (oView == null)
			{
				oView = m_oActivity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleSpinnerDropDownItem, null);
			}

			TextView oTextView = null;

			oTextView = oView.FindViewById<TextView>(Android.Resource.Id.Text1);
			oTextView.Text = m_aStrings[nPosition];

			return (oView);
		}
	}
}

