/**  版本信息模板在安装目录下，可自行修改。
* T_Geneset.cs
*
* 功 能： N/A
* 类 名： T_Geneset
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:40   N/A    初版
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
	/// T_Geneset:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Geneset
	{
		public T_Geneset()
		{}
		#region Model
		private int _geneid;
		private string _genename;
		private string _genecode;
		private string _genecodeexpand;
		private string _genet212;
		private string _unit;
		private int? _m_decimal;
		private int? _datatype;
		private bool _zs;
		private string _remark;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		private int? _genetype;
		/// <summary>
		/// 
		/// </summary>
		public int geneID
		{
			set{ _geneid=value;}
			get{return _geneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string genename
		{
			set{ _genename=value;}
			get{return _genename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string genecode
		{
			set{ _genecode=value;}
			get{return _genecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string genecodeExpand
		{
			set{ _genecodeexpand=value;}
			get{return _genecodeexpand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string geneT212
		{
			set{ _genet212=value;}
			get{return _genet212;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? m_decimal
		{
			set{ _m_decimal=value;}
			get{return _m_decimal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DataType
		{
			set{ _datatype=value;}
			get{return _datatype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ZS
		{
			set{ _zs=value;}
			get{return _zs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		public int? GeneType
		{
			set{ _genetype=value;}
			get{return _genetype;}
		}
		#endregion Model

	}
}

