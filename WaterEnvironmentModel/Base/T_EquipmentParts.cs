/**  版本信息模板在安装目录下，可自行修改。
* T_EquipmentParts.cs
*
* 功 能： N/A
* 类 名： T_EquipmentParts
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:38   N/A    初版
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
	/// T_EquipmentParts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_EquipmentParts
	{
		public T_EquipmentParts()
		{}
		#region Model
		private int _partsid;
		private string _partsname;
		private string _partsmodel;
		private string _partstype;
		private string _partsunit;
		private int? _partstockdata;
		private int? _partssurplusdata;
		private string _partscode;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		private decimal? _price;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int Partsid
		{
			set{ _partsid=value;}
			get{return _partsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartsName
		{
			set{ _partsname=value;}
			get{return _partsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartsModel
		{
			set{ _partsmodel=value;}
			get{return _partsmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartsType
		{
			set{ _partstype=value;}
			get{return _partstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartsUnit
		{
			set{ _partsunit=value;}
			get{return _partsunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PartStockData
		{
			set{ _partstockdata=value;}
			get{return _partstockdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PartsSurplusData
		{
			set{ _partssurplusdata=value;}
			get{return _partssurplusdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartsCode
		{
			set{ _partscode=value;}
			get{return _partscode;}
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
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
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

