﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F19AEFC5531D6DB90433B73F3988E8E8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Common;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using TikzEdt;


namespace TikzEdt {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        internal Common.RecentFileList RecentFileList;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button cmdAbortCompilation;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.CheckBox chkOverlay;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.RichTextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\MainWindow.xaml"
        internal ICSharpCode.AvalonEdit.TextEditor txtCode;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\MainWindow.xaml"
        internal TikzEdt.TikzDisplay tikzDisplay1;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\MainWindow.xaml"
        internal TikzEdt.PdfOverlay pdfOverlay1;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.Primitives.StatusBar statusBar1;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\MainWindow.xaml"
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TikzEdt;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\..\MainWindow.xaml"
            ((TikzEdt.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenCommandHandler);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandHandler);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveAsCommandHandler);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandHandler);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.AlwaysTrue);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 7:
            this.RecentFileList = ((Common.RecentFileList)(target));
            return;
            case 8:
            
            #line 63 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.CompileClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 64 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AbortCompilationClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 88 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CompileClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cmdAbortCompilation = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\MainWindow.xaml"
            this.cmdAbortCompilation.Click += new System.Windows.RoutedEventHandler(this.AbortCompilationClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.chkOverlay = ((System.Windows.Controls.CheckBox)(target));
            
            #line 95 "..\..\..\MainWindow.xaml"
            this.chkOverlay.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\MainWindow.xaml"
            this.chkOverlay.Unchecked += new System.Windows.RoutedEventHandler(this.chkOverlay_Unchecked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtStatus = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 14:
            this.txtCode = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.txtCode.DocumentChanged += new System.EventHandler(this.txtCode_DocumentChanged);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.tikzDisplay1 = ((TikzEdt.TikzDisplay)(target));
            return;
            case 16:
            this.pdfOverlay1 = ((TikzEdt.PdfOverlay)(target));
            return;
            case 17:
            this.statusBar1 = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            case 18:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\MainWindow.xaml"
            this.button1.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
