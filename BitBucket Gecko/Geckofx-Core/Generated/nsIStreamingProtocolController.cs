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
// Generated by IDLImporter from file nsIStreamingProtocolController.idl
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
    /// Metadata of the media stream.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("294adb30-856c-11e2-9e96-0800200c9a66")]
	public interface nsIStreamingProtocolMetaData
	{
		
		/// <summary>
        /// Frame type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFrameTypeAttribute();
		
		/// <summary>
        /// Frame type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFrameTypeAttribute(uint aFrameType);
		
		/// <summary>
        /// The total tracks for the given media stream session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTotalTracksAttribute();
		
		/// <summary>
        /// The total tracks for the given media stream session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTotalTracksAttribute(uint aTotalTracks);
		
		/// <summary>
        /// The mime type of the track.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType);
		
		/// <summary>
        /// The mime type of the track.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMimeTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aMimeType);
		
		/// <summary>
        /// The width of the resolution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetWidthAttribute();
		
		/// <summary>
        /// The width of the resolution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWidthAttribute(uint aWidth);
		
		/// <summary>
        /// The height of the resolution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHeightAttribute();
		
		/// <summary>
        /// The height of the resolution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeightAttribute(uint aHeight);
		
		/// <summary>
        /// The duration of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDurationAttribute();
		
		/// <summary>
        /// The duration of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDurationAttribute(ulong aDuration);
		
		/// <summary>
        /// The sample rate of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSampleRateAttribute();
		
		/// <summary>
        /// The sample rate of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSampleRateAttribute(uint aSampleRate);
		
		/// <summary>
        /// The timestamp indicates the stream absolute position
        /// relative to the beginning of the presentation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTimeStampAttribute();
		
		/// <summary>
        /// The timestamp indicates the stream absolute position
        /// relative to the beginning of the presentation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimeStampAttribute(ulong aTimeStamp);
		
		/// <summary>
        /// The total number of audio channels in the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetChannelCountAttribute();
		
		/// <summary>
        /// The total number of audio channels in the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannelCountAttribute(uint aChannelCount);
		
		/// <summary>
        /// The AAC audio codec specific data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEsdsDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEsdsData);
		
		/// <summary>
        /// The AAC audio codec specific data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEsdsDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEsdsData);
		
		/// <summary>
        /// The AVCC format extradata of H.264 stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAvccDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAvccData);
		
		/// <summary>
        /// The AVCC format extradata of H.264 stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAvccDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAvccData);
	}
	
	/// <summary>
    /// nsIStreamingProtocolListener
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c4f6b660-892e-11e2-9e96-0800200c9a66")]
	public interface nsIStreamingProtocolListener
	{
		
		/// <summary>
        /// Called when the data may be read without blocking the calling thread.
        /// @param index The track number of the media stream.
        /// @param data Raw data of the media stream on given track number.
        /// @param length The length of the raw data.
        /// @param offset The offset in the data stream from the start of the media
        /// presentation in bytes.
        /// @param meta The meta data of the frame.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnMediaDataAvailable(byte index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data, uint length, uint offset, [MarshalAs(UnmanagedType.Interface)] nsIStreamingProtocolMetaData meta);
		
		/// <summary>
        /// Called when the meta data for a given session is available.
        /// @param index The track number of the media stream.
        /// @param meta The meta data of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnConnected(byte index, [MarshalAs(UnmanagedType.Interface)] nsIStreamingProtocolMetaData meta);
		
		/// <summary>
        /// Called when the Rtsp session is closed.
        /// @param index Track number of the media stream.
        /// @param reason The reason of disconnection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnDisconnected(byte index, int reason);
	}
	
	/// <summary>
    /// Media stream controller API: control and retrieve meta data from media stream.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a9bdd4b0-8559-11e2-9e96-0800200c9a66")]
	public interface nsIStreamingProtocolController
	{
		
		/// <summary>
        /// Preprare the URI before we can start the connection.
        /// @param aUri The URI of the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);
		
		/// <summary>
        /// Asynchronously open this controller.  Data is fed to the specified
        /// media stream listener as it becomes available. If asyncOpen returns
        /// successfully, the controller is responsible for keeping itself alive
        /// until it has called onStopRequest on aListener.
        ///
        /// @param aListener The nsIStreamingProtocolListener implementation
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamingProtocolListener aListener);
		
		/// <summary>
        /// Get the metadata of a track.
        /// @param index Index of a track.
        /// @return A nsIStreamingProtocolMetaData.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamingProtocolMetaData GetTrackMetaData(System.IntPtr index);
		
		/// <summary>
        /// Tell the streaming server to start sending media data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Play();
		
		/// <summary>
        /// Tell the streaming server to pause sending media data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Pause();
		
		/// <summary>
        /// Tell the streaming server to resume the suspended media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		/// <summary>
        /// Tell the streaming server to suspend the media stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suspend();
		
		/// <summary>
        /// Tell the streaming server to send media data in specific time.
        /// @param seekTimeUs Start time of the media stream in microseconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Seek(ulong seekTimeUs);
		
		/// <summary>
        /// Tell the streaming server to stop the
        /// media stream and close the connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop();
		
		/// <summary>
        /// Total number of audio/video tracks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetTotalTracksAttribute();
	}
}
