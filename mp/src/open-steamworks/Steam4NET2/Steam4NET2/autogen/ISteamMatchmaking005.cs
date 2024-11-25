// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamMatchmaking005VTable
	{
		public IntPtr GetFavoriteGameCount0;
		public IntPtr GetFavoriteGame1;
		public IntPtr AddFavoriteGame2;
		public IntPtr RemoveFavoriteGame3;
		public IntPtr RequestLobbyList4;
		public IntPtr AddRequestLobbyListFilter5;
		public IntPtr AddRequestLobbyListNumericalFilter6;
		public IntPtr AddRequestLobbyListSlotsAvailableFilter7;
		public IntPtr AddRequestLobbyListNearValueFilter8;
		public IntPtr GetLobbyByIndex9;
		public IntPtr CreateLobby10;
		public IntPtr JoinLobby11;
		public IntPtr LeaveLobby12;
		public IntPtr InviteUserToLobby13;
		public IntPtr GetNumLobbyMembers14;
		public IntPtr GetLobbyMemberByIndex15;
		public IntPtr GetLobbyData16;
		public IntPtr SetLobbyData17;
		public IntPtr GetLobbyMemberData18;
		public IntPtr SetLobbyMemberData19;
		public IntPtr SendLobbyChatMsg20;
		public IntPtr GetLobbyChatEntry21;
		public IntPtr RequestLobbyData22;
		public IntPtr SetLobbyGameServer23;
		public IntPtr GetLobbyGameServer24;
		public IntPtr SetLobbyMemberLimit25;
		public IntPtr GetLobbyMemberLimit26;
		public IntPtr RequestFriendsLobbies27;
		public IntPtr SetLobbyType28;
		public IntPtr GetLobbyOwner29;
		public IntPtr GetLobbyDistance30;
		private IntPtr DTorISteamMatchmaking00531;
	};
	
	[InteropHelp.InterfaceVersion("SteamMatchMaking005")]
	public class ISteamMatchmaking005 : InteropHelp.NativeWrapper<ISteamMatchmaking005VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFavoriteGameCount( IntPtr thisptr );
		public Int32 GetFavoriteGameCount(  ) 
		{
			return this.GetFunction<NativeGetFavoriteGameCount>( this.Functions.GetFavoriteGameCount0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFavoriteGameIUUUUUU( IntPtr thisptr, Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetFavoriteGame( Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeGetFavoriteGameIUUUUUU>( this.Functions.GetFavoriteGame1 )( this.ObjectAddress, iGame, ref pnAppID, ref pnIP, ref pnConnPort, ref pnQueryPort, ref punFlags, ref pRTime32LastPlayedOnServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeAddFavoriteGameUUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer );
		public Int32 AddFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeAddFavoriteGameUUUUUU>( this.Functions.AddFavoriteGame2 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveFavoriteGameUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RemoveFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags ) 
		{
			return this.GetFunction<NativeRemoveFavoriteGameUUUUU>( this.Functions.RemoveFavoriteGame3 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestLobbyList( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 RequestLobbyList(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeRequestLobbyList>( this.Functions.RequestLobbyList4 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListFilterSS( IntPtr thisptr, string pchKeyToMatch, string pchValueToMatch );
		public void AddRequestLobbyListFilter( string pchKeyToMatch, string pchValueToMatch ) 
		{
			this.GetFunction<NativeAddRequestLobbyListFilterSS>( this.Functions.AddRequestLobbyListFilter5 )( this.ObjectAddress, pchKeyToMatch, pchValueToMatch ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListNumericalFilterSII( IntPtr thisptr, string pchKeyToMatch, Int32 nValueToMatch, Int32 nComparisonType );
		public void AddRequestLobbyListNumericalFilter( string pchKeyToMatch, Int32 nValueToMatch, Int32 nComparisonType ) 
		{
			this.GetFunction<NativeAddRequestLobbyListNumericalFilterSII>( this.Functions.AddRequestLobbyListNumericalFilter6 )( this.ObjectAddress, pchKeyToMatch, nValueToMatch, nComparisonType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListSlotsAvailableFilter( IntPtr thisptr );
		public void AddRequestLobbyListSlotsAvailableFilter(  ) 
		{
			this.GetFunction<NativeAddRequestLobbyListSlotsAvailableFilter>( this.Functions.AddRequestLobbyListSlotsAvailableFilter7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListNearValueFilterSI( IntPtr thisptr, string pchKeyToMatch, Int32 nValueToBeCloseTo );
		public void AddRequestLobbyListNearValueFilter( string pchKeyToMatch, Int32 nValueToBeCloseTo ) 
		{
			this.GetFunction<NativeAddRequestLobbyListNearValueFilterSI>( this.Functions.AddRequestLobbyListNearValueFilter8 )( this.ObjectAddress, pchKeyToMatch, nValueToBeCloseTo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iLobby );
		public CSteamID GetLobbyByIndex( Int32 iLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyByIndexI>( this.Functions.GetLobbyByIndex9 )( this.ObjectAddress, ref ret, iLobby ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreateLobbyE( IntPtr thisptr, ref UInt64 retarg, ELobbyType eLobbyType );
		public UInt64 CreateLobby( ELobbyType eLobbyType ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeCreateLobbyE>( this.Functions.CreateLobby10 )( this.ObjectAddress, ref ret, eLobbyType ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeJoinLobbyC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby );
		public UInt64 JoinLobby( CSteamID steamIDLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeJoinLobbyC>( this.Functions.JoinLobby11 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64() ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLeaveLobbyC( IntPtr thisptr, UInt64 steamIDLobby );
		public void LeaveLobby( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeLeaveLobbyC>( this.Functions.LeaveLobby12 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToLobbyCC( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDInvitee );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool InviteUserToLobby( CSteamID steamIDLobby, CSteamID steamIDInvitee ) 
		{
			return this.GetFunction<NativeInviteUserToLobbyCC>( this.Functions.InviteUserToLobby13 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDInvitee.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNumLobbyMembersC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetNumLobbyMembers( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetNumLobbyMembersC>( this.Functions.GetNumLobbyMembers14 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyMemberByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby, Int32 iMember );
		public CSteamID GetLobbyMemberByIndex( CSteamID steamIDLobby, Int32 iMember ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyMemberByIndexCI>( this.Functions.GetLobbyMemberByIndex15 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64(), iMember ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLobbyDataCS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey );
		public string GetLobbyData( CSteamID steamIDLobby, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLobbyDataCS>( this.Functions.GetLobbyData16 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			return this.GetFunction<NativeSetLobbyDataCSS>( this.Functions.SetLobbyData17 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLobbyMemberDataCCS( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDUser, string pchKey );
		public string GetLobbyMemberData( CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLobbyMemberDataCCS>( this.Functions.GetLobbyMemberData18 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDUser.ConvertToUint64(), pchKey ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyMemberDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		public void SetLobbyMemberData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			this.GetFunction<NativeSetLobbyMemberDataCSS>( this.Functions.SetLobbyMemberData19 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendLobbyChatMsgCBI( IntPtr thisptr, UInt64 steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendLobbyChatMsg( CSteamID steamIDLobby, Byte[] pvMsgBody ) 
		{
			return this.GetFunction<NativeSendLobbyChatMsgCBI>( this.Functions.SendLobbyChatMsg20 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pvMsgBody, (Int32) pvMsgBody.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyChatEntryCICBIE( IntPtr thisptr, UInt64 steamIDLobby, Int32 iChatID, ref UInt64 pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType );
		public Int32 GetLobbyChatEntry( CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, ref EChatEntryType peChatEntryType ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyChatEntryCICBIE>( this.Functions.GetLobbyChatEntry21 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), iChatID, ref s0, pvData, (Int32) pvData.Length, ref peChatEntryType ); pSteamIDUser = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestLobbyDataC( IntPtr thisptr, UInt64 steamIDLobby );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestLobbyData( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeRequestLobbyDataC>( this.Functions.RequestLobbyData22 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyGameServerCUUC( IntPtr thisptr, UInt64 steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, UInt64 steamIDGameServer );
		public void SetLobbyGameServer( CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer ) 
		{
			this.GetFunction<NativeSetLobbyGameServerCUUC>( this.Functions.SetLobbyGameServer23 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), unGameServerIP, unGameServerPort, steamIDGameServer.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLobbyGameServerCUUC( IntPtr thisptr, UInt64 steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref UInt64 psteamIDGameServer );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLobbyGameServer( CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyGameServerCUUC>( this.Functions.GetLobbyGameServer24 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), ref punGameServerIP, ref punGameServerPort, ref s0 ); psteamIDGameServer = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyMemberLimitCI( IntPtr thisptr, UInt64 steamIDLobby, Int32 cMaxMembers );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyMemberLimit( CSteamID steamIDLobby, Int32 cMaxMembers ) 
		{
			return this.GetFunction<NativeSetLobbyMemberLimitCI>( this.Functions.SetLobbyMemberLimit25 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), cMaxMembers ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyMemberLimitC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetLobbyMemberLimit( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetLobbyMemberLimitC>( this.Functions.GetLobbyMemberLimit26 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestFriendsLobbies( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RequestFriendsLobbies(  ) 
		{
			return this.GetFunction<NativeRequestFriendsLobbies>( this.Functions.RequestFriendsLobbies27 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyTypeCE( IntPtr thisptr, UInt64 steamIDLobby, ELobbyType eLobbyType );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetLobbyType( CSteamID steamIDLobby, ELobbyType eLobbyType ) 
		{
			return this.GetFunction<NativeSetLobbyTypeCE>( this.Functions.SetLobbyType28 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), eLobbyType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyOwnerC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby );
		public CSteamID GetLobbyOwner( CSteamID steamIDLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyOwnerC>( this.Functions.GetLobbyOwner29 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64() ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate double NativeGetLobbyDistanceC( IntPtr thisptr, UInt64 steamIDLobby );
		public double GetLobbyDistance( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetLobbyDistanceC>( this.Functions.GetLobbyDistance30 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
	};
}
