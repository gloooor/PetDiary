﻿#pragma checksum "..\..\..\Views\ReporlActivity.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A36CF9D2449E6CFD2F2378F58BAA5F67E002878EBCA1495EEA53ABA066801500"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PetDiary;
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


namespace PetDiary {
    
    
    /// <summary>
    /// ReporlActivity
    /// </summary>
    public partial class ReporlActivity : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtlocation;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txthours;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtminutes;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcomment;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butsavepet;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Views\ReporlActivity.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butcancelpet;
        
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
            System.Uri resourceLocater = new System.Uri("/PetDiary;component/views/reporlactivity.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ReporlActivity.xaml"
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
            this.txtlocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txthours = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtminutes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtcomment = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.slider = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.butsavepet = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.butcancelpet = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Views\ReporlActivity.xaml"
            this.butcancelpet.Click += new System.Windows.RoutedEventHandler(this.butcancelpet_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
