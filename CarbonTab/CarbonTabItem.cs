using System.Windows;
using System.Windows.Controls;

namespace CarbonTab
{
    /// <summary>
    /// A single tab page inside the <see cref="CarbonTabControl"/>
    /// </summary>
    public class CarbonTabItem : TabItem
    {
        /// <summary>
        /// Returns a new instance of <see cref="CarbonTabItem"/>
        /// </summary>
        static CarbonTabItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CarbonTabItem), new FrameworkPropertyMetadata(typeof(CarbonTabItem)));
        }

        /// <summary>
        /// Returns true if this tab item is the first in the tab control
        /// </summary>
        public bool IsFirst
        {
            get => (bool)GetValue(IsFirstProperty);
            set => SetValue(IsFirstProperty, value);
        }

        /// <summary>
        /// Returns true if this tab item is the last in the tab control
        /// </summary>
        public bool IsLast
        {
            get => (bool)GetValue(IsLastProperty);
            set => SetValue(IsLastProperty, value);
        }

        /// <summary>
        /// Returns corner radius to apply to the 
        /// </summary>
        public double CornerRadius
        {
            get => (double) GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsFirst.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsFirstProperty =
            DependencyProperty.Register(nameof(IsFirst), typeof(bool), typeof(CarbonTabItem), new PropertyMetadata(defaultValue: true));

        // Using a DependencyProperty as the backing store for IsLast.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLastProperty =
            DependencyProperty.Register(nameof(IsLast), typeof(bool), typeof(CarbonTabItem), new PropertyMetadata(defaultValue: true));

        // Using a DependencyProperty as the backing store for CornerRadius.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(double), typeof(CarbonTabItem), new PropertyMetadata(default(double)));
    }
}