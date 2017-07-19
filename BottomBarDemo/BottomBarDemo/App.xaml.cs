using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BottomBarDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            BottomBarPage bottomBarPage = new BottomBarPage();

            string[] tabTitles = { "Favorites", "Friends", "Nearby", "Recents", "Restaurants" };
            string[] tabColors = { null, "#5D4037", "#7B1FA2", "#FF5252", "#FF9800" };
            int[] tabBadgeCounts = { 0, 1, 5, 3, 4 };
            string[] tabBadgeColors = { "#000000", "#FF0000", "#000000", "#000000", "#000000" };

            for (int i = 0; i < tabTitles.Length; ++i)
            {
                string title = tabTitles[i];
                string tabColor = tabColors[i];
                int tabBadgeCount = tabBadgeCounts[i];
                string tabBadgeColor = tabBadgeColors[i];

                FileImageSource icon = (FileImageSource)FileImageSource.FromFile(string.Format("ic_{0}.png", title.ToLowerInvariant()));

                // create tab page
                if (i == 0)
                {
                    var tabPage = new TabPage()
                    {
                        Title = title,
                        Icon = icon
                    };

                    // set tab color
                    if (tabColor != null)
                    {
                        BottomBarPageExtension.SetTabColor(tabPage, Color.FromHex(tabColor));
                    }
                    // Set badges
                    BottomBarPageExtension.SetBadgeCount(tabPage, tabBadgeCount);
                    BottomBarPageExtension.SetBadgeColor(tabPage, Color.FromHex(tabBadgeColor));

                    // set label based on title
                    tabPage.UpdateLabel();

                    // add tab pag to tab control
                    bottomBarPage.FixedMode = true;
                    bottomBarPage.Children.Add(tabPage);
                }
                else if (i == 1)
                {
                    var tabPage = new TopBarPage()
                    {
                        Title = title,
                        Icon = icon
                    };

                    // set tab color
                    if (tabColor != null)
                    {
                        BottomBarPageExtension.SetTabColor(tabPage, Color.FromHex(tabColor));
                    }
                    // Set badges
                    BottomBarPageExtension.SetBadgeCount(tabPage, tabBadgeCount);
                    BottomBarPageExtension.SetBadgeColor(tabPage, Color.FromHex(tabBadgeColor));

                    // set label based on title
                    //tabPage.UpdateLabel();

                    // add tab pag to tab control
                    bottomBarPage.FixedMode = true;
                    bottomBarPage.Children.Add(tabPage);
                }
                else
                {
                    var tabPage = new ListPage()
                    {
                        Title = title,
                        Icon = icon
                    };

                    // set tab color
                    if (tabColor != null)
                    {
                        BottomBarPageExtension.SetTabColor(tabPage, Color.FromHex(tabColor));
                    }
                    // Set badges
                    BottomBarPageExtension.SetBadgeCount(tabPage, tabBadgeCount);
                    BottomBarPageExtension.SetBadgeColor(tabPage, Color.FromHex(tabBadgeColor));

                    // set label based on title
                    //tabPage.UpdateLabel();

                    // add tab pag to tab control
                    bottomBarPage.FixedMode = true;
                    bottomBarPage.Children.Add(tabPage);
                }
            }

            MainPage = bottomBarPage;
        }
    

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
