/**  版本信息模板在安装目录下，可自行修改。
* T_ReturnCommandResult.cs
*
* 功 能： N/A
* 类 名： T_ReturnCommandResult
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:40   N/A    初版
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
	/// T_ReturnCommandResult:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ReturnCommandResult
	{
		public T_ReturnCommandResult()
		{}
		#region Model
		private int _id;
		private DateTime _writetime;
		private string _mncode;
		private string _cn;
		private int _result;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public string MNCode
		{
			set{ _mncode=value;}
			get{return _mncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CN
		{
			set{ _cn=value;}
			get{return _cn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Result
		{
			set{ _result=value;}
			get{return _result;}
		}
		#endregion Model

	}
}

