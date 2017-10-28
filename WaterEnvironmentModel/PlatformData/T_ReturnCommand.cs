/**  版本信息模板在安装目录下，可自行修改。
* T_ReturnCommand.cs
*
* 功 能： N/A
* 类 名： T_ReturnCommand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:39   N/A    初版
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
	/// T_ReturnCommand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ReturnCommand
	{
		public T_ReturnCommand()
		{}
		#region Model
		private int _orderid;
		private string _mncode;
		private string _devcode;
		private string _ordercode;
		private string _ordername;
		private string _ordertext;
		private DateTime? _writetime;
		/// <summary>
		/// 
		/// </summary>
		public int OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
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
		public string DevCode
		{
			set{ _devcode=value;}
			get{return _devcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderCode
		{
			set{ _ordercode=value;}
			get{return _ordercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderName
		{
			set{ _ordername=value;}
			get{return _ordername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderText
		{
			set{ _ordertext=value;}
			get{return _ordertext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? WriteTime
		{
			set{ _writetime=value;}
			get{return _writetime;}
		}
		#endregion Model

	}
}

