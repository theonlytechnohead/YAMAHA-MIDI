﻿#pragma checksum "..\..\CreateOSCDevice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "843EF62ED62F51A92F5F59D9ADEC084F86F99C9203E6EBCDDC9A4098785288E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using YAMAHA_MIDI;


namespace YAMAHA_MIDI {
    
    
    /// <summary>
    /// CreateOSCDevice
    /// </summary>
    public partial class CreateOSCDevice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal YAMAHA_MIDI.IPTextBox addressIPTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox listenPort;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sendPort;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CreateOSCDevice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/YAMAHA MIDI;component/createoscdevice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateOSCDevice.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 8 "..\..\CreateOSCDevice.xaml"
            ((YAMAHA_MIDI.CreateOSCDevice)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.addressIPTextBox = ((YAMAHA_MIDI.IPTextBox)(target));
            return;
            case 4:
            this.listenPort = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\CreateOSCDevice.xaml"
            this.listenPort.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.listenPort_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 22 "..\..\CreateOSCDevice.xaml"
            this.listenPort.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sendPort = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\CreateOSCDevice.xaml"
            this.sendPort.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.sendPort_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 23 "..\..\CreateOSCDevice.xaml"
            this.sendPort.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\CreateOSCDevice.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\CreateOSCDevice.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

