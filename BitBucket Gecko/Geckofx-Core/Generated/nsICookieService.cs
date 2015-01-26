// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsICookieService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// nsICookieService
    ///
    /// Provides methods for setting and getting cookies in the context of a
    /// page load.  See nsICookieManager for methods to manipulate the cookie
    /// database directly.  This separation of interface is mainly historical.
    ///
    /// This service broadcasts the notifications detailed below when the cookie
    /// list is changed, or a cookie is rejected.
    ///
    /// NOTE: observers of these notifications *must* not attempt to change profile
    /// or switch into or out of private browsing mode from within the
    /// observer. Doing so will cause undefined behavior. Mutating the cookie
    /// list (e.g. by calling methods on nsICookieService and friends) is
    /// allowed, but beware that there may be pending notifications you haven't
    /// seen yet -- for instance, a "batch-deleted" notification will likely be
    /// immediately followed by "added". You may check the state of the cookie
    /// list to determine if this is the case.
    ///
    /// topic  : "cookie-changed"
    /// broadcast whenever the cookie list changes in some way. see
    /// explanation of data strings below.
    /// subject: see below.
    /// data   : "deleted"
    /// a cookie was deleted. the subject is an nsICookie2 representing
    /// the deleted cookie.
    /// "added"
    /// a cookie was added. the subject is an nsICookie2 representing
    /// the added cookie.
    /// "changed"
    /// a cookie was changed. the subject is an nsICookie2 representing
    /// the new cookie. (note that host, path, and name are invariant
    /// for a given cookie; other parameters may change.)
    /// "batch-deleted"
    /// a set of cookies was purged (typically, because they have either
    /// expired or because the cookie list has grown too large). The subject
    /// is an nsIArray of nsICookie2's representing the deleted cookies.
    /// Note that the array could contain a single cookie.
    /// "cleared"
    /// the entire cookie list was cleared. the subject is null.
    /// "reload"
    /// the entire cookie list should be reloaded.  the subject is null.
    ///
    /// topic  : "cookie-rejected"
    /// broadcast whenever a cookie was rejected from being set as a
    /// result of user prefs.
    /// subject: an nsIURI interface pointer representing the URI that attempted
    /// to set the cookie.
    /// data   : none.
    ///
    /// topic  : "third-party-cookie-accepted"
    /// broadcast whenever a third party cookie was accepted
    /// subject:  an nsIURI interface pointer representing the URI that attempted
    /// to set the cookie.
    /// data   :  the referrer, or "?" if unknown
    ///
    /// topic  : "third-party-cookie-rejected"
    /// broadcast whenever a third party cookie was rejected
    /// subject:  an nsIURI interface pointer representing the URI that attempted
    /// to set the cookie.
    /// data   :  the referrer, or "?" if unknown
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2aaa897a-293c-4d2b-a657-8c9b7136996d")]
	public interface nsICookieService
	{
		
		/// <summary>
        /// Get the complete cookie string associated with the URI.
        ///
        /// @param aURI
        /// The URI of the document for which cookies are being queried.
        /// file:// URIs (i.e. with an empty host) are allowed, but any other
        /// scheme must have a non-empty host. A trailing dot in the host
        /// is acceptable, and will be stripped. This argument must not be null.
        /// @param aChannel
        /// the channel used to load the document.  this parameter should not
        /// be null, otherwise the cookies will not be returned if third-party
        /// cookies have been disabled by the user. (the channel is used
        /// to determine the originating URI of the document; if it is not
        /// provided, the cookies will be assumed third-party.)
        ///
        /// @return the resulting cookie string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Get the complete cookie string associated with the URI.
        ///
        /// This function is NOT redundant with getCookieString, as the result
        /// will be different based on httponly (see bug 178993)
        ///
        /// @param aURI
        /// The URI of the document for which cookies are being queried.
        /// file:// URIs (i.e. with an empty host) are allowed, but any other
        /// scheme must have a non-empty host. A trailing dot in the host
        /// is acceptable, and will be stripped. This argument must not be null.
        /// @param aFirstURI
        /// the URI that the user originally typed in or clicked on to initiate
        /// the load of the document referenced by aURI.
        /// @param aChannel
        /// the channel used to load the document.  this parameter should not
        /// be null, otherwise the cookies will not be returned if third-party
        /// cookies have been disabled by the user. (the channel is used
        /// to determine the originating URI of the document; if it is not
        /// provided, the cookies will be assumed third-party.)
        ///
        /// @return the resulting cookie string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Set the cookie string associated with the URI.
        ///
        /// @param aURI
        /// The URI of the document for which cookies are being queried.
        /// file:// URIs (i.e. with an empty host) are allowed, but any other
        /// scheme must have a non-empty host. A trailing dot in the host
        /// is acceptable, and will be stripped. This argument must not be null.
        /// @param aPrompt
        /// the prompt to use for all user-level cookie notifications. This is
        /// presently ignored and can be null. (Prompt information is determined
        /// from the channel if necessary.)
        /// @param aCookie
        /// the cookie string to set.
        /// @param aChannel
        /// the channel used to load the document.  this parameter should not
        /// be null, otherwise the cookies will not be set if third-party
        /// cookies have been disabled by the user. (the channel is used
        /// to determine the originating URI of the document; if it is not
        /// provided, the cookies will be assumed third-party.)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt aPrompt, [MarshalAs(UnmanagedType.LPStr)] string aCookie, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Set the cookie string and expires associated with the URI.
        ///
        /// This function is NOT redundant with setCookieString, as the result
        /// will be different based on httponly (see bug 178993)
        ///
        /// @param aURI
        /// The URI of the document for which cookies are being queried.
        /// file:// URIs (i.e. with an empty host) are allowed, but any other
        /// scheme must have a non-empty host. A trailing dot in the host
        /// is acceptable, and will be stripped. This argument must not be null.
        /// @param aFirstURI
        /// the URI that the user originally typed in or clicked on to initiate
        /// the load of the document referenced by aURI.
        /// @param aPrompt
        /// the prompt to use for all user-level cookie notifications. This is
        /// presently ignored and can be null. (Prompt information is determined
        /// from the channel if necessary.)
        /// @param aCookie
        /// the cookie string to set.
        /// @param aServerTime
        /// the current time reported by the server, if available. This should
        /// be the string from the Date header in an HTTP response. If the
        /// string is empty or null, server time is assumed to be the current
        /// local time. If provided, it will be used to calculate the expiry
        /// time of the cookie relative to the server's local time.
        /// @param aChannel
        /// the channel used to load the document.  this parameter should not
        /// be null, otherwise the cookies will not be set if third-party
        /// cookies have been disabled by the user. (the channel is used
        /// to determine the originating URI of the document; if it is not
        /// provided, the cookies will be assumed third-party.)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt aPrompt, [MarshalAs(UnmanagedType.LPStr)] string aCookie, [MarshalAs(UnmanagedType.LPStr)] string aServerTime, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
	}
}
