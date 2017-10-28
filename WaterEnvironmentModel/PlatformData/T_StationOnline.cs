/**  版本信息模板在安装目录下，可自行修改。
* T_StationOnline.cs
*
* 功 能： N/A
* 类 名： T_StationOnline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:43   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// T_StationOnline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_StationOnline
	{
		public T_StationOnline()
		{}
		#region Model
		private string _mncode;
		private string _lastonlineip;
		private string _pw;
		private DateTime? _updatetime;
		/// <summary>
		/// 
		/// </summary>
		public string Mncode
		{
			set{ _mncode=value;}
			get{return _mncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastOnlineIp
		{
			set{ _lastonlineip=value;}
			get{return _lastonlineip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PW
		{
			set{ _pw=value;}
			get{return _pw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

