#pragma checksum "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA3F9BCBFBD5861751F682EAC3A4F80DD4B38B2D1228BCD5ADFDAA7433A399CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using PCVerwaltung.PurchaseWindows;
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


namespace PCVerwaltung.PurchaseWindows {
    
    
    /// <summary>
    /// MonitorPurchWindow
    /// </summary>
    public partial class MonitorPurchWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HerstellerTxtb;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModellTxtb;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuflösungsTxtb;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PreisTxtb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompleteOrderBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/PCVerwaltung;component/purchasewindows/monitorpurchwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
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
            this.HerstellerTxtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ModellTxtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AuflösungsTxtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PreisTxtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CompleteOrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
            this.CompleteOrderBtn.Click += new System.Windows.RoutedEventHandler(this.CompleteBtnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\PurchaseWindows\MonitorPurchWindow.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

