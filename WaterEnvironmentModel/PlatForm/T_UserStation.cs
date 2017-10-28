/**  版本信息模板在安装目录下，可自行修改。
* T_UserStation.cs
*
* 功 能： N/A
* 类 名： T_UserStation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:27:18   N/A    初版
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
	/// T_UserStation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_UserStation
	{
		public T_UserStation()
		{}
		#region Model
		private int _id;
		private DateTime _checktime;
		private string _userid;
		private int _pointid;
		private int? _verifyuser;
		private int? _verify;
		private string _remark;
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
		public DateTime CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
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
		public int? VerifyUser
		{
			set{ _verifyuser=value;}
			get{return _verifyuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Verify
		{
			set{ _verify=value;}
			get{return _verify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

