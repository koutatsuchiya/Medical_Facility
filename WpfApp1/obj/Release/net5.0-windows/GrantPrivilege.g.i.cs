﻿#pragma checksum "..\..\..\GrantPrivilege.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142051AA571D60F39C3EBE8CA6EAF1349A5B4574"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// GrantPrivilege
    /// </summary>
    public partial class GrantPrivilege : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PriTableToUser;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton puR;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ruR;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pCombo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox rCombo;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tCombo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox wCheck;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\GrantPrivilege.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button grantBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/grantprivilege.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GrantPrivilege.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PriTableToUser = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\GrantPrivilege.xaml"
            this.PriTableToUser.Checked += new System.Windows.RoutedEventHandler(this.PriTableToUser_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.puR = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\..\GrantPrivilege.xaml"
            this.puR.Checked += new System.Windows.RoutedEventHandler(this.puR_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ruR = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\..\GrantPrivilege.xaml"
            this.ruR.Checked += new System.Windows.RoutedEventHandler(this.ruR_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.rCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.tCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.wCheck = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.grantBtn = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\GrantPrivilege.xaml"
            this.grantBtn.Click += new System.Windows.RoutedEventHandler(this.grantBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

