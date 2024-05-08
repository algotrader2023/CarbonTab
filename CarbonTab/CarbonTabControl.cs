using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarbonTab
{
    /// <summary>
    /// A custom TabControl implementation
    /// </summary>
    public class CarbonTabControl : TabControl
    {
        /// <summary>
        /// Returns a new instance of <see cref="CarbonTabControl"/>
        /// </summary>
        static CarbonTabControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CarbonTabControl), new FrameworkPropertyMetadata(typeof(CarbonTabControl)));
        }

        /// <summary>
        /// Update the left and right tab item
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            int itemCount = Items.Count;
            int index = 0;
            foreach(object tabItem in Items)
            {
                if(tabItem is CarbonTabItem)
                {
                    CarbonTabItem _tabItem = tabItem as CarbonTabItem;
                    if (index == 0)
                    {
                        _tabItem.IsFirst = true;
                        _tabItem.IsLast = false;
                    }
                    else if (index == (itemCount - 1))
                    {
                        _tabItem.IsFirst = false;
                        _tabItem.IsLast = true;
                    }
                    else
                    {
                        _tabItem.IsFirst = _tabItem.IsLast = false;
                    }
                }
                index++;
            }
        }


        public HorizontalAlignment TabPanelHAlign
        {
            get { return (HorizontalAlignment)GetValue(TabPanelHAlignProperty); }
            set { SetValue(TabPanelHAlignProperty, value); }
        }

        public VerticalAlignment TabPanelVAlign
        {
            get { return (VerticalAlignment) GetValue(TabPanelVAlignProperty); }
            set { SetValue(TabPanelVAlignProperty, value); }
        }

        public Brush SelectedTabBrush
        {
            get { return (Brush)GetValue(SelectedTabBrushProperty); }
            set { SetValue(SelectedTabBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TabPanelHAlign.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TabPanelHAlignProperty =
            DependencyProperty.Register(nameof(TabPanelHAlign), typeof(HorizontalAlignment), typeof(CarbonTabControl), new PropertyMetadata(defaultValue: HorizontalAlignment.Left));


        // Using a DependencyProperty as the backing store for TabPanelHAlign.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TabPanelVAlignProperty =
            DependencyProperty.Register(nameof(TabPanelVAlign), typeof(VerticalAlignment), typeof(CarbonTabControl), new PropertyMetadata(defaultValue: VerticalAlignment.Top));
                

        // Using a DependencyProperty as the backing store for SelectedTabBrush.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedTabBrushProperty =
            DependencyProperty.Register(nameof(SelectedTabBrush), typeof(Brush), typeof(CarbonTabControl), new PropertyMetadata(defaultValue: Brushes.Gray));

    }
}
