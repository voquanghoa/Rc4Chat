﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonShare {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TextResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TextResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CommonShare.TextResource", typeof(TextResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///	&lt;title&gt;Client&lt;/title&gt;
        ///	&lt;style type=&apos;text/css&apos;&gt;
        ///		 body{font-family:  &apos;Segoe UI&apos;, tahoma, sans-serif;}
        ///		.message{padding: 6px;margin: 4px;text-align: left;cursor:default;word-wrap:break-word;}
        ///		.mine{margin-left: 100px;background: DarkOrange;}
        ///		.remote{margin-right: 100px;background: #999;}
        ///	&lt;/style&gt;
        ///	&lt;script language=&apos;javascript&apos;&gt;
        ///		window.onload=toBottom;
        ///		function toBottom(){ window.scrollTo(0, document.body.scrollHeight);}
        ///	&lt;/script&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///{cont [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MessageHtmlFormat {
            get {
                return ResourceManager.GetString("MessageHtmlFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div class=&apos;message remote&apos; title=&apos;{tite} &apos;&quot; style=&apos;background:{color}&apos;&gt;&lt;b&gt;{nickname}&lt;/b&gt; {content}&lt;/div&gt;.
        /// </summary>
        internal static string RemoteMessageHtmlFormat {
            get {
                return ResourceManager.GetString("RemoteMessageHtmlFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div class=&apos;message mine&apos; title=&apos;{title}&apos;&gt;{content}&lt;/div&gt;.
        /// </summary>
        internal static string SelfMessage {
            get {
                return ResourceManager.GetString("SelfMessage", resourceCulture);
            }
        }
    }
}
