// Updated by XamlIntelliSenseFileGenerator 08/03/2024 15:40:24
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4EE509DA0C3D572BDAF91347FEBDD6795649F8FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Learning_WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Learning_WPF
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Learning_WPF;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\MainWindow.xaml"
                    ((Learning_WPF.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.tbxSearch = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.btnSearch = ((System.Windows.Controls.Button)(target));

#line 14 "..\..\..\MainWindow.xaml"
                    this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.cbxFilter = ((System.Windows.Controls.ComboBox)(target));

#line 17 "..\..\..\MainWindow.xaml"
                    this.cbxFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxFilter_SelectionChanged);

#line default
#line hidden
                    return;
                case 5:
                    this.lbxExpenses = ((System.Windows.Controls.ListBox)(target));
                    return;
                case 6:
                    this.tblkTotal = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 7:
                    this.btnAdd = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\..\MainWindow.xaml"
                    this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.btnRemove = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\..\MainWindow.xaml"
                    this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.btnSave = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\..\MainWindow.xaml"
                    this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.btnLoad = ((System.Windows.Controls.Button)(target));

#line 27 "..\..\..\MainWindow.xaml"
                    this.btnLoad.Click += new System.Windows.RoutedEventHandler(this.btnLoad_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.btnShowAll = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\..\MainWindow.xaml"
                    this.btnShowAll.Click += new System.Windows.RoutedEventHandler(this.btnShowAll_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

