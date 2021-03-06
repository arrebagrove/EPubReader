﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ePubReader.Controls
{
    /// <summary>
    /// Items control class to display EPubContainer items
    /// </summary>
    public class EPubItemsControl : ItemsControl
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new EPubItemContainer();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is EPubItemContainer;
        }
    }
}
