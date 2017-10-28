/**  版本信息模板在安装目录下，可自行修改。
* T_DataMemory.cs
*
* 功 能： N/A
* 类 名： T_DataMemory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:29   N/A    初版
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
	/// T_DataMemory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_DataMemory
	{
		public T_DataMemory()
		{}
		#region Model
		private int _id;
		private int _pointid;
		private string _hsdtablename;
		private string _addtablename;
		private string _gftablename;
		private string _gfaddtablename;
		private string _mncode;
		/// <summary>
		/// 
		/// </summary>
		public int ID
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
		public string HsdTableName
		{
			set{ _hsdtablename=value;}
			get{return _hsdtablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddTableName
		{
			set{ _addtablename=value;}
			get{return _addtablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GfTableName
		{
			set{ _gftablename=value;}
			get{return _gftablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GfAddTableName
		{
			set{ _gfaddtablename=value;}
			get{return _gfaddtablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MnCode
		{
			set{ _mncode=value;}
			get{return _mncode;}
		}
		#endregion Model

	}
}

