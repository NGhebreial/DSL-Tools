#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"ce")]
[assembly: AssemblyProduct(@"GEB_NGN_PCR_Practica1")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"ce.GEB_NGN_PCR_Practica1.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100D18E8CC7E31EA66D7E495C7FB01AF3DB261408792E4908672D713B597825739426BAD550C5B6BDC0E55C5E993986D8D9012564625335D8400617B29ED910307C0D59DC1AE4CEED3DF0BA000C7483E4D7EAF63054D0E356625D51703A24E887A3BB4B6D5C4EDBAD20C87E8420157EB379B9C8565DACB42044905F51D06079A3BC")]