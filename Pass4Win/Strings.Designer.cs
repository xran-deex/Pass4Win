﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pass4Win {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pass4Win.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to When using an external Git program Pass4Win assumes you know what you&apos;re doing and will not init the repo or change connection strings. The connection should be setup for use without passphrases..
        /// </summary>
        internal static string Config_ExternalGit_Warning {
            get {
                return ResourceManager.GetString("Config_ExternalGit_Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pay Attention!.
        /// </summary>
        internal static string Config_ExternalGit_Warning_Title {
            get {
                return ResourceManager.GetString("Config_ExternalGit_Warning_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entry already exists..
        /// </summary>
        internal static string Error_already_exists {
            get {
                return ResourceManager.GetString("Error_already_exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t connect to remote git repository. Pass4Win set to offline mode..
        /// </summary>
        internal static string Error_connection {
            get {
                return ResourceManager.GetString("Error_connection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t reach your GIT host. Pass4Win set to offline mode..
        /// </summary>
        internal static string Error_git_unreachable {
            get {
                return ResourceManager.GetString("Error_git_unreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host unreachable!.
        /// </summary>
        internal static string Error_host_unreachable {
            get {
                return ResourceManager.GetString("Error_host_unreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be between {0} and {1}, in seconds.
        /// </summary>
        internal static string Error_invalid_PassValidTime {
            get {
                return ResourceManager.GetString("Error_invalid_PassValidTime", resourceCulture);
            }
        }
 
        /// <summary>
        ///   Looks up a localized string similar to So it seems you have a key defined in .gpg-id that&apos;s not in your GPG keystore as public key. Please correct this. Key.
        /// </summary>
        internal static string Error_key_missing_part1 {
            get {
                return ResourceManager.GetString("Error_key_missing_part1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to is missing..
        /// </summary>
        internal static string Error_key_missing_part2 {
            get {
                return ResourceManager.GetString("Error_key_missing_part2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no specific keys set.
        /// </summary>
        internal static string Error_keys_set {
            get {
                return ResourceManager.GetString("Error_keys_set", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Need key...... Restart the program and try again..
        /// </summary>
        internal static string Error_nokey {
            get {
                return ResourceManager.GetString("Error_nokey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty..
        /// </summary>
        internal static string Error_not_empty {
            get {
                return ResourceManager.GetString("Error_not_empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid URL!.
        /// </summary>
        internal static string Error_notvalid_URL {
            get {
                return ResourceManager.GetString("Error_notvalid_URL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In the config remote is disabled..
        /// </summary>
        internal static string Error_remote_disabled {
            get {
                return ResourceManager.GetString("Error_remote_disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a required field!.
        /// </summary>
        internal static string Error_required_field {
            get {
                return ResourceManager.GetString("Error_required_field", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid name, can only use characters or numbers and _ - \\..
        /// </summary>
        internal static string Error_valid_filename {
            get {
                return ResourceManager.GetString("Error_valid_filename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong......
        /// </summary>
        internal static string Error_weird_shit_happened {
            get {
                return ResourceManager.GetString("Error_weird_shit_happened", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You shouldn&apos;t see this.... Awkward right... Encryption failed.
        /// </summary>
        internal static string Error_weird_shit_happened_encryption {
            get {
                return ResourceManager.GetString("Error_weird_shit_happened_encryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty file.
        /// </summary>
        internal static string FrmMain_DecryptPass_Empty_file {
            get {
                return ResourceManager.GetString("FrmMain_DecryptPass_Empty_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commit failed..
        /// </summary>
        internal static string FrmMain_EncryptCallback_Commit_failed_ {
            get {
                return ResourceManager.GetString("FrmMain_EncryptCallback_Commit_failed_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Push to remote repo failed..
        /// </summary>
        internal static string FrmMain_EncryptCallback_Push_to_remote_repo_failed_ {
            get {
                return ResourceManager.GetString("FrmMain_EncryptCallback_Push_to_remote_repo_failed_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename.
        /// </summary>
        internal static string FrmMain_RenameToolStripMenuItemClick_Rename {
            get {
                return ResourceManager.GetString("FrmMain_RenameToolStripMenuItemClick_Rename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New File.
        /// </summary>
        internal static string Info_add_dialog {
            get {
                return ResourceManager.GetString("Info_add_dialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to pull from Git server.
        /// </summary>
        internal static string Info_git_error {
            get {
                return ResourceManager.GetString("Info_git_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pulling from Git Server.
        /// </summary>
        internal static string Info_git_pull {
            get {
                return ResourceManager.GetString("Info_git_pull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully pulled from Git server.
        /// </summary>
        internal static string Info_git_succes {
            get {
                return ResourceManager.GetString("Info_git_succes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a newer version of Pass4Win, do you want to update?.
        /// </summary>
        internal static string Info_new_version {
            get {
                return ResourceManager.GetString("Info_new_version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update available.
        /// </summary>
        internal static string Info_new_version_caption {
            get {
                return ResourceManager.GetString("Info_new_version_caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a new name.
        /// </summary>
        internal static string Input_new_name {
            get {
                return ResourceManager.GetString("Input_new_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name:.
        /// </summary>
        internal static string Input_new_name_label {
            get {
                return ResourceManager.GetString("Input_new_name_label", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string InputBox_Show_Cancel {
            get {
                return ResourceManager.GetString("InputBox_Show_Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        internal static string InputBox_Show_OK {
            get {
                return ResourceManager.GetString("InputBox_Show_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation Error.
        /// </summary>
        internal static string InputBox_Show_Validation_Error {
            get {
                return ResourceManager.GetString("InputBox_Show_Validation_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ready.
        /// </summary>
        internal static string Ready {
            get {
                return ResourceManager.GetString("Ready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Countdown to clearing clipboard.
        /// </summary>
        internal static string Statusbar_countdown {
            get {
                return ResourceManager.GetString("Statusbar_countdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to version.
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
    }
}
