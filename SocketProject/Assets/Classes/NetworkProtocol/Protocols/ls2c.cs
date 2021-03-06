using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace twp
{
	namespace protocol
	{
		public class ls2c
		{
			public const ushort kMSGIDX_REP_CHARACTER_LIST 		= (ushort)protocol.ERange.MSG_BASE_LS2C + 1;
			public const ushort kMSGIDX_REP_CREATE_CHARACTER 	= (ushort)protocol.ERange.MSG_BASE_LS2C + 2;
			public const ushort kMSGIDX_REP_FORCE_OUT_CHARACTER = (ushort)protocol.ERange.MSG_BASE_LS2C + 3;
			
			//
            // 角色列表
            //
			public class RepCharacterList : PackBaseSTC
			{
				// 角色数量
				public byte char_count;
				// 上次选择角色序号
				public byte last_sel_idx;
				// 角色信息
				public List<twp.app.unit.CharacterBase> char_data = new List<twp.app.unit.CharacterBase>();
				
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					bin.Get_(out char_count);
					bin.Get_(out last_sel_idx);
					for(int i = 0; i <char_count; i++)
					{
						twp.app.unit.CharacterBase ch = new twp.app.unit.CharacterBase();
						ch.FromBin(bin);
						char_data.Add(ch);
					}
				}
			}
			
			
			 //
            // 返回创建角色结果
            //
            public class RepCreateCharacter : PackBaseSTC
            {
                public enum e_result_
                {
                    E_FAILED_COMMONERROR = 0,
                    E_SUCCESS = 1,					
                    E_FAILED_REACHLIMIT,			//	到了角色数量上限，LIMIT_CHARACTER_NUM
                    E_FAILED_INVALIDPARAM,			//	非法的创建参数s
                    E_FAILED_INALIDNAME,			//	非法的名字
                    E_FAILED_REPEATEDNAME,			//	名字重复
                }
				public e_result_ e_result;

                // 创建成功的角色id
                public UInt32 charidx_created;

                public RepCreateCharacter()
                {
					header = kMSGIDX_REP_CREATE_CHARACTER;
					e_result = e_result_.E_FAILED_COMMONERROR;
					charidx_created = (UInt32)twp.app.unit.EUnitLimit.INVALID_CHARINDEX;
				}
			
				public new void FromBin(NetSocket.ByteArray bin)
				{
					base.FromBin(bin);
					//
					int e_result__;
					bin.Get_(out e_result__);
					e_result = (e_result_) e_result__;
					//
					bin.Get_(out charidx_created);
				}
            };
		}
	}
}