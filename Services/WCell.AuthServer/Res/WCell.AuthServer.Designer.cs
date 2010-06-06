﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCell.AuthServer.Res {
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
    internal class WCell_AuthServer {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WCell_AuthServer() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WCell.AuthServer.Res.WCell.AuthServer", typeof(WCell_AuthServer).Assembly);
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
        ///   Looks up a localized string similar to Client attempting to challenge auth for account: {0}.
        /// </summary>
        internal static string AccountChallenge {
            get {
                return ResourceManager.GetString("AccountChallenge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully created account &quot;{0}&quot; (Role: {1})..
        /// </summary>
        internal static string AccountCreated {
            get {
                return ResourceManager.GetString("AccountCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create account &quot;{0}&quot;..
        /// </summary>
        internal static string AccountCreationFailed {
            get {
                return ResourceManager.GetString("AccountCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client attempted to log into non-existant account: {0}.
        /// </summary>
        internal static string AccountNotFound {
            get {
                return ResourceManager.GetString("AccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Re-)Cached {0} Accounts..
        /// </summary>
        internal static string AccountsCached {
            get {
                return ResourceManager.GetString("AccountsCached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A request for non-existant account &apos;{0}&apos; was made from {1} (Last Login from: {2}).
        /// </summary>
        internal static string AttemptedRequestForUnknownAccount {
            get {
                return ResourceManager.GetString("AttemptedRequestForUnknownAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet &apos;{0}&apos; parsed successfully!.
        /// </summary>
        internal static string AuthPacketParsed {
            get {
                return ResourceManager.GetString("AuthPacketParsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IPC service address already bound to; make sure you aren&apos;t already running the Authentication server!.
        /// </summary>
        internal static string AuthServiceAlreadyListening {
            get {
                return ResourceManager.GetString("AuthServiceAlreadyListening", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto-creating account: {0}.
        /// </summary>
        internal static string AutocreatingAccount {
            get {
                return ResourceManager.GetString("AutocreatingAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Caching Accounts....
        /// </summary>
        internal static string CachingAccounts {
            get {
                return ResourceManager.GetString("CachingAccounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not retrieve Authentication info for account &apos;{0}&apos;!.
        /// </summary>
        internal static string CannotRetrieveAuthenticationInfo {
            get {
                return ResourceManager.GetString("CannotRetrieveAuthenticationInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account Challenge failed.
        /// </summary>
        internal static string ChallengeFailed {
            get {
                return ResourceManager.GetString("ChallengeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client connected to the server. Address: {0}.
        /// </summary>
        internal static string ClientConnected {
            get {
                return ResourceManager.GetString("ClientConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client disconnected from the server. Address: {0}.
        /// </summary>
        internal static string ClientDisconnected {
            get {
                return ResourceManager.GetString("ClientDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client cannot be null!.
        /// </summary>
        internal static string ClientNull {
            get {
                return ResourceManager.GetString("ClientNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a fatal database error, server not started.
        /// </summary>
        internal static string DatabaseFailure {
            get {
                return ResourceManager.GetString("DatabaseFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PacketHandler for Packet {0} &apos;{1}&apos; has been overridden with &apos;{2}&apos;!.
        /// </summary>
        internal static string HandlerAlreadyRegistered {
            get {
                return ResourceManager.GetString("HandlerAlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid authentication packet!.
        /// </summary>
        internal static string InvalidAuthPacket {
            get {
                return ResourceManager.GetString("InvalidAuthPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client-supplied proof of Account {0} did not match server-generated proof..
        /// </summary>
        internal static string InvalidClientProof {
            get {
                return ResourceManager.GetString("InvalidClientProof", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email address: {0}.
        /// </summary>
        internal static string InvalidEmailAddress {
            get {
                return ResourceManager.GetString("InvalidEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create packet handler delegate from method &apos;{0}&apos;: invalid method signature!.
        /// </summary>
        internal static string InvalidHandlerMethodSignature {
            get {
                return ResourceManager.GetString("InvalidHandlerMethodSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IPC Service failed - Restarting in &apos;{0}&apos; seconds....
        /// </summary>
        internal static string IPCServiceFailed {
            get {
                return ResourceManager.GetString("IPCServiceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IPC Service stopped successfully..
        /// </summary>
        internal static string IPCServiceShutdown {
            get {
                return ResourceManager.GetString("IPCServiceShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IPC Service started successfully - Listening on {0}.
        /// </summary>
        internal static string IPCServiceStarted {
            get {
                return ResourceManager.GetString("IPCServiceStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occured while trying to handle packet! Packet ID: &apos;{0}&apos;.
        /// </summary>
        internal static string PacketHandleException {
            get {
                return ResourceManager.GetString("PacketHandleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse packet properly! Given opcode: {0:X4}.
        /// </summary>
        internal static string PacketParseFailed {
            get {
                return ResourceManager.GetString("PacketParseFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Privilege configuration changed; reloading!.
        /// </summary>
        internal static string PrivilegeConfigChanged {
            get {
                return ResourceManager.GetString("PrivilegeConfigChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Realm disconnected: {0}.
        /// </summary>
        internal static string RealmDisconnected {
            get {
                return ResourceManager.GetString("RealmDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Realm registered: {0}.
        /// </summary>
        internal static string RealmRegistered {
            get {
                return ResourceManager.GetString("RealmRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Realm unregistered: {0}.
        /// </summary>
        internal static string RealmUnregistered {
            get {
                return ResourceManager.GetString("RealmUnregistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Realm update from {0}.
        /// </summary>
        internal static string RealmUpdated {
            get {
                return ResourceManager.GetString("RealmUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registered all packet handlers!.
        /// </summary>
        internal static string RegisteredAllHandlers {
            get {
                return ResourceManager.GetString("RegisteredAllHandlers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registered handler for &apos;{0}&apos; for {1}.
        /// </summary>
        internal static string RegisteredHandler {
            get {
                return ResourceManager.GetString("RegisteredHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occured when starting/initializing: {0}.
        /// </summary>
        internal static string StartInitException {
            get {
                return ResourceManager.GetString("StartInitException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping/cleaning up: {0}.
        /// </summary>
        internal static string StopCleanup {
            get {
                return ResourceManager.GetString("StopCleanup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occured when stopping/cleaning up: {0}.
        /// </summary>
        internal static string StopCleanupException {
            get {
                return ResourceManager.GetString("StopCleanupException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UDP messages are not part of the protocol.
        /// </summary>
        internal static string UDPNotImplemented {
            get {
                return ResourceManager.GetString("UDPNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled packet {0} ({1}), Size: {2} bytes.
        /// </summary>
        internal static string UnhandledPacket {
            get {
                return ResourceManager.GetString("UnhandledPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown username or password given for IPC authentication! Username: &apos;{0}&apos;  Password: &apos;{1}&apos; .
        /// </summary>
        internal static string UnknownIPCLogin {
            get {
                return ResourceManager.GetString("UnknownIPCLogin", resourceCulture);
            }
        }
    }
}
