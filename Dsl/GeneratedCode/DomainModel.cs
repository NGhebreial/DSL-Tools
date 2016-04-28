﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace ce.GEB_NGN_PCR_Practica1
{
	/// <summary>
	/// DomainModel GEB_NGN_PCR_Practica1DomainModel
	/// Description for ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1
	/// </summary>
	[DslDesign::DisplayNameResource("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel.DisplayName", typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel), "ce.GEB_NGN_PCR_Practica1.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel.Description", typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel), "ce.GEB_NGN_PCR_Practica1.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("fa624d84-4831-44f2-9a9b-75b62bed1fd6")]
	public partial class GEB_NGN_PCR_Practica1DomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// GEB_NGN_PCR_Practica1DomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0xfa624d84, 0x4831, 0x44f2, 0x9a, 0x9b, 0x75, 0xb6, 0x2b, 0xed, 0x1f, 0xd6);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public GEB_NGN_PCR_Practica1DomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(Prototools),
				typeof(Ventana),
				typeof(Menu),
				typeof(MenuItem),
				typeof(PrototoolsHasVentana),
				typeof(MenuHasMenuItem),
				typeof(VentanaHasMenu),
				typeof(GEB_NGN_PCR_Practica1Diagram),
				typeof(CompartmentShape1),
				typeof(CompartmentMenuandItems),
				typeof(global::ce.GEB_NGN_PCR_Practica1.FixUpDiagram),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Prototools), "NombreProyecto", Prototools.NombreProyectoDomainPropertyId, typeof(Prototools.NombreProyectoPropertyHandler)),
				new DomainMemberInfo(typeof(Ventana), "NombreVentana", Ventana.NombreVentanaDomainPropertyId, typeof(Ventana.NombreVentanaPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "NombreMenu", Menu.NombreMenuDomainPropertyId, typeof(Menu.NombreMenuPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "TipoLetraMenu", Menu.TipoLetraMenuDomainPropertyId, typeof(Menu.TipoLetraMenuPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "TamañoLetraMenu", Menu.TamañoLetraMenuDomainPropertyId, typeof(Menu.TamañoLetraMenuPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "ColorLetraMenu", Menu.ColorLetraMenuDomainPropertyId, typeof(Menu.ColorLetraMenuPropertyHandler)),
				new DomainMemberInfo(typeof(MenuItem), "NombreItem", MenuItem.NombreItemDomainPropertyId, typeof(MenuItem.NombreItemPropertyHandler)),
				new DomainMemberInfo(typeof(MenuItem), "TipoLetraItem", MenuItem.TipoLetraItemDomainPropertyId, typeof(MenuItem.TipoLetraItemPropertyHandler)),
				new DomainMemberInfo(typeof(MenuItem), "ColorLetraItem", MenuItem.ColorLetraItemDomainPropertyId, typeof(MenuItem.ColorLetraItemPropertyHandler)),
				new DomainMemberInfo(typeof(MenuItem), "TamañoLetraItem", MenuItem.TamañoLetraItemDomainPropertyId, typeof(MenuItem.TamañoLetraItemPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(PrototoolsHasVentana), "Prototools", PrototoolsHasVentana.PrototoolsDomainRoleId),
				new DomainRolePlayerInfo(typeof(PrototoolsHasVentana), "Ventana", PrototoolsHasVentana.VentanaDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasMenuItem), "Menu", MenuHasMenuItem.MenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasMenuItem), "MenuItem", MenuHasMenuItem.MenuItemDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasMenu), "Ventana", VentanaHasMenu.VentanaDomainRoleId),
				new DomainRolePlayerInfo(typeof(VentanaHasMenu), "Menu", VentanaHasMenu.MenuDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(7);
				createElementMap.Add(typeof(Prototools), 0);
				createElementMap.Add(typeof(Ventana), 1);
				createElementMap.Add(typeof(Menu), 2);
				createElementMap.Add(typeof(MenuItem), 3);
				createElementMap.Add(typeof(GEB_NGN_PCR_Practica1Diagram), 4);
				createElementMap.Add(typeof(CompartmentShape1), 5);
				createElementMap.Add(typeof(CompartmentMenuandItems), 6);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new Prototools(partition, propertyAssignments);
				case 1: return new Ventana(partition, propertyAssignments);
				case 2: return new Menu(partition, propertyAssignments);
				case 3: return new MenuItem(partition, propertyAssignments);
				case 4: return new GEB_NGN_PCR_Practica1Diagram(partition, propertyAssignments);
				case 5: return new CompartmentShape1(partition, propertyAssignments);
				case 6: return new CompartmentMenuandItems(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(3);
				createElementLinkMap.Add(typeof(PrototoolsHasVentana), 0);
				createElementLinkMap.Add(typeof(MenuHasMenuItem), 1);
				createElementLinkMap.Add(typeof(VentanaHasMenu), 2);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new PrototoolsHasVentana(partition, roleAssignments, propertyAssignments);
				case 1: return new MenuHasMenuItem(partition, roleAssignments, propertyAssignments);
				case 2: return new VentanaHasMenu(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "ce.GEB_NGN_PCR_Practica1.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GEB_NGN_PCR_Practica1DomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (GEB_NGN_PCR_Practica1DomainModel.resourceManager == null)
				{
					GEB_NGN_PCR_Practica1DomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(GEB_NGN_PCR_Practica1DomainModel).Assembly);
				}
				return GEB_NGN_PCR_Practica1DomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return GEB_NGN_PCR_Practica1DomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return GEB_NGN_PCR_Practica1DomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (GEB_NGN_PCR_Practica1DomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new GEB_NGN_PCR_Practica1CopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					GEB_NGN_PCR_Practica1DomainModel.copyClosure = copyFilter;
				}
				return GEB_NGN_PCR_Practica1DomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (GEB_NGN_PCR_Practica1DomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new GEB_NGN_PCR_Practica1DeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					GEB_NGN_PCR_Practica1DomainModel.removeClosure = removeFilter;
				}
				return GEB_NGN_PCR_Practica1DomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::ce.GEB_NGN_PCR_Practica1.FixUpDiagram));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::ce.GEB_NGN_PCR_Practica1.FixUpDiagram));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class GEB_NGN_PCR_Practica1DeleteClosure : GEB_NGN_PCR_Practica1DeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public GEB_NGN_PCR_Practica1DeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class GEB_NGN_PCR_Practica1DeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public GEB_NGN_PCR_Practica1DeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::ce.GEB_NGN_PCR_Practica1.PrototoolsHasVentana.VentanaDomainRoleId, true);
			DomainRoles.Add(global::ce.GEB_NGN_PCR_Practica1.MenuHasMenuItem.MenuItemDomainRoleId, true);
			DomainRoles.Add(global::ce.GEB_NGN_PCR_Practica1.VentanaHasMenu.MenuDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class GEB_NGN_PCR_Practica1CopyClosure : GEB_NGN_PCR_Practica1CopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public GEB_NGN_PCR_Practica1CopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class GEB_NGN_PCR_Practica1CopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public GEB_NGN_PCR_Practica1CopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
