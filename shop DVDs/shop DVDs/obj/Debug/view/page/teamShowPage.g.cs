#pragma checksum "..\..\..\..\view\page\teamShowPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7386E8D7250FB6FFC1AB04F26B1B028E5F203C983DDC532C1796F8A5270FE4B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using shop_DVDs.view.page;


namespace shop_DVDs.view.page {
    
    
    /// <summary>
    /// teamShowPage
    /// </summary>
    public partial class teamShowPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\view\page\teamShowPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid top;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\view\page\teamShowPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid contet;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\view\page\teamShowPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\view\page\teamShowPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\view\page\teamShowPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button remove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ень;component/view/page/teamshowpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\view\page\teamShowPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.top = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.contet = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\view\page\teamShowPage.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.edit = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\view\page\teamShowPage.xaml"
            this.edit.Click += new System.Windows.RoutedEventHandler(this.edit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.remove = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\view\page\teamShowPage.xaml"
            this.remove.Click += new System.Windows.RoutedEventHandler(this.remove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

