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

[module: global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1Diagram")]

namespace ce.GEB_NGN_PCR_Practica1
{
	/// <summary>
	/// DomainClass GEB_NGN_PCR_Practica1Diagram
	/// Description for ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1Diagram
	/// </summary>
	[DslDesign::DisplayNameResource("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1Diagram.DisplayName", typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel), "ce.GEB_NGN_PCR_Practica1.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1Diagram.Description", typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel), "ce.GEB_NGN_PCR_Practica1.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1DomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("8cddf9e7-0088-4111-b590-586e600d1466")]
	public partial class GEB_NGN_PCR_Practica1Diagram : DslDiagrams::Diagram
	{
		#region Diagram boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		#endregion
		#region Toolbox filters
		private static global::System.ComponentModel.ToolboxItemFilterAttribute[] toolboxFilters = new global::System.ComponentModel.ToolboxItemFilterAttribute[] {
					new global::System.ComponentModel.ToolboxItemFilterAttribute(global::ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1ToolboxHelperBase.ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) };
		
		/// <summary>
		/// Toolbox item filter attributes for this diagram.
		/// </summary>
		public override global::System.Collections.ICollection TargetToolboxItemFilterAttributes
		{
			get
			{
				return toolboxFilters;
			}
		}
		#endregion
		#region Auto-placement
		/// <summary>
		/// Indicate that child shapes should added through view fixup should be placed automatically.
		/// </summary>
		public override bool ShouldAutoPlaceChildShapes
		{
			get
			{
				return true;
			}
		}
		#endregion
		#region Shape mapping
		/// <summary>
		/// Called during view fixup to ask the parent whether a shape should be created for the given child element.
		/// </summary>
		/// <remarks>
		/// Always return true, since we assume there is only one diagram per model file for DSL scenarios.
		/// </remarks>
		protected override bool ShouldAddShapeForElement(DslModeling::ModelElement element)
		{
			return true;
		}
		
		
		/// <summary>
		/// Creates a new shape for the given model element as part of view fixup
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Justification = "Generated code.")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
		protected override DslDiagrams::ShapeElement CreateChildShape(DslModeling::ModelElement element)
		{
			if(element is global::ce.GEB_NGN_PCR_Practica1.Ventana)
			{
				global::ce.GEB_NGN_PCR_Practica1.CompartmentShape1 newShape = new global::ce.GEB_NGN_PCR_Practica1.CompartmentShape1(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			if(element is global::ce.GEB_NGN_PCR_Practica1.Menu)
			{
				global::ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems newShape = new global::ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			if(element is global::ce.GEB_NGN_PCR_Practica1.MenuItem)
			{
				global::ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems newShape = new global::ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			return base.CreateChildShape(element);
		}
		#endregion
		#region Decorator mapping
		/// <summary>
		/// Initialize shape decorator mappings.  This is done here rather than in individual shapes because decorator maps
		/// are defined per diagram type rather than per shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
			global::ce.GEB_NGN_PCR_Practica1.CompartmentShape1.DecoratorsInitialized += CompartmentShape1DecoratorMap.OnDecoratorsInitialized;
			global::ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems.DecoratorsInitialized += CompartmentMenuandItemsDecoratorMap.OnDecoratorsInitialized;
		}
		
		/// <summary>
		/// Class containing decorator path traversal methods for CompartmentShape1.
		/// </summary>
		internal static partial class CompartmentShape1DecoratorMap
		{
			/// <summary>
			/// Event handler called when decorator initialization is complete for CompartmentShape1.  Adds decorator mappings for this shape or connector.
			/// </summary>
			public static void OnDecoratorsInitialized(object sender, global::System.EventArgs e)
			{
				DslDiagrams::ShapeElement shape = (DslDiagrams::ShapeElement)sender;
				DslDiagrams::AssociatedPropertyInfo propertyInfo;
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.Ventana.NombreVentanaDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Nombre").AssociateValueWith(shape.Store, propertyInfo);
			}
		}
		
		/// <summary>
		/// Class containing decorator path traversal methods for CompartmentMenuandItems.
		/// </summary>
		internal static partial class CompartmentMenuandItemsDecoratorMap
		{
			/// <summary>
			/// Event handler called when decorator initialization is complete for CompartmentMenuandItems.  Adds decorator mappings for this shape or connector.
			/// </summary>
			public static void OnDecoratorsInitialized(object sender, global::System.EventArgs e)
			{
				DslDiagrams::ShapeElement shape = (DslDiagrams::ShapeElement)sender;
				DslDiagrams::AssociatedPropertyInfo propertyInfo;
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.Menu.ColorLetraMenuDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Color de letra").AssociateValueWith(shape.Store, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.MenuItem.ColorLetraItemDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Color de letra").AssociateValueWith(shape.Store, global::ce.GEB_NGN_PCR_Practica1.MenuItem.DomainClassId, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.Menu.NombreMenuDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Nombre").AssociateValueWith(shape.Store, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.MenuItem.NombreItemDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Nombre").AssociateValueWith(shape.Store, global::ce.GEB_NGN_PCR_Practica1.MenuItem.DomainClassId, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.Menu.TamañoLetraMenuDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Tamaño de letra").AssociateValueWith(shape.Store, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.MenuItem.TamañoLetraItemDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Tamaño de letra").AssociateValueWith(shape.Store, global::ce.GEB_NGN_PCR_Practica1.MenuItem.DomainClassId, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.Menu.TipoLetraMenuDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Tipo de letra").AssociateValueWith(shape.Store, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::ce.GEB_NGN_PCR_Practica1.MenuItem.TipoLetraItemDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Tipo de letra").AssociateValueWith(shape.Store, global::ce.GEB_NGN_PCR_Practica1.MenuItem.DomainClassId, propertyInfo);
			}
		}
		
		#endregion
		#region Constructors, domain class Id
	
		/// <summary>
		/// GEB_NGN_PCR_Practica1Diagram domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x8cddf9e7, 0x0088, 0x4111, 0xb5, 0x90, 0x58, 0x6e, 0x60, 0x0d, 0x14, 0x66);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public GEB_NGN_PCR_Practica1Diagram(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public GEB_NGN_PCR_Practica1Diagram(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ce.GEB_NGN_PCR_Practica1
{
	
		/// <summary>
		/// Double derived implementation for the rule that initiates view fixup when an element that has an associated shape is added to the model.
		/// This now enables the DSL author to everride the SkipFixUp() method 
		/// </summary>
		internal partial class FixUpDiagramBase : DslModeling::AddRule
		{
			protected virtual bool SkipFixup(DslModeling::ModelElement childElement)
			{
				return childElement.IsDeleted;
			}
		}
	
		/// <summary>
		/// Rule that initiates view fixup when an element that has an associated shape is added to the model. 
		/// </summary>
		[DslModeling::RuleOn(typeof(global::ce.GEB_NGN_PCR_Practica1.MenuItem), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::ce.GEB_NGN_PCR_Practica1.Menu), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::ce.GEB_NGN_PCR_Practica1.Ventana), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		internal sealed partial class FixUpDiagram : FixUpDiagramBase
		{
			[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				if(e == null) throw new global::System.ArgumentNullException("e");
			
				DslModeling::ModelElement childElement = e.ModelElement;
				if (this.SkipFixup(childElement))
					return;
				DslModeling::ModelElement parentElement;
				if(childElement is global::ce.GEB_NGN_PCR_Practica1.MenuItem)
				{
					parentElement = GetParentForMenuItem((global::ce.GEB_NGN_PCR_Practica1.MenuItem)childElement);
				} else
				if(childElement is global::ce.GEB_NGN_PCR_Practica1.Menu)
				{
					parentElement = GetParentForMenu((global::ce.GEB_NGN_PCR_Practica1.Menu)childElement);
				} else
				if(childElement is global::ce.GEB_NGN_PCR_Practica1.Ventana)
				{
					parentElement = GetParentForVentana((global::ce.GEB_NGN_PCR_Practica1.Ventana)childElement);
				} else
				{
					parentElement = null;
				}
				
				if(parentElement != null)
				{
					DslDiagrams::Diagram.FixUpDiagram(parentElement, childElement);
				}
			}
			public static global::ce.GEB_NGN_PCR_Practica1.Prototools GetParentForVentana( global::ce.GEB_NGN_PCR_Practica1.Ventana root )
			{
				// Segments 0 and 1
				global::ce.GEB_NGN_PCR_Practica1.Prototools result = root.Prototools;
				if ( result == null ) return null;
				return result;
			}
			public static global::ce.GEB_NGN_PCR_Practica1.Prototools GetParentForMenu( global::ce.GEB_NGN_PCR_Practica1.Menu root )
			{
				// Segments 0 and 1
				global::ce.GEB_NGN_PCR_Practica1.Ventana root2 = root.Ventana;
				if ( root2 == null ) return null;
				// Segments 2 and 3
				global::ce.GEB_NGN_PCR_Practica1.Prototools result = root2.Prototools;
				if ( result == null ) return null;
				return result;
			}
			public static global::ce.GEB_NGN_PCR_Practica1.Prototools GetParentForMenuItem( global::ce.GEB_NGN_PCR_Practica1.MenuItem root )
			{
				// Segments 0 and 1
				global::ce.GEB_NGN_PCR_Practica1.Menu root2 = root.Menu;
				if ( root2 == null ) return null;
				// Segments 2 and 3
				global::ce.GEB_NGN_PCR_Practica1.Ventana root4 = root2.Ventana;
				if ( root4 == null ) return null;
				// Segments 4 and 5
				global::ce.GEB_NGN_PCR_Practica1.Prototools result = root4.Prototools;
				if ( result == null ) return null;
				return result;
			}
		}
		
	
	}
