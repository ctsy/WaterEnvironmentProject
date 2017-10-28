/**  版本信息模板在安装目录下，可自行修改。
* T_StationGeneSet.cs
*
* 功 能： N/A
* 类 名： T_StationGeneSet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:52   N/A    初版
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
	/// T_StationGeneSet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_StationGeneSet
	{
		public T_StationGeneSet()
		{}
		#region Model
		private string _pointcode;
		private string _genecode;
		private string _devcode;
		private bool _isstop;
		private int? _daynum;
		private decimal? _standardvalue;
		private decimal? _daymaxvalue;
		private decimal? _dayminvalue;
		private string _changetype;
		private decimal? _changerate;
		private decimal? _multiple;
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
		public string PointCode
		{
			set{ _pointcode=value;}
			get{return _pointcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GeneCode
		{
			set{ _genecode=value;}
			get{return _genecode;}
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
		public decimal? StandardValue
		{
			set{ _standardvalue=value;}
			get{return _standardvalue;}
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
		public decimal? Multiple
		{
			set{ _multiple=value;}
			get{return _multiple;}
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

