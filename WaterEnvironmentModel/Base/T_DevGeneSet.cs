/**  版本信息模板在安装目录下，可自行修改。
* T_DevGeneSet.cs
*
* 功 能： N/A
* 类 名： T_DevGeneSet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:37   N/A    初版
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
	/// T_DevGeneSet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_DevGeneSet
	{
		public T_DevGeneSet()
		{}
		#region Model
		private int _id;
		private int? _pointid;
		private string _devcode;
		private int? _geneid;
		private bool _isstop;
		private int? _daynum;
		private decimal? _rangeup=0M;
		private decimal? _rangedown=0M;
		private decimal? _standardmaxvalue=0M;
		private decimal? _standardminvalue=0M;
		private bool _isjudgestandard;
		private decimal? _daymaxvalue;
		private decimal? _dayminvalue;
		private string _changetype;
		private decimal? _changerate;
		private string _detectionprinciple;
		private bool _haszs= false;
		private bool _haspf= false;
		private int? _decimalplaces;
		private int? _sort;
		private string _recordflag;
		private string _excelserverrcid;
		private int? _excelserverrn;
		private int? _excelservercn;
		private string _excelserverrc1;
		private string _excelserverwiid;
		private string _excelserverrtid;
		private int? _excelserverchg;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public string DevCode
		{
			set{ _devcode=value;}
			get{return _devcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GeneID
		{
			set{ _geneid=value;}
			get{return _geneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isStop
		{
			set{ _isstop=value;}
			get{return _isstop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayNum
		{
			set{ _daynum=value;}
			get{return _daynum;}
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
		public decimal? RangeDown
		{
			set{ _rangedown=value;}
			get{return _rangedown;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardMaxValue
		{
			set{ _standardmaxvalue=value;}
			get{return _standardmaxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? StandardMinValue
		{
			set{ _standardminvalue=value;}
			get{return _standardminvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsJudgeStandard
		{
			set{ _isjudgestandard=value;}
			get{return _isjudgestandard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DayMaxValue
		{
			set{ _daymaxvalue=value;}
			get{return _daymaxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DayMinValue
		{
			set{ _dayminvalue=value;}
			get{return _dayminvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChangeType
		{
			set{ _changetype=value;}
			get{return _changetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ChangeRate
		{
			set{ _changerate=value;}
			get{return _changerate;}
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
		public bool HasZs
		{
			set{ _haszs=value;}
			get{return _haszs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool HasPf
		{
			set{ _haspf=value;}
			get{return _haspf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DecimalPlaces
		{
			set{ _decimalplaces=value;}
			get{return _decimalplaces;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
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
		#endregion Model

	}
}

