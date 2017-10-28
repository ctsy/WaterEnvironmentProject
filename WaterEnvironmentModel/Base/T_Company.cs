/**  版本信息模板在安装目录下，可自行修改。
* T_Company.cs
*
* 功 能： N/A
* 类 名： T_Company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:34   N/A    初版
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
	/// T_Company:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Company
	{
		public T_Company()
		{}
		#region Model
		private string _areacode;
		private string _companycode;
		private string _companyname;
		private string _companytype;
		private string _companyindustry;
		private string _companyphone;
		private string _companylegal;
		private string _companylegalno;
		private string _companyaddress;
		private string _town;
		private string _street;
		private bool _companyisstop;
		private string _remark;
		private DateTime? _updatetime;
		private string _updateperson;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		private string _contrator;
		private int _companyid;
		private int? _areaid;
		private decimal? _longitude;
		private decimal? _latitude;
		/// <summary>
		/// 
		/// </summary>
		public string AreaCode
		{
			set{ _areacode=value;}
			get{return _areacode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyCode
		{
			set{ _companycode=value;}
			get{return _companycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyType
		{
			set{ _companytype=value;}
			get{return _companytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyIndustry
		{
			set{ _companyindustry=value;}
			get{return _companyindustry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyPhone
		{
			set{ _companyphone=value;}
			get{return _companyphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyLegal
		{
			set{ _companylegal=value;}
			get{return _companylegal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyLegalNo
		{
			set{ _companylegalno=value;}
			get{return _companylegalno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Town
		{
			set{ _town=value;}
			get{return _town;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Street
		{
			set{ _street=value;}
			get{return _street;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool CompanyIsStop
		{
			set{ _companyisstop=value;}
			get{return _companyisstop;}
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
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpdatePerson
		{
			set{ _updateperson=value;}
			get{return _updateperson;}
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
		public string contrator
		{
			set{ _contrator=value;}
			get{return _contrator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AreaID
		{
			set{ _areaid=value;}
			get{return _areaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		#endregion Model

	}
}

