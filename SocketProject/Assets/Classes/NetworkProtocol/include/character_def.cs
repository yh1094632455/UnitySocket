using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using twp;
using twp.protocol;
using System.IO;
using twp.app.unit;

namespace twp
{
	namespace app
	{
		namespace unit
		{

		   //
		   // 角色类型
		   //
		   public enum CharacterType
		   {
		    // 非法角色类型
		    CHARACTER_TYPE_INVALID = 0,
		    // 男
		    CHARACTER_TYPE_MALE = 1,
		    // 女
		    CHARACTER_TYPE_FEMALE,
		    // 总数量
		    CHARACTER_TYPE_NUM = CHARACTER_TYPE_FEMALE,
		   };
			
			 public enum CharacterFlags
			{
				CHARACTER_FLAG_NONE								= 0x00000000,
				// 进入过游戏
				CHARACTER_FLAG_ENTERED_GAME						= 0x00000001,
			};


            //
            //	角色创建所需参数
            //
            public class CharacterCreationParam
            {
                // 名字
                public string	name = "";//byte[] name = new byte[(int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH+1];
				// 角色类型
				public byte char_type;
				//country
				public byte country;
#if false				
				public void FromBin(NetSocket.ByteArray bin)
				{
					name = bin.GetByteArray_((int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH+1);
					bin.Get_ (out char_type);
				}
#endif		
				public byte[] ToBin()
				{
					NetSocket.ByteArray bin = new NetSocket.ByteArray();
					
					 // 名字
					byte[] nameBuf = new byte[(int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH+1];
					NetSocket.ByteArray.ArraySet(nameBuf, (byte)0);
					byte[] byteData = System.Text.Encoding.UTF8.GetBytes(name);
					System.Array.Copy(byteData, nameBuf, Mathf.Min(byteData.Length, nameBuf.Length));
					bin.Put(nameBuf);
					
					// 角色类型
					bin.Put( char_type );
					
					bin.Put( country );
					
					return bin.GetData();
				}
            };
			
			//
			public class CharacterBase
			{
				// 角色唯一id
				public uint char_idx;
				// 名字
				public string name; //(int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH+1
				// 角色类型，temporary for sex
				public byte char_type;// 1, 2
				//表示国家的类型
				public byte country;
				// 标记
				public uint flags;
				
				public void FromBin(NetSocket.ByteArray bin)
				{
					bin.Get_ (out char_idx);
					name = bin.GetStringData((int)twp.app.unit.EUnitLimit.LIMIT_NAME_STR_LENGTH+1);
					bin.Get_ (out char_type);
					bin.Get_ (out country);
					bin.Get_ (out flags);
				}
			}
			
			public class PlayerBattleAttr
			{
				// 生命
				public int hp;
				// 等级
				public int level;

				// 力量
				public int strength;
				// 智力
				public int intelligence;
				// 绝技
				public int stunt;

				// 物攻
				public int physics_attack;
				// 物防
				public int physics_defence;
				// 法攻
				public int magic_attack;
				// 法防
				public int magic_defence; 
				// 绝攻
				public int stunt_attack;
				// 绝防
				public int stunt_defence;

				// 暴击
				public int critical;
				// 韧性
				public int tenacity;
				// 格挡
				public int block;
				// 破甲
				public int brokenarmour;
				// 闪避
				public int dodge;
				// 命中
				public int hit;
				
				public void FromBin(NetSocket.ByteArray bin)
				{
					bin.Get_ (out hp);
					bin.Get_ (out level);
					bin.Get_ (out strength);
					bin.Get_ (out intelligence);
					bin.Get_ (out stunt);
					bin.Get_ (out physics_attack);
					bin.Get_ (out physics_defence);
					
					bin.Get_ (out magic_attack);
					bin.Get_ (out magic_defence);
					bin.Get_ (out stunt_attack);
					bin.Get_ (out stunt_defence);
					bin.Get_ (out critical);
					bin.Get_ (out tenacity);
					bin.Get_ (out block);
					bin.Get_ (out brokenarmour);
					bin.Get_ (out dodge);
					bin.Get_ (out hit);
				}
				
				public byte[] ToBin()
				{
					NetSocket.ByteArray bin = new NetSocket.ByteArray();
					bin.Put(hp);
					bin.Put(level);
					bin.Put(strength);
					bin.Put(intelligence);
					bin.Put(stunt);
					bin.Put(physics_attack);
					bin.Put(physics_defence);
					
					bin.Put(magic_attack);
					bin.Put(magic_defence);
					bin.Put(stunt_attack);
					bin.Put(stunt_defence);
					bin.Put(critical);
					bin.Put(tenacity);
					bin.Put(block);
					bin.Put(brokenarmour);
					bin.Put(dodge);
					bin.Put(hit);
					return bin.GetData();
				}
			}

			//coc 添加 2013-8-13
			public class CharacterInfoForClient : CharacterBase
			{	
				public UInt64 gold;     // 钻石(点卷)
				public UInt32 copper;   // 铜
				public UInt32 silver;   // 银
				public UInt32 food;     // 粮食
				public UInt32 max_food; // 最大粮食
				public UInt32 population;     // 人口
				public UInt32 max_population; // 最大人口
				public UInt16 plunder_count;   // 掠夺次数
    		    public UInt16 exploit_count;   // 被掠夺次数
    			public UInt32 battle_integral; // 战斗积分
				public byte area_idx;
				// 请求者最后副本通关id
				public UInt32 last_passed_instance_type_idx;
				//最後查看城市id(暂时无效数据)
				public UInt64 last_citys_idx;
				//联盟ID
				public UInt32 guild_idx;
				// client setting
				public CharacterClientSettings bin_client_settings = new CharacterClientSettings();
				// 区域主城信息
				public CharacterCityDatas bin_character_citys = new CharacterCityDatas();
				   // 区域资源信息
    			public AreaResourceInfo bin_area_resource = new AreaResourceInfo();
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					bin.Get_ (out gold);
					bin.Get_ (out copper);
					bin.Get_ (out silver);
					bin.Get_ (out food);
					bin.Get_ (out max_food);
					bin.Get_ (out population);					
					bin.Get_ (out max_population);
					bin.Get_ (out plunder_count);
					bin.Get_ (out exploit_count);
					bin.Get_ (out battle_integral);
					bin.Get_ (out area_idx);
					bin.Get_ (out last_passed_instance_type_idx);
					bin.Get_ (out last_citys_idx);
					bin.Get_ (out guild_idx);
					bin_client_settings.FromBin(bin);
					bin_character_citys.FromBin(bin);
					
					//
				    bin_area_resource.FromBin(bin);
				}
			}
		}
	}
}

