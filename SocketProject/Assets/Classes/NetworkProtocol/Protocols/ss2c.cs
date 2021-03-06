using System;
using twp.app.unit;
using twp.app;
using System.Runtime.InteropServices;

namespace twp
{
	namespace protocol
	{
		public class ss2c
		{			
#region
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_CHARACTER_INFO = (ushort)protocol.ERange.MSG_BASE_SS2C + 1;
			public const ushort kMSGIDX_ENTER_SCENE = (ushort)protocol.ERange.MSG_BASE_SS2C + 2;
			//////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_CHAT = (ushort)protocol.ERange.MSG_BASE_SS2C + 3;
			public const ushort kMSGIDX_REP_CHAT = (ushort)protocol.ERange.MSG_BASE_SS2C + 4;
			public const ushort kMSGIDX_NOTIFY_CHAR_MODIFICATION = (ushort)protocol.ERange.MSG_BASE_SS2C + 5;
			public const ushort kMSGIDX_REP_CLIENT_SETTINGS = (ushort)protocol.ERange.MSG_BASE_SS2C + 6;
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_NOTIFY_CD_TIME_UPDATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 7;
			public const ushort kMSGIDX_REP_CD_TIME_LIST = (ushort)protocol.ERange.MSG_BASE_SS2C + 8;
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_CLEAN_CD_TIME = (ushort)protocol.ERange.MSG_BASE_SS2C + 9;
			public const ushort kMSGIDX_TRANSFER_ERROR = (ushort)protocol.ERange.MSG_BASE_SS2C + 10;
			//////////////////////////////////////////////////////////////////////////
			// mail 11 - 19
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_MAIL_LIST = (ushort)protocol.ERange.MSG_BASE_SS2C + 11;
			public const ushort kMSGIDX_REP_READ_MAIL = (ushort)protocol.ERange.MSG_BASE_SS2C + 12;
			public const ushort kMSGIDX_NOTIFY_MAIL_COUNT = (ushort)protocol.ERange.MSG_BASE_SS2C + 13;
			public const ushort kMSGIDX_REP_MAIL_COMMAND = (ushort)protocol.ERange.MSG_BASE_SS2C + 14;
			public const ushort kMSGIDX_NOTIFY_DELETE_MAIL = (ushort)protocol.ERange.MSG_BASE_SS2C + 15;
			//////////////////////////////////////////////////////////////////////////
			// city 20 - 29
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_ALL_CITY = (ushort)protocol.ERange.MSG_BASE_SS2C + 21;// -- 所有城市id
			public const ushort kMSGIDX_REP_CITY_OPERATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 22;// -- 单体城市改变
			public const ushort kMSGIDX_REP_CITY_HERO_OPERATION = (ushort)protocol.ERange.MSG_BASE_SS2C + 23;// -- 英雄操作
			//////////////////////////////////////////////////////////////////////////
			// build 40 - 59
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_BUILD_OPERATION = (ushort)protocol.ERange.MSG_BASE_SS2C + 40;
			public const ushort kMSGIDX_REP_ADD_BUILD = (ushort)protocol.ERange.MSG_BASE_SS2C + 41;
			public const ushort kMSGIDX_REP_DEL_BUILD = (ushort)protocol.ERange.MSG_BASE_SS2C + 42;
			public const ushort kMSGIDX_REP_MOVE_BUILD = (ushort)protocol.ERange.MSG_BASE_SS2C + 43;
			//////////////////////////////////////////////////////////////////////////
			// build effect 50 - 59
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_HERO_INFO = (ushort)protocol.ERange.MSG_BASE_SS2C + 50;
			public const ushort kMSGIDX_REP_CALL_HERO = (ushort)protocol.ERange.MSG_BASE_SS2C + 51;
			//////////////////////////////////////////////////////////////////////////
			// hero effect 60 - 79
			/////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_ADD_HERO_INFO = (ushort)protocol.ERange.MSG_BASE_SS2C + 61;
			//////////////////////////////////////////////////////////////////////////
			// unit 80 - 89
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_UNIT_ENTERAOI = (ushort)protocol.ERange.MSG_BASE_SS2C + 80;// -- 单位进入
			public const ushort kMSGIDX_UNIT_LEAVEAOI = (ushort)protocol.ERange.MSG_BASE_SS2C + 81;// -- 单位离开
			public const ushort kMSGIDX_UNIT_MOVE = (ushort)protocol.ERange.MSG_BASE_SS2C + 82;// -- 单位移动
			//////////////////////////////////////////////////////////////////////////
			// instance 90 - 109
			/////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_INSTANCE_UDPATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 90;// -- 副本更新
			public const ushort kMSGIDX_REP_INSTANCE_RESUME = (ushort)protocol.ERange.MSG_BASE_SS2C + 91;// -- 数据恢复
			public const ushort kMSGIDX_REP_MONSTER_UPDATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 92;// -- 怪物更新
			public const ushort kMSGIDX_REP_COMBAT_OBJ_UPDATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 93;// -- 多体伤害
			//////////////////////////////////////////////////////////////////////////
			// 匹配 110 - 114
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_MATCH_OPERATE = (ushort)protocol.ERange.MSG_BASE_SS2C + 110; // -- 匹配操作下发
			//////////////////////////////////////////////////////////////////////////
			// shop  114 - 119
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_ITEM_TRADE_ITEM_LIST = (ushort)protocol.ERange.MSG_BASE_SS2C + 114;
			public const ushort kMSGIDX_REP_MARKET_RESULT = (ushort)protocol.ERange.MSG_BASE_SS2C + 115;// -- 商品操作结果
			//////////////////////////////////////////////////////////////////////////
			// 好友 120 - 129
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_RELATION_LIST = (ushort)protocol.ERange.MSG_BASE_SS2C + 121; // -- 好友列表
			public const ushort kMSGIDX_REP_RELATION_OPERATION_RESULT = (ushort)protocol.ERange.MSG_BASE_SS2C + 122; // -- 好友操作
			public const ushort kMSGIDX_UPDATE_RELATION_MEMBER = (ushort)protocol.ERange.MSG_BASE_SS2C + 123; // -- 更新好友
			/////////////////////////////////////////////////////////////////////////
			// aura 131 - 140
			public const ushort kMSGIDX_NOTIFY_AURA_EVENT_LIST = (ushort)protocol.ERange.MSG_BASE_SS2C + 131;// -- buffer更新
			/////////////////////////////////////////////////////////////////////////
			//////////////////////////////////////////////////////////////////////////
			// area 130 - 139
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_SHOW_AREA_DATA = (ushort)protocol.ERange.MSG_BASE_SS2C + 130;// -- 查看区域城市数据
			///////////////////////////////////////////////////////////////////////////
			// city caches (140 - 149)
			///////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_SEARCH_CITY_DATA = (ushort)protocol.ERange.MSG_BASE_SS2C + 140;// -- 显示城市数据
   
			//////////////////////////////////////////////////////////////////////////
			// 区域资源管理 (150 - 155) AreaResourceControl
			//////////////////////////////////////////////////////////////////////////
			public const ushort kMSGIDX_REP_UPDATE_AREA_RESOURCE_DATA = (ushort)protocol.ERange.MSG_BASE_SS2C + 150;// --更新区域资源个体
			#endregion
			//----------------------------------------------------------------------------------------
			//已修改 2013-8-13
			// 进入场景
			//			
			public class EnterScene : PackBaseSTC
			{
				public twp.app.scene.Location location = new twp.app.scene.Location ();
				// 副本创建规则
				public twp.app.scene.CreateInstanceRule instance_create_rules = new twp.app.scene.CreateInstanceRule ();
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					location.FromBin (bin);
					instance_create_rules.FromBin (bin);
				}	
				
			};
			
			//已修改 2013-8-13
			// 角色信息
			//  
			public class CharacterInfo : PackBaseSTC
			{
				public UInt32 last_login_ip;
				// char info
				public twp.app.unit.CharacterInfoForClient char_info;

				public CharacterInfo ()
				{
					header = kMSGIDX_CHARACTER_INFO;
					char_info = new twp.app.unit.CharacterInfoForClient ();
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					bin.Get_ (out last_login_ip);
					char_info.FromBin (bin);
				}
			}
			
			//
			// 角色属性改变通知
			//
			public class NotifyCharModification : PackBaseSTC
			{
				public enum ELimit
				{
					BUF_LEN = 4096,
				};
				// 实际的结构长度
				public UInt16 length;
				// mod的数量
				public UInt16 mod_count;
				// buff
				public byte[] buffer ;//= new byte[(int)ELimit.BUF_LEN];
				
				public NotifyCharModification ()
				{
					header = kMSGIDX_NOTIFY_CHAR_MODIFICATION;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);//10
					bin.Get_ (out length);//2
					bin.Get_ (out mod_count);//2
					buffer = bin.GetByteArray_ ((UInt16)(length - /*header = */10 - sizeof(UInt16) - sizeof(UInt16))); // 7 ?
				}
			};
			
			public class Chat :  PackBaseSTC
			{
				public twp.app.chat.ChatType chat_type;
				public UInt32 sender_idx;
				public string sender_name; //EUnitLimit.LIMIT_NAME_STR_LENGTH + 1
				public UInt16 chat_size;
				public string chat_txt; //ChatDefine.LIMIT_CHAT_TEXT_LENGTH + 1
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					uint chatType;
					bin.Get_ (out chatType);
					chat_type = (twp.app.chat.ChatType)chatType;
					bin.Get_ (out sender_idx);
					sender_name = bin.GetStringData ((int)EUnitLimit.LIMIT_NAME_STR_LENGTH + 1);
					bin.Get_ (out chat_size);
					chat_txt = bin.GetStringData ((int)(chat_size - bin.mRP));
				}
			};
			
			public class RepChat : PackBaseSTC
			{
				public enum Error_Type
				{
					E_CHAT_SUCCESS = 0,
					E_CHAT_NOT_ONLINE = 1,
					E_CHAT_NOT_IN_LEAGUE = 2,
				}
				
				public Error_Type result_type;
				
				public class DstOffline
				{
					UInt32 dst_char_idx;
					string dst_char_name;
				}
				
				public class DstRefuse
				{
					UInt32 dst_char_idx;
					string dst_char_name;
				}
				
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
				}
			};
			
			///////////////////////////////////////////////////////////////////////////
			// 副本
			///////////////////////////////////////////////////////////////////////////

			//
			// 副本更新
			//

			// -- begin
			public class NotifyInstanceSceneInfoUpdate : PackBaseSTC
			{
				// 游戏准备
				public class Into_Combat_Time //into_combat_time//8
				{
					public UInt32 cown_time; // 倒计时时间
					public UInt32 game_time; // 游戏总时间
					public void FromBin (NetSocket.ByteArray bin)
					{
						bin.Get_ (out cown_time);
						bin.Get_ (out game_time);
						bin.Move(14-8);
					}
				}
				
				// 游戏开始
				public class  Combat_End_Time//4
				{
					public UInt32 game_time;

					public void FromBin (NetSocket.ByteArray bin)
					{
						bin.Get_ (out game_time);
						bin.Move(14-4);
					}
				}
				
				// 单位出生
				public class Combat_Born//11
				{
					public twp.app.unit.UnitType type;
					public UInt32 obj_idx;
					public byte row;
					public byte col;
					public UInt32 dest_obj;
					
					public void FromBin (NetSocket.ByteArray bin)
					{
						byte temp;
						bin.Get_ (out temp);
						type = (twp.app.unit.UnitType)temp;
						
						bin.Get_ (out obj_idx);
						bin.Get_ (out row);
						bin.Get_ (out col);
						bin.Get_ (out dest_obj);
						bin.Move(14-11);
					}
				}

				// 游戏结束
				public class Combat_End//14
				{
					public twp.app.scene.CombatResultType result;// 结果
					public byte score;   // 评分
					public UInt32 copper; // 奖励铜币
					public UInt32 food;   // 奖励粮食
					public UInt32[] hero_loss = new UInt32[(int)twp.app.scene.ELimitInstance.INSTANCE_OVER_HERO_DIALOG_COUNT]; // 英雄损耗


					public void FromBin (NetSocket.ByteArray bin)
					{
						byte temp;
						bin.Get_ (out temp);
						result = (twp.app.scene.CombatResultType)temp;
						bin.Get_(out score);
						bin.Get_(out copper);
						bin.Get_(out food);
						for(int i = 0; i < (int)twp.app.scene.ELimitInstance.INSTANCE_OVER_HERO_DIALOG_COUNT; i++)
						{
							bin.Get_(out hero_loss[i]);
						}
						
					}
				}
				
				//C# 实现内联体(未经调试)
				//[StructLayout(LayoutKind.Explicit/*,Size=8*/)]  
				public class InnerUnion
				{  
					//[System.Runtime.InteropServices.FieldOffset(0)]  
					public Into_Combat_Time into_combat_time;//游戏准备
					
					// 游戏开始
					//[System.Runtime.InteropServices.FieldOffset(0)] 
					public Combat_End_Time combat_end_time;
					
					// 单位出生
					//[System.Runtime.InteropServices.FieldOffset(0)] 
					public Combat_Born combat_born;
					
					// 游戏结束
					//[System.Runtime.InteropServices.FieldOffset(0)] 
					public Combat_End combat_end;
					
					public void FromBin (twp.app.scene.InstanceEventType type, NetSocket.ByteArray bin)
					{
						switch (type) {
							
						case twp.app.scene.InstanceEventType.ET_INTO_COMBAT_TIME:
							{
								into_combat_time = new Into_Combat_Time ();
								into_combat_time.FromBin (bin);
								break;
							}
						case twp.app.scene.InstanceEventType.ET_INTO_COMBAT_SUCCED:
						case twp.app.scene.InstanceEventType.ET_INTO_COMBAT_FAIL:
							{
								combat_end_time = new Combat_End_Time ();
								combat_end_time.FromBin (bin);
								break;
							}
						case twp.app.scene.InstanceEventType.ET_ING_COMBAT_UNIT_BORN:
							{
								combat_born = new Combat_Born ();
								combat_born.FromBin (bin);
								break;
							}
						case twp.app.scene.InstanceEventType.ET_ING_COMBAT_OVER:
							{
								combat_end = new Combat_End ();
								combat_end.FromBin (bin);
								break;
							}
							
						}
						
					} 
				}
				
				// 事件类型
				public twp.app.scene.InstanceEventType event_type;
				public InnerUnion innerUnion = new InnerUnion ();
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					byte temp;
					bin.Get_ (out temp);
					event_type = (twp.app.scene.InstanceEventType)temp;
					innerUnion.FromBin (event_type, bin);
				}

			};
			
			
   //
   // 怪物更新
   //
   public class NotifyInstanceMonUpdate : PackBaseSTC
   {
    
    public class Unit_Born//16
    {
     public twp.app.unit.UnitID unit_idx = new twp.app.unit.UnitID();
	 public byte camp;
	 public UInt32 hp;
     public byte row;
     public byte col;
     
     public void FromBin(NetSocket.ByteArray bin)
     {
      unit_idx.FromBin(bin);
	  bin.Get_(out camp);
	  bin.Get_(out hp);
      bin.Get_(out row);
      bin.Get_(out col);
      
      bin.Move(18-16);
     }
    }
    
    public class Unit_Chage_Dest//18
    {
     public twp.app.unit.UnitID src_idx = new twp.app.unit.UnitID();
     public twp.app.unit.UnitID dst_idx = new twp.app.unit.UnitID();
     public void FromBin(NetSocket.ByteArray bin)
     {
      src_idx.FromBin(bin);
      dst_idx.FromBin(bin);
     }
    }
    
   // [StructLayout(LayoutKind.Explicit/*,Size=8*/)]  
    public class InnerUnion
    {
     // 单位出生
    // [System.Runtime.InteropServices.FieldOffset(0)] 
     public Unit_Born unit_born;
     
    // [System.Runtime.InteropServices.FieldOffset(0)] 
     // 改变攻击目标
     public Unit_Chage_Dest unit_chage_dest;
     
     public void FromBin(twp.app.scene.InstanceMonEventType type, NetSocket.ByteArray bin)
     {
      
      switch(type)
      {
      case twp.app.scene.InstanceMonEventType.ET_INFO_MON_BORN:
      {
       unit_born = new Unit_Born();
       unit_born.FromBin(bin);
       break;
      }
      case twp.app.scene.InstanceMonEventType.ET_INFO_MON_CHANGE_DEST:
      {
       unit_chage_dest = new  Unit_Chage_Dest();
       unit_chage_dest.FromBin(bin);
       
       break;
      }
      default:
      {
       UnityEngine.Debug.LogError("Unhandle type = " + type);
       break;
      }
       
      }
     }
     
    }
    
    public twp.app.scene.InstanceMonEventType event_type;
    public InnerUnion innerUnion = new InnerUnion();
    
    public NotifyInstanceMonUpdate()
    {
     header = kMSGIDX_REP_MONSTER_UPDATE;
    }
    
    public new void FromBin(NetSocket.ByteArray bin)
    {
     base.FromBin(bin);
     byte temp;
     bin.Get_(out temp);
     event_type = (twp.app.scene.InstanceMonEventType)temp;
     innerUnion.FromBin(event_type, bin);
    }
    
    
   };
   
   //
   // 多体效果
   //
   public class CombatHurtOjbectBase : PackBaseSTC
   {
    public twp.app.unit.UnitID src_idx = new twp.app.unit.UnitID();//攻击发起者
	public twp.app.unit.UnitID dest_idx = new twp.app.unit.UnitID();// 锁定目标
    
    public CombatHurtOjbectBase()
    {
     header = kMSGIDX_REP_COMBAT_OBJ_UPDATE;
    }
    
    public new void FromBin(NetSocket.ByteArray bin)
    {
     	base.FromBin(bin);
     	src_idx.FromBin(bin);
		dest_idx.FromBin(bin);
    }
   };

   // 怪物
   public class CombatMonHurtElem
   {
    public UInt32 hpValue;//攻击伤害血量
    public UInt32 hp;//当前血量
    
    public void FromBin(NetSocket.ByteArray bin)
    {
     bin.Get_(out hpValue);
     bin.Get_(out hp);
    }
   };

   // 建筑
   public class CombatBuildHurtElem
   {
    public UInt32 hpValue;//攻击伤害血量
    public UInt32 hp;//当前血量
    
    public void FromBin(NetSocket.ByteArray bin)
    {
     bin.Get_(out hpValue);
     bin.Get_(out hp);
    }
   };

   public class CombatHurtOjbectListElem
   {
    
    //[StructLayout(LayoutKind.Explicit/*,Size=8*/)] 
    public class InnerUnion
    {
     //[System.Runtime.InteropServices.FieldOffset(0)] 
     public CombatMonHurtElem mon;     // 怪物
     
     //[System.Runtime.InteropServices.FieldOffset(0)] 
     public CombatBuildHurtElem build; // 建筑
     
     public void FromBin(twp.app.unit.UnitType type ,NetSocket.ByteArray bin)
     {
      switch(type)
      {
       
      case twp.app.unit.UnitType.UNITTYPE_MONSTER:
      {
       mon = new CombatMonHurtElem();
       mon.FromBin(bin);
       break;
      }
      default:
      {
       build = new CombatBuildHurtElem();
       //???? All Left is Building???
       build.FromBin(bin);
       break;
      }
       
      }
       
     }
     
    }
    
    public twp.app.unit.UnitID unit_idx = new twp.app.unit.UnitID();
    
    public InnerUnion innerUnion = new InnerUnion();
    
    public void FromBin(NetSocket.ByteArray bin)
    {
     unit_idx.FromBin(bin);
     innerUnion.FromBin(unit_idx.type ,bin);
    }
    
    
   };

   public class CombatUpdateOjbectList : CombatHurtOjbectBase
   {
    //amount
    UInt16 _amount;

    public UInt16 amount {
     get{ return _amount;} 
    }
    
    //elem
    CombatHurtOjbectListElem[] _elems = new CombatHurtOjbectListElem[10];

    public CombatHurtOjbectListElem Get (UInt16 index)
    {
     return index >= _amount ? null : _elems [index];
    }
    
    public new void FromBin(NetSocket.ByteArray bin)
    {
     base.FromBin(bin);
     bin.Get_(out _amount);
     for (uint i = 0; i < _amount; ++i) {
      _elems [i] = new CombatHurtOjbectListElem ();
      _elems [i].FromBin (bin);
     }
     
    }
    
   };
   
   // end --

			//
			// 副本数据恢复
			//
			
			// -- begin

			// 建筑
			public class CombatResumeBuildData
			{
				public UInt32 build_idx; // 建筑ID
				public twp.app.build.BuildsType main_type; // 建筑类型
				public twp.app.build.SubType sub_type;
				public UInt16 level;     // 等级
				public byte row;        // 位置信息
				public byte col;
				
				public void FromBin (NetSocket.ByteArray bin)
				{
					bin.Get_ (out build_idx);
					
					byte tempType;
					bin.Get_ (out tempType);
					main_type = (twp.app.build.BuildsType)tempType;
					
					bin.Get_ (out tempType);
					sub_type = (twp.app.build.SubType)tempType;
					
					bin.Get_ (out level);
					bin.Get_ (out row);
					bin.Get_ (out col);
				}
			};

			// 英雄
			public class CombatResumeMonData
			{
				
				public UInt32 build_idx;   // 附属建筑ID
				public UInt32 mon_idx;     // 怪物ID
				public UInt32 mon_type;    // 怪物类型
				public byte mon_level;    // 怪物等级
				public UInt32 hp;          // 血量
				public UInt32 attack;      // 攻击力
				public UInt32 defense;     // 防御力
				
				public void FromBin (NetSocket.ByteArray bin)
				{
					bin.Get_ (out build_idx);
					bin.Get_ (out mon_idx);
					bin.Get_ (out mon_type);
					bin.Get_ (out mon_level);
					bin.Get_ (out hp);
					bin.Get_ (out attack);
					bin.Get_ (out defense);
					
				}
				
			};
			
			public class RepInstanceResumeBase : PackBaseSTC
			{
				public twp.app.scene.CombatResumeType type;
				public UInt32 char_idx; //所属玩家（系统为0）
				public twp.app.scene.CombatCampType camp; // 阵营
				
				public RepInstanceResumeBase ()
				{
					header = kMSGIDX_REP_INSTANCE_RESUME;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.scene.CombatResumeType)temp;
					
					bin.Get_ (out char_idx);
					
					bin.Get_ (out temp);
					camp = (twp.app.scene.CombatCampType)temp;
					
				}
				
			};
			
			public class RepInstanceResumeElem
			{
				public twp.app.scene.CombatResumeElemType type;
				
				
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					//[FieldOffset(0)]
					public CombatResumeBuildData build_data;    // 建筑信息
					//[FieldOffset(0)]
					public CombatResumeMonData mon_data;      // 英雄信息
					
					public void FromBin (twp.app.scene.CombatResumeElemType  type, NetSocket.ByteArray bin)
					{
						switch (type) {
						case twp.app.scene.CombatResumeElemType.RESUME_ELEM_TYPE_BUILD_DATA:
							{
								build_data = new CombatResumeBuildData ();
								build_data.FromBin (bin);
						
								bin.Move (25 - 10);
								break;
							}
						case twp.app.scene.CombatResumeElemType.RESUME_ELEM_TYPE_HERO_DATA:
							{
								mon_data = new CombatResumeMonData ();
								mon_data.FromBin (bin);
								break;
							}
						default:
							{
								//TDMacro.Assert (false, "Not Process the condition");
								break;
							}
							
						}
					}
				}
				
				public InnerUnion innerUnion = new InnerUnion ();
				
				public void FromBin (NetSocket.ByteArray bin)
				{
					byte tempType;
					bin.Get_ (out tempType);
					type = (twp.app.scene.CombatResumeElemType)tempType;
					innerUnion.FromBin (type, bin);
				}
			};

			public class CombatResumeList : RepInstanceResumeBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				//elem
				RepInstanceResumeElem[] _elems = new RepInstanceResumeElem[32];

				public RepInstanceResumeElem Get (UInt16 index)
				{
					return index >= _amount ? null : _elems [index];
				}
				
				//FromBin
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					bin.Get_ (out _amount);
					for (uint i = 0; i < _amount; ++i) {
						_elems [i] = new RepInstanceResumeElem ();
						_elems [i].FromBin (bin);
					}
				}
				
			}
			
			////////////////////////////////////////////////////
			// city
			////////////////////////////////////////////////////

			//用户的所有城市id
			public class CityIDForClient
			{
				public byte  area_id;
				public UInt64 city_idx;

				public void FromBin (NetSocket.ByteArray bin)
				{
					bin.Get_ (out area_id);
					bin.Get_ (out city_idx);
				}
			};
			
			public class RepAllCityBase : PackBaseSTC
			{
				public RepAllCityBase ()
				{
					header = kMSGIDX_REP_ALL_CITY;
				}
			};
			
			public class VarLenStruct_RepCityListBase : RepAllCityBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				//elem
				CityIDForClient[] _elems = new CityIDForClient[128];

				public CityIDForClient Get (UInt16 index)
				{
					return index >= _amount ? null : _elems [index];
				}
				
				//FromBin
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					bin.Get_ (out _amount);
					for (uint i = 0; i < _amount; ++i) {
						_elems [i] = new CityIDForClient ();
						_elems [i].FromBin (bin);
					}
				}
			}
			// 获得主要城市列表
			public class RepAllCityList : VarLenStruct_RepCityListBase
			{
			};
	
			// 主城操作 
			public class RepCityOperation : PackBaseSTC //(1)
			{
				public twp.app.unit.CityOperateType type;
			
				//[StructLayout(LayoutKind.Explicit/*, Size = 8*/)]
				public class InnerUnion
				{
					public class Create
					{
						public byte area;    // 地图ID
						public UInt64 city_id;// 城市id
						public twp.app.city.CitysType city_type; // 城市类型
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out area);
							bin.Get_ (out city_id);
							byte temp;
							bin.Get_ (out temp);
							city_type = (twp.app.city.CitysType)temp;
						}
					}
					
					//[FieldOffset(0)]
					public Create create;
					
					public void FromBin (NetSocket.ByteArray bin, twp.app.unit.CityOperateType type_)
					{
						switch (type_) {
						case twp.app.unit.CityOperateType.AREA_CITY_OPERATION_TYPE_CONSTRUCT:
							create = new Create ();
							create.FromBin (bin);
							break;
						default:
							//TDMacro.Assert (false, "Wrong CityOperateType, when parsing");
							break;
						}
					}
				}
				public InnerUnion innerUnion = new InnerUnion ();
				
				public  RepCityOperation ()
				{
					header = kMSGIDX_REP_SEARCH_CITY_DATA;	
				}

				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.unit.CityOperateType)temp;
					innerUnion.FromBin (bin, type);
				}		
			};
			
			//建筑操作返回
			public class RepBuildOperation : PackBaseSTC
			{
				public twp.app.build.BuildOperationEvent type;
				
				public enum ResultType
				{
					E_SERVER_ERROR = 0,//服务器内部错误
					E_SUCCESS ,//成功
					E_FAILED ,//失败
					E_NO_ENGINEER, //矮人工匠数量不够
					E_POS_ERROR ,//当前位置不可放置
				};
				public ResultType e_result;
				public byte area_idx;
				public UInt64 city_idx;
				public twp.app.build.BuildsType build_type; // 主类型
				
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					//[FieldOffset(0)]
					public twp.app.city.BuildsInfoDP base_build;
					//[FieldOffset(0)]
					public twp.app.city.WallsInfoDP wall_build;
					
					public void FromBin (NetSocket.ByteArray bin, twp.app.build.BuildsType build_type)
					{
						switch (build_type) {
						case twp.app.build.BuildsType.BUILD_TYPE_WALL:
							{
								wall_build = new twp.app.city.WallsInfoDP ();
								wall_build.FromBin (bin);
							}
							break;
						default:
							{
								base_build = new twp.app.city.BuildsInfoDP ();
								base_build.FromBin (bin);
							}
							break;
						}
					}
				}
				public InnerUnion innerUnion = new InnerUnion ();
				
				public RepBuildOperation ()
				{
					header = kMSGIDX_REP_BUILD_OPERATION;
				}
		
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.build.BuildOperationEvent)temp;
					
					bin.Get_ (out temp);
					e_result = (ResultType)temp;
					
					bin.Get_ (out area_idx);
					bin.Get_ (out city_idx);
					
					bin.Get_ (out temp);
					build_type = (twp.app.build.BuildsType)temp;
					
					innerUnion.FromBin (bin, build_type);
				
				}
			
			};
			
			public class RepHeroInfoBase : PackBaseSTC
			{
				public twp.app.hero.HERO_LIST_TYPE hero_list_type;

				public RepHeroInfoBase ()
				{
					header = kMSGIDX_REP_HERO_INFO;
				}

				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					int temp;
					bin.Get_ (out temp);
					hero_list_type = (twp.app.hero.HERO_LIST_TYPE)temp;
				}
			};

			public class VarLenStruct_RepHeroInfoBase : RepHeroInfoBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount {
					get {
						return _amount;
					}	
				}
				
				//elem
				public twp.app.hero.HeroForClient[] _elems = new twp.app.hero.HeroForClient[64];

				public twp.app.hero.HeroForClient Get (UInt16 index)
				{
					if (index >= _amount)
						return null;
					return _elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (uint i = 0; i < _amount; ++i) {
						_elems [i] = new twp.app.hero.HeroForClient ();
						_elems [i].FromBin (bin);
					}
				}
			}
			//英雄信息返回
			public class RepHeroInfo : VarLenStruct_RepHeroInfoBase
			{
			
			};
			
			//召唤英雄
			public class RepCallHero : PackBaseSTC
			{
				public enum ResultType
				{
					E_SUCCESS = 1,// 成功
					E_FAILED,
				};
				public ResultType e_result;
		
				public RepCallHero ()
				{
					header = kMSGIDX_REP_CALL_HERO;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					int temp;
					bin.Get_ (out temp);
					e_result = (ResultType)temp;
				}
			};	
			
			////////////////////////////////////////////////////////////////////////
			// 冷却时间 begin
			////////////////////////////////////////////////////////////////////////
			public class RepCdTimeListElem
			{
				// cd类别
				public UInt32 cd_sort;
				// cd时间
				public UInt32 cd_remain_time;
				
				public void FromBin (NetSocket.ByteArray bin)
				{
					bin.Get_ (out cd_sort);
					bin.Get_ (out cd_remain_time);
				}
			};
			
			//
			// 冷却时间列表
			//
			public class RepCdTimeListBase : PackBaseSTC
			{
				public RepCdTimeListBase ()
				{
					header = kMSGIDX_REP_CD_TIME_LIST;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
				}
			};
			
			public class VarLenStruct_RepCdTimeList : RepCdTimeListBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount { get { return _amount; } }
				
				//elem
				public RepCdTimeListElem[] _elems = new RepCdTimeListElem[32];

				public RepCdTimeListElem Get (UInt16 index)
				{
					if (index >= _amount)
						return null;
					return _elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (uint i = 0; i < _amount; ++i) {
						if (null == _elems [i])
							_elems [i] = new RepCdTimeListElem ();
						_elems [i].FromBin (bin);
					}
				}
			};
			
			public class RepCdTimeList : VarLenStruct_RepCdTimeList
			{
				
			};
			
			//
			// 更新冷却时间
			// 
			public class NotifyUpdateCdTimeListBase : PackBaseSTC
			{
				NotifyUpdateCdTimeListBase ()
				{
					header = kMSGIDX_NOTIFY_CD_TIME_UPDATE;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
				}

			};
			
			public class VarLenStruct_NotifyUpdateCdTimeList : RepCdTimeListBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount { get { return _amount; } }
				
				//elem
				public RepCdTimeListElem[] _elems = new RepCdTimeListElem[32];

				public RepCdTimeListElem Get (UInt16 index)
				{
					if (index >= _amount)
						return null;
					return _elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (uint i = 0; i < _amount; ++i) {
						if (null == _elems [i])
							_elems [i] = new RepCdTimeListElem ();
						_elems [i].FromBin (bin);
					}
				}
			};
			
			public class NotifyUpdateCdTimeList : VarLenStruct_NotifyUpdateCdTimeList
			{
				
			};
			
			public class RepCleanCdTime : PackBaseSTC
			{
				public enum E_RESULT
				{
					S_SUCCESS = 0,
					E_FAILED,
				}
				
				public E_RESULT e_result;
				public UInt32 cd_sort;
				
				public RepCleanCdTime ()
				{
					header = kMSGIDX_REP_CLEAN_CD_TIME;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					Int32 enumValue;
					bin.Get_ (out enumValue);
					e_result = (E_RESULT)enumValue;
					bin.Get_ (out cd_sort);
				}
			};
			////////////////////////////////////////////////////////////////////////
			// 冷却时间 end
			////////////////////////////////////////////////////////////////////////
			
			////////////////////////////////////////////////////////////////
			// area
			////////////////////////////////////////////////////////////////

			// 显示区域中城市数据

			public class RepShowAreaBase : PackBaseSTC
			{
				public byte area;  // 区域id
				public RepShowAreaBase ()
				{
					header = kMSGIDX_REP_SHOW_AREA_DATA;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out area);
				}
			};

			public class RepShowAreaElem
			{
				public byte country;                      // 国家
				public string name;	//twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1// 玩家名字
				public UInt32 battle_integral;             // 战斗积分
				public UInt64 city_idx;                    // 城市id
				public byte city_level;                   // 主城等级
				
				public void FromBin (NetSocket.ByteArray bin)
				{
					bin.Get_ (out country);
					name = bin.GetStringData ((int)(twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1));
					bin.Get_ (out battle_integral);
					bin.Get_ (out city_idx);
					bin.Get_ (out city_level);
				}
			};
	
			public class VarLenStruct_RepShowAreaBase : RepShowAreaBase
			{
				//amount
				UInt16 _amount;

				public UInt16 amount {
					get {
						return _amount;	
					}
				}
			
				//elem
				RepShowAreaElem[] _elems = new RepShowAreaElem[25];

				public RepShowAreaElem Get (UInt16 index)
				{
					if (index >= _amount)
						return null;
					return _elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					bin.Get_ (out _amount);
					for (UInt16 i = 0; i < _amount; ++i) {
						_elems [i] = new RepShowAreaElem ();
						_elems [i].FromBin (bin);
					}
				}
			}
	
			public class RepShowAreaList : VarLenStruct_RepShowAreaBase
			{

			};
//================================================================//			
			public class RepSearchCityDataBase : PackBaseSTC
			{
				public byte area_id;
				public UInt64 city_id;
				public UInt32 char_idx;//城市所属玩家
				public RepSearchCityDataBase ()
				{
					header = kMSGIDX_REP_SEARCH_CITY_DATA;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);	
					bin.Get_ (out area_id);
					bin.Get_ (out city_id);
					bin.Get_ (out char_idx);
				}
			};
			
			public class ResumeBuildData
			{// 建筑数据
				public twp.app.city.BuildsInfoDP data = new twp.app.city.BuildsInfoDP ();

				public void FromBin (NetSocket.ByteArray bin)
				{
					data.FromBin (bin);	
				}
			};

			public class ResumeWallData
			{// 城墙数据
				public twp.app.city.WallsInfoDP data = new twp.app.city.WallsInfoDP ();

				public void FromBin (NetSocket.ByteArray bin)
				{
					data.FromBin (bin);	
				}
			};

			public class ResumeHeroData
			{
				public twp.app.city.CityResumeElemType type;

				void FromBin (NetSocket.ByteArray bin)
				{
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.city.CityResumeElemType)temp;
				}
			};

			public class RepSearchCityDataElem
			{
				public twp.app.city.CityResumeElemType type;
				
				//[StructLayout(LayoutKind.Explicit)]
    	public class InnerUnion
				{
					//[FieldOffset(0)]
					public ResumeBuildData builds;
					//[FieldOffset(0)]
					public ResumeWallData walls;

					public void FromBin (NetSocket.ByteArray bin, twp.app.city.CityResumeElemType type_)
					{
						switch (type_) {
						case twp.app.city.CityResumeElemType.RESUME_ELEM_TYPE_BUILD:
							builds = new ResumeBuildData ();
							builds.FromBin (bin);
							break;
						case twp.app.city.CityResumeElemType.RESUME_ELEM_TYPE_WALL:
							walls = new ResumeWallData ();
							walls.FromBin (bin);
							break;
						default:
							break;
						}	
					}
				};
				public InnerUnion innerUnion = new InnerUnion ();

				public void FromBin (NetSocket.ByteArray bin)
				{
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.city.CityResumeElemType)temp;
					innerUnion.FromBin (bin, type);
				}
			};
			
			public class VarLenStruct_RepSearchCityDataBase : RepSearchCityDataBase
			{
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				RepSearchCityDataElem[] elems = new RepSearchCityDataElem[64];

				public RepSearchCityDataElem Get (UInt16 index)
				{
					return index >= _amount ? null : elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					bin.Get_ (out _amount);
					for (UInt16 i = 0; i < _amount; ++i) {
						elems [i] = new RepSearchCityDataElem ();
						elems [i].FromBin (bin);
					}
				}
			}

			public class RepSearchCityDataList : VarLenStruct_RepSearchCityDataBase
			{
				
			}
//================================================================//	
			
			//掠夺是匹配，抢占是玩家选择
			public class RepMatchInfo : PackBaseSTC
			{
				public	twp.app.mate.MatchOperateType  type;
				
				//[StructLayout(LayoutKind.Explicit)]
			public class InnerUnion
				{
					public class Match_Enemy
					{
						public byte map_id;         //地图ID
						public UInt64 city_id;     //主城ID
						public UInt32 char_idx;    //玩家ID
						public byte country; 		//国家
						public string char_name;
						//	public byte[] char_name = new byte[(UInt16)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1];//玩家名称
						public UInt32 battle_integral;//战斗积分
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out map_id);
							bin.Get_ (out city_id);
							bin.Get_ (out char_idx);
							bin.Get_ (out country);
							char_name = bin.GetStringData ((UInt16)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1);
							//			for (UInt16 i = 0; i < (UInt16)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1; ++i) {
							//				bin.Get_ (out char_name [i]);
							//			}
							bin.Get_ (out battle_integral);
						}
					}
					//[FieldOffset(0)]
					public Match_Enemy match_Enemy;
					
					public void FromBin (twp.app.mate.MatchOperateType  type, NetSocket.ByteArray bin)
					{
						switch (type) {
						case twp.app.mate.MatchOperateType.PLAYER_OPERATE_MATCH_CITY:
							match_Enemy = new Match_Enemy ();
							match_Enemy.FromBin (bin);
							break;
						default:
#if true
							match_Enemy = new Match_Enemy ();
							match_Enemy.FromBin (bin);
#endif
							break;
						}
					}
				}
				
				public InnerUnion innerUnion = new InnerUnion ();
				
				public RepMatchInfo ()
				{
					header = kMSGIDX_REP_MATCH_OPERATE;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.mate.MatchOperateType)temp;
					innerUnion.FromBin (type, bin);
				}
			};

			public class RepCityHeroOperation : PackBaseSTC
			{
				public twp.app.city.CityHeroOperate type;
				public twp.app.hero.E_HERO_TYPE result;
				public byte area_id;
				public UInt64 city_id;
				
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					//召唤英雄
					public class Summon_Hero
					{
						public twp.app.hero.HeroForClient hero = new twp.app.hero.HeroForClient ();

						public void FromBin (NetSocket.ByteArray bin)
						{
							hero.FromBin (bin);	
						}
					}
					//召唤前浏览英雄信息
					public class Browser_Hero
					{
						public twp.app.hero.BrowserHero hero = new twp.app.hero.BrowserHero ();

						public void FromBin (NetSocket.ByteArray bin)
						{
							hero.FromBin (bin);
						}
					}
					//升级后的英雄
					public class Levelup_Hero
					{
						public twp.app.hero.HeroForClient hero = new twp.app.hero.HeroForClient ();
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							hero.FromBin (bin);
						}
					};
					//解雇英雄
					public class Fire_Hero
					{
						public UInt64 hero_id;
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);	
						}
					};
					//购买次数
					public class Buy_Train_Times
					{
						public UInt64 hero_id;
						public UInt32 train_times;
						public UInt32 buy_train_times;
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out train_times);
							bin.Get_ (out buy_train_times);
						}
					};
					//技能学习 & 升级技能
					public class Learn_Skill
					{
						public UInt64 hero_id;
						public UInt32 skill_id;
						public UInt32 remove_skill_id; //要删除的技能， 技能升级后id不一样
						public UInt32 levelup_cd;
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out skill_id);
							bin.Get_ (out remove_skill_id);
							bin.Get_ (out levelup_cd);
						}
					};
					//培养英雄
					public class Train_Hero
    			 	{
      					public UInt64 hero_id;//英雄id hero_id 0表示一键培养, 其他id表示对应的英雄培养
      					public UInt32 attack;
      					public UInt32 defense;
      					public UInt32 max_hp;
      					public UInt32 hp;
						public UInt32 train_times;
						public UInt32 buy_train_times;
						
						public void FromBin (NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out attack);
							bin.Get_ (out defense);
							bin.Get_ (out max_hp);
							bin.Get_ (out hp);
							bin.Get_ (out train_times);
							bin.Get_ (out buy_train_times);
						}
     				}; 

          			public class Build_Add_Hero//进驻
    			 	{
     				 	public UInt64 hero_id;
      					public UInt16 build_id;
      					public UInt16 build_order;//如果发0过来的话，具体顺序就服务端这边帮你算的, 非0就直接插入到对应的位置中
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_ (out 	hero_id);
							bin.Get_ (out build_id);
							bin.Get_ (out build_order);
						}
    				 }; 

     				public class Build_Del_Hero//离开建筑
     				{
      					public UInt64 hero_id;
      					public UInt16 build_id;
      					public UInt16 build_order;
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out build_id);
							bin.Get_ (out build_order);
						}
     				}; 
					
					     public class Clean_Train_Cd//清除培养cd
     				{
      					public UInt64 hero_id;
      					public UInt32 train_cd_times;
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out train_cd_times);
						}
     				}; 

     				public class Clean_Skill_Cd//清除升级技能cd
     				{
      					public UInt64 hero_id;
      					public UInt32 skill_id;
      					public UInt32 skill_cd_times;
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_ (out hero_id);
							bin.Get_ (out skill_id);
							bin.Get_ (out skill_cd_times);
						}
     				}; 
	#region				
					//[FieldOffset(0)]
					public Summon_Hero summon_hero;
					//[FieldOffset(0)]
					public Browser_Hero browse_hero;
					//[FieldOffset(0)]
					public Levelup_Hero levelup_hero;
					//[FieldOffset(0)]
					public Fire_Hero fire_hero;
					//[FieldOffset(0)]
					public Buy_Train_Times buy_train_times;
					//[FieldOffset(0)]
					public Learn_Skill learn_skill;
					//[FieldOffset(0)]
					public Train_Hero train_hero;
					//[FieldOffset(0)]
					public Build_Add_Hero build_add_hero;
					//[FieldOffset(0)]
					public Build_Del_Hero build_del_hero;
					//[FieldOffset(0)]
					public Clean_Train_Cd clean_train_cd;
					//[FieldOffset(0)]
					public Clean_Skill_Cd clean_skill_cd;
	#endregion				
					public void FromBin (NetSocket.ByteArray bin, twp.app.city.CityHeroOperate type)
					{
						switch (type) {
						case twp.app.city.CityHeroOperate.CITY_CALL_HERO://召唤英雄
							{
								summon_hero = new Summon_Hero ();
								summon_hero.FromBin (bin);
							}
							break;
						case twp.app.city.CityHeroOperate.CITY_CALL_BROWSER_HERO://召唤前浏览英雄信息
							{
								browse_hero = new Browser_Hero ();
								browse_hero.FromBin (bin);
							}
							break;
						case twp.app.city.CityHeroOperate.CITY_LEVEL_UP_HERO://升级后的英雄
							{
								levelup_hero = new Levelup_Hero ();
								levelup_hero.FromBin (bin);
							}
							break;
						case twp.app.city.CityHeroOperate.CITY_FIRE_HERO://解雇英雄
							{
								fire_hero = new Fire_Hero ();
								fire_hero.FromBin (bin);
							}
							break;
						case twp.app.city.CityHeroOperate.CITY_BUY_TRAIN_TIMES://购买次数
							{
								buy_train_times = new Buy_Train_Times ();
								buy_train_times.FromBin (bin);
							}
							break;
					//	case twp.app.city.CityHeroOperate.CITY_LEVEL_UP_HERO_SKILL:
					//		goto case twp.app.city.CityHeroOperate.CITY_HERO_LEARN_SKILL;
						case twp.app.city.CityHeroOperate.CITY_HERO_LEARN_SKILL:
							{
								learn_skill = new Learn_Skill ();
								learn_skill.FromBin (bin);
							}
							break;
						case twp.app.city.CityHeroOperate.CITY_TRAIN_HERO:
						{
								train_hero = new Train_Hero();
								train_hero.FromBin(bin);
						}	
							break;
						case twp.app.city.CityHeroOperate.CITY_BUILD_ADD_HERO:
						{
							build_add_hero = new Build_Add_Hero();
							build_add_hero.FromBin(bin);
						}
							break;
						case twp.app.city.CityHeroOperate.CITY_BUILD_DEL_HERO:
						{
							build_del_hero = new Build_Del_Hero();
							build_del_hero.FromBin(bin);
						}
							break;
						case twp.app.city.CityHeroOperate.CITY_GIVE_UP_BROWSER_HERO:
						{
							//哈哈└(^o^)┘
						}
							break;
						case twp.app.city.CityHeroOperate.CITY_HERO_CLEAN_TRAIN_CD:
						{
							clean_train_cd = new Clean_Train_Cd();
							clean_train_cd.FromBin(bin);
						}
							break;	
						case twp.app.city.CityHeroOperate.CITY_HERO_CLEAN_SKILL_CD:
						{
							clean_skill_cd = new Clean_Skill_Cd();
							clean_skill_cd.FromBin(bin);
						}
							break;
						default:
							UnityEngine.Debug.LogError ("twp.app.city.CityHeroOperate error:" + type);
							break;
						}
					}
				}
				public InnerUnion innerUnion = new InnerUnion ();
					
				public RepCityHeroOperation ()
				{
					header = kMSGIDX_REP_CITY_HERO_OPERATION;	
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					byte temp;
					bin.Get_ (out temp);
					type = (twp.app.city.CityHeroOperate)temp;
					
					int temp0;
					bin.Get_ (out temp0);
					result = (twp.app.hero.E_HERO_TYPE)temp0;
					
					//---------------
					//---------------
					bin.Get_ (out area_id);
					bin.Get_ (out city_id);
					innerUnion.FromBin (bin, type);
				}
			};
			
	//
			// 跳转场景失败原因
			//
			public class TransferError : PackBaseSTC
			{
				public enum Result
				{
					E_FAILED_UNKNOWERROR = 0,
					E_FAILED_NOTEXIST,		// 不存在
					E_FAILED_INTOCOMBAT,	// 战斗中
					// 队友不在主场景 无法完成
					E_FAILED_GROUP_MEMBER_NOT_IN_MAINWORLD_SCENE,
				}
				
				public class Group_Member
				{
					public UInt32 char_idx;

					public void FromBin (NetSocket.ByteArray bin)
					{
						bin.Get_ (out char_idx);
					}
				}
				
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					//[FieldOffset(0)]
					public Group_Member group_member;
					
					public void FromBin (NetSocket.ByteArray bin)
					{
						group_member = new Group_Member ();
						group_member.FromBin (bin);
					}
				}
				
				public Result result;
				public InnerUnion innerUnion = new InnerUnion ();

				public TransferError ()
				{
					header = kMSGIDX_TRANSFER_ERROR;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					int temp;
					bin.Get_ (out temp);
					result = (Result)temp;
					
					innerUnion.FromBin (bin);
				}
			};
			
			
			//////////////////////////////////////////////////////////////////////////
			//区域资源管理 
			//////////////////////////////////////////////////////////////////////////
			// 区域资源更新
			public class RepUpdateAreaResource : PackBaseSTC
			{
				public byte area_idx; //区域
				public twp.app.resource.AreaResourceType area_resouce_type; //操作类型
			
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					public class Resouce
					{  //资源更新
						public twp.app.resource.ResourceType type;  //资源类型
						//resource::OperateType  operate_type;//资源操作方式（+，-）
						public UInt32 amount;                      // 数量
						public void FromBin(NetSocket.ByteArray bin){
							//
							byte temp;
							bin.Get_ (out temp);
							type = (twp.app.resource.ResourceType)temp;
							//
							bin.Get_ (out amount);
						}
					}
					public class Engineer
					{ //工程师更新
						public twp.app.resource.EngineerType type; //工程师状态
						public twp.app.resource.Engineer engineer_info = new twp.app.resource.Engineer();//工程师数据
						public void FromBin(NetSocket.ByteArray bin){
							//
							byte temp;
							bin.Get_ (out temp);
							type = (twp.app.resource.EngineerType)temp;
							//
							engineer_info.FromBin(bin);
						}
					}
					
					//[FieldOffset(0)]
					public Resouce resouce;
					//[FieldOffset(0)]
					public Engineer engineer;
					
					public void FromBin(NetSocket.ByteArray bin, twp.app.resource.AreaResourceType type){
							switch (type) {
						case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_RESOURCE:
							goto case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_RESOURCE_MAX;
						case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_RESOURCE_MAX:
						{
							resouce = new Resouce();
							resouce.FromBin(bin);
						}
							break;
						case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_ENGINEER:
							goto case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_ENGINEER_MAX;
						case twp.app.resource.AreaResourceType.AREA_RESOURCE_TYPE_ENGINEER_MAX:
						{
							engineer = new Engineer();
							engineer.FromBin(bin);
						}
							break;
							default:
							break;
						}
					}
				}
				public InnerUnion innerUnion = new InnerUnion();
				
				public RepUpdateAreaResource ()
				{
					header = kMSGIDX_REP_UPDATE_AREA_RESOURCE_DATA;	
				}
 
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					bin.Get_ (out 	area_idx);
					//
					byte temp;
					bin.Get_ (out temp);
					area_resouce_type = (twp.app.resource.AreaResourceType)temp;
					//
					innerUnion.FromBin(bin, area_resouce_type);	
				}
			};
			
			
			
			
			//////////////////////////////////////////////////////////////////////////
			// shop
			//////////////////////////////////////////////////////////////////////////

			//
			// 商店物品列表
			//
			public class RepItemTradeItemListBase : PackBaseSTC
			{
				public ushort shop_idx;
				public bool last_list;
				
				public RepItemTradeItemListBase()
				{
					header = kMSGIDX_REP_ITEM_TRADE_ITEM_LIST;
				}
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					
					bin.Get_(out shop_idx);
					sbyte flag;
					bin.Get_(out flag);
					last_list = (flag==0) ? false : true;
				}
			}
			
			public class VarLenStruct_RepItemTradeItemList : RepItemTradeItemListBase
			{
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				app.item.ShopItem[] elems = new app.item.ShopItem[64];

				public app.item.ShopItem Get (UInt16 index)
				{
					return index >= _amount ? null : elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (UInt16 i = 0; i < _amount; ++i)
					{
						elems [i] = new app.item.ShopItem ();
						elems [i].FromBin (bin);
					}
				}
			}
			
			public class RepItemTradeItemList : VarLenStruct_RepItemTradeItemList
			{
				
			}
			
			public class RepShopHandleResult : PackBaseSTC
			{
				public byte event_type;
				public byte err_type;
				
				public RepShopHandleResult()
				{
					header = kMSGIDX_REP_MARKET_RESULT;
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					
					bin.Get_(out event_type);
					bin.Get_(out err_type);
				}
			}
			
			
			//////////////////////////////////////////////////////////////////////////
			// 好友
			//////////////////////////////////////////////////////////////////////////
			
			public class RepRelationListInfoBase : PackBaseSTC
			{
				//好友列表内数量
				twp.app.relation.RelationBaseInfo base_info = null;
				
				public RepRelationListInfoBase()
				{
					header = kMSGIDX_REP_RELATION_LIST;
				}
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					
					base_info.FromBin(bin);
				}
			}
			
			public class VarLenStruct_RepRelationMemberInfoList : RepRelationListInfoBase
			{
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				app.relation.RelationMemberInfo[] elems = new app.relation.RelationMemberInfo[(int)app.relation.RelationDefine.RELATION_COUNT_TOTAL_MAX];

				public app.relation.RelationMemberInfo Get(UInt16 index)
				{
					return index >= _amount ? null : elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (UInt16 i = 0; i < _amount; ++i)
					{
						elems [i] = new app.relation.RelationMemberInfo();
						elems [i].FromBin (bin);
					}
				}
			}
			
			// 好友列表
			public class RepRelationMemberInfoList : VarLenStruct_RepRelationMemberInfoList
			{
				
			}
			
			// 操作结果
			public class RepRelationOperation : PackBaseSTC
			{
				// 操作方式
				public app.relation.OperationRelation operation_type;
				// 操作成功与否
				public bool result;
				
				//[StructLayout(LayoutKind.Explicit)]
				public class InnerUnion
				{
					public class AddMember
					{
						public UInt32 char_idx;
						public string char_name;
						
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_(out char_idx);
							char_name = bin.GetStringData((int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH + 1);
						}
					}
					
					public class DeleteMember
					{
						public UInt32 target_id;
						
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_(out target_id);
						}
					}
					
					public class ResultType
					{
						public byte result_type;
						
						public void FromBin(NetSocket.ByteArray bin)
						{
							bin.Get_(out result_type);
						}
					}
					
					//[FieldOffset(0)]
					public AddMember add_member;
					//[FieldOffset(0)]
					public DeleteMember delete_member;
					//[FieldOffset(0)]
					public ResultType result_type;
					
					public void FromBin(NetSocket.ByteArray bin, app.relation.OperationRelation opera)
					{
						switch(opera)
						{
							case app.relation.OperationRelation.OPERATION_RELATION_ADD_ID:
							case app.relation.OperationRelation.OPERATION_RELATION_ADD_NAME:
							{
								add_member.FromBin(bin);
								break;
							}
							case app.relation.OperationRelation.OPERATION_RELATION_DELETE:
							{
								delete_member.FromBin(bin);
								break;
							}
							case app.relation.OperationRelation.OPERATION_RELATION_NULL:
							{
								result_type.FromBin(bin);
								break;
							}
						}
					}
				}
				
				public InnerUnion innerUnion = new InnerUnion();
				
				public RepRelationOperation()
				{
					header = kMSGIDX_REP_RELATION_OPERATION_RESULT;
				}
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					
					byte v;
					bin.Get_(out v);
					operation_type = (app.relation.OperationRelation)v;
					sbyte flag;
					bin.Get_(out flag);
					result = (flag == 0)? false : true;
					innerUnion.FromBin(bin, operation_type);
				}
			}
			
			// 好友更新
			public class UpdateRelationMember : PackBaseSTC
			{
				public app.relation.RelationMemberInfo member_info;
				
				public UpdateRelationMember()
				{
					header = kMSGIDX_UPDATE_RELATION_MEMBER;
				}
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					
					member_info.FromBin(bin);
				}
			}
			
			//
			// AURA信息更新
			//
			public class NotifyAuraEventListBase : PackBaseSTC
			{
				public NotifyAuraEventListBase()
				{
					header = kMSGIDX_NOTIFY_AURA_EVENT_LIST;
				}
			};
			
			public class NotifyAuraEventList : NotifyAuraEventListBase
			{
				UInt16 _amount;

				public UInt16 amount {
					get{ return _amount;}	
				}
				
				twp.app.aura.AuraEvent[] elems = new twp.app.aura.AuraEvent[64]; 
				
				public twp.app.aura.AuraEvent Get (UInt16 index)
				{
					return index >= _amount ? null : elems [index];
				}
				
				public new void FromBin (NetSocket.ByteArray bin)
				{
					base.FromBin (bin);
					
					bin.Get_ (out _amount);
					for (UInt16 i = 0; i < _amount; ++i)
					{
						elems [i] = new twp.app.aura.AuraEvent ();
						elems [i].FromBin (bin);
					}
				}
			};
			
		}
	}
}
