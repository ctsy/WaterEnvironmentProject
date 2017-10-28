/**  版本信息模板在安装目录下，可自行修改。
* T_SummaryMinutedata.cs
*
* 功 能： N/A
* 类 名： T_SummaryMinutedata
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:48   N/A    初版
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
	/// T_SummaryMinutedata:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_SummaryMinutedata
	{
		public T_SummaryMinutedata()
		{}
		#region Model
		private DateTime _datatime;
		private int _pointid;
		private int _geneid;
		private int _datatype;
		private string _statevalue;
		private decimal? _datavalue;
		private decimal? _datamaxvalue;
		private decimal? _dataminvalue;
		private decimal? _datacouvalue;
		private decimal? _convertvalue;
		private decimal? _convertmaxvalue;
		private decimal? _convertminvalue;
		private DateTime _writetime;
		private string _devcode;
		private string _person;
		private DateTime? _audittime;
		private int? _abnormalledger;
		/// <summary>
		/// 
		/// </summary>
		public DateTime DataTime
		{
			set{ _datatime=value;}
			get{return _datatime;}
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
		public int GeneID
		{
			set{ _geneid=value;}
			get{return _geneid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DataType
		{
			set{ _datatype=value;}
			get{return _datatype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateValue
		{
			set{ _statevalue=value;}
			get{return _statevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DataValue
		{
			set{ _datavalue=value;}
			get{return _datavalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DataMaxValue
		{
			set{ _datamaxvalue=value;}
			get{return _datamaxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DataMinValue
		{
			set{ _dataminvalue=value;}
			get{return _dataminvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DataCouValue
		{
			set{ _datacouvalue=value;}
			get{return _datacouvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ConvertValue
		{
			set{ _convertvalue=value;}
			get{return _convertvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ConvertMaxValue
		{
			set{ _convertmaxvalue=value;}
			get{return _convertmaxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ConvertMinValue
		{
			set{ _convertminvalue=value;}
			get{return _convertminvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime WriteTime
		{
			set{ _writetime=value;}
			get{return _writetime;}
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
		public string Person
		{
			set{ _person=value;}
			get{return _person;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuditTime
		{
			set{ _audittime=value;}
			get{return _audittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AbnormalLedger
		{
			set{ _abnormalledger=value;}
			get{return _abnormalledger;}
		}
		#endregion Model

	}
}

