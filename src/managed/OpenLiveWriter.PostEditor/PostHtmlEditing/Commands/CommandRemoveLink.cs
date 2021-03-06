// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;
using OpenLiveWriter.ApplicationFramework;

namespace OpenLiveWriter.PostEditor.PostHtmlEditing.Commands
{
	/// <summary>
	/// Summary description for CommandCopy.
	/// </summary>
	public class CommandRemoveLink : Command
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public CommandRemoveLink(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			//
			//
		}

		public CommandRemoveLink()
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
			// CommandRemoveLink
			//
			this.ContextMenuPath = "&Remove Link@102";
			this.Identifier = "OpenLiveWriter.PostEditor.Commands.PostHtmlEditing.CommandRemoveLink";
			this.MainMenuPath = "&Insert@4/&Remove Link-@300";
			this.MenuText = "&Remove Link";
			this.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.Text = "Remove Link";
			this.VisibleOnMainMenu = false;

		}
		#endregion
	}
}
