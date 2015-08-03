﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CognitoSyncGenerator.Templates.Component
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class Component : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("%YAML 1.2\r\n---\r\nsummary: AWS ");
            
            #line 8 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BaseName"]));
            
            #line default
            #line hidden
            this.Write(" SDK for Xamarin\r\ngetting-started: GettingStarted.md\r\ndetails: Details.md\r\nlicens" +
                    "e: ..\\License.md\r\nicons: \r\n  - ..\\awsmobile_128.png\r\n  - ..\\awsmobile_512.png\r\np" +
                    "ublisher: Amazon Web Services\r\nname: ");
            
            #line 16 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ComponentTitle"]));
            
            #line default
            #line hidden
            this.Write("\r\nid: aws-");
            
            #line 17 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BaseName"].ToString().ToLowerInvariant()));
            
            #line default
            #line hidden
            this.Write("-sdk\r\nsamples: \r\n  - name: \"");
            
            #line 19 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BaseName"]));
            
            #line default
            #line hidden
            this.Write("-Sample\"\r\n    path: ");
            
            #line 20 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["SolutionFilePath"]));
            
            #line default
            #line hidden
            this.Write("\r\npublisher-url: http://aws.amazon.com/mobile/sdk/\r\npackages:\r\n  android:\r\n");
            
            #line 24 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 28 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write(", Version=");
            
            #line 28 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 29 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    }

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 32 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(",Version=");
            
            #line 32 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            
            #line 32 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetPreviewFlag"]));
            
            #line default
            #line hidden
            this.Write("\r\n  ios-unified:\r\n");
            
            #line 34 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 38 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write(", Version=");
            
            #line 38 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 39 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    }

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 42 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(",Version=");
            
            #line 42 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            
            #line 42 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetPreviewFlag"]));
            
            #line default
            #line hidden
            this.Write("\r\n  winphone-8.0:\r\n");
            
            #line 44 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 48 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write(", Version=");
            
            #line 48 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 49 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    }

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 52 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(",Version=");
            
            #line 52 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            
            #line 52 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetPreviewFlag"]));
            
            #line default
            #line hidden
            this.Write("\r\n  winphone-8.1:\r\n");
            
            #line 54 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    foreach(var awsDependencyKVP in ((IDictionary<string, string>)this.Session["AWSDependencies"]))
    {

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 58 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Key));
            
            #line default
            #line hidden
            this.Write(", Version=");
            
            #line 58 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(awsDependencyKVP.Value));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 59 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

    }

            
            #line default
            #line hidden
            this.Write("  - ");
            
            #line 62 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(",Version=");
            
            #line 62 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            
            #line 62 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NuGetPreviewFlag"]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 63 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"

//component doesnot support preview flags like nuget, so we dont add that

            
            #line default
            #line hidden
            this.Write("version: ");
            
            #line 66 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\Component\Component.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyVersion"]));
            
            #line default
            #line hidden
            this.Write("\r\nis-shell: true\r\n...");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
