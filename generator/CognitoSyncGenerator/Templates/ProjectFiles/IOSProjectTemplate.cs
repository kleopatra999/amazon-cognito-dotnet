﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CognitoSyncGenerator.Templates.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class IOSProjectTemplate : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Project ToolsVersion=\"4.0\" DefaultTarget" +
                    "s=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n  <Prope" +
                    "rtyGroup>\r\n    <Configuration Condition=\" \'$(Configuration)\' == \'\' \">Debug</Conf" +
                    "iguration>\r\n    <Platform Condition=\" \'$(Platform)\' == \'\' \">iPhoneSimulator</Pla" +
                    "tform>\r\n    <ProductVersion>8.0.30703</ProductVersion>\r\n    <SchemaVersion>2.0</" +
                    "SchemaVersion>\r\n    <ProjectGuid>{C69BAD61-901B-44C6-8989-1B06CEF1C491}</Project" +
                    "Guid>\r\n    <ProjectTypeGuids>{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-30" +
                    "1F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>\r\n    <OutputType>Library</OutputTy" +
                    "pe>\r\n    <RootNamespace>Amazon.CognitoSync.SyncManager</RootNamespace>\r\n    <Ass" +
                    "emblyName>AWSSDK.SyncManager</AssemblyName>\r\n    <IPhoneResourcePrefix>Resources" +
                    "</IPhoneResourcePrefix>\r\n    <BaseIntermediateOutputPath>obj\\Xamarin.iOS10</Base" +
                    "IntermediateOutputPath>\r\n    <SolutionDir Condition=\"$(SolutionDir) == \'\' Or $(S" +
                    "olutionDir) == \'*Undefined*\'\">..\\</SolutionDir>\r\n    <RestorePackages>true</Rest" +
                    "orePackages>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Configuration)" +
                    "|$(Platform)\' == \'Debug|AnyCPU\' \">\r\n    <DebugSymbols>true</DebugSymbols>\r\n    <" +
                    "DebugType>full</DebugType>\r\n    <Optimize>false</Optimize>\r\n    <OutputPath>bin\\" +
                    "Debug\\Xamarin.iOS10</OutputPath>\r\n    <DefineConstants>TRACE;DEBUG;__UNIFIED__;_" +
                    "_MOBILE__;__IOS__;PCL;AWS_ASYNC_API;LOCAL_FILE</DefineConstants>\r\n    <ErrorRepo" +
                    "rt>prompt</ErrorReport>\r\n    <WarningLevel>4</WarningLevel>\r\n    <ConsolePause>f" +
                    "alse</ConsolePause>\r\n    <MtouchDebug>true</MtouchDebug>\r\n    <CodesignKey>iPhon" +
                    "e Developer</CodesignKey>\r\n    <NoWarn>419,1570,1591</NoWarn>\r\n    <CodeAnalysis" +
                    "ModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisModuleSuppressionsFile" +
                    ">\r\n    <DocumentationFile>bin\\Debug\\Xamarin.iOS10\\AWSSDK.SyncManager.xml</Docume" +
                    "ntationFile>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Configuration)" +
                    "|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugSymbols>true</DebugSymbols>\r\n   " +
                    " <DebugType>pdbonly</DebugType>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>" +
                    "bin\\Release\\Xamarin.iOS10</OutputPath>\r\n    <DefineConstants>TRACE;;PCL;__IOS__;" +
                    "AWS_ASYNC_API;LOCAL_FILE</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport" +
                    ">\r\n    <WarningLevel>4</WarningLevel>\r\n    <ConsolePause>false</ConsolePause>\r\n " +
                    "   <CodesignKey>iPhone Developer</CodesignKey>\r\n    <NoWarn>419,1570,1591</NoWar" +
                    "n>\r\n    <CodeAnalysisModuleSuppressionsFile>GlobalSuppressions.cs</CodeAnalysisM" +
                    "oduleSuppressionsFile>\r\n    <DocumentationFile>bin\\Release\\Xamarin.iOS10\\AWSSDK." +
                    "SyncManager.xml</DocumentationFile>\r\n  </PropertyGroup>\r\n  <PropertyGroup>\r\n    " +
                    "<SignAssembly>true</SignAssembly>\r\n  </PropertyGroup>\r\n  <Choose>\r\n    <When Con" +
                    "dition=\" \'$(AWSKeyFile)\' == \'\' \">\r\n      <PropertyGroup>\r\n        <AssemblyOrigi" +
                    "natorKeyFile>..\\awssdk.dll.snk</AssemblyOriginatorKeyFile>\r\n      </PropertyGrou" +
                    "p>\r\n    </When>\r\n    <Otherwise>\r\n      <PropertyGroup>\r\n        <AssemblyOrigin" +
                    "atorKeyFile>$(AWSKeyFile)</AssemblyOriginatorKeyFile>\r\n      </PropertyGroup>\r\n " +
                    "   </Otherwise>\r\n  </Choose>\r\n  <ItemGroup>\r\n    <Compile Include=\"SyncManager\\*" +
                    ".cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n    <Compile Include=\"Sync" +
                    "Manager\\_pcl\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n    <Compile" +
                    " Include=\"SyncManager\\Exceptions\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Co" +
                    "mpile>\r\n    <Compile Include=\"SyncManager\\Model\\*.cs\">\r\n      <SubType>Code</Sub" +
                    "Type>\r\n    </Compile>\r\n    <Compile Include=\"SyncManager\\Storage\\*.cs\">\r\n      <" +
                    "SubType>Code</SubType>\r\n    </Compile>\r\n    <Compile Include=\"SyncManager\\Storag" +
                    "e\\_pcl\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n    <Compile Inclu" +
                    "de=\"SyncManager\\Util\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n  </" +
                    "ItemGroup>\r\n  <ItemGroup>\r\n    <Compile Include=\"Properties\\AssemblyInfo.cs\" />\r" +
                    "\n    <None Include=\"packages.config\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 95 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"

			foreach(var dependency in this.Config.Dependencies)
			{
				if(dependency.TestOnly)
					continue;

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 101 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Prefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 101 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <HintPath>");
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.PackagesPath));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Prefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.Version));
            
            #line default
            #line hidden
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.InPreview?PreviewFlag:""));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 102 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dependency.ReferencePaths["iOS"]));
            
            #line default
            #line hidden
            this.Write("</HintPath>\r\n      <Private>True</Private>\r\n    </Reference>\r\n");
            
            #line 105 "C:\dev\dotnet\AWSDotNetSyncManager\generator\CognitoSyncGenerator\Templates\ProjectFiles\IOSProjectTemplate.tt"

			}

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"System\" />\r\n    <Reference Include=\"System.Net\" />\r\n    <" +
                    "Reference Include=\"System.Core\" />\r\n    <Reference Include=\"System.Xml.Linq\" />\r" +
                    "\n    <Reference Include=\"System.Xml\" />\r\n    <Reference Include=\"Xamarin.iOS\" />" +
                    "\r\n    <Reference Include=\"SQLitePCL, Version=3.8.7.2, Culture=neutral, PublicKey" +
                    "Token=bddade01e9c850c5, processorArchitecture=MSIL\">\r\n      <HintPath>..\\package" +
                    "s\\SQLitePCL.3.8.7.2\\lib\\Xamarin.iOS10\\SQLitePCL.dll</HintPath>\r\n      <Private>T" +
                    "rue</Private>\r\n    </Reference>\r\n    <Reference Include=\"SQLitePCL.Ext, Version=" +
                    "3.8.7.2, Culture=neutral, PublicKeyToken=bddade01e9c850c5, processorArchitecture" +
                    "=MSIL\">\r\n      <HintPath>..\\packages\\SQLitePCL.3.8.7.2\\lib\\Xamarin.iOS10\\SQLiteP" +
                    "CL.Ext.dll</HintPath>\r\n      <Private>True</Private>\r\n    </Reference>\r\n    <Ref" +
                    "erence Include=\"PCLCrypto\">\r\n      <HintPath>..\\packages\\PCLCrypto.1.0.2.15130\\l" +
                    "ib\\portable-net40+sl50+win+wpa81+wp80+MonoAndroid10+xamarinios10+MonoTouch10\\PCL" +
                    "Crypto.dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"PCLStorage\">\r\n " +
                    "     <HintPath>..\\packages\\PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+mo" +
                    "noandroid+monotouch+Xamarin.iOS+Xamarin.Mac\\PCLStorage.dll</HintPath>\r\n    </Ref" +
                    "erence>\r\n    <Reference Include=\"PCLStorage.Abstractions\">\r\n      <HintPath>..\\p" +
                    "ackages\\PCLStorage.1.0.2\\lib\\portable-net45+wp8+wpa81+win8+monoandroid+monotouch" +
                    "+Xamarin.iOS+Xamarin.Mac\\PCLStorage.Abstractions.dll</HintPath>\r\n    </Reference" +
                    ">\r\n    <Reference Include=\"System.Net.Http\" />\r\n    <Reference Include=\"System.N" +
                    "et.Http.Extensions\">\r\n      <HintPath>..\\packages\\Microsoft.Net.Http.2.2.29\\lib\\" +
                    "Xamarin.iOS10\\System.Net.Http.Extensions.dll</HintPath>\r\n    </Reference>\r\n    <" +
                    "Reference Include=\"System.Net.Http.Primitives\">\r\n      <HintPath>..\\packages\\Mic" +
                    "rosoft.Net.Http.2.2.29\\lib\\Xamarin.iOS10\\System.Net.Http.Primitives.dll</HintPat" +
                    "h>\r\n    </Reference>\r\n  </ItemGroup>\r\n  <Import Project=\"$(MSBuildExtensionsPath" +
                    ")\\Xamarin\\iOS\\Xamarin.iOS.CSharp.targets\" />\r\n  <Import Project=\"$(SolutionDir)\\" +
                    ".nuget\\NuGet.targets\" Condition=\"Exists(\'$(SolutionDir)\\.nuget\\NuGet.targets\')\" " +
                    "/>\r\n  <Target Name=\"EnsureNuGetPackageBuildImports\" BeforeTargets=\"PrepareForBui" +
                    "ld\">\r\n    <PropertyGroup>\r\n      <ErrorText>This project references NuGet packag" +
                    "e(s) that are missing on this computer. Enable NuGet Package Restore to download" +
                    " them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105." +
                    " The missing file is {0}.</ErrorText>\r\n    </PropertyGroup>\r\n    <Error Conditio" +
                    "n=\"!Exists(\'$(SolutionDir)\\.nuget\\NuGet.targets\')\" Text=\"$([System.String]::Form" +
                    "at(\'$(ErrorText)\', \'$(SolutionDir)\\.nuget\\NuGet.targets\'))\" />\r\n  </Target>\r\n  <" +
                    "!-- To modify your build process, add your task inside one of the targets below " +
                    "and uncomment it. \r\n       Other similar extension points exist, see Microsoft.C" +
                    "ommon.targets.\r\n  <Target Name=\"BeforeBuild\">\r\n  </Target>\r\n  <Target Name=\"Afte" +
                    "rBuild\">\r\n  </Target>\r\n  -->\r\n</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
