﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJETOMODELODDD.DOMINIO.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=JRCARVALHOVAIO;AttachDbFilename=C:\\Aprendendo_C#\\PROJETOMODELODDD\\Pro" +
            "jetoModeloDDD\\PROJETOMODELO.MVC\\App_Data\\ProjetoModeloDDDDB.mdf;Initial Catalog=" +
            "ProjetoModeloDDDDB;Integrated Security=True")]
        public string ProjetoModeloDDDDBConnectionString {
            get {
                return ((string)(this["ProjetoModeloDDDDBConnectionString"]));
            }
        }
    }
}