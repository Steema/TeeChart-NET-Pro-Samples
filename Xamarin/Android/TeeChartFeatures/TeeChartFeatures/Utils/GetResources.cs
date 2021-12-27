using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TeeChartFeatures.Utils
{
    public class GetResources
    {
        /// <summary>
        /// Devuelve un string de los Resources
        /// </summary>
        /// <param name="identificador"></param>
        /// <returns></returns>
        public static string GetString(int identificador)
        {
            return Application.Context.GetString(identificador);
        }
        /// <summary>
        /// Devuelve un color de los Resources
        /// </summary>
        /// <param name="context"></param>
        /// <param name="identificador"></param>
        /// <returns></returns>
        public static Android.Graphics.Color GetColor(Context context, int identificador)
        {
            return new Android.Graphics.Color(Android.Support.V4.Content.ContextCompat.GetColor(context, identificador));
        }

    }
}