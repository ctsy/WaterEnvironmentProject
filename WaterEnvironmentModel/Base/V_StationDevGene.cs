/**  版本信息模板在安装目录下，可自行修改。
* V_StationDevGene.cs
*
* 功 能： N/A
* 类 名： V_StationDevGene
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:00:19   N/A    初版
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
	/// V_StationDevGene:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class V_StationDevGene
	{
		public V_StationDevGene()
		{}
		#region Model
		private string _areaname;
		private int _pointid;
		private string _pointname;
		private string _mncode;
		private int _geneid;
		private string _genename;
		private string _unit;
		private string _genet212;
		private string _instrumentid;
		private string _instrumentname;
		private string _instrumentmodel;
		private DateTime? _installdate;
		private string _devcode;
		private bool _isstop;
		private int? _daynum;
		private decimal? _rangedown;
		private decimal? _rangeup;
		private decimal? _standardminvalue;
		private decimal? _standardmaxvalue;
		private decimal? _dayminvalue;
		private decimal? _daymaxvalue;
		private string _changetype;
		private decimal? _changerate;
		private string _detectionprinciple;
		private bool _haszs;
		private bool _haspf;
		private bool _isjudgestandard;
		private int? _decimalplaces;
		private int? _sort;
		private bool _pointuses;
		private string _pointcode;
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
		public int PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
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
		public string MnCode
		{
			set{ _mncode=value;}
			get{return _mncode;}
		}
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
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
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
		public decimal? RangeDown
		{
			set{ _rangedown=value;}
			get{return _rangedown;}
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
		public decimal? StandardMinValue
		{
			set{ _standardminvalue=value;}
			get{return _standardminvalue;}
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
		public decimal? DayMinValue
		{
			set{ _dayminvalue=value;}
			get{return _dayminvalue;}
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
		public bool IsJudgeStandard
		{
			set{ _isjudgestandard=value;}
			get{return _isjudgestandard;}
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
		public bool PointUses
		{
			set{ _pointuses=value;}
			get{return _pointuses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PointCode
		{
			set{ _pointcode=value;}
			get{return _pointcode;}
		}
		#endregion Model

	}
}

