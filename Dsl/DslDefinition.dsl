<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="fa624d84-4831-44f2-9a9b-75b62bed1fd6" Description="Description for ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1" Name="GEB_NGN_PCR_Practica1" DisplayName="GEB_NGN_PCR_Practica1" Namespace="ce.GEB_NGN_PCR_Practica1" ProductName="GEB_NGN_PCR_Practica1" CompanyName="ce" PackageGuid="e0319584-b821-4bca-b15c-9b825d535441" PackageNamespace="ce.GEB_NGN_PCR_Practica1" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="e6ab8902-c5de-4be0-8118-51837bb12c12" Description="The root in which all other elements are embedded. Appears as a diagram." Name="Prototools" DisplayName="Prototools" Namespace="ce.GEB_NGN_PCR_Practica1">
      <Properties>
        <DomainProperty Id="4c6967ec-e7fb-42b9-8fd5-98ebb5fe0d98" Description="Description for ce.GEB_NGN_PCR_Practica1.Prototools.Nombre Proyecto" Name="NombreProyecto" DisplayName="Nombre Proyecto">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Ventana" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>PrototoolsHasVentana.Ventana</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="889ae4d3-7cdf-4e6f-bdca-f96dc927d852" Description="Description for ce.GEB_NGN_PCR_Practica1.Ventana" Name="Ventana" DisplayName="Ventana" Namespace="ce.GEB_NGN_PCR_Practica1">
      <Properties>
        <DomainProperty Id="410ba747-8840-4dde-8d7f-b6183ebc4396" Description="Description for ce.GEB_NGN_PCR_Practica1.Ventana.Nombre Ventana" Name="NombreVentana" DisplayName="Nombre Ventana">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Menu" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>VentanaHasMenu.Menu</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="3cb52dae-bcb8-449a-8742-d676a2d0c37d" Description="Description for ce.GEB_NGN_PCR_Practica1.Menu" Name="Menu" DisplayName="Menu" Namespace="ce.GEB_NGN_PCR_Practica1">
      <Properties>
        <DomainProperty Id="779c70b3-9d08-4370-b863-1c622fb57bf4" Description="Description for ce.GEB_NGN_PCR_Practica1.Menu.Nombre Menu" Name="NombreMenu" DisplayName="Nombre Menu">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="523df02a-2822-4db8-9109-36290f9b5ee4" Description="Description for ce.GEB_NGN_PCR_Practica1.Menu.Tipo Letra Menu" Name="TipoLetraMenu" DisplayName="Tipo Letra Menu">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="52bd14ea-107e-4631-ad15-daa432a4e44d" Description="Description for ce.GEB_NGN_PCR_Practica1.Menu.Tamaño Letra Menu" Name="TamañoLetraMenu" DisplayName="Tamaño Letra Menu">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="79c1f29a-cba8-48b3-90d0-33bceb0f7f0e" Description="Description for ce.GEB_NGN_PCR_Practica1.Menu.Color Letra Menu" Name="ColorLetraMenu" DisplayName="Color Letra Menu">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="MenuItem" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>MenuHasMenuItem.MenuItem</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="9cfc54bf-a9a9-49d3-94f1-c0121d8014d5" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuItem" Name="MenuItem" DisplayName="Menu Item" Namespace="ce.GEB_NGN_PCR_Practica1">
      <Properties>
        <DomainProperty Id="60a988ce-ddd3-4283-82b7-b998c6544962" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuItem.Nombre Item" Name="NombreItem" DisplayName="Nombre Item">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="edc39d8d-8bbe-4e8e-b0f7-44d9bdd0a487" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuItem.Tipo Letra Item" Name="TipoLetraItem" DisplayName="Tipo Letra Item">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="da80c161-6443-4bb9-808f-64e0537a7eb6" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuItem.Color Letra Item" Name="ColorLetraItem" DisplayName="Color Letra Item">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="2ea77d81-5094-4b8a-bed2-f3a81ff22dde" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuItem.Tamaño Letra Item" Name="TamañoLetraItem" DisplayName="Tamaño Letra Item">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="1579b68b-8ef0-491f-972f-d8e60c3f2484" Description="Description for ce.GEB_NGN_PCR_Practica1.PrototoolsHasVentana" Name="PrototoolsHasVentana" DisplayName="Prototools Has Ventana" Namespace="ce.GEB_NGN_PCR_Practica1" IsEmbedding="true">
      <Source>
        <DomainRole Id="0c379363-deb6-4f22-8d4f-03283fbf75a7" Description="Description for ce.GEB_NGN_PCR_Practica1.PrototoolsHasVentana.Prototools" Name="Prototools" DisplayName="Prototools" PropertyName="Ventana" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Ventana">
          <RolePlayer>
            <DomainClassMoniker Name="Prototools" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="859043b7-7971-485e-a483-c66f42aabcde" Description="Description for ce.GEB_NGN_PCR_Practica1.PrototoolsHasVentana.Ventana" Name="Ventana" DisplayName="Ventana" PropertyName="Prototools" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Prototools">
          <RolePlayer>
            <DomainClassMoniker Name="Ventana" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="494f1412-5868-4fd6-9407-769a03347791" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuHasMenuItem" Name="MenuHasMenuItem" DisplayName="Menu Has Menu Item" Namespace="ce.GEB_NGN_PCR_Practica1" IsEmbedding="true">
      <Source>
        <DomainRole Id="4c2d99da-6298-47d8-a13b-8cff27869eda" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuHasMenuItem.Menu" Name="Menu" DisplayName="Menu" PropertyName="MenuItem" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Menu Item">
          <RolePlayer>
            <DomainClassMoniker Name="Menu" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="ccb2d2b2-8a83-421e-89af-4d4fceafb4b0" Description="Description for ce.GEB_NGN_PCR_Practica1.MenuHasMenuItem.MenuItem" Name="MenuItem" DisplayName="Menu Item" PropertyName="Menu" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Menu">
          <RolePlayer>
            <DomainClassMoniker Name="MenuItem" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="04e40001-c9d7-45e2-8ea2-13be2f6056d4" Description="Description for ce.GEB_NGN_PCR_Practica1.VentanaHasMenu" Name="VentanaHasMenu" DisplayName="Ventana Has Menu" Namespace="ce.GEB_NGN_PCR_Practica1" IsEmbedding="true">
      <Source>
        <DomainRole Id="227df8d1-f1d9-45e4-bfb1-dda67005e10c" Description="Description for ce.GEB_NGN_PCR_Practica1.VentanaHasMenu.Ventana" Name="Ventana" DisplayName="Ventana" PropertyName="Menu" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Menu">
          <RolePlayer>
            <DomainClassMoniker Name="Ventana" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="7d6ac4b1-38eb-4b4c-9c1a-27c27ca13a3b" Description="Description for ce.GEB_NGN_PCR_Practica1.VentanaHasMenu.Menu" Name="Menu" DisplayName="Menu" PropertyName="Ventana" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Ventana">
          <RolePlayer>
            <DomainClassMoniker Name="Menu" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <CompartmentShape Id="316e0c58-767f-4ba6-90c7-95af608dac78" Description="Description for ce.GEB_NGN_PCR_Practica1.CompartmentShape1" Name="CompartmentShape1" DisplayName="Ventana" Namespace="ce.GEB_NGN_PCR_Practica1" FixedTooltipText="Ventana" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Nombre" DisplayName="Nombre" DefaultText="Nombre" />
      </ShapeHasDecorators>
    </CompartmentShape>
    <CompartmentShape Id="ec8a62b0-29a2-450e-b1cc-58cb5fcf4a83" Description="Description for ce.GEB_NGN_PCR_Practica1.CompartmentMenuandItems" Name="CompartmentMenuandItems" DisplayName="Compartment Menuand Items" Namespace="ce.GEB_NGN_PCR_Practica1" FixedTooltipText="Compartment Menuand Items" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Nombre" DisplayName="Nombre" DefaultText="Nombre" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Tipo de letra" DisplayName="Tipo de letra" DefaultText="Tipo de letra" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Tamaño de letra" DisplayName="Tamaño de letra" DefaultText="Tamaño de letra" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Color de letra" DisplayName="Color de letra" DefaultText="Color de letra" />
      </ShapeHasDecorators>
    </CompartmentShape>
  </Shapes>
  <XmlSerializationBehavior Name="GEB_NGN_PCR_Practica1SerializationBehavior" Namespace="ce.GEB_NGN_PCR_Practica1">
    <ClassData>
      <XmlClassData TypeName="Prototools" MonikerAttributeName="" SerializeId="true" MonikerElementName="prototoolsMoniker" ElementName="prototools" MonikerTypeName="PrototoolsMoniker">
        <DomainClassMoniker Name="Prototools" />
        <ElementData>
          <XmlPropertyData XmlName="nombreProyecto">
            <DomainPropertyMoniker Name="Prototools/NombreProyecto" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="ventana">
            <DomainRelationshipMoniker Name="PrototoolsHasVentana" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="GEB_NGN_PCR_Practica1Diagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="gEB_NGN_PCR_Practica1DiagramMoniker" ElementName="gEB_NGN_PCR_Practica1Diagram" MonikerTypeName="GEB_NGN_PCR_Practica1DiagramMoniker">
        <DiagramMoniker Name="GEB_NGN_PCR_Practica1Diagram" />
      </XmlClassData>
      <XmlClassData TypeName="Ventana" MonikerAttributeName="" SerializeId="true" MonikerElementName="ventanaMoniker" ElementName="ventana" MonikerTypeName="VentanaMoniker">
        <DomainClassMoniker Name="Ventana" />
        <ElementData>
          <XmlPropertyData XmlName="nombreVentana">
            <DomainPropertyMoniker Name="Ventana/NombreVentana" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="menu">
            <DomainRelationshipMoniker Name="VentanaHasMenu" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="CompartmentShape1" MonikerAttributeName="" SerializeId="true" MonikerElementName="compartmentShape1Moniker" ElementName="compartmentShape1" MonikerTypeName="CompartmentShape1Moniker">
        <CompartmentShapeMoniker Name="CompartmentShape1" />
      </XmlClassData>
      <XmlClassData TypeName="PrototoolsHasVentana" MonikerAttributeName="" SerializeId="true" MonikerElementName="prototoolsHasVentanaMoniker" ElementName="prototoolsHasVentana" MonikerTypeName="PrototoolsHasVentanaMoniker">
        <DomainRelationshipMoniker Name="PrototoolsHasVentana" />
      </XmlClassData>
      <XmlClassData TypeName="Menu" MonikerAttributeName="" SerializeId="true" MonikerElementName="menuMoniker" ElementName="menu" MonikerTypeName="MenuMoniker">
        <DomainClassMoniker Name="Menu" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="menuItem">
            <DomainRelationshipMoniker Name="MenuHasMenuItem" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="nombreMenu">
            <DomainPropertyMoniker Name="Menu/NombreMenu" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="tipoLetraMenu">
            <DomainPropertyMoniker Name="Menu/TipoLetraMenu" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="tamañoLetraMenu">
            <DomainPropertyMoniker Name="Menu/TamañoLetraMenu" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="colorLetraMenu">
            <DomainPropertyMoniker Name="Menu/ColorLetraMenu" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="MenuItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="menuItemMoniker" ElementName="menuItem" MonikerTypeName="MenuItemMoniker">
        <DomainClassMoniker Name="MenuItem" />
        <ElementData>
          <XmlPropertyData XmlName="nombreItem">
            <DomainPropertyMoniker Name="MenuItem/NombreItem" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="tipoLetraItem">
            <DomainPropertyMoniker Name="MenuItem/TipoLetraItem" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="colorLetraItem">
            <DomainPropertyMoniker Name="MenuItem/ColorLetraItem" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="tamañoLetraItem">
            <DomainPropertyMoniker Name="MenuItem/TamañoLetraItem" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="MenuHasMenuItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="menuHasMenuItemMoniker" ElementName="menuHasMenuItem" MonikerTypeName="MenuHasMenuItemMoniker">
        <DomainRelationshipMoniker Name="MenuHasMenuItem" />
      </XmlClassData>
      <XmlClassData TypeName="VentanaHasMenu" MonikerAttributeName="" SerializeId="true" MonikerElementName="ventanaHasMenuMoniker" ElementName="ventanaHasMenu" MonikerTypeName="VentanaHasMenuMoniker">
        <DomainRelationshipMoniker Name="VentanaHasMenu" />
      </XmlClassData>
      <XmlClassData TypeName="CompartmentMenuandItems" MonikerAttributeName="" SerializeId="true" MonikerElementName="compartmentMenuandItemsMoniker" ElementName="compartmentMenuandItems" MonikerTypeName="CompartmentMenuandItemsMoniker">
        <CompartmentShapeMoniker Name="CompartmentMenuandItems" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="GEB_NGN_PCR_Practica1Explorer" />
  <Diagram Id="8cddf9e7-0088-4111-b590-586e600d1466" Description="Description for ce.GEB_NGN_PCR_Practica1.GEB_NGN_PCR_Practica1Diagram" Name="GEB_NGN_PCR_Practica1Diagram" DisplayName="Minimal Language Diagram" Namespace="ce.GEB_NGN_PCR_Practica1">
    <Class>
      <DomainClassMoniker Name="Prototools" />
    </Class>
    <ShapeMaps>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Ventana" />
        <ParentElementPath>
          <DomainPath>PrototoolsHasVentana.Prototools/!Prototools</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentShape1/Nombre" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Ventana/NombreVentana" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="CompartmentShape1" />
      </CompartmentShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Menu" />
        <ParentElementPath>
          <DomainPath>VentanaHasMenu.Ventana/!Ventana/PrototoolsHasVentana.Prototools/!Prototools</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Color de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Menu/ColorLetraMenu" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Nombre" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Menu/NombreMenu" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Tamaño de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Menu/TamañoLetraMenu" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Tipo de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Menu/TipoLetraMenu" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="CompartmentMenuandItems" />
      </CompartmentShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="MenuItem" />
        <ParentElementPath>
          <DomainPath>MenuHasMenuItem.Menu/!Menu/VentanaHasMenu.Ventana/!Ventana/PrototoolsHasVentana.Prototools/!Prototools</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Color de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="MenuItem/ColorLetraItem" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Nombre" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="MenuItem/NombreItem" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Tamaño de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="MenuItem/TamañoLetraItem" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CompartmentMenuandItems/Tipo de letra" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="MenuItem/TipoLetraItem" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="CompartmentMenuandItems" />
      </CompartmentShapeMap>
    </ShapeMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="GEB_NGN_PCR_prototools" EditorGuid="36a3df3d-f3e7-47ec-9c76-2fa962f23a8e">
    <RootClass>
      <DomainClassMoniker Name="Prototools" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="GEB_NGN_PCR_Practica1SerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="GEB_NGN_PCR_Practica1">
      <ElementTool Name="Ventana" ToolboxIcon="Resources\ExampleShapeToolBitmap.bmp" Caption="Ventana" Tooltip="Ventana" HelpKeyword="Ventana">
        <DomainClassMoniker Name="Ventana" />
      </ElementTool>
      <ElementTool Name="Menu" ToolboxIcon="Resources\list26.bmp" Caption="Menu" Tooltip="Menu" HelpKeyword="Menu">
        <DomainClassMoniker Name="Menu" />
      </ElementTool>
      <ElementTool Name="MenuItem" ToolboxIcon="Resources\book87.bmp" Caption="MenuItem" Tooltip="Menu Item" HelpKeyword="MenuItem">
        <DomainClassMoniker Name="MenuItem" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="GEB_NGN_PCR_Practica1Diagram" />
  </Designer>
  <Explorer ExplorerGuid="0873e3eb-54f0-4101-8e85-c8a2d4ebd4cb" Title="GEB_NGN_PCR_Practica1 Explorer">
    <ExplorerBehaviorMoniker Name="GEB_NGN_PCR_Practica1/GEB_NGN_PCR_Practica1Explorer" />
  </Explorer>
</Dsl>