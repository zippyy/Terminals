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
// Generated by IDLImporter from file nsINavBookmarksService.idl
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
    /// Observer for bookmarks changes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8ab925f8-af9b-4837-afa0-ffed507212ce")]
	public interface nsINavBookmarkObserver
	{
		
		/// <summary>
        /// Notifies that a batch transaction has started.
        /// Other notifications will be sent during the batch, but the observer is
        /// guaranteed that onEndUpdateBatch() will be called at its completion.
        /// During a batch the observer should do its best to reduce the work done to
        /// handle notifications, since multiple changes are going to happen in a short
        /// timeframe.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnBeginUpdateBatch();
		
		/// <summary>
        /// Notifies that a batch transaction has ended.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndUpdateBatch();
		
		/// <summary>
        /// Notifies that an item (any type) was added.  Called after the actual
        /// addition took place.
        /// When a new item is created, all the items following it in the same folder
        /// will have their index shifted down, but no additional notifications will
        /// be sent.
        ///
        /// @param aItemId
        /// The id of the item that was added.
        /// @param aParentId
        /// The id of the folder to which the item was added.
        /// @param aIndex
        /// The item's index in the folder.
        /// @param aItemType
        /// The type of the added item (see TYPE_* constants below).
        /// @param aURI
        /// The URI of the added item if it was TYPE_BOOKMARK, null otherwise.
        /// @param aTitle
        /// The title of the added item.
        /// @param aDateAdded
        /// The stored date added value, in microseconds from the epoch.
        /// @param aGUID
        /// The unique ID associated with the item.
        /// @param aParentGUID
        /// The unique ID associated with the item's parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemAdded(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, long aDateAdded, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGUID);
		
		/// <summary>
        /// Notifies that an item was removed.  Called after the actual remove took
        /// place.
        /// When an item is removed, all the items following it in the same folder
        /// will have their index shifted down, but no additional notifications will
        /// be sent.
        ///
        /// @param aItemId
        /// The id of the item that was removed.
        /// @param aParentId
        /// The id of the folder from which the item was removed.
        /// @param aIndex
        /// The bookmark's index in the folder.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aURI
        /// The URI of the added item if it was TYPE_BOOKMARK, null otherwise.
        /// @param aGUID
        /// The unique ID associated with the item.
        /// @param aParentGUID
        /// The unique ID associated with the item's parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemRemoved(long aItemId, long aParentId, int aIndex, ushort aItemType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGUID);
		
		/// <summary>
        /// Notifies that an item's information has changed.  This will be called
        /// whenever any attributes like "title" are changed.
        ///
        /// @param aItemId
        /// The id of the item that was changed.
        /// @param aProperty
        /// The property which changed.  Can be null for the removal of all of
        /// the annotations, in this case aIsAnnotationProperty is true.
        /// @param aIsAnnotationProperty
        /// Whether or not aProperty is the name of an annotation.  If true
        /// aNewValue is always an empty string.
        /// @param aNewValue
        /// For certain properties, this is set to the new value of the
        /// property (see the list below).
        /// @param aLastModified
        /// If lastModified changed, this parameter is the new value, otherwise
        /// it's set to 0.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aParentId
        /// The id of the folder containing the item.
        /// @param aGUID
        /// The unique ID associated with the item.
        /// @param aParentGUID
        /// The unique ID associated with the item's parent.
        ///
        /// @note List of values that may be associated with properties:
        /// aProperty     | aNewValue
        /// =====================================================================
        /// cleartime      | Empty string (all visits to this item were removed).
        /// title         | The new title.
        /// favicon       | The "moz-anno" URL of the new favicon.
        /// uri           | new URL.
        /// tags          | Empty string (tags for this item changed)
        /// dateAdded     | PRTime (as string) when the item was first added.
        /// lastModified  | PRTime (as string) when the item was last modified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemChanged(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aProperty, [MarshalAs(UnmanagedType.U1)] bool aIsAnnotationProperty, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNewValue, long aLastModified, ushort aItemType, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGUID);
		
		/// <summary>
        /// Notifies that the item was visited.  Can be invoked only for TYPE_BOOKMARK
        /// items.
        ///
        /// @param aItemId
        /// The id of the bookmark that was visited.
        /// @param aVisitId
        /// The id of the visit.
        /// @param aTime
        /// The time of the visit.
        /// @param aTransitionType
        /// The transition for the visit.  See nsINavHistoryService::TRANSITION_*
        /// constants for a list of possible values.
        /// @param aURI
        /// The nsIURI for this bookmark.
        /// @param aParentId
        /// The id of the folder containing the item.
        /// @param aGUID
        /// The unique ID associated with the item.
        /// @param aParentGUID
        /// The unique ID associated with the item's parent.
        ///
        /// @see onItemChanged with property = "cleartime" for when all visits to an
        /// item are removed.
        ///
        /// @note The reported time is the time of the visit that was added, which may
        /// be well in the past since the visit time can be specified.  This
        /// means that the visit the observer is told about may not be the most
        /// recent visit for that page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemVisited(long aItemId, long aVisitId, long aTime, uint aTransitionType, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, long aParentId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParentGUID);
		
		/// <summary>
        /// Notifies that an item has been moved.
        ///
        /// @param aItemId
        /// The id of the item that was moved.
        /// @param aOldParentId
        /// The id of the old parent.
        /// @param aOldIndex
        /// The old index inside the old parent.
        /// @param aNewParentId
        /// The id of the new parent.
        /// @param aNewIndex
        /// The index inside the new parent.
        /// @param aItemType
        /// The type of the item to be removed (see TYPE_* constants below).
        /// @param aGUID
        /// The unique ID associated with the item.
        /// @param aOldParentGUID
        /// The unique ID associated with the old item's parent.
        /// @param aNewParentGUID
        /// The unique ID associated with the new item's parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnItemMoved(long aItemId, long aOldParentId, int aOldIndex, long aNewParentId, int aNewIndex, ushort aItemType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOldParentGUID, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNewParentGUID);
	}
	
	/// <summary>
    /// The BookmarksService interface provides methods for managing bookmarked
    /// history items.  Bookmarks consist of a set of user-customizable
    /// folders.  A URI in history can be contained in one or more such folders.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("A78EA368-E28E-462E-897A-26606D4DDCE6")]
	public interface nsINavBookmarksService
	{
		
		/// <summary>
        /// The item ID of the Places root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetPlacesRootAttribute();
		
		/// <summary>
        /// The item ID of the bookmarks menu folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetBookmarksMenuFolderAttribute();
		
		/// <summary>
        /// The item ID of the top-level folder that contain the tag "folders".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetTagsFolderAttribute();
		
		/// <summary>
        /// The item ID of the unfiled-bookmarks folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetUnfiledBookmarksFolderAttribute();
		
		/// <summary>
        /// The item ID of the personal toolbar folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetToolbarFolderAttribute();
		
		/// <summary>
        /// Inserts a child bookmark into the given folder.
        ///
        /// @param aParentId
        /// The id of the parent folder
        /// @param aURI
        /// The URI to insert
        /// @param aIndex
        /// The index to insert at, or DEFAULT_INDEX to append
        /// @param aTitle
        /// The title for the new bookmark
        /// @param [optional] aGUID
        /// The GUID to be set for the new item.  If not set, a new GUID is
        /// generated.  Unless you've a very sound reason, such as an undo
        /// manager implementation, do not pass this argument.
        /// @return The ID of the newly-created bookmark.
        ///
        /// @note aTitle will be truncated to TITLE_LENGTH_MAX and
        /// aURI will be truncated to URI_LENGTH_MAX.
        /// @throws if aGUID is malformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int InsertBookmark(long aParentId, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID);
		
		/// <summary>
        /// Removes a child item. Used to delete a bookmark or separator.
        /// @param aItemId
        /// The child item to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveItem(long aItemId);
		
		/// <summary>
        /// Creates a new child folder and inserts it under the given parent.
        /// @param aParentFolder
        /// The id of the parent folder
        /// @param aName
        /// The name of the new folder
        /// @param aIndex
        /// The index to insert at, or DEFAULT_INDEX to append
        /// @param [optional] aGUID
        /// The GUID to be set for the new item.  If not set, a new GUID is
        /// generated.  Unless you've a very sound reason, such as an undo
        /// manager implementation, do not pass this argument.
        /// @return The ID of the newly-inserted folder.
        /// @throws if aGUID is malformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CreateFolder(long aParentFolder, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase name, int index, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID);
		
		/// <summary>
        /// Gets an undo-able transaction for removing a folder from the bookmarks
        /// tree.
        /// @param aItemId
        /// The id of the folder to remove.
        /// @return An object implementing nsITransaction that can be used to undo
        /// or redo the action.
        ///
        /// This method exists because complex delete->undo operations rely on
        /// recreated folders to have the same ID they had before they were deleted,
        /// so that any other items deleted in different transactions can be
        /// re-inserted correctly. This provides a safe encapsulation of this
        /// functionality without exposing the ability to recreate folders with
        /// specific IDs (potentially dangerous if abused by other code!) in the
        /// public API.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransaction GetRemoveFolderTransaction(long aItemId);
		
		/// <summary>
        /// Convenience function for container services.  Removes
        /// all children of the given folder.
        /// @param aItemId
        /// The id of the folder to remove children from.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFolderChildren(long aItemId);
		
		/// <summary>
        /// Moves an item to a different container, preserving its contents.
        /// @param aItemId
        /// The id of the item to move
        /// @param aNewParentId
        /// The id of the new parent
        /// @param aIndex
        /// The index under aNewParent, or DEFAULT_INDEX to append
        ///
        /// NOTE: When moving down in the same container we take into account the
        /// removal of the original item. If you want to move from index X to
        /// index Y > X you must use moveItem(id, folder, Y + 1)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveItem(long aItemId, long aNewParentId, int aIndex);
		
		/// <summary>
        /// Inserts a bookmark separator into the given folder at the given index.
        /// The separator can be removed using removeChildAt().
        /// @param aParentId
        /// The id of the parent folder
        /// @param aIndex
        /// The separator's index under folder, or DEFAULT_INDEX to append
        /// @param [optional] aGUID
        /// The GUID to be set for the new item.  If not set, a new GUID is
        /// generated.  Unless you've a very sound reason, such as an undo
        /// manager implementation, do not pass this argument.
        /// @return The ID of the new separator.
        /// @throws if aGUID is malformed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int InsertSeparator(long aParentId, int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGUID);
		
		/// <summary>
        /// Get the itemId given the containing folder and the index.
        /// @param aParentId
        /// The id of the diret parent folder of the item
        /// @param aIndex
        /// The index of the item within the parent folder.
        /// Pass DEFAULT_INDEX for the last item.
        /// @return The ID of the found item, -1 if the item does not exists.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIdForItemAt(long aParentId, int aIndex);
		
		/// <summary>
        /// Set the title for an item.
        /// @param aItemId
        /// The id of the item whose title should be updated.
        /// @param aTitle
        /// The new title for the bookmark.
        ///
        /// @note  aTitle will be truncated to TITLE_LENGTH_MAX.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aTitle);
		
		/// <summary>
        /// Get the title for an item.
        ///
        /// If no item title is available it will return a void string (null in JS).
        ///
        /// @param aItemId
        /// The id of the item whose title should be retrieved
        /// @return The title of the item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetItemTitle(long aItemId, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Set the date added time for an item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemDateAdded(long aItemId, long aDateAdded);
		
		/// <summary>
        /// Get the date added time for an item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetItemDateAdded(long aItemId);
		
		/// <summary>
        /// Set the last modified time for an item.
        ///
        /// @note This is the only method that will send an itemChanged notification
        /// for the property.  lastModified will still be updated in
        /// any other method that changes an item property, but we will send
        /// the corresponding itemChanged notification instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemLastModified(long aItemId, long aLastModified);
		
		/// <summary>
        /// Get the last modified time for an item.
        ///
        /// @note When an item is added lastModified is set to the same value as
        /// dateAdded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetItemLastModified(long aItemId);
		
		/// <summary>
        /// Get the URI for a bookmark item.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBookmarkURI(long aItemId);
		
		/// <summary>
        /// Get the index for an item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemIndex(long aItemId);
		
		/// <summary>
        /// Changes the index for a item. This method does not change the indices of
        /// any other items in the same folder, so ensure that the new index does not
        /// already exist, or change the index of other items accordingly, otherwise
        /// the indices will become corrupted.
        ///
        /// WARNING: This is API is intended for scenarios such as folder sorting,
        /// where the caller manages the indices of *all* items in the folder.
        /// You must always ensure each index is unique after a reordering.
        ///
        /// @param aItemId    The id of the item to modify
        /// @param aNewIndex  The new index
        ///
        /// @throws If aNewIndex is out of bounds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemIndex(long aItemId, int aNewIndex);
		
		/// <summary>
        /// Get an item's type (bookmark, separator, folder).
        /// The type is one of the TYPE_* constants defined above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetItemType(long aItemId);
		
		/// <summary>
        /// Checks whether a folder is marked as read-only.
        /// If this is set to true, UI will not allow the user to add, remove,
        /// or reorder children in this folder. The default for all folders is false.
        /// Note: This does not restrict API calls, only UI actions.
        ///
        /// @param aItemId
        /// the item-id of the folder.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFolderReadonly(long aItemId);
		
		/// <summary>
        /// Sets or unsets the readonly flag from a folder.
        /// If this is set to true, UI will not allow the user to add, remove,
        /// or reorder children in this folder. The default for all folders is false.
        /// Note: This does not restrict API calls, only UI actions.
        ///
        /// @param aFolder
        /// the item-id of the folder.
        /// @param aReadOnly
        /// the read-only state (boolean).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFolderReadonly(long aFolder, [MarshalAs(UnmanagedType.U1)] bool aReadOnly);
		
		/// <summary>
        /// Returns true if the given URI is in any bookmark folder. If you want the
        /// results to be redirect-aware, use getBookmarkedURIFor()
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsBookmarked([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Used to see if the given URI is bookmarked, or any page that redirected to
        /// it is bookmarked. For example, if I bookmark "mozilla.org" by manually
        /// typing it in, and follow the bookmark, I will get redirected to
        /// "www.mozilla.org". Logically, this new page is also bookmarked. This
        /// function, if given "www.mozilla.org", will return the URI of the bookmark,
        /// in this case "mozilla.org".
        ///
        /// If there is no bookmarked page found, it will return NULL.
        ///
        /// @note The function will only return bookmarks in the first 2 levels of
        /// redirection (1 -> 2 -> aURI).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBookmarkedURIFor([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Change the bookmarked URI for a bookmark.
        /// This changes which "place" the bookmark points at,
        /// which means all annotations, etc are carried along.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChangeBookmarkURI(long aItemId, [MarshalAs(UnmanagedType.Interface)] nsIURI aNewURI);
		
		/// <summary>
        /// Get the parent folder's id for an item.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFolderIdForItem(long aItemId);
		
		/// <summary>
        /// Returns the list of bookmark ids that contain the given URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBookmarkIdsForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref int[] bookmarks);
		
		/// <summary>
        /// Associates the given keyword with the given bookmark.
        ///
        /// Use an empty keyword to clear the keyword associated with the URI.
        /// In both of these cases, succeeds but does nothing if the URL/keyword is not found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetKeywordForBookmark(long aItemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aKeyword);
		
		/// <summary>
        /// Retrieves the keyword for the given URI. Will be void string
        /// (null in JS) if no such keyword is found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeywordForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Retrieves the keyword for the given bookmark. Will be void string
        /// (null in JS) if no such keyword is found.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeywordForBookmark(long aItemId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Returns the URI associated with the given keyword. Empty if no such
        /// keyword is found.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIForKeyword([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase keyword);
		
		/// <summary>
        /// Adds a bookmark observer. If ownsWeak is false, the bookmark service will
        /// keep an owning reference to the observer.  If ownsWeak is true, then
        /// aObserver must implement nsISupportsWeakReference, and the bookmark
        /// service will keep a weak reference to the observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer, [MarshalAs(UnmanagedType.U1)] bool ownsWeak);
		
		/// <summary>
        /// Removes a bookmark observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsINavBookmarkObserver observer);
		
		/// <summary>
        /// Runs the passed callback inside of a database transaction.
        /// Use this when a lot of things are about to change, for example
        /// adding or deleting a large number of bookmark items. Calls can
        /// be nested. Observers are notified when batches begin and end, via
        /// nsINavBookmarkObserver.onBeginUpdateBatch/onEndUpdateBatch.
        ///
        /// @param aCallback
        /// nsINavHistoryBatchCallback interface to call.
        /// @param aUserData
        /// Opaque parameter passed to nsINavBookmarksBatchCallback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RunInBatchMode([MarshalAs(UnmanagedType.Interface)] nsINavHistoryBatchCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
	}
	
	/// <summary>nsINavBookmarksServiceConsts </summary>
	public class nsINavBookmarksServiceConsts
	{
		
		// <summary>
        // This value should be used for APIs that allow passing in an index
        // where an index is not known, or not required to be specified.
        // e.g.: When appending an item to a folder.
        // </summary>
		public const short DEFAULT_INDEX = -1;
		
		// 
		public const ushort TYPE_BOOKMARK = 1;
		
		// 
		public const ushort TYPE_FOLDER = 2;
		
		// 
		public const ushort TYPE_SEPARATOR = 3;
		
		// <summary>
        // This const exists just to avoid reusing the value.
        // </summary>
		public const ushort TYPE_DYNAMIC_CONTAINER = 4;
	}
}
