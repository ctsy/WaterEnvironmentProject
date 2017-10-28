/**  版本信息模板在安装目录下，可自行修改。
* T_StationInformation.cs
*
* 功 能： N/A
* 类 名： T_StationInformation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:54   N/A    初版
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
	/// T_StationInformation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_StationInformation
	{
		public T_StationInformation()
		{}
		#region Model
		private string _companycode;
		private string _pointcode;
		private string _pointname;
		private bool _pointuses;
		private int? _pointtype;
		private string _operatedlevel;
		private string _operatedcenter;
		private string _operatedgroup;
		private string _director;
		private string _routerip;
		private string _dataip;
		private string _vedioip;
		private string _lineno;
		private string _vlan;
		private string _netoperator;
		private string _nettype;
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
		private string _mncode;
		private string _outletno;
		private DateTime? _passtime;
		private string _pointcode1;
		private string _envirlevel;
		private bool _ispatrol;
		private bool _iscontract;
		private int? _companyid;
		private int _pointid;
		private string _longitude;
		private string _latitude;
		private int? _frequency;
		private string _pointaddress;
		private string _pointcodeb;
		private string _controlsystem;
		private string _treatmentprocess;
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
		public string PointCode
		{
			set{ _pointcode=value;}
			get{return _pointcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PointName
		{
			set{ _pointname=value;}
			get{return _pointname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PointUses
		{
			set{ _pointuses=value;}
			get{return _pointuses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointType
		{
			set{ _pointtype=value;}
			get{return _pointtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatedLevel
		{
			set{ _operatedlevel=value;}
			get{return _operatedlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatedCenter
		{
			set{ _operatedcenter=value;}
			get{return _operatedcenter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatedGroup
		{
			set{ _operatedgroup=value;}
			get{return _operatedgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Director
		{
			set{ _director=value;}
			get{return _director;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RouterIP
		{
			set{ _routerip=value;}
			get{return _routerip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataIP
		{
			set{ _dataip=value;}
			get{return _dataip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VedioIP
		{
			set{ _vedioip=value;}
			get{return _vedioip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LineNo
		{
			set{ _lineno=value;}
			get{return _lineno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Vlan
		{
			set{ _vlan=value;}
			get{return _vlan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NetOperator
		{
			set{ _netoperator=value;}
			get{return _netoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NetType
		{
			set{ _nettype=value;}
			get{return _nettype;}
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
		public string MnCode
		{
			set{ _mncode=value;}
			get{return _mncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutletNo
		{
			set{ _outletno=value;}
			get{return _outletno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PassTime
		{
			set{ _passtime=value;}
			get{return _passtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PointCode1
		{
			set{ _pointcode1=value;}
			get{return _pointcode1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnvirLevel
		{
			set{ _envirlevel=value;}
			get{return _envirlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsPatrol
		{
			set{ _ispatrol=value;}
			get{return _ispatrol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsContract
		{
			set{ _iscontract=value;}
			get{return _iscontract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CompanyID
		{
			set{ _companyid=value;}
			get{return _companyid;}
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
		public string Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string latitude
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? frequency
		{
			set{ _frequency=value;}
			get{return _frequency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pointaddress
		{
			set{ _pointaddress=value;}
			get{return _pointaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PointCodeB
		{
			set{ _pointcodeb=value;}
			get{return _pointcodeb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Controlsystem
		{
			set{ _controlsystem=value;}
			get{return _controlsystem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Treatmentprocess
		{
			set{ _treatmentprocess=value;}
			get{return _treatmentprocess;}
		}
		#endregion Model

	}
}

