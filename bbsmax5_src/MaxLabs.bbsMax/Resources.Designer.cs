﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaxLabs.bbsMax {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MaxLabs.bbsMax.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 inlcude必须通过src属性指定所要包含的文件 的本地化字符串。
        /// </summary>
        internal static string PageBase_IncludeSrcIsRequired {
            get {
                return ResourceManager.GetString("PageBase_IncludeSrcIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 插件目录{0}不存在 的本地化字符串。
        /// </summary>
        internal static string PluginManager_PluginFolderNotFound {
            get {
                return ResourceManager.GetString("PluginManager_PluginFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 标示为模板变量的属性必须是只读属性 的本地化字符串。
        /// </summary>
        internal static string TemplateVairableAttribute_PropertyMustBeReadonly {
            get {
                return ResourceManager.GetString("TemplateVairableAttribute_PropertyMustBeReadonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无法将字符串“{0}”转换为{1}类型的值 的本地化字符串。
        /// </summary>
        internal static string TryParse_ParseFailed {
            get {
                return ResourceManager.GetString("TryParse_ParseFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 TryParse不支持字符串到{0}类型的转换! 的本地化字符串。
        /// </summary>
        internal static string TryParse_TypeNotSupport {
            get {
                return ResourceManager.GetString("TryParse_TypeNotSupport", resourceCulture);
            }
        }
    }
}