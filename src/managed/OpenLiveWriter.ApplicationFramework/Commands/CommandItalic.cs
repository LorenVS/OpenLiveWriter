// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;

namespace OpenLiveWriter.ApplicationFramework.Commands
{
	/// <summary>
	/// Summary description for CommandCopy.
	/// </summary>
	public class CommandItalic : Command
	{

		public CommandItalic(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			//
			//
		}

		public CommandItalic()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			//
			//
		}


		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			//
			// CommandItalic
			//
			this.ContextMenuPath = "";
			this.Identifier = "MindShare.ApplicationCore.Commands.Italic";
			this.MainMenuPath = "";
			this.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.Text = "Italic";

		}
		#endregion
	}
}
