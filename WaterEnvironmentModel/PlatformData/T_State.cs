/**  版本信息模板在安装目录下，可自行修改。
* T_State.cs
*
* 功 能： N/A
* 类 名： T_State
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/25 14:44:42   N/A    初版
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
	/// T_State:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_State
	{
		public T_State()
		{}
		#region Model
		private string _statemark;
		private string _stateexplanation;
		private string _stategroup;
		private string _statevalue;
		private string _devicestate;
		/// <summary>
		/// 
		/// </summary>
		public string StateMark
		{
			set{ _statemark=value;}
			get{return _statemark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateExplanation
		{
			set{ _stateexplanation=value;}
			get{return _stateexplanation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateGroup
		{
			set{ _stategroup=value;}
			get{return _stategroup;}
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
		public string DeviceState
		{
			set{ _devicestate=value;}
			get{return _devicestate;}
		}
		#endregion Model

	}
}

