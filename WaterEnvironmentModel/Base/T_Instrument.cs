/**  版本信息模板在安装目录下，可自行修改。
* T_Instrument.cs
*
* 功 能： N/A
* 类 名： T_Instrument
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:42   N/A    初版
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
	/// T_Instrument:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Instrument
	{
		public T_Instrument()
		{}
		#region Model
		private int? _instrumentid;
		private string _instrumentname;
		private string _instrumentmodel;
		private string _instrumenttype;
		private int? _supplierid;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		private string _kingdeeid;
		private string _innerid;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int? InstrumentID
		{
			set{ _instrumentid=value;}
			get{return _instrumentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InstrumentName
		{
			set{ _instrumentname=value;}
			get{return _instrumentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InstrumentModel
		{
			set{ _instrumentmodel=value;}
			get{return _instrumentmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InstrumentType
		{
			set{ _instrumenttype=value;}
			get{return _instrumenttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SupplierId
		{
			set{ _supplierid=value;}
			get{return _supplierid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelServerRCID
		{
			set{ _excelserverrcid=value;}
			get{return _excelserverrcid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExcelServerRN
		{
			set{ _excelserverrn=value;}
			get{return _excelserverrn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExcelServerCN
		{
			set{ _excelservercn=value;}
			get{return _excelservercn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelServerRC1
		{
			set{ _excelserverrc1=value;}
			get{return _excelserverrc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelServerWIID
		{
			set{ _excelserverwiid=value;}
			get{return _excelserverwiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelServerRTID
		{
			set{ _excelserverrtid=value;}
			get{return _excelserverrtid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExcelServerCHG
		{
			set{ _excelserverchg=value;}
			get{return _excelserverchg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KingdeeId
		{
			set{ _kingdeeid=value;}
			get{return _kingdeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InnerId
		{
			set{ _innerid=value;}
			get{return _innerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

