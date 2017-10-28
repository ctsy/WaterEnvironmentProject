/**  版本信息模板在安装目录下，可自行修改。
* V_Company.cs
*
* 功 能： N/A
* 类 名： V_Company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:13   N/A    初版
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
	/// V_Company:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class V_Company
	{
		public V_Company()
		{}
		#region Model
		private string _areacode;
		private string _areaname;
		private string _companycode;
		private string _companyname;
		private string _companytype;
		private string _companyindustry;
		private string _companyaddress;
		private string _companyphone;
		private string _companylegal;
		private string _companylegalno;
		private bool _companyisstop;
		private string _是否运维;
		private string _town;
		private string _street;
		private string _remark;
		private DateTime? _updatetime;
		private string _updateperson;
		private int _companyid;
		private int? _areaid;
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
		public string areaname
		{
			set{ _areaname=value;}
			get{return _areaname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string companycode
		{
			set{ _companycode=value;}
			get{return _companycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string companyname
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
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
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
		public bool CompanyIsStop
		{
			set{ _companyisstop=value;}
			get{return _companyisstop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 是否运维
		{
			set{ _是否运维=value;}
			get{return _是否运维;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string town
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
		#endregion Model

	}
}

