using System;
using System.Runtime.InteropServices;

namespace twp
{
	namespace protocol
	{
		enum EVersion
		{
			PROTOCOL_VERSION_MAJOR	= 0,		//	协议主版本号
			PROTOCOL_VERSION_MINOR	= 1,		//	协议次版本号
		}
	
		//
		//	TWP 网络层保留的协议号区间
		//
	
		enum ERange
		{
			PROTOCOL_RESERVED_LOW		= 0,		//	net 保留的协议号，最小值
			PROTOCOL_RESERVED_HIGH		= 999,		//	net 保留的协议号，最大值
		
			MSG_APPLAYER_BASE			= 1000,		//	应用层协议起始号码
		
			MSG_APPLAYER_PER_INTERVAL	= 1000,   // 消息起始结束间隔
		
			//	cluster internal msgs
			MSG_BASE_INTERNAL			= MSG_APPLAYER_BASE + 100,
			MSG_BASE_C2FEP				= MSG_APPLAYER_BASE + 1000,
			MSG_BASE_C2LS				= MSG_APPLAYER_BASE + 2000,
			MSG_BASE_C2WS				= MSG_APPLAYER_BASE + 3000,
			MSG_BASE_C2SS				= MSG_APPLAYER_BASE + 4000,
			MSG_BASE_FEP2C				= MSG_APPLAYER_BASE + 5000,
			MSG_BASE_FEP2WS				= MSG_APPLAYER_BASE + 6000,
			MSG_BASE_FEP2LS				= MSG_APPLAYER_BASE + 7000,
			MSG_BASE_FEP2SS				= MSG_APPLAYER_BASE + 8000,
			MSG_BASE_WS2LS				= MSG_APPLAYER_BASE + 9000,
			MSG_BASE_WS2SS				= MSG_APPLAYER_BASE + 10000,
			MSG_BASE_WS2FEP				= MSG_APPLAYER_BASE + 11000,
			MSG_BASE_WS2DP				= MSG_APPLAYER_BASE + 12000,
			MSG_BASE_WS2C				= MSG_APPLAYER_BASE + 13000,
			MSG_BASE_LS2C				= MSG_APPLAYER_BASE + 14000,
			MSG_BASE_LS2DP				= MSG_APPLAYER_BASE + 15000,
			MSG_BASE_LS2FEP				= MSG_APPLAYER_BASE + 16000,
			MSG_BASE_LS2WS				= MSG_APPLAYER_BASE + 17000,
			MSG_BASE_SS2C				= MSG_APPLAYER_BASE + 18000,
			MSG_BASE_SS2WS				= MSG_APPLAYER_BASE + 19000,
			MSG_BASE_SS2DP				= MSG_APPLAYER_BASE + 20000,
			MSG_BASE_SS2FEP				= MSG_APPLAYER_BASE + 21000,
			MSG_BASE_DP2LS				= MSG_APPLAYER_BASE + 22000,
			MSG_BASE_DP2WS				= MSG_APPLAYER_BASE + 23000,
			MSG_BASE_DP2SS				= MSG_APPLAYER_BASE + 24000,
		
			// gde related
			MSG_GDE_BASE				= MSG_APPLAYER_BASE + 25000,
			MSG_BASE_C2GDES				= MSG_APPLAYER_BASE + 25100,
			MSG_BASE_GDES2GDES			= MSG_APPLAYER_BASE + 25200,
			MSG_BASE_GDES2C				= MSG_APPLAYER_BASE + 25300,
			
			// 其他server发送给dp的log消息
			MSG_BASE_LOG_S2DP			= MSG_APPLAYER_BASE + 26000,
		}
		
		public class PacketBase
		{
			public ushort header;
			
			public byte[] ToBin()
			{
				return System.BitConverter.GetBytes(header);
			}
			
			public void FromBin(NetSocket.ByteArray bin)
			{
				bin.Get_(out header);	
			}
		}
		
		// 作为 Client to Server 协议定义的基类
		public class PackBaseCTS : PacketBase
		{
			//	来源client的uid，FEP 发送前填充此数据
			public app.ClientUID client_uid;
			
			public PackBaseCTS()
			{
				client_uid = new app.ClientUID();
				client_uid.fepsrv_uid = 0;
				client_uid.fepsession_uid = 0;
			}
			
			public new byte[] ToBin()
			{
				NetSocket.ByteArray bin = new NetSocket.ByteArray();
				bin.Put(base.ToBin());
				bin.Put(client_uid.fepsrv_uid);
				bin.Put(client_uid.fepsession_uid);
				return bin.GetData();
			}
		};
		
		// 作为 Server to Client 协议定义的基类
		public class PackBaseSTC : PacketBase
		{
			// 来源client的uid，FEP 发送前清空此数据
			public twp.app.ClientUID client_uid;
			
			public PackBaseSTC()
			{
				client_uid = new twp.app.ClientUID();
			}

			public new void FromBin(NetSocket.ByteArray bin)
			{
				base.FromBin(bin);
				
				bin.Get_(out client_uid.fepsrv_uid);
				bin.Get_(out client_uid.fepsession_uid);
			}
		}
	
		enum EPacketLimit
        {
            MSG_MAX_CTS_PACK_LEN = 4096,
            MSG_MAX_STC_PACK_LEN = 4096,
        };
 
	}
}
