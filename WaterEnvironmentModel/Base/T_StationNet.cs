/**  版本信息模板在安装目录下，可自行修改。
* T_StationNet.cs
*
* 功 能： N/A
* 类 名： T_StationNet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 11:20:56   N/A    初版
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
	/// T_StationNet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_StationNet
	{
		public T_StationNet()
		{}
		#region Model
		private int _pointid;
		private string _routerip;
		private string _routerport;
		private string _rounteruser;
		private string _rounterpws;
		private string _dataip;
		private string _dataport;
		private string _datauser;
		private string _datapws;
		private string _vedioip;
		private string _videoport;
		private string _vidioid;
		private string _videouser;
		private string _videopws;
		private string _lineno;
		private string _vlan;
		private string _netoperator;
		private string _nettype;
		private string _pw;
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
		public int PointID
		{
			set{ _pointid=value;}
			get{return _pointid;}
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
		public string RouterPort
		{
			set{ _routerport=value;}
			get{return _routerport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RounterUser
		{
			set{ _rounteruser=value;}
			get{return _rounteruser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RounterPws
		{
			set{ _rounterpws=value;}
			get{return _rounterpws;}
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
		public string DataPort
		{
			set{ _dataport=value;}
			get{return _dataport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataUser
		{
			set{ _datauser=value;}
			get{return _datauser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataPws
		{
			set{ _datapws=value;}
			get{return _datapws;}
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
		public string VideoPort
		{
			set{ _videoport=value;}
			get{return _videoport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VidioID
		{
			set{ _vidioid=value;}
			get{return _vidioid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VideoUser
		{
			set{ _videouser=value;}
			get{return _videouser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VideoPws
		{
			set{ _videopws=value;}
			get{return _videopws;}
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
		public string PW
		{
			set{ _pw=value;}
			get{return _pw;}
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

