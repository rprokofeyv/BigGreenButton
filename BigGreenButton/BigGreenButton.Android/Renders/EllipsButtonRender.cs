using Android.Content;
using BigGreenButton.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(EllipsButtonRender))]
namespace BigGreenButton.Droid.Renders
{
    public class EllipsButtonRender : ButtonRenderer
    {
        public EllipsButtonRender(Context context) : base(context)
        {

        }
    }
}