/**  版本信息模板在安装目录下，可自行修改。
* V_StationIp.cs
*
* 功 能： N/A
* 类 名： V_StationIp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:20   N/A    初版
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
	/// V_StationIp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class V_StationIp
	{
		public V_StationIp()
		{}
		#region Model
		private string _areacode;
		private string _areaname;
		private string _companycode;
		private string _companyname;
		private string _pointcode;
		private string _pointname;
		private string _envirlevel;
		private string _operatedlevel;
		private string _name;
		private string _mncode;
		private string _routerip;
		private string _dataip;
		private string _vedioip;
		private string _lineno;
		private string _vlan;
		private string _netoperator;
		private string _nettype;
		private string _是否运维;
		private string _是否合同;
		private string _是否巡检;
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
		public string AreaName
		{
			set{ _areaname=value;}
			get{return _areaname;}
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
		public string companyname
		{
			set{ _companyname=value;}
			get{return _companyname;}
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
		public string envirlevel
		{
			set{ _envirlevel=value;}
			get{return _envirlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operatedlevel
		{
			set{ _operatedlevel=value;}
			get{return _operatedlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string 是否运维
		{
			set{ _是否运维=value;}
			get{return _是否运维;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 是否合同
		{
			set{ _是否合同=value;}
			get{return _是否合同;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 是否巡检
		{
			set{ _是否巡检=value;}
			get{return _是否巡检;}
		}
		#endregion Model

	}
}

