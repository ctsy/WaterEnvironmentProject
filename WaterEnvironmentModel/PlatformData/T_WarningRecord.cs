/**  版本信息模板在安装目录下，可自行修改。
* T_WarningRecord.cs
*
* 功 能： N/A
* 类 名： T_WarningRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:53   N/A    初版
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
	/// T_WarningRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_WarningRecord
	{
		public T_WarningRecord()
		{}
		#region Model
		private int _id;
		private int _pointid;
		private int _geneid;
		private decimal? _value;
		private string _content;
		private DateTime _writetime;
		private string _warningtype;
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
		public int GeneID
		{
			set{ _geneid=value;}
			get{return _geneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Value
		{
			set{ _value=value;}
			get{return _value;}
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
		public string WarningType
		{
			set{ _warningtype=value;}
			get{return _warningtype;}
		}
		#endregion Model

	}
}

