﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinectApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KinectApp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Comparison in progress.
        /// </summary>
        internal static string ComparisonInProgressText {
            get {
                return ResourceManager.GetString("ComparisonInProgressText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KStudio Event File.
        /// </summary>
        internal static string EventFileDescription {
            get {
                return ResourceManager.GetString("EventFileDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (*.xef, *.xrf)|*.xef;*.xrf.
        /// </summary>
        internal static string EventFileFilter {
            get {
                return ResourceManager.GetString("EventFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No ready Kinect found!.
        /// </summary>
        internal static string NoSensorStatusText {
            get {
                return ResourceManager.GetString("NoSensorStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Playback in progress.
        /// </summary>
        internal static string PlaybackInProgressText {
            get {
                return ResourceManager.GetString("PlaybackInProgressText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recording in progress.
        /// </summary>
        internal static string RecordingInProgressText {
            get {
                return ResourceManager.GetString("RecordingInProgressText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running.
        /// </summary>
        internal static string RunningStatusText {
            get {
                return ResourceManager.GetString("RunningStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kinect not available!.
        /// </summary>
        internal static string SensorNotAvailableStatusText {
            get {
                return ResourceManager.GetString("SensorNotAvailableStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .xef.
        /// </summary>
        internal static string XefExtension {
            get {
                return ResourceManager.GetString("XefExtension", resourceCulture);
            }
        }
    }
}
