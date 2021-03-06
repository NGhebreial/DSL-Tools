﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using VSTextTemplatingHost = global::Microsoft.VisualStudio.TextTemplating.VSHost;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
	
namespace ce.GEB_NGN_PCR_Practica1
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\10.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(GEB_NGN_PCR_Practica1ExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(GEB_NGN_PCR_Practica1ExplorerToolWindow), Constants.GEB_NGN_PCR_Practica1EditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@GEB_NGN_PCR_Practica1ToolboxTab;ce.GEB_NGN_PCR_Practica1.Dsl.dll", "ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxTab",
					"@VentanaToolboxItem;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					"ce.GEB_NGN_PCR_Practica1.VentanaToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Ventana", 
					"@VentanaToolboxBitmap;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxTab",
					"@MenuToolboxItem;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					"ce.GEB_NGN_PCR_Practica1.MenuToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Menu", 
					"@MenuToolboxBitmap;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxTab",
					"@MenuItemToolboxItem;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					"ce.GEB_NGN_PCR_Practica1.MenuItemToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"MenuItem", 
					"@MenuItemToolboxBitmap;ce.GEB_NGN_PCR_Practica1.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideEditorFactory(typeof(GEB_NGN_PCR_Practica1EditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(GEB_NGN_PCR_Practica1EditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"GEB_NGN_PCR_Practica1", typeof(GEB_NGN_PCR_Practica1EditorFactory))]
	internal abstract partial class GEB_NGN_PCR_Practica1PackageBase : DslShell::ModelingPackage
	{
		protected global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new GEB_NGN_PCR_Practica1EditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			GEB_NGN_PCR_Practica1CommandSet commandSet = new GEB_NGN_PCR_Practica1CommandSet(this);
			commandSet.Initialize();
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			GEB_NGN_PCR_Practica1ClipboardCommandSet clipboardCommandSet = new GEB_NGN_PCR_Practica1ClipboardCommandSet(this);
			clipboardCommandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(GEB_NGN_PCR_Practica1ExplorerToolWindow));

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			this.SetupDynamicToolbox();
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}
	}

}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace ce.GEB_NGN_PCR_Practica1
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", 1)]
	[VSShell::ProvideToolboxItems(1)]
	[VSTextTemplatingHost::ProvideDirectiveProcessor(typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DirectiveProcessor), global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DirectiveProcessor.GEB_NGN_PCR_Practica1DirectiveProcessorName, "A directive processor that provides access to GEB_NGN_PCR_Practica1 files")]
	[global::System.Runtime.InteropServices.Guid(Constants.GEB_NGN_PCR_Practica1PackageId)]
	internal sealed partial class GEB_NGN_PCR_Practica1Package : GEB_NGN_PCR_Practica1PackageBase
	{
	}
}