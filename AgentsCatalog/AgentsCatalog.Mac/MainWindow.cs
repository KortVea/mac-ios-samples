﻿using System;

using Foundation;
using AppKit;

namespace AgentsCatalog.Mac {
	public partial class MainWindow : NSWindow {
		public MainWindow(IntPtr handle)
			: base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindow(NSCoder coder)
			: base (coder)
		{
		}
	}
}
