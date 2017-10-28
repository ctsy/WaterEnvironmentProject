/**  版本信息模板在安装目录下，可自行修改。
* T_Group.cs
*
* 功 能： N/A
* 类 名： T_Group
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/10/27 14:27:12   N/A    初版
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
	/// T_Group:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Group
	{
		public T_Group()
		{}
		#region Model
		private int _id;
		private string _groupname;
		private bool _addmember= true;
		private string _role;
		private bool _variable= true;
		private bool _deletable= true;
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
		public string GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool AddMember
		{
			set{ _addmember=value;}
			get{return _addmember;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Role
		{
			set{ _role=value;}
			get{return _role;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Variable
		{
			set{ _variable=value;}
			get{return _variable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool deletable
		{
			set{ _deletable=value;}
			get{return _deletable;}
		}
		#endregion Model

	}
}

