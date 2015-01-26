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
// Generated by IDLImporter from file nsIContentSecurityPolicy.idl
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
    /// nsIContentSecurityPolicy
    /// Describes an XPCOM component used to model and enforce CSPs.  Instances of
    /// this class may have multiple policies within them, but there should only be
    /// one of these per document/principal.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8b91f829-b1bf-4327-8ece-4000aa823394")]
	public interface nsIContentSecurityPolicy : nsISerializable
	{
		
		/// <summary>
        /// Initialize the object implementing nsISerializable, which must have
        /// been freshly constructed via CreateInstance.  All data members that
        /// can't be set to default values must have been serialized by write,
        /// and should be read from aInputStream in the same order by this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);
		
		/// <summary>
        /// Serialize the object implementing nsISerializable to aOutputStream, by
        /// writing each data member that must be recovered later to reconstitute
        /// a working replica of this object, in a canonical member and byte order,
        /// to aOutputStream.
        ///
        /// NB: a class that implements nsISerializable *must* also implement
        /// nsIClassInfo, in particular nsIClassInfo::GetClassID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);
		
		/// <summary>
        /// Set to true when the CSP has been read in and parsed and is ready to
        /// enforce.  This is a barrier for the nsDocument so it doesn't load any
        /// sub-content until either it knows that a CSP is ready or will not be used.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInitializedAttribute();
		
		/// <summary>
        /// Set to true when the CSP has been read in and parsed and is ready to
        /// enforce.  This is a barrier for the nsDocument so it doesn't load any
        /// sub-content until either it knows that a CSP is ready or will not be used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedAttribute([MarshalAs(UnmanagedType.U1)] bool aIsInitialized);
		
		/// <summary>
        /// Accessor method for a read-only string version of the policy at a given
        /// index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPolicy(uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Returns the number of policies attached to this CSP instance.  Useful with
        /// getPolicy().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPolicyCountAttribute();
		
		/// <summary>
        /// Returns the number of policies attached to this CSP instance.  Useful with
        /// getPolicy().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPolicyCountAttribute(int aPolicyCount);
		
		/// <summary>
        /// Remove a policy associated with this CSP context.
        /// @throws NS_ERROR_FAILURE if the index is out of bounds or invalid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePolicy(uint index);
		
		/// <summary>
        /// Parse and install a CSP policy.
        /// @param aPolicy
        /// String representation of the policy (e.g., header value)
        /// @param selfURI
        /// the URI of the protected document/principal
        /// @param reportOnly
        /// Should this policy affect content, script and style processing or
        /// just send reports if it is violated?
        /// @param specCompliant
        /// Whether or not the policy conforms to the W3C specification.
        /// If this is false, that indicates this policy is from the older
        /// implementation with different semantics and directive names.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendPolicy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase policyString, [MarshalAs(UnmanagedType.Interface)] nsIURI selfURI, [MarshalAs(UnmanagedType.U1)] bool reportOnly, [MarshalAs(UnmanagedType.U1)] bool specCompliant);
		
		/// <summary>
        /// Whether this policy allows in-page script.
        /// @param shouldReportViolations
        /// Whether or not the use of inline script should be reported.
        /// This function always returns "true" for report-only policies, but when
        /// any policy (report-only or otherwise) is violated,
        /// shouldReportViolations is true as well.
        /// @return
        /// Whether or not the effects of the inline script should be allowed
        /// (block the compilation if false).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowsInlineScript([MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolations);
		
		/// <summary>
        /// whether this policy allows eval and eval-like functions
        /// such as setTimeout("code string", time).
        /// @param shouldReportViolations
        /// Whether or not the use of eval should be reported.
        /// This function returns "true" when violating report-only policies, but
        /// when any policy (report-only or otherwise) is violated,
        /// shouldReportViolations is true as well.
        /// @return
        /// Whether or not the effects of the eval call should be allowed
        /// (block the call if false).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowsEval([MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolations);
		
		/// <summary>
        /// Whether this policy allows in-page styles.
        /// This includes <style> tags with text content and style="" attributes in
        /// HTML elements.
        /// @param shouldReportViolations
        /// Whether or not the use of inline style should be reported.
        /// If there are report-only policies, this function may return true
        /// (don't block), but one or more policy may still want to send
        /// violation reports so shouldReportViolations will be true even if the
        /// inline style should be permitted.
        /// @return
        /// Whether or not the effects of the inline style should be allowed
        /// (block the rules if false).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowsInlineStyle([MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolations);
		
		/// <summary>
        /// Whether this policy accepts the given nonce
        /// @param aNonce
        /// The nonce string to check against the policy
        /// @param aContentType
        /// The type of element on which we encountered this nonce
        /// @param shouldReportViolation
        /// Whether or not the use of an incorrect nonce should be reported.
        /// This function always returns "true" for report-only policies, but when
        /// the report-only policy is violated, shouldReportViolation is true as
        /// well.
        /// @return
        /// Whether or not this nonce is valid
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowsNonce([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNonce, uint aContentType, [MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolation);
		
		/// <summary>
        /// Whether this policy accepts the given inline resource based on the hash
        /// of its content.
        /// @param aContent
        /// The content of the inline resource to hash (and compare to the
        /// hashes listed in the policy)
        /// @param aContentType
        /// The type of inline element (script or style)
        /// @param shouldReportViolation
        /// Whether this inline resource should be reported as a hash-source
        /// violation. If there are no hash-sources in the policy, this is
        /// always false.
        /// @return
        /// Whether or not this inline resource is whitelisted by a hash-source
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowsHash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aContent, ushort aContentType, [MarshalAs(UnmanagedType.U1)] ref bool shouldReportViolation);
		
		/// <summary>
        /// For each violated policy (of type violationType), log policy violation on
        /// the Error Console and send a report to report-uris present in the violated
        /// policies.
        ///
        /// @param violationType
        /// one of the VIOLATION_TYPE_* constants, e.g. inline-script or eval
        /// @param sourceFile
        /// name of the source file containing the violation (if available)
        /// @param contentSample
        /// sample of the violating content (to aid debugging)
        /// @param lineNum
        /// source line number of the violation (if available)
        /// @param aNonce
        /// (optional) If this is a nonce violation, include the nonce so we can
        /// recheck to determine which policies were violated and send the
        /// appropriate reports.
        /// @param aContent
        /// (optional) If this is a hash violation, include contents of the inline
        /// resource in the question so we can recheck the hash in order to
        /// determine which policies were violated and send the appropriate
        /// reports.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogViolationDetails(ushort violationType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceFile, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase scriptSample, int lineNum, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase nonce, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase content);
		
		/// <summary>
        /// Called after the CSP object is created to fill in appropriate request
        /// context and give it a reference to its owning principal for violation
        /// report generation.
        /// This will use whatever data is available, choosing earlier arguments first
        /// if multiple are available.  Either way, it will attempt to obtain the URI,
        /// referrer and the principal from whatever is available.  If the channel is
        /// available, it'll also store that for processing policy-uri directives.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestContext([MarshalAs(UnmanagedType.Interface)] nsIURI selfURI, [MarshalAs(UnmanagedType.Interface)] nsIURI referrer, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal documentPrincipal, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// Verifies ancestry as permitted by the policy.
        ///
        /// NOTE: Calls to this may trigger violation reports when queried, so this
        /// value should not be cached.
        ///
        /// @param docShell
        /// containing the protected resource
        /// @return
        /// true if the frame's ancestors are all allowed by policy (except for
        /// report-only policies, which will send reports and then return true
        /// here when violated).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PermitsAncestry([MarshalAs(UnmanagedType.Interface)] nsIDocShell docShell);
		
		/// <summary>
        /// Delegate method called by the service when sub-elements of the protected
        /// document are being loaded.  Given a bit of information about the request,
        /// decides whether or not the policy is satisfied.
        ///
        /// Calls to this may trigger violation reports when queried, so
        /// this value should not be cached.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldLoad(uint aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeTypeGuess, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra);
		
		/// <summary>
        /// Delegate method called by the service when sub-elements of the protected
        /// document are being processed.  Given a bit of information about the request,
        /// decides whether or not the policy is satisfied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ShouldProcess(uint aContentType, [MarshalAs(UnmanagedType.Interface)] nsIURI aContentLocation, [MarshalAs(UnmanagedType.Interface)] nsIURI aRequestOrigin, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType, [MarshalAs(UnmanagedType.Interface)] nsISupports aExtra);
	}
	
	/// <summary>nsIContentSecurityPolicyConsts </summary>
	public class nsIContentSecurityPolicyConsts
	{
		
		// 
		public const ushort VIOLATION_TYPE_INLINE_SCRIPT = 1;
		
		// 
		public const ushort VIOLATION_TYPE_EVAL = 2;
		
		// 
		public const ushort VIOLATION_TYPE_INLINE_STYLE = 3;
		
		// 
		public const ushort VIOLATION_TYPE_NONCE_SCRIPT = 4;
		
		// 
		public const ushort VIOLATION_TYPE_NONCE_STYLE = 5;
		
		// 
		public const ushort VIOLATION_TYPE_HASH_SCRIPT = 6;
		
		// 
		public const ushort VIOLATION_TYPE_HASH_STYLE = 7;
	}
}
