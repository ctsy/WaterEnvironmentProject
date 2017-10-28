/**  版本信息模板在安装目录下，可自行修改。
* T_StationDev.cs
*
* 功 能： N/A
* 类 名： T_StationDev
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:51   N/A    初版
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
	/// T_StationDev:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_StationDev
	{
		public T_StationDev()
		{}
		#region Model
		private string _instrumentid;
		private string _pointcode;
		private DateTime? _installdate;
		private string _devcode;
		private string _detectionprinciple;
		private string _rangelow;
		private string _rangeup;
		private string _protocol;
		private string _transmissiontype;
		private string _devstatus;
		private string _remark;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		private int _stationdevid;
		private string _recordflag;
		private int? _pointid;
		private string _processmetermodel;
		private DateTime? _inputtime;
		private string _currentsituation;
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
		public string PointCode
		{
			set{ _pointcode=value;}
			get{return _pointcode;}
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
		public string RangeLow
		{
			set{ _rangelow=value;}
			get{return _rangelow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RangeUp
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
		/// <summary>
		/// 
		/// </summary>
		public string Processmetermodel
		{
			set{ _processmetermodel=value;}
			get{return _processmetermodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Inputtime
		{
			set{ _inputtime=value;}
			get{return _inputtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string currentsituation
		{
			set{ _currentsituation=value;}
			get{return _currentsituation;}
		}
		#endregion Model

	}
}

