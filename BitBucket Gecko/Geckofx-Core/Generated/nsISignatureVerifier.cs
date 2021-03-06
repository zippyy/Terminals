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
// Generated by IDLImporter from file nsISignatureVerifier.idl
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
    /// NB: This isn't actually a principal at all. The naming is just historical.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("22870b07-b5ef-481b-9f7f-d41787d4e617")]
	public interface nsISignatureVerifier
	{
		
		/// <summary>
        ///-8172 is the error code returned by PSM </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICertificatePrincipal VerifySignature([MarshalAs(UnmanagedType.LPStr)] string aSignature, uint aSignatureLen, [MarshalAs(UnmanagedType.LPStr)] string plaintext, uint plaintextLen, ref int errorCode);
	}
	
	/// <summary>nsISignatureVerifierConsts </summary>
	public class nsISignatureVerifierConsts
	{
		
		// <summary>
        //Sig Verification Error Codes </summary>
		public const long VERIFY_OK = 0;
		
		// 
		public const long VERIFY_ERROR_UNKNOWN_CA = -8172;
	}
}
