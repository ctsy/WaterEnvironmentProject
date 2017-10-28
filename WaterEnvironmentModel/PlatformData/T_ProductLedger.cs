/**  版本信息模板在安装目录下，可自行修改。
* T_ProductLedger.cs
*
* 功 能： N/A
* 类 名： T_ProductLedger
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:36   N/A    初版
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
	/// T_ProductLedger:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ProductLedger
	{
		public T_ProductLedger()
		{}
		#region Model
		private int _id;
		private int _pointid;
		private string _maintaintype;
		private DateTime _ledgertime;
		private string _content;
		private DateTime _writetime;
		private string _writeperson;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MaintainType
		{
			set{ _maintaintype=value;}
			get{return _maintaintype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LedgerTime
		{
			set{ _ledgertime=value;}
			get{return _ledgertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime WriteTime
		{
			set{ _writetime=value;}
			get{return _writetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WritePerson
		{
			set{ _writeperson=value;}
			get{return _writeperson;}
		}
		#endregion Model

	}
}

