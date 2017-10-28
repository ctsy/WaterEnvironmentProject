/**  版本信息模板在安装目录下，可自行修改。
* V_StationDev.cs
*
* 功 能： N/A
* 类 名： V_StationDev
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:17   N/A    初版
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
	/// V_StationDev:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class V_StationDev
	{
		public V_StationDev()
		{}
		#region Model
		private int? _sortid;
		private string _areaname;
		private string _companycode;
		private string _companyname;
		private string _pointcode;
		private string _pointname;
		private string _name;
		private string _operatedlevel;
		private string _instrumentid;
		private string _instrumentname;
		private string _instrumentmodel;
		private string _instrumenttype;
		private DateTime? _installdate;
		private string _devcode;
		private string _detectionprinciple;
		private decimal? _rangelow;
		private decimal? _rangeup;
		private string _protocol;
		private string _transmissiontype;
		private string _devstatus;
		private string _remark;
		private int _stationdevid;
		private string _recordflag;
		private int? _pointid;
		/// <summary>
		/// 
		/// </summary>
		public int? SortId
		{
			set{ _sortid=value;}
			get{return _sortid;}
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
		public string CompanyName
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string InstrumentID
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
		public DateTime? InstallDate
		{
			set{ _installdate=value;}
			get{return _installdate;}
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
		public string DetectionPrinciple
		{
			set{ _detectionprinciple=value;}
			get{return _detectionprinciple;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RangeLow
		{
			set{ _rangelow=value;}
			get{return _rangelow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RangeUp
		{
			set{ _rangeup=value;}
			get{return _rangeup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Protocol
		{
			set{ _protocol=value;}
			get{return _protocol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransmissionType
		{
			set{ _transmissiontype=value;}
			get{return _transmissiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DevStatus
		{
			set{ _devstatus=value;}
			get{return _devstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StationDevID
		{
			set{ _stationdevid=value;}
			get{return _stationdevid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecordFlag
		{
			set{ _recordflag=value;}
			get{return _recordflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
		}
		#endregion Model

	}
}

